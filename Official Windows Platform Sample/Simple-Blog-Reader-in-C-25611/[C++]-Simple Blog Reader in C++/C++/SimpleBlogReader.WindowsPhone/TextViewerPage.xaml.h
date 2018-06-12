//
// TextViewerPage.xaml.h
// Declaration of the TextViewerPage class
//

#pragma once

#include "TextViewerPage.g.h"
#include "Common\NavigationHelper.h"

namespace SimpleBlogReader
{
    namespace WFC = Windows::Foundation::Collections;
    namespace WUIX = Windows::UI::Xaml;
    namespace WUIXNav = Windows::UI::Xaml::Navigation;
    namespace WUIXDoc = Windows::UI::Xaml::Documents;
    namespace WUIXControls = Windows::UI::Xaml::Controls;

	/// <summary>
	/// A basic page that provides characteristics common to most applications.
	/// </summary>
	[Windows::Foundation::Metadata::WebHostHidden]
	public ref class TextViewerPage sealed
	{
	public:
		TextViewerPage();

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
        void RichTextHyperlinkClicked(WUIXDoc::Hyperlink^ link, 
            WUIXDoc::HyperlinkClickEventArgs^ args);

	private:
		void LoadState(Platform::Object^ sender, Common::LoadStateEventArgs^ e);
		void SaveState(Platform::Object^ sender, Common::SaveStateEventArgs^ e);

		static Windows::UI::Xaml::DependencyProperty^ _defaultViewModelProperty;
		static Windows::UI::Xaml::DependencyProperty^ _navigationHelperProperty;
      
        FeedItem^ m_feedItem;
    };

}
