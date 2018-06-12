//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "MainPage.xaml.h"
#include "services\mobile services\TodoCppClient\TodoCppClientMobileService.h"

using namespace GetStartedWithMobileServices;

using namespace Platform;
using namespace Platform::Collections;
using namespace web;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

MainPage::MainPage()
{
	InitializeComponent();

    items = ref new Vector<TodoItem^>();
    ListItems->ItemsSource = items;
    todoTable = std::make_shared<azure::mobile::table>
        (AzureMobileHelper::TodoCppClientMobileService::GetClient(), L"TodoItem");
}

void MainPage::InsertTodoItem(TodoItem^ todoItem)
{
    auto obj = json::value::object();
    obj[U("text")] = json::value::string(todoItem->Text->Data());
    obj[U("complete")] = json::value::boolean(todoItem->Complete);
    todoTable->insert(obj).then([=](json::value result)
    {
        if (result.is_object())
        {
            todoItem->ID = result[U("id")].as_integer();
            items->Append(todoItem);
        }
    }, concurrency::task_continuation_context::use_current());
}

void MainPage::RefreshTodoItems()
{
    azure::mobile::query_params query;
    query.where(U("complete ne true"));

    todoTable->read(query).then([this](json::value result)
    {
        if (result.is_array())
        {
            items = ref new Vector<TodoItem^>();

            for (auto iter = result.cbegin(); iter != result.cend(); ++iter)
            {
                if (iter->second.is_object())
                {
                    items->Append(ref new TodoItem(iter->second));
                }
            }
            ListItems->ItemsSource = items;
        }
    }, concurrency::task_continuation_context::use_current());
}

void MainPage::UpdateCheckedTodoItem(TodoItem^ item)
{
    auto obj = json::value::object();
    obj[U("text")] = json::value::string(item->Text->Data());
    obj[U("complete")] = json::value::boolean(true);
    obj[U("id")] = json::value::number(item->ID);

    todoTable->update(obj).then([this, item](json::value v)
    {}, concurrency::task_continuation_context::use_current());
}

void MainPage::ButtonRefresh_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ args)
{
    RefreshTodoItems();
}

void MainPage::ButtonSave_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ args)
{
    auto todoItem = ref new TodoItem(TextInput->Text);
    InsertTodoItem(todoItem);
}

void MainPage::CheckBoxComplete_Checked(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ args)
{
    auto cb = dynamic_cast<CheckBox^>(sender);
    TodoItem^ item = dynamic_cast<TodoItem^>(cb->DataContext);
    UpdateCheckedTodoItem(item);
}

void MainPage::OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e)
{
    RefreshTodoItems();
}
