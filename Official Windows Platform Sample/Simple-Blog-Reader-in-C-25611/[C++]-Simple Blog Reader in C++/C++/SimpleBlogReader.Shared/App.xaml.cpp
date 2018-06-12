//
// App.xaml.cpp
// Implementation of the App class.
//

#include "pch.h"
#include "Common\SuspensionManager.h"
#include "MainPage.xaml.h"

using namespace SimpleBlogReader;
using namespace SimpleBlogReader::Common;
using namespace concurrency;
using namespace Platform;
using namespace std;

using namespace Platform::Collections;
using namespace Windows::ApplicationModel;
using namespace Windows::ApplicationModel::Activation;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Storage;
using namespace Windows::UI::Xaml::Media::Animation;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

/// <summary>
/// Initializes the singleton application object. This is the first line of authored code
/// executed, and as such is the logical equivalent of main() or WinMain().
/// </summary>
App::App()
{
    InitializeComponent();
    Suspending += ref new SuspendingEventHandler(this, &App::OnSuspending);
}

/// <summary>
/// Invoked when the application is launched normally by the end user. Other entry points
/// will be used when the application is launched to open a specific file, to display
/// search results, and so forth.
/// </summary>
/// <param name="e">Details about the launch request and process.</param>
void App::OnLaunched(LaunchActivatedEventArgs^ e)
{

#if _DEBUG
    if (IsDebuggerPresent())
    {
        DebugSettings->EnableFrameRateCounter = true;
    }
#endif

    auto rootFrame = dynamic_cast<Frame^>(Window::Current->Content);

    // Do not repeat app initialization when the Window already has content,
    // just ensure that the window is active.
    if (rootFrame == nullptr)
    {
        // Create a Frame to act as the navigation context and associate it with
        // a SuspensionManager key
        rootFrame = ref new Frame();
        SuspensionManager::RegisterFrame(rootFrame, "AppFrame");

        // Initialize the Atom and RSS feed objects with data from the web
        FeedDataSource^ feedDataSource =
            safe_cast<FeedDataSource^>(App::Current->Resources->Lookup("feedDataSource"));
        if (feedDataSource->Feeds->Size == 0)
        {
            if (e->PreviousExecutionState == ApplicationExecutionState::Terminated)
            {
                // On resume FeedDataSource needs to know whether the app was on a
                // specific FeedData, which will be the unless it was on MainPage
                // when it was terminated.
                ApplicationDataContainer^ localSettings = ApplicationData::Current->LocalSettings;
                auto values = localSettings->Values;
                if (localSettings->Values->HasKey("LastViewedFeed"))
                {
                    feedDataSource->CurrentFeedUri =
                        safe_cast<String^>(localSettings->Values->Lookup("LastViewedFeed"));
                }
            }

            feedDataSource->InitDataSource();
        }

        // We have 4 pges in the app
        rootFrame->CacheSize = 4;
        auto prerequisite = task<void>([](){});
        if (e->PreviousExecutionState == ApplicationExecutionState::Terminated)
        {
            // Now restore the pages if we are resuming
            prerequisite = Common::SuspensionManager::RestoreAsync();
        }

        // if we're starting fresh, prerequisite will execute immediately.
        // if resuming from termination, prerequisite will wait until RestoreAsync() completes.
        prerequisite.then([=]()
        {
            if (rootFrame->Content == nullptr)
            {
                if (!rootFrame->Navigate(MainPage::typeid, e->Arguments))
                {
                    throw ref new FailureException("Failed to create initial page");
                }
            }
            // Place the frame in the current Window
            Window::Current->Content = rootFrame;
            Window::Current->Activate();
        }, task_continuation_context::use_current());
    }

    // There is a frame, but is has no content, so navigate to main page
    // and activate the window.
    else if (rootFrame->Content == nullptr)
    {
#if WINAPI_FAMILY==WINAPI_FAMILY_PHONE_APP
        // Removes the turnstile navigation for startup.
        if (rootFrame->ContentTransitions != nullptr)
        {
            _transitions = ref new TransitionCollection();
            for (auto transition : rootFrame->ContentTransitions)
            {
                _transitions->Append(transition);
            }
        }

        rootFrame->ContentTransitions = nullptr;
        _firstNavigatedToken = rootFrame->Navigated += 
            ref new NavigatedEventHandler(this, &App::RootFrame_FirstNavigated);

        // When the navigation stack isn't restored navigate to the first page,
        // configuring the new page by passing required information as a navigation
        // parameter.
#endif

        if (!rootFrame->Navigate(MainPage::typeid, e->Arguments))
        {
            throw ref new FailureException("Failed to create initial page");
        }

        // Ensure the current window is active in this code path.
        // we also called this inside the task for the other path.
        Window::Current->Activate();
    }
}

#if WINAPI_FAMILY==WINAPI_FAMILY_PHONE_APP
/// <summary>
/// Restores the content transitions after the app has launched.
/// </summary>
void App::RootFrame_FirstNavigated(Object^ sender, NavigationEventArgs^ e)
{
    auto rootFrame = safe_cast<Frame^>(sender);

    TransitionCollection^ newTransitions;
    if (_transitions == nullptr)
    {
        newTransitions = ref new TransitionCollection();
        newTransitions->Append(ref new NavigationThemeTransition());
    }
    else
    {
        newTransitions = _transitions;
    }

    rootFrame->ContentTransitions = newTransitions;

    rootFrame->Navigated -= _firstNavigatedToken;
}
#endif

/// <summary>
/// Invoked when application execution is being suspended. Application state is saved
/// without knowing whether the application will be terminated or resumed with the contents
/// of memory still intact.
/// </summary>
void App::OnSuspending(Object^ sender, SuspendingEventArgs^ e)
{
    (void)sender;	// Unused parameter
    (void)e;		// Unused parameter

    // Save application state and stop any background activity
    auto deferral = e->SuspendingOperation->GetDeferral();
    create_task(Common::SuspensionManager::SaveAsync())
        .then([deferral]()
    {
        deferral->Complete();
    });
}

///<summary>
/// Grabs the URI that the user entered, then inserts it into the in-memory list
/// and retrieves the data. Then adds the new feed to the data file so it's 
/// there the next time the app starts up.
///</summary>
void App::AddFeed(String^ feedUri)
{
    auto feedDataSource =
        safe_cast<FeedDataSource^>(App::Current->Resources->Lookup("feedDataSource"));
    auto client = ref new Windows::Web::Syndication::SyndicationClient();

    // The UI is data-bound to the items collection and will update automatically
    // after we append to the collection.
    create_task(feedDataSource->RetrieveFeedAndInitData(feedUri, client))
        .then([this, feedUri] {

        // Add the uri to the roaming data. The API requires an IIterable so we have to 
        // put the uri in a Vector.
        Vector<String^>^ vec = ref new Vector<String^>();
        vec->Append(feedUri);
        concurrency::create_task(ApplicationData::Current->LocalFolder->
            CreateFileAsync("feeds.txt", CreationCollisionOption::OpenIfExists))
            .then([vec](StorageFile^ file)
        {
            FileIO::AppendLinesAsync(file, vec);
        });
    });
}

/// <summary>
/// Called when the user chooses to remove some feeds which otherwise
/// are valid Urls and currently are displaying in the UI, and are stored in 
/// the Feeds collection as well as in the feeds.txt file.
/// </summary>
void App::RemoveFeeds(Vector<FeedData^>^ feedsToDelete)
{
    // Create a new list of feeds, excluding the ones the user selected.
    auto feedDataSource =
        safe_cast<FeedDataSource^>(App::Current->Resources->Lookup("feedDataSource"));  

    // If we delete the "last viewed feed" we need to also remove the reference to it
    // from local settings.
    ApplicationDataContainer^ localSettings = ApplicationData::Current->LocalSettings;
    String^ lastViewed;

    if (localSettings->Values->HasKey("LastViewedFeed"))
    {
        lastViewed =
            safe_cast<String^>(localSettings->Values->Lookup("LastViewedFeed"));
    }

    // When performance is an issue, consider using Vector::ReplaceAll
    for (const auto& item : feedsToDelete)
    {
        unsigned int index = -1;
        bool b = feedDataSource->Feeds->IndexOf(item, &index);
        if (index >= 0)
        {
            feedDataSource->Feeds->RemoveAt(index);           
        }

        // Prevent ourself from trying later to reference 
        // the page we just deleted.
        if (lastViewed != nullptr && lastViewed == item->Title)
        {
            localSettings->Values->Remove("LastViewedFeed");
        }
    }

    // Re-initialize feeds.txt with the new list of URLs.
    Vector<String^>^ newFeedList = ref new Vector<String^>();
    for (const auto& item : feedDataSource->Feeds)
    {
        newFeedList->Append(item->Uri);
    }

    // Overwrite the old data file with the new list.
    create_task(ApplicationData::Current->LocalFolder->
        CreateFileAsync("feeds.txt", CreationCollisionOption::OpenIfExists))
        .then([newFeedList](StorageFile^ file)
    {
        FileIO::WriteLinesAsync(file, newFeedList);
    });
}


///<summary>
/// This function enables the user to back out after
/// entering a bad url in the "Add Feed" text box, for example pasting in a 
/// partial address. This function will also be called if a URL that was previously 
/// formatted correctly one day starts returning malformed XML when we try to load it.
/// In either case, the FeedData was not added to the Feeds collection, and so 
/// we only need to delete the URL from the data file.
/// </summary>
void App::DeleteUrlFromFeedFile(Platform::String^ s)
{
    // Overwrite the old data file with the new list.
    create_task(ApplicationData::Current->LocalFolder->
        CreateFileAsync("feeds.txt", CreationCollisionOption::OpenIfExists))
        .then([this](StorageFile^ file)
    {
        return FileIO::ReadLinesAsync(file);
    }).then([this, s](IVector<String^>^ lines)
    {
        for (unsigned int i = 0; i < lines->Size; ++i)
        {
            if (lines->GetAt(i) == s)
            {
                lines->RemoveAt(i);
            }
        }
        return lines;
    }).then([this](IVector<String^>^ lines)
    {
        create_task(ApplicationData::Current->LocalFolder->
            CreateFileAsync("feeds.txt", CreationCollisionOption::OpenIfExists))
            .then([this, lines](StorageFile^ file)
        {
            FileIO::WriteLinesAsync(file, lines);
        });
    });
}

///<summary>
/// Returns the feed that the user last selected from MainPage.
///<summary>
task<FeedData^> App::GetCurrentFeedAsync()
{
    FeedDataSource^ feedDataSource =
        safe_cast<FeedDataSource^>(App::Current->Resources->Lookup("feedDataSource"));
    return create_task(feedDataSource->m_LastViewedFeedEvent);
}

///<summary>
/// So that we can always get the current feed in the same way, we call this 
/// method from ItemsPage when we change the current feed. This way the caller 
/// doesn't care whether we're resuming from termination or new navigating.
/// The only other place we set the event is in InitDataSource in FeedData.cpp 
/// when resuming from termination.
///</summary>
void App::SetCurrentFeed(FeedData^ feed)
{
    // Enable any pages waiting on the FeedData to continue
    FeedDataSource^ feedDataSource =
        safe_cast<FeedDataSource^>(App::Current->Resources->Lookup("feedDataSource"));
    feedDataSource->m_LastViewedFeedEvent = task_completion_event<FeedData^>();
    feedDataSource->m_LastViewedFeedEvent.set(feed);

    // Store the current URI so that we can look up the correct feedData object on resume.
    ApplicationDataContainer^ localSettings =
        ApplicationData::Current->LocalSettings;
    auto values = localSettings->Values;
    values->Insert("LastViewedFeed",
        dynamic_cast<PropertyValue^>(PropertyValue::CreateString(feed->Uri)));
}

// We stored the string ID when the app was suspended
// because storing the FeedItem itself would have required
// more custom serialization code. Here is where we retrieve
// the FeedItem based on its string ID.
FeedItem^ App::GetFeedItem(FeedData^ fd, String^ uri)
{
    auto items = fd->Items;
    auto itEnd = end(items);
    auto it = std::find_if(begin(items), itEnd,
        [uri](FeedItem^ fi)
    {
        return fi->Link->AbsoluteUri == uri;
    });

    if (it != itEnd)
    {
        return *it;
    }

    return nullptr;
}
