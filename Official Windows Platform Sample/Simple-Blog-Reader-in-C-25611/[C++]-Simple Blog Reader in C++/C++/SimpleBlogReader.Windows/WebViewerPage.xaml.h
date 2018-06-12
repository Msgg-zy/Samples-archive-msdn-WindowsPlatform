//
// WebViewerPage.xaml.h
// Declaration of the WebViewerPage class
//

#pragma once

#include "WebViewerPage.g.h"
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
	public ref class WebViewerPage sealed
	{
	public:
		WebViewerPage();

		/// <summary>
		/// This can be changed to a strongly typed view model.
		/// </summary>
		property WFC::IObservableMap<Platform::String^, Platform::Object^>^ DefaultViewModel
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
		void SaveState(Platform::Object^ sender, Common::SaveStateEventArgs^ e);

		static Windows::UI::Xaml::DependencyProperty^ _defaultViewModelProperty;
		static Windows::UI::Xaml::DependencyProperty^ _navigationHelperProperty;

        Platform::String^ m_feedItemUri;
        void pageRoot_SizeChanged(Platform::Object^ sender, WUIX::SizeChangedEventArgs^ e);
	};
}
