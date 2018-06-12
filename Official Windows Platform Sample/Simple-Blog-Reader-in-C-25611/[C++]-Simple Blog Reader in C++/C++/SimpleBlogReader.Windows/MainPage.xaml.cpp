//
// ItemsPage1.xaml.cpp
// Implementation of the MainPage class
//

#include "pch.h"
#include "MainPage.xaml.h"
#include "SplitPage.xaml.h"

using namespace SimpleBlogReader;

using namespace Platform;
using namespace Platform::Collections;
using namespace concurrency;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Graphics::Display;
using namespace Windows::UI::ViewManagement;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Interop;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233

MainPage::MainPage()
{
	InitializeComponent();
	SetValue(_defaultViewModelProperty, ref new Map<String^,Object^>(std::less<String^>()));
	auto navigationHelper = ref new Common::NavigationHelper(this);
	SetValue(_navigationHelperProperty, navigationHelper);
	navigationHelper->LoadState += 
        ref new Common::LoadStateEventHandler(this, &MainPage::LoadState);
}

DependencyProperty^ MainPage::_defaultViewModelProperty =
	DependencyProperty::Register("DefaultViewModel",
		TypeName(IObservableMap<String^,Object^>::typeid), TypeName(MainPage::typeid), nullptr);

/// <summary>
/// Used as a simple view model.
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
/// Populates the page with content passed during navigation.  Any saved state is also
/// provided when recreating a page from a prior session.
/// </summary>
/// <param name="navigationParameter">The parameter value passed to
/// <see cref="Frame::Navigate(Type, Object)"/> when this page was initially requested.
/// </param>
/// <param name="pageState">A map of state preserved by this page during an earlier
/// session.  This will be null the first time a page is visited.</param>
void MainPage::LoadState(Platform::Object^ sender, Common::LoadStateEventArgs^ e)
{
	(void) sender;	// Unused parameter
	(void) e;	// Unused parameter


    // This is the first page to load on startup. The feedDataSource was constructed 
    // when the app loaded in response to this declaration in app.xaml: 
    // <local:FeedDataSource x:Key="feedDataSource" /> and was initialized aynchronously
    //  in the OnLaunched event handler in app.xaml.cpp.  Initialization might 
    // still be happening, but that's ok. 
    auto feedDataSource = 
        safe_cast<FeedDataSource^>(App::Current->Resources->Lookup("feedDataSource"));

    // In ItemsPage.xaml, the page's DefaultViewModel is set as DataContext:
    // DataContext="{Binding DefaultViewModel, RelativeSource={RelativeSource Self}}"
    // Because ItemsPage displays a collection of feeds, we set the Items element
    // to the FeedDataSource::Feeds collection. By comparison, the SplitPage sets this element to 
    // the Items collection of one FeedData object.
    this->DefaultViewModel->Insert("Items", feedDataSource->Feeds);
}

/// <summary>
/// Invoked when the device orientation changes. 
/// </summary>
void MainPage::pageRoot_SizeChanged(Platform::Object^ sender, SizeChangedEventArgs^ e)
{
    if (e->NewSize.Height / e->NewSize.Width >= 1)
    {
        VisualStateManager::GoToState(this, "Portrait", false);
    }
    else
    {
        VisualStateManager::GoToState(this, "DefaultLayout", false);
    }
}

/// <summary>
/// Invoked when the user clicks the "add" button to add a new feed.  
/// Retrieves the feed data, updates the UI, adds the feed to the ListView
/// and appends it to the data file.
/// </summary>
void MainPage::AddFeed_Click(Object^ sender, RoutedEventArgs^ e)
{
    auto app = safe_cast<App^>(App::Current);
    app->AddFeed(tbNewFeed->Text);
}

/// <summary>
/// Invoked when the user clicks the remove button. This changes the grid or list
///  to multi-select so that clicking on an item adds a check mark to it without 
/// any navigation action. This method also makes the "delete" and  "cancel" buttons
/// visible so that the user can delete selected items, or cancel the operation.
/// </summary>
void MainPage::removeFeed_Click(Object^ sender, RoutedEventArgs^ e)
{
    VisualStateManager::GoToState(this, "Checkboxes", false);
    removeButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    addButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    deleteButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    cancelButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
}

///<summary>
/// Invoked when the user presses the "trash can" delete button on the app bar.
///</summary>
void SimpleBlogReader::MainPage::deleteButton_Click(Object^ sender, RoutedEventArgs^ e)
{

    // Determine whether listview or gridview is active.
    IVector<Object^>^ itemsToDelete;
    if (ItemListView->ActualHeight > 0)
    {
        itemsToDelete = ItemListView->SelectedItems;
    }
    else
    {
        itemsToDelete = ItemGridView->SelectedItems;
    }

    // Convert the Vector<Object^> to a Vector<FeedData^>
    // before passing it to RemoveFeeds.
    auto titlesToDelete = ref new Vector<FeedData^>();
    for (const auto& item : itemsToDelete)
    {
        // Get the feed the user selected. Objects in a Vector
        // have type VectorProxy and that's why two casts are required.
        Object^ proxy = safe_cast<Object^>(item);
        FeedData^ item = safe_cast<FeedData^>(proxy);
        titlesToDelete->Append(item);
    }

    // Remove it from the data file and app-wide feed collection
    auto app = safe_cast<App^>(App::Current);
    app->RemoveFeeds(titlesToDelete); 
   
    // Return the UI to normal state.
    VisualStateManager::GoToState(this, "Normal", false);
    removeButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    addButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    deleteButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    cancelButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
}

///<summary>
/// Invoked when the user presses the "X" cancel button on the app bar. Returns the app 
/// to the state where clicking on an item causes navigation to the feed.
///</summary>
void MainPage::cancelButton_Click(Object^ sender, RoutedEventArgs^ e)
{
    VisualStateManager::GoToState(this, "Normal", false);
    removeButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    addButton->Visibility = Windows::UI::Xaml::Visibility::Visible;
    deleteButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    cancelButton->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
}


///<summary>
/// Invoked when the user clicks on an item to navigate to a feed. This event 
/// handler is not invoked when the grid is in multiple selection mode when the 
/// user is selecting items to delete.
/// </summary>
void MainPage::ItemGridView_ItemClick(Object^ sender, ItemClickEventArgs^ e)
{
        // We must manually cast from Object^ to FeedData^.
        auto feedData = safe_cast<FeedData^>(e->ClickedItem);

        // Store the feed and tell other pages it's loaded and ready to go.
        auto app = safe_cast<App^>(App::Current);
        app->SetCurrentFeed(feedData);

        // Only navigate if there are items in the feed
        if (feedData->Items->Size > 0)
        {
            // Navigate to SplitPage and pass the title of the selected feed.
            // SplitPage will receive this in its LoadState method in the 
            // navigationParamter.
            this->Frame->Navigate(SplitPage::typeid, feedData->Title);
        }
}
