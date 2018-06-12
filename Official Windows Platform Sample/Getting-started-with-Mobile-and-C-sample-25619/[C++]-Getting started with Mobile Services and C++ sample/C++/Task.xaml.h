//
// Task.xaml.h
// Declaration of the Task class
//

#pragma once

#include "Task.g.h"

namespace GetStartedWithMobileServices
{
	[Windows::Foundation::Metadata::WebHostHidden]
	public ref class Task sealed
	{
	public:
		Task();

        property int Number
        {
            int get()
            {
                return safe_cast<int>(GetValue(NumberProperty));
            }
            void set(int value)
            {
                SetValue(NumberProperty, value);
            }
        }

        property Platform::String^ Title
        {
            Platform::String^ get()
            {
                return safe_cast<Platform::String^>(GetValue(TitleProperty));
            }
            void set(Platform::String^ value)
            {
                SetValue(TitleProperty, value);
            }
        }

        property Platform::String^ Description
        {
            Platform::String^ get()
            {
                return safe_cast<Platform::String^>(GetValue(DescriptionProperty));
            }
            void set(Platform::String^ value)
            {
                SetValue(DescriptionProperty, value);
            }
        }

    private:
        static Windows::UI::Xaml::DependencyProperty^ NumberProperty;
        static Windows::UI::Xaml::DependencyProperty^ TitleProperty;
        static Windows::UI::Xaml::DependencyProperty^ DescriptionProperty;
    };
}
