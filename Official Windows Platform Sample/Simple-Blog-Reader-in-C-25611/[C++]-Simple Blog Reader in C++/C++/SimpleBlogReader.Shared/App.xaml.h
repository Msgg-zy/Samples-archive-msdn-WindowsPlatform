//
// App.xaml.h
// Declaration of the App class.
//

#pragma once
#include "FeedData.h"
#include "DateConverter.h"
#include "TextHelper.h"
#include "App.g.h"

namespace SimpleBlogReader
{

    namespace WFC = Windows::Foundation::Collections;
    namespace WUIXNav = Windows::UI::Xaml::Navigation;
    namespace WUIXDoc = Windows::UI::Xaml::Documents;
    namespace WAM = Windows::ApplicationModel;

	/// <summary>
	/// Provides application-specific behavior to supplement the default Application class.
	/// </summary>
	ref class App sealed
	{
	public:
		App();

		virtual void OnLaunched(WAM::Activation::LaunchActivatedEventArgs^ e) override;
    internal:
        concurrency::task<FeedData^> GetCurrentFeedAsync();
        void SetCurrentFeed(FeedData^ feed);
        FeedItem^ GetFeedItem(FeedData^ fd, Platform::String^ uri);
        void AddFeed(Platform::String^ feedUri);
        void RemoveFeeds(Platform::Collections::Vector<FeedData^>^ feedsToDelete);
        void DeleteUrlFromFeedFile(Platform::String^ s);
	private:
#if WINAPI_FAMILY==WINAPI_FAMILY_PHONE_APP
		Windows::UI::Xaml::Media::Animation::TransitionCollection^ _transitions;
		Windows::Foundation::EventRegistrationToken _firstNavigatedToken;

		void RootFrame_FirstNavigated(Platform::Object^ sender, WUIXNav::NavigationEventArgs^ e);
#endif

		void OnSuspending(Platform::Object^ sender, WAM::SuspendingEventArgs^ e);
	};
}
