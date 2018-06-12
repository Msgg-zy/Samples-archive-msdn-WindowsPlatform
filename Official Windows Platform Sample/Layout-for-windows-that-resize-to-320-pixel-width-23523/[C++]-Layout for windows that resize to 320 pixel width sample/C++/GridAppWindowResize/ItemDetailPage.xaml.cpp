﻿//
// ItemDetailPage.xaml.cpp
// Implementation of the ItemDetailPage class
//

#include "pch.h"
#include "ItemDetailPage.xaml.h"

using namespace GridAppWindowResize;

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

// The Item Detail Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234232

ItemDetailPage::ItemDetailPage()
{
	InitializeComponent();
	SetValue(_defaultViewModelProperty, ref new Map<String^,Object^>(std::less<String^>()));
	auto navigationHelper = ref new Common::NavigationHelper(this);
	SetValue(_navigationHelperProperty, navigationHelper);
	navigationHelper->LoadState += ref new Common::LoadStateEventHandler(this, &ItemDetailPage::LoadState);
	SizeChanged += ref new Windows::UI::Xaml::SizeChangedEventHandler(this, &GridAppWindowResize::ItemDetailPage::OnSizeChanged);
}

DependencyProperty^ ItemDetailPage::_defaultViewModelProperty =
	DependencyProperty::Register("DefaultViewModel",
		TypeName(IObservableMap<String^,Object^>::typeid), TypeName(ItemDetailPage::typeid), nullptr);

/// <summary>
/// used as a trivial view model.
/// </summary>
IObservableMap<String^, Object^>^ ItemDetailPage::DefaultViewModel::get()
{
	return safe_cast<IObservableMap<String^, Object^>^>(GetValue(_defaultViewModelProperty));
}

DependencyProperty^ ItemDetailPage::_navigationHelperProperty =
	DependencyProperty::Register("NavigationHelper",
		TypeName(Common::NavigationHelper::typeid), TypeName(ItemDetailPage::typeid), nullptr);

/// <summary>
/// Gets an implementation of <see cref="NavigationHelper"/> designed to be
/// used as a trivial view model.
/// </summary>
Common::NavigationHelper^ ItemDetailPage::NavigationHelper::get()
{
	return safe_cast<Common::NavigationHelper^>(GetValue(_navigationHelperProperty));
}

/// <summary>
/// Populates the page with content passed during navigation.  Any saved state is also
/// provided when recreating a page from a prior session.
/// </summary>
/// <param name="sender">
/// The source of the event; typically <see cref="NavigationHelper"/>
/// </param>
/// <param name="e">Event data that provides both the navigation parameter passed to
/// <see cref="Frame::Navigate(Type, Object)"/> when this page was initially requested and
/// a dictionary of state preserved by this page during an earlier
/// session.  The state will be null the first time a page is visited.</param>
void ItemDetailPage::LoadState(Object^ sender, Common::LoadStateEventArgs^ e)
{
	String^ navigationParameter = safe_cast<String^>(e->NavigationParameter);

	// Allow saved page state to override the initial item to display
	if (e->PageState != nullptr && e->PageState->HasKey("SelectedItem"))
	{
		navigationParameter = safe_cast<String^>(e->PageState->Lookup("SelectedItem"));
	}

	// TODO: Create an appropriate data model for your problem domain to replace the sample data
	Data::SampleDataSource::GetItem(safe_cast<String^>(navigationParameter))
	.then([this](Data::SampleDataItem^ item)
	{
		DefaultViewModel->Insert("Item", item);
	}, task_continuation_context::use_current());
}

#pragma region NavigationHelper registration

/// The methods provided in this section are simply used to allow
/// NavigationHelper to respond to the page's navigation methods.
/// 
/// Page specific logic should be placed in event handlers for the  
/// <see cref="NavigationHelper::LoadState"/>
/// and <see cref="NavigationHelper::SaveState"/>.
/// The navigation parameter is available in the LoadState method 
/// in addition to page state preserved during an earlier session.

void ItemDetailPage::OnNavigatedTo(NavigationEventArgs^ e)
{
	NavigationHelper->OnNavigatedTo(e);
}

void ItemDetailPage::OnNavigatedFrom(NavigationEventArgs^ e)
{
	NavigationHelper->OnNavigatedFrom(e);
}
#pragma endregion

/// /// If the page is resized to less than 500 pixels, use the layout for narrow widths. 
/// Otherwise, use the default layout.
void GridAppWindowResize::ItemDetailPage::OnSizeChanged(Platform::Object ^sender, Windows::UI::Xaml::SizeChangedEventArgs ^e)
{
	(void) sender;	// Unused parameter

	if (e->NewSize.Width < 500)
	{
		VisualStateManager::GoToState(this, "MinimalLayout", true);
	}
	else
	{
		VisualStateManager::GoToState(this, "DefaultLayout", true);
	}
}
