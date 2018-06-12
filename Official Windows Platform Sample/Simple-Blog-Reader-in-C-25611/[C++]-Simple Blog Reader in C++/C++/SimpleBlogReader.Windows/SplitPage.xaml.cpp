//
// SplitPage.xaml.cpp
// Implementation of the SplitPage class
//

#include "pch.h"
#include "SplitPage.xaml.h"
#include "WebViewerPage.xaml.h"
using namespace SimpleBlogReader;
using namespace SimpleBlogReader::Common;

using namespace Platform;
using namespace Platform::Collections;
using namespace concurrency;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Core;
using namespace Windows::UI::ViewManagement;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Documents;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Split Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234234

SplitPage::SplitPage()
{
    InitializeComponent();
    SetValue(_defaultViewModelProperty, ref new Map<String^, Object^>(std::less<String^>()));
    auto navigationHelper = ref new Common::NavigationHelper(this,
        ref new Common::RelayCommand(
        [this](Object^) -> bool
    {
        return CanGoBack();
    },
        [this](Object^) -> void
    {
        GoBack();
    }
        )
        );
    SetValue(_navigationHelperProperty, navigationHelper);
    navigationHelper->LoadState += 
        ref new Common::LoadStateEventHandler(this, &SplitPage::LoadState);
    navigationHelper->SaveState += 
        ref new Common::SaveStateEventHandler(this, &SplitPage::SaveState);

    ItemListView->SelectionChanged += 
        ref new SelectionChangedEventHandler(this, &SplitPage::ItemListView_SelectionChanged);
    Window::Current->SizeChanged += 
        ref new WindowSizeChangedEventHandler(this, &SplitPage::Window_SizeChanged);
    InvalidateVisualState();

}

DependencyProperty^ SplitPage::_defaultViewModelProperty =
DependencyProperty::Register("DefaultViewModel",
TypeName(IObservableMap<String^, Object^>::typeid), TypeName(SplitPage::typeid), nullptr);

/// <summary>
/// used as a trivial view model.
/// </summary>
IObservableMap<String^, Object^>^ SplitPage::DefaultViewModel::get()
{
    return safe_cast<IObservableMap<String^, Object^>^>(GetValue(_defaultViewModelProperty));
}

DependencyProperty^ SplitPage::_navigationHelperProperty =
DependencyProperty::Register("NavigationHelper",
TypeName(Common::NavigationHelper::typeid), TypeName(SplitPage::typeid), nullptr);

/// <summary>
/// Gets an implementation of <see cref="NavigationHelper"/> designed to be
/// used as a trivial view model.
/// </summary>
Common::NavigationHelper^ SplitPage::NavigationHelper::get()
{
    //	return _navigationHelper;
    return safe_cast<Common::NavigationHelper^>(GetValue(_navigationHelperProperty));
}

#pragma region Page state management

/// <summary>
/// Populates the page with content passed during navigation.  Any saved state is also
/// provided when recreating a page from a prior session.
/// </summary>
/// <param name="navigationParameter">The parameter value passed to
/// <see cref="Frame::Navigate(Type, Object)"/> when this page was initially requested.
/// </param>
/// <param name="pageState">A map of state preserved by this page during an earlier
/// session.  This will be null the first time a page is visited.</param>
void SplitPage::LoadState(Platform::Object^ sender, Common::LoadStateEventArgs^ e)
{
    if (!this->DefaultViewModel->HasKey("Feed"))
    {
        auto app = safe_cast<App^>(App::Current);
        app->GetCurrentFeedAsync().then([this, app, e](FeedData^ fd)
        {
            // Insert into the ViewModel for this page to initialize itemsViewSource->View
            this->DefaultViewModel->Insert("Feed", fd);
            this->DefaultViewModel->Insert("Items", fd->Items);
            
            if (e->PageState == nullptr)
            {
                // When this is a new page, select the first item automatically 
                // unless logical page navigation is being used (see the logical
                // page navigation #region below).
                if (!UsingLogicalPageNavigation() && itemsViewSource->View != nullptr)
                {
                    this->itemsViewSource->View->MoveCurrentToFirst();
                }
                else
                {
                    this->itemsViewSource->View->MoveCurrentToPosition(-1);
                }
            }
            else
            {
                auto itemUri = safe_cast<String^>(e->PageState->Lookup("SelectedItemUri"));
                auto app = safe_cast<App^>(App::Current);
                auto selectedItem = app->GetFeedItem(fd, itemUri);

                if (selectedItem != nullptr)
                {
                    this->itemsViewSource->View->MoveCurrentTo(selectedItem);
                }
            }
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
void SplitPage::SaveState(Platform::Object^ sender, Common::SaveStateEventArgs^ e)
{
    if (itemsViewSource->View != nullptr)
    {
        auto selectedItem = itemsViewSource->View->CurrentItem;
        if (selectedItem != nullptr)
        {
            auto feedItem = safe_cast<FeedItem^>(selectedItem);
            e->PageState->Insert("SelectedItemUri", feedItem->Link->AbsoluteUri);
        }
    }
}

#pragma endregion

#pragma region Logical page navigation

// Visual state management typically reflects the four application view states directly (full
// screen landscape and portrait plus snapped and filled views.)  The split page is designed so
// that the snapped and portrait view states each have two distinct sub-states: either the item
// list or the details are displayed, but not both at the same time.
//
// This is all implemented with a single physical page that can represent two logical pages.
// The code below achieves this goal without making the user aware of the distinction.

/// <summary>
/// Invoked to determine whether the page should act as one logical page or two.
/// </summary>
/// <returns>True when the current view state is portrait or snapped, false
/// otherwise.</returns>
bool SplitPage::CanGoBack()
{
    if (UsingLogicalPageNavigation() && ItemListView->SelectedItem != nullptr)
    {
        return true;
    }
    else
    {
        return NavigationHelper->CanGoBack();
    }
}

void SplitPage::GoBack()
{
    if (UsingLogicalPageNavigation() && ItemListView->SelectedItem != nullptr)
    {
        // When logical page navigation is in effect and there's a selected item that
        // item's details are currently displayed.  Clearing the selection will return to
        // the item list.  From the user's point of view this is a logical backward
        // navigation.
        ItemListView->SelectedItem = nullptr;
    }
    else
    {
        NavigationHelper->GoBack();
    }
}

/// <summary>
/// Invoked with the Window changes size
/// </summary>
/// <param name="sender">The current Window</param>
/// <param name="e">Event data that describes the new size of the Window</param>
void SplitPage::Window_SizeChanged(Platform::Object^ sender, WindowSizeChangedEventArgs^ e)
{
    InvalidateVisualState();
}


/// <summary>
/// Invoked to determine whether the page should act as one logical page or two.
/// </summary>
/// <returns>True if the window should show act as one logical page, false
/// otherwise.</returns>
bool SplitPage::UsingLogicalPageNavigation()
{
    return Window::Current->Bounds.Width <= MinimumWidthForSupportingTwoPanes;
}

void SplitPage::InvalidateVisualState()
{
    auto visualState = DetermineVisualState();
    VisualStateManager::GoToState(this, visualState, false);
    NavigationHelper->GoBackCommand->RaiseCanExecuteChanged();
}

/// <summary>
/// Invoked to determine the name of the visual state that corresponds to an application
/// view state.
/// </summary>
/// <returns>The name of the desired visual state.  This is the same as the name of the
/// view state except when there is a selected item in portrait and snapped views where
/// this additional logical page is represented by adding a suffix of _Detail.</returns>
Platform::String^ SplitPage::DetermineVisualState()
{
    if (!UsingLogicalPageNavigation())
        return "PrimaryView";

    // Update the back button's enabled state when the view state changes
    auto logicalPageBack = UsingLogicalPageNavigation() 
        && ItemListView->SelectedItem != nullptr;

    return logicalPageBack ? "SinglePane_Detail" : "SinglePane";
}

#pragma endregion

#pragma region Navigation support

/// The methods provided in this section are simply used to allow
/// NavigationHelper to respond to the page's navigation methods.
/// 
/// Page specific logic should be placed in event handlers for the  
/// <see cref="NavigationHelper::LoadState"/>
/// and <see cref="NavigationHelper::SaveState"/>.
/// The navigation parameter is available in the LoadState method 
/// in addition to page state preserved during an earlier session.

void SplitPage::OnNavigatedTo(NavigationEventArgs^ e)
{
    NavigationHelper->OnNavigatedTo(e);
}

void SplitPage::OnNavigatedFrom(NavigationEventArgs^ e)
{
    NavigationHelper->OnNavigatedFrom(e);

}
#pragma endregion

void SimpleBlogReader::SplitPage::fwdButton_Click(Platform::Object^ sender, RoutedEventArgs^ e)
{
    // Navigate to the appropriate destination page, and configure the new page
    // by passing required information as a navigation parameter.
    auto selectedItem = dynamic_cast<FeedItem^>(this->ItemListView->SelectedItem);

    // selectedItem will be nullptr if the user invokes the app bar
    // and clicks on "view web page" without selecting an item.
    if (this->Frame != nullptr && selectedItem != nullptr)
    {
        auto itemUri = safe_cast<String^>(selectedItem->Link->AbsoluteUri);
        this->Frame->Navigate(WebViewerPage::typeid, itemUri);
    }
}

/// <summary>
/// 
/// 
/// </summary>
void SimpleBlogReader::SplitPage::pageRoot_SizeChanged(
    Platform::Object^ sender,
    SizeChangedEventArgs^ e)
{
    if (e->NewSize.Height / e->NewSize.Width >= 1)
    {
        VisualStateManager::GoToState(this, "SinglePane", true);
    }
    else
    {
        VisualStateManager::GoToState(this, "PrimaryView", true);
    }
}

/// <summary>
///  Navigate to the appropriate destination page, and configure the new page
///  by passing required information as a navigation parameter.
/// </summary>
void SplitPage::RichTextHyperlinkClicked(
    Hyperlink^ hyperLink,
    HyperlinkClickEventArgs^ args)
{
   
    auto selectedItem = dynamic_cast<FeedItem^>(this->ItemListView->SelectedItem);

    // selectedItem will be nullptr if the user invokes the app bar
    // and clicks on "view web page" without selecting an item.
    if (this->Frame != nullptr && selectedItem != nullptr)
    {
        auto itemUri = safe_cast<String^>(selectedItem->Link->AbsoluteUri);
        this->Frame->Navigate(WebViewerPage::typeid, itemUri);
    }
}

void SimpleBlogReader::SplitPage::ItemListView_SelectionChanged(
    Platform::Object^ sender,
    SelectionChangedEventArgs^ e)
{
    if (UsingLogicalPageNavigation())
    {
        InvalidateVisualState();
    }

    // Sometimes there is no selected item, e.g. when navigating back
    // from detail in logical page navigation.
    auto fi = dynamic_cast<FeedItem^>(ItemListView->SelectedItem);
    if (fi != nullptr)
    {
        BlogTextBlock->Blocks->Clear();
        TextHelper^ helper = ref new TextHelper();
        auto blocks = helper->CreateRichText(fi->Content, 
            ref new TypedEventHandler<Hyperlink^, 
            HyperlinkClickEventArgs^>(this, &SplitPage::RichTextHyperlinkClicked));
        for (auto b : blocks)
        {
            BlogTextBlock->Blocks->Append(b);
        }
    }
}


