//
// SplitPage.xaml.h
// Declaration of the SplitPage class
//

#pragma once

#include "SplitPage.g.h"
#include "Common\NavigationHelper.h"

namespace SimpleBlogReader
{
    namespace WFC = Windows::Foundation::Collections;
    namespace WUIX = Windows::UI::Xaml;
    namespace WUIXNav = Windows::UI::Xaml::Navigation;
    namespace WUIXDoc = Windows::UI::Xaml::Documents;
    namespace WUIXControls = Windows::UI::Xaml::Controls;

	/// <summary>
	/// A page that displays a group title, a list of items within the group, and details for the
	/// currently selected item.
	/// </summary>
	[Windows::Foundation::Metadata::WebHostHidden]
	public ref class SplitPage sealed
	{
	public:
		SplitPage();

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
		void SaveState(Object^ sender, Common::SaveStateEventArgs^ e);
		bool CanGoBack();
		void GoBack();
        void RichTextHyperlinkClicked(WUIXDoc::Hyperlink^ link, 
            WUIXDoc::HyperlinkClickEventArgs^ args);

#pragma region Logical page navigation

		// The split page isdesigned so that when the Window does have enough space to show
		// both the list and the dteails, only one pane will be shown at at time.
		//
		// This is all implemented with a single physical page that can represent two logical
		// pages.  The code below achieves this goal without making the user aware of the
		// distinction.

		void Window_SizeChanged(Platform::Object^ sender, 
            Windows::UI::Core::WindowSizeChangedEventArgs^ e);
		void ItemListView_SelectionChanged(Platform::Object^ sender, 
            WUIXControls::SelectionChangedEventArgs^ e);
		bool UsingLogicalPageNavigation();
		void InvalidateVisualState();
		Platform::String^ DetermineVisualState();

#pragma endregion

		static Windows::UI::Xaml::DependencyProperty^ _defaultViewModelProperty;
		static Windows::UI::Xaml::DependencyProperty^ _navigationHelperProperty;
		static const int MinimumWidthForSupportingTwoPanes = 768;

        void fwdButton_Click(Platform::Object^ sender, WUIX::RoutedEventArgs^ e);
        void pageRoot_SizeChanged(Platform::Object^ sender, WUIX::SizeChangedEventArgs^ e);
	};
}
