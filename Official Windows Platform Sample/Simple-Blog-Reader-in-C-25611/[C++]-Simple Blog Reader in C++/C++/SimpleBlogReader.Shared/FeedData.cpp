#include "pch.h"
#include "FeedData.h"

using namespace std;
using namespace concurrency;
using namespace SimpleBlogReader;
using namespace Platform;
using namespace Platform::Collections;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Web::Syndication;
using namespace Windows::Storage;
using namespace Windows::Storage::Streams;

FeedDataSource::FeedDataSource()
{
    m_feeds = ref new Vector<FeedData^>();
    CurrentFeedUri = "";
}

///<summary>
/// Uses SyndicationClient to get the top-level feed object, then initializes 
/// the app's data structures. In the case of a bad feed URL, the exception is 
/// caught and the user can permanently delete the feed.
///</summary>
task<void> FeedDataSource::RetrieveFeedAndInitData(String^ url, SyndicationClient^ client)
{
    // Create the async operation. feedOp is an 
    // IAsyncOperationWithProgress<SyndicationFeed^, RetrievalProgress>^
    auto feedUri = ref new Uri(url);
    auto feedOp = client->RetrieveFeedAsync(feedUri);

    // Create the task object and pass it the async operation.
    // SyndicationFeed^ is the type of the return value that the feedOp 
    // operation will pass to the continuation. The continuation can run
    // on any thread.
    return create_task(feedOp).then([this, url](SyndicationFeed^ feed) -> FeedData^
    {
        return GetFeedData(url, feed);
    }, concurrency::task_continuation_context::use_arbitrary())

        // Append the initialized FeedData object to the items collection.
        // This has to happen on the UI thread. By default, a .then
        // continuation runs in the same apartment that it was called on.
        // We can append safely to the Vector from multiple threads
        // without taking an explicit lock.
        .then([this, url](FeedData^ fd)
    {
        if (fd->Uri == CurrentFeedUri)
        {
            // By setting the event we tell the resuming SplitPage the data
            // is ready to be consumed.
            m_LastViewedFeedEvent.set(fd);
        }

        m_feeds->Append(fd);

    })

        // The last continuation serves as an error handler.
        // get() will surface any unhandled exceptions in this task chain.
        .then([this, url](task<void> t)
    {
        try
        {
            t.get();
        }

        catch (Platform::Exception^ e)
        {
            // Sometimes a feed URL changes(I'm talking to you, Windows blogs!)
            // When that happens, or when the users pastes in an invalid URL or a 
            // URL is valid but the content is malformed somehow, an exception is 
            // thrown in the task chain before the feed is added to the Feeds 
            // collection. The only recourse is to stop trying to read the feed.
            // That means deleting it from the feeds.txt file in local settings.
            SyndicationErrorStatus status = SyndicationError::GetStatus(e->HResult);
            String^ msgString;

            // Define the action that will occur when the user presses the popup button.
            auto handler = ref new Windows::UI::Popups::UICommandInvokedHandler(
                [this, url](Windows::UI::Popups::IUICommand^ command)
            {
                auto app = safe_cast<App^>(App::Current);
                app->DeleteUrlFromFeedFile(url);               
            });

            // Display a message that hopefully is helpful.
            if (status == SyndicationErrorStatus::InvalidXml) 
            {
                msgString = "There seems to be a problem with the formatting in this feed: ";               
            }

            if (status == SyndicationErrorStatus::Unknown) 
            {                
                msgString = "I can't load this feed (is the URL correct?): ";
            }

            // Show the popup.
            auto msg = ref new Windows::UI::Popups::MessageDialog(
                msgString + url);
            auto cmd = ref new Windows::UI::Popups::UICommand(
                ref new String(L"Forget this feed."), handler, 1);
            msg->Commands->Append(cmd);
            msg->ShowAsync();
        }
    }); //end task chain
}

///<summary>
/// Retrieve the data for each Atom or RSS feed and put it into our custom data structures.
///</summary>
void FeedDataSource::InitDataSource()
{
    auto urls = GetUserURLsAsync()
        .then([this](IVector<String^>^ urls)
    {
        // Populate the list of feeds.
        SyndicationClient^ client = ref new SyndicationClient();
        for (auto url : urls)
        {
            RetrieveFeedAndInitData(url, client);
        }
    });
}

///<summary>
/// Creates our app-specific representation of a FeedData.
///</summary>
FeedData^ FeedDataSource::GetFeedData(String^ feedUri, SyndicationFeed^ feed)
{
    FeedData^ feedData = ref new FeedData();

    // Store the Uri now in order to map completion_events 
    // when resuming from termination.
    feedData->Uri = feedUri;

    // Get the title of the feed (not the individual posts).
    // auto app = safe_cast<App^>(App::Current);
    TextHelper^ helper = ref new TextHelper();

    feedData->Title = helper->UnescapeText(feed->Title->Text);
    if (feed->Subtitle != nullptr)
    {
        feedData->Description = helper->UnescapeText(feed->Subtitle->Text);
    }

    // Occasionally a feed might have no posts, so we guard against that here.
    if (feed->Items->Size > 0)
    {
        // Use the date of the latest post as the last updated date.
        feedData->PubDate = feed->Items->GetAt(0)->PublishedDate;

        for (auto item : feed->Items)
        {
            FeedItem^ feedItem;
            feedItem = ref new FeedItem();
            feedItem->Title = helper->UnescapeText(item->Title->Text);
            feedItem->PubDate = item->PublishedDate;

            //Only get first author in case of multiple entries.
            item->Authors->Size > 0 ? feedItem->Author = 
                item->Authors->GetAt(0)->Name : feedItem->Author = L"";

            if (feed->SourceFormat == SyndicationFormat::Atom10)
            {
                // Sometimes a post has only the link to the web page
                if (item->Content != nullptr)
                {
                    feedItem->Content = helper->UnescapeText(item->Content->Text);
                }
                feedItem->Link = ref new Uri(item->Id);
            }
            else
            {
                feedItem->Content = item->Summary->Text;
                feedItem->Link = item->Links->GetAt(0)->Uri;
            }
            feedData->Items->Append(feedItem);
        };
    }
    else
    {
        feedData->Description = "NO ITEMS AVAILABLE." + feedData->Description;
    }

    return feedData;

} //end GetFeedData


/// <summary>
/// The first time the app runs, the default feed URLs are loaded from the local resources
/// into a text file that is stored in the app folder. All subsequent additions and lookups 
/// are against that file. The method has to return a task because the file access is an 
/// async operation, and the call site needs to be able to continue from it with a .then method.
/// </summary>

task<IVector<String^>^> FeedDataSource::GetUserURLsAsync()
{
    return create_task(ApplicationData::Current->LocalFolder->
        CreateFileAsync("feeds.txt", CreationCollisionOption::OpenIfExists))
        .then([](StorageFile^ file)
    {
        return FileIO::ReadLinesAsync(file);
    }).then([](IVector<String^>^ t)
    {
        if (t->Size == 0)
        {
            // The data file is new, so we'll populate it with the 
            // default URLs that are stored in the apps resources.
            //  auto vec = ref new Vector<String^>();
            auto loader = ref new Windows::ApplicationModel::Resources::ResourceLoader();

            
            t->Append(loader->GetString("URL_1"));
            t->Append(loader->GetString("URL_2"));
            t->Append(loader->GetString("URL_3"));

            // Note: If using string resources seems too heavyweight, you can just hard code
            // the default strings: t->Append("http://sxp.microsoft.com/feeds/3.0/devblogs");
        
            // Before we return the URLs, lets create the new file asynchronously for use next time. 
            // We don't need the result of the operation now because we already have vec, so we can 
            // just kick off the task to run whenever it gets scheduled.
            create_task(ApplicationData::Current->LocalFolder->
                CreateFileAsync("feeds.txt", CreationCollisionOption::OpenIfExists))
                .then([t](StorageFile^ file)
            {
                FileIO::AppendLinesAsync(file, t);
            });
        }

        // Return the URLs.
        return create_task([t]()
        {
            return safe_cast<IVector<String^>^>(t);
        });
    });
}



