//
// MainPage.xaml.cpp
// Implementation of the MainPage class
//

#include "pch.h"
#include "MainPage.xaml.h"
#include "FeedPage.xaml.h"

using namespace SimpleBlogReader;
using namespace Platform;
using namespace Platform::Collections;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;
using namespace Windows::UI::Xaml::Interop;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

MainPage::MainPage()
{
	InitializeComponent();
	SetValue(_defaultViewModelProperty, 
        ref new Platform::Collections::Map<String^, Object^>(std::less<String^>()));
	auto navigationHelper = ref new Common::NavigationHelper(this);
	SetValue(_navigationHelperProperty, navigationHelper);
	navigationHelper->LoadState += 
        ref new Common::LoadStateEventHandler(this, &MainPage::LoadState);
	navigationHelper->SaveState += 
        ref new Common::SaveStateEventHandler(this, &MainPage::SaveState);
}

DependencyProperty^ MainPage::_defaultViewModelProperty =
DependencyProperty::Register("DefaultViewModel",
TypeName(IObservableMap<String^, Object^>::typeid), TypeName(MainPage::typeid), nullptr);

/// <summary>
/// Used as a trivial view model.
/// </summary>
IObservableMap<String^, Object^>^ MainPage::DefaultViewModel::get()
{
	return safe_cast<IObservableMap<String^, Object^>^>(GetValue(_defaultViewModelProperty));
}

DependencyProperty^ MainPage::_navigationHelperProperty =
DependencyProperty::Register("NavigationHelper",
TypeName(Common::NavigationHelper::typeid), TypeName(MainPage::typeid), nullptr);

/// <summary>
/// Gets an implementation of <see cref="NavigationHelper"/> designed to be
/// used as a trivial view model.
/// </summary>
Common::NavigationHelper^ MainPage::NavigationHelper::get()
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

void MainPage::OnNavigatedTo(NavigationEventArgs^ e)
{
	NavigationHelper->OnNavigatedTo(e);
}

void MainPage::OnNavigatedFrom(NavigationEventArgs^ e)
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
void MainPage::LoadState(Object^ sender, Common::LoadStateEventArgs^ e)
{
    auto feedDataSource = 
        safe_cast<FeedDataSource^>(App::Current->Resources->Lookup("feedDataSource"));
    this->DefaultViewModel->Insert("Items", feedDataSource->Feeds);
}

/// <summary>
/// Preserves state associated with this page in case the application is suspended or the
/// page is discarded from the navigation cache.  Values must conform to the serialization
/// requirements of <see cref="SuspensionManager::SessionState"/>.
/// </summary>
/// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
/// <param name="e">Event data that provides an empty dictionary to be populated with
/// serializable state.</param>
void MainPage::SaveState(Object^ sender, Common::SaveStateEventArgs^ e){
	(void) sender;	// Unused parameter
	(void) e; // Unused parameter
}


void MainPage::AddFeed_Click(Platform::Object^ sender, RoutedEventArgs^ e)
{
    if (tbNewFeed->Text->Length() > 9)
    {
        auto app = static_cast<App^>(App::Current);
        app->AddFeed(tbNewFeed->Text);
    }
}


void MainPage::removeFeed_Click(Platform::Object^ sender, RoutedEventArgs^ e)
{
    VisualStateManager::GoToState(this, "Checkboxes", false);
    removeButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    addButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    deleteButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    cancelButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
}


void MainPage::deleteButton_Click(Platform::Object^ sender, RoutedEventArgs^ e)
{
    auto titlesToDelete = ref new Vector<FeedData^>();

    for (auto& item : ItemListView->SelectedItems)
    {
        // Get the feed the user selected.
        Object^ proxy = safe_cast<Object^>(item);
        FeedData^ item = safe_cast<FeedData^>(proxy);
        titlesToDelete->Append(item);
    }

    // Remove it from the data file and app-wide feed collection
    auto app = safe_cast<App^>(App::Current);
    app->RemoveFeeds(titlesToDelete);

    VisualStateManager::GoToState(this, "Normal", false);
    removeButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    addButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    deleteButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    cancelButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;

}


void MainPage::cancelButton_Click(Platform::Object^ sender, RoutedEventArgs^ e)
{
    VisualStateManager::GoToState(this, "Normal", false);
    removeButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    addButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    deleteButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    cancelButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
}


void MainPage::ItemListView_ItemClick(Platform::Object^ sender, ItemClickEventArgs^ e)
{
    // We must manually cast from Object^ to FeedData^.
    auto feedData = safe_cast<FeedData^>(e->ClickedItem);

    auto app = safe_cast<App^>(App::Current);
    app->SetCurrentFeed(feedData);

    // Navigate to FeedPage and pass the title of the selected feed.
    // FeedPage will receive this in its LoadState method in the navigationParamter.
    this->Frame->Navigate(FeedPage::typeid, feedData->Uri);
}
