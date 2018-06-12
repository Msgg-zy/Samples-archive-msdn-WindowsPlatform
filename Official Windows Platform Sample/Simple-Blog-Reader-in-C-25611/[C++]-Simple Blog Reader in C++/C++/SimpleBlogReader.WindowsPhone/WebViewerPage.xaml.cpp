//
// WebViewerPage.xaml.cpp
// Implementation of the WebViewerPage class
//

#include "pch.h"
#include "WebViewerPage.xaml.h"

using namespace SimpleBlogReader;
using namespace concurrency;

using namespace Platform;
using namespace Platform::Collections;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Graphics::Display;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Media::Animation;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

WebViewerPage::WebViewerPage()
{
    InitializeComponent();
    SetValue(_defaultViewModelProperty,
        ref new Platform::Collections::Map<String^, Object^>(std::less<String^>()));
    auto navigationHelper = ref new Common::NavigationHelper(this);
    SetValue(_navigationHelperProperty, navigationHelper);
    navigationHelper->LoadState +=
        ref new Common::LoadStateEventHandler(this, &WebViewerPage::LoadState);
    navigationHelper->SaveState += 
        ref new Common::SaveStateEventHandler(this, &WebViewerPage::SaveState);
}

DependencyProperty^ WebViewerPage::_defaultViewModelProperty =
DependencyProperty::Register("DefaultViewModel",
TypeName(IObservableMap<String^, Object^>::typeid), TypeName(WebViewerPage::typeid), nullptr);

/// <summary>
/// Used as a trivial view model.
/// </summary>
IObservableMap<String^, Object^>^ WebViewerPage::DefaultViewModel::get()
{
    return safe_cast<IObservableMap<String^, Object^>^>(GetValue(_defaultViewModelProperty));
}

DependencyProperty^ WebViewerPage::_navigationHelperProperty =
DependencyProperty::Register("NavigationHelper",
TypeName(Common::NavigationHelper::typeid), TypeName(WebViewerPage::typeid), nullptr);

/// <summary>
/// Gets an implementation of <see cref="NavigationHelper"/> designed to be
/// used as a trivial view model.
/// </summary>
Common::NavigationHelper^ WebViewerPage::NavigationHelper::get()
{
    return safe_cast<Common::NavigationHelper^>(GetValue(_navigationHelperProperty));
}

#pragma region Navigation support

/// The methods provided in this section are simply used to allow
/// NavigationHelper to respond to the page's navigation methods.
/// 
/// Page specific logic should be placed in event handlers for the  
/// <see cref="NavigationHelper::LoadState"/>
/// and <see cref="NavigationHelper::SaveState"/>.
/// The navigation parameter is available in the LoadState method 
/// in addition to page state preserved during an earlier session.

void WebViewerPage::OnNavigatedTo(NavigationEventArgs^ e)
{
    NavigationHelper->OnNavigatedTo(e);
}

void WebViewerPage::OnNavigatedFrom(NavigationEventArgs^ e)
{
    NavigationHelper->OnNavigatedFrom(e);
}

#pragma endregion

/// <summary>
/// Populates the page with content passed during navigation. Any saved state is also
/// provided when recreating a page from a prior session.
/// </summary>
/// <param name="sender">
/// The source of the event; typically <see cref="NavigationHelper"/>
/// </param>
/// <param name="e">Event data that provides both the navigation parameter passed to
/// <see cref="Frame::Navigate(Type, Object)"/> when this page was initially requested and
/// a dictionary of state preserved by this page during an earlier
/// session. The state will be null the first time a page is visited.</param>
void WebViewerPage::LoadState(Object^ sender, Common::LoadStateEventArgs^ e)
{
    (void)sender;	// Unused parameter
    // Run the PopInThemeAnimation. 
    Storyboard^ sb = dynamic_cast<Storyboard^>(this->FindName("PopInStoryboard"));
    if (sb != nullptr)
    {
        sb->Begin();
    }

    if (e->PageState == nullptr)
    {
        m_feedItemUri = safe_cast<String^>(e->NavigationParameter);
        contentView->Navigate(ref new Uri(m_feedItemUri));
    }
    // We are resuming from suspension:
    else
    {
        m_feedItemUri = safe_cast<String^>(e->PageState->Lookup("FeedItemUri"));
        contentView->Navigate(ref new Uri(m_feedItemUri));
    }
}

/// <summary>
/// Preserves state associated with this page in case the application is suspended or the
/// page is discarded from the navigation cache.  Values must conform to the serialization
/// requirements of <see cref="SuspensionManager::SessionState"/>.
/// </summary>
/// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
/// <param name="e">Event data that provides an empty dictionary to be populated with
/// serializable state.</param>
void WebViewerPage::SaveState(Object^ sender, Common::SaveStateEventArgs^ e){
    (void)sender;	// Unused parameter
    (void)e; // Unused parameter
    e->PageState->Insert("FeedItemUri", m_feedItemUri);
}
