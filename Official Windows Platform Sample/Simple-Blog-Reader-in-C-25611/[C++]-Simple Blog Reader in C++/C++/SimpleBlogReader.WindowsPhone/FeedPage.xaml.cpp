//
// FeedPage.xaml.cpp
// Implementation of the FeedPage class
//

#include "pch.h"
#include "FeedPage.xaml.h"
#include "TextViewerPage.xaml.h"

using namespace SimpleBlogReader;
using namespace concurrency;

using namespace Platform;
using namespace Platform::Collections;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Graphics::Display;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

FeedPage::FeedPage()
{
    InitializeComponent();
    SetValue(_defaultViewModelProperty, 
        ref new Platform::Collections::Map<String^, Object^>(std::less<String^>()));
    auto navigationHelper = ref new Common::NavigationHelper(this);
    SetValue(_navigationHelperProperty, navigationHelper);
    navigationHelper->LoadState += 
        ref new Common::LoadStateEventHandler(this, &FeedPage::LoadState);
    navigationHelper->SaveState += 
        ref new Common::SaveStateEventHandler(this, &FeedPage::SaveState);
}

DependencyProperty^ FeedPage::_defaultViewModelProperty =
DependencyProperty::Register("DefaultViewModel",
TypeName(IObservableMap<String^, Object^>::typeid), TypeName(FeedPage::typeid), nullptr);

/// <summary>
/// Used as a trivial view model.
/// </summary>
IObservableMap<String^, Object^>^ FeedPage::DefaultViewModel::get()
{
    return safe_cast<IObservableMap<String^, Object^>^>(GetValue(_defaultViewModelProperty));
}

DependencyProperty^ FeedPage::_navigationHelperProperty =
DependencyProperty::Register("NavigationHelper",
TypeName(Common::NavigationHelper::typeid), TypeName(FeedPage::typeid), nullptr);

/// <summary>
/// Gets an implementation of <see cref="NavigationHelper"/> designed to be
/// used as a trivial view model.
/// </summary>
Common::NavigationHelper^ FeedPage::NavigationHelper::get()
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

void FeedPage::OnNavigatedTo(NavigationEventArgs^ e)
{
    NavigationHelper->OnNavigatedTo(e);
}

void FeedPage::OnNavigatedFrom(NavigationEventArgs^ e)
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
void FeedPage::LoadState(Object^ sender, Common::LoadStateEventArgs^ e)
{

    (void)sender;	// Unused parameter

    if (!this->DefaultViewModel->HasKey("Feed"))
    {
        auto app = safe_cast<App^>(App::Current);
        app->GetCurrentFeedAsync().then([this, e](FeedData^ fd)
        {
            // Insert into the ViewModel for this page to 
            // initialize itemsViewSource->View
            this->DefaultViewModel->Insert("Feed", fd);
            this->DefaultViewModel->Insert("Items", fd->Items);
        }, task_continuation_context::use_current());
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
void FeedPage::SaveState(Object^ sender, Common::SaveStateEventArgs^ e)
{
    (void)sender;	// Unused parameter
}

void FeedPage::ItemListView_ItemClick(Platform::Object^ sender, ItemClickEventArgs^ e)
{
    FeedItem^ clickedItem = dynamic_cast<FeedItem^>(e->ClickedItem);
    this->Frame->Navigate(TextViewerPage::typeid, clickedItem->Link->AbsoluteUri);
}
