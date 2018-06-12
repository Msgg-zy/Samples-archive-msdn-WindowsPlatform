//feeddata.h

#pragma once
#include "pch.h"

namespace SimpleBlogReader
{

    namespace WFC = Windows::Foundation::Collections;
    namespace WF = Windows::Foundation;
    namespace WUIXD = Windows::UI::Xaml::Documents;
    namespace WWS = Windows::Web::Syndication;


    /// <summary>
    /// To be bindable, a class must be defined within a namespace
    /// and a bindable attribute needs to be applied.
    /// A FeedItem represents a single blog post.
    /// </summary>
    [Windows::UI::Xaml::Data::Bindable]
    public ref class FeedItem sealed
    {
    public:
        property Platform::String^ Title;
        property Platform::String^ Author;
        property Platform::String^ Content;
        property Windows::Foundation::DateTime PubDate;
        property Windows::Foundation::Uri^ Link;

    private:
        ~FeedItem(void){}
    };

    /// <summary>
    /// A FeedData object represents a feed that contains 
    /// one or more FeedItems. 
    /// </summary>
    [Windows::UI::Xaml::Data::Bindable]
    public ref class FeedData sealed
    {
    public:
        FeedData(void)
        {
            m_items = ref new Platform::Collections::Vector<FeedItem^>();
        }

        // The public members must be Windows Runtime types so that
        // the XAML controls can bind to them from a separate .winmd.
        property Platform::String^ Title;
        property WFC::IVector<FeedItem^>^ Items
        {
            WFC::IVector<FeedItem^>^ get() { return m_items; }
        }

        property Platform::String^ Description;
        property Windows::Foundation::DateTime PubDate;
        property Platform::String^ Uri;

    private:
        ~FeedData(void){}
        Platform::Collections::Vector<FeedItem^>^ m_items;
    };

    /// <summary>
    /// A FeedDataSource represents a collection of FeedData objects
    /// and provides the methods to retrieve the stores URLs and download 
    /// the source data from which FeedData and FeedItem objects are constructed.
    /// This class is instantiated at startup by this declaration in the 
    /// ResourceDictionary in app.xaml: <local:FeedDataSource x:Key="feedDataSource" /> 
    /// </summary>
    [Windows::UI::Xaml::Data::Bindable]
    public ref class FeedDataSource sealed
    {
    private:
        Platform::Collections::Vector<FeedData^>^ m_feeds;
        FeedData^ GetFeedData(Platform::String^ feedUri, WWS::SyndicationFeed^ feed);
        concurrency::task<WFC::IVector<Platform::String^>^> GetUserURLsAsync();
        void DeleteBadFeedHandler(Windows::UI::Popups::UICommand^ command);

    public:
        FeedDataSource();
        property Windows::Foundation::Collections::IObservableVector<FeedData^>^ Feeds
        {
            Windows::Foundation::Collections::IObservableVector<FeedData^>^ get()
            {
                return this->m_feeds;
            }
        }
        property Platform::String^ CurrentFeedUri;
        void InitDataSource();        

    internal:
        // This is used to prevent SplitPage from prematurely loading the last viewed page on resume.
        concurrency::task_completion_event<FeedData^> m_LastViewedFeedEvent;
        concurrency::task<void> RetrieveFeedAndInitData(Platform::String^ url, WWS::SyndicationClient^ client);
    };
}

