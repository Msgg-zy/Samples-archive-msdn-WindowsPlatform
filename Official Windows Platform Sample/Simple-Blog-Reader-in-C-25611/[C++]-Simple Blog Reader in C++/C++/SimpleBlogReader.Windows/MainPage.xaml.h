//
// ItemsPage1.xaml.h
// Declaration of the ItemsPage1 class
//

#pragma once

#include "MainPage.g.h"
#include "Common\NavigationHelper.h"

namespace SimpleBlogReader
{
    namespace WFC = Windows::Foundation::Collections;
    namespace WUIX = Windows::UI::Xaml;
    namespace WUIXNav = Windows::UI::Xaml::Navigation;
    namespace WUIXControls = Windows::UI::Xaml::Controls;
	/// <summary>
	/// A page that displays a collection of item previews.  In the Split Application 
	/// this page is used to display and select one of the available groups.
	/// </summary>
	[Windows::Foundation::Metadata::WebHostHidden]
	public ref class MainPage sealed
	{
	public:
		MainPage();

		/// <summary>
		/// This can be changed to a strongly typed view model.
		/// </summary>
		property WFC::IObservableMap<Platform::String^, 
            Platform::Object^>^ DefaultViewModel
		{
			WFC::IObservableMap<Platform::String^, Platform::Object^>^  get();
		}

		/// <summary>
		/// NavigationHelper is used on each page to aid in navigation and 
		/// process lifetime management
		/// </summary>
		property Common::NavigationHelper^ NavigationHelper
		{
			Common::NavigationHelper^ get();
		}

	protected:
        virtual void OnNavigatedTo(WUIXNav::NavigationEventArgs^ e) override;
        virtual void OnNavigatedFrom(WUIXNav::NavigationEventArgs^ e) override;

	private:
		void LoadState(Platform::Object^ sender, Common::LoadStateEventArgs^ e);

        static WUIX::DependencyProperty^ _defaultViewModelProperty;
        static WUIX::DependencyProperty^ _navigationHelperProperty;
        void pageRoot_SizeChanged(Platform::Object^ sender, WUIX::SizeChangedEventArgs^ e);

        void AddFeed_Click(Platform::Object^ sender, WUIX::RoutedEventArgs^ e);
        void removeFeed_Click(Platform::Object^ sender, WUIX::RoutedEventArgs^ e);
        void deleteButton_Click(Platform::Object^ sender, WUIX::RoutedEventArgs^ e);
        void cancelButton_Click(Platform::Object^ sender, WUIX::RoutedEventArgs^ e);
        void ItemGridView_ItemClick(Platform::Object^ sender, WUIXControls::ItemClickEventArgs^ e);
    };
}
