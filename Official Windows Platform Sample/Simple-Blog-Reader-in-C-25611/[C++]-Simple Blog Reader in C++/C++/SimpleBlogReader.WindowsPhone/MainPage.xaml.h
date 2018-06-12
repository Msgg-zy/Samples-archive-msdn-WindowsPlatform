//
// MainPage.xaml.h
// Declaration of the MainPage class
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
	/// A basic page that provides characteristics common to most applications.
	/// </summary>
	[Windows::Foundation::Metadata::WebHostHidden]
	public ref class MainPage sealed
	{
	public:
		MainPage();

		/// <summary>
		/// Gets the view model for this <see cref="Page"/>. 
		/// This can be changed to a strongly typed view model.
		/// </summary>
		property WFC::IObservableMap<Platform::String^, Platform::Object^>^ DefaultViewModel
		{
			WFC::IObservableMap<Platform::String^, Platform::Object^>^  get();
		}

		/// <summary>
		/// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
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
		void SaveState(Platform::Object^ sender, Common::SaveStateEventArgs^ e);

		static WUIX::DependencyProperty^ _defaultViewModelProperty;
		static WUIX::DependencyProperty^ _navigationHelperProperty;
        void AddFeed_Click(Platform::Object^ sender, WUIX::RoutedEventArgs^ e);
        void removeFeed_Click(Platform::Object^ sender, WUIX::RoutedEventArgs^ e);
        void deleteButton_Click(Platform::Object^ sender, WUIX::RoutedEventArgs^ e);
        void cancelButton_Click(Platform::Object^ sender, WUIX::RoutedEventArgs^ e);
        void ItemListView_ItemClick(Platform::Object^ sender, WUIXControls::ItemClickEventArgs^ e);
    };

}
