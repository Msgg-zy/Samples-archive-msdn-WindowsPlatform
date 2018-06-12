//
// TextViewerPage.xaml.cpp
// Implementation of the TextViewerPage class
//

#include "pch.h"
#include "TextViewerPage.xaml.h"
#include "TextHelper.h"
#include "WebViewerPage.xaml.h"

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
using namespace Windows::Data::Html;
using namespace Windows::UI::Xaml::Documents;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

TextViewerPage::TextViewerPage()
{
    InitializeComponent();
    SetValue(_defaultViewModelProperty, 
        ref new Platform::Collections::Map<String^, Object^>(std::less<String^>()));
    auto navigationHelper = ref new Common::NavigationHelper(this);
    SetValue(_navigationHelperProperty, navigationHelper);
    navigationHelper->LoadState += 
        ref new Common::LoadStateEventHandler(this, &TextViewerPage::LoadState);
    navigationHelper->SaveState += 
        ref new Common::SaveStateEventHandler(this, &TextViewerPage::SaveState);

  //  this->DataContext = DefaultViewModel;

}

DependencyProperty^ TextViewerPage::_defaultViewModelProperty =
DependencyProperty::Register("DefaultViewModel",
TypeName(IObservableMap<String^, Object^>::typeid), TypeName(TextViewerPage::typeid), nullptr);

/// <summary>
/// Used as a trivial view model.
/// </summary>
IObservableMap<String^, Object^>^ TextViewerPage::DefaultViewModel::get()
{
    return safe_cast<IObservableMap<String^, Object^>^>(GetValue(_defaultViewModelProperty));
}

DependencyProperty^ TextViewerPage::_navigationHelperProperty =
DependencyProperty::Register("NavigationHelper",
TypeName(Common::NavigationHelper::typeid), TypeName(TextViewerPage::typeid), nullptr);

/// <summary>
/// Gets an implementation of <see cref="NavigationHelper"/> designed to be
/// used as a trivial view model.
/// </summary>
Common::NavigationHelper^ TextViewerPage::NavigationHelper::get()
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

void TextViewerPage::OnNavigatedTo(NavigationEventArgs^ e)
{
    NavigationHelper->OnNavigatedTo(e);
}

void TextViewerPage::OnNavigatedFrom(NavigationEventArgs^ e)
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
/// <see cref="Frame::Navigate(Type, Object)"/> when this page was initially 
/// requested and a dictionary of state preserved by this page during an earlier
/// session. The state will be null the first time a page is visited.</param>
void TextViewerPage::LoadState(Object^ sender, Common::LoadStateEventArgs^ e)
{
    (void)sender;	// Unused parameter
    // (void)e;	// Unused parameter

    auto app = safe_cast<App^>(App::Current);
    app->GetCurrentFeedAsync().then([this, app, e](FeedData^ fd)
    {        
        m_feedItem = app->GetFeedItem(fd, safe_cast<String^>(e->NavigationParameter));
        FeedItemTitle->Text = m_feedItem->Title;
        BlogTextBlock->Blocks->Clear();
        TextHelper^ helper = ref new TextHelper();

        auto blocks = helper->
            CreateRichText(m_feedItem->Content, 
                ref new TypedEventHandler<Hyperlink^, HyperlinkClickEventArgs^>
                (this, &TextViewerPage::RichTextHyperlinkClicked));
        for (auto b : blocks)
        {
            BlogTextBlock->Blocks->Append(b);
        }
    }, task_continuation_context::use_current());    
}

void TextViewerPage::SaveState(Object^ sender, Common::SaveStateEventArgs^ e){
    (void)sender;	// Unused parameter

    e->PageState->Insert("Uri", m_feedItem->Link->AbsoluteUri);
}

///<summary>
/// Invoked when the user clicks on the "Link" text at the top of the rich text 
/// view of the feed. This navigates to the web page. Identical action to using
/// the App bar "forward" button.
///</summary>
void TextViewerPage::RichTextHyperlinkClicked(Hyperlink^ hyperLink, 
    HyperlinkClickEventArgs^ args)
{
    this->Frame->Navigate(WebViewerPage::typeid, m_feedItem->Link->AbsoluteUri);
}


