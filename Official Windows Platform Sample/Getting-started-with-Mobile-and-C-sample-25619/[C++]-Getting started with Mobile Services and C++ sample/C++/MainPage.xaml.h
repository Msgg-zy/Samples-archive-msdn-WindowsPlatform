//
// MainPage.xaml.h
// Declaration of the MainPage class.
//

#pragma once

#include "MainPage.g.h"
#include <azuremobile.h>

namespace GetStartedWithMobileServices
{
    /// <summary>
    /// Represents a to do list item.
    /// </summary>
    [Windows::UI::Xaml::Data::BindableAttribute]
    public ref class TodoItem sealed
    {
    public:
        TodoItem()
        {
            Text = L"";
            Complete = false;
            ID = 0;
        }

        property int ID;
        property Platform::String^ Text;
        property bool Complete;

    internal:
        TodoItem(Platform::String^ text, bool complete = false, int id = 0)
        {
            Text = text;
            Complete = complete;
            ID = id;
        }

        // TodoItem conversion constructor from json object
        TodoItem(const web::json::value& jsonvalue)
        {
            Text = ref new Platform::String(jsonvalue[U("text")].as_string().c_str());
            Complete = jsonvalue[U("complete")].as_bool();
            ID = jsonvalue[U("id")].as_integer();
        }
    };
    
    /// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public ref class MainPage sealed
	{
	public:
		MainPage();

    protected:
        virtual void ButtonRefresh_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ args);
        virtual void ButtonSave_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ args);
        virtual void CheckBoxComplete_Checked(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ args);
        virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;

    private:
        void InsertTodoItem(TodoItem^ todoItem);
        void RefreshTodoItems();
        void UpdateCheckedTodoItem(TodoItem^ todoItem);

        Platform::Collections::Vector<TodoItem^>^ items;
        std::shared_ptr<azure::mobile::table> todoTable;
    };
}
