//
// Task.xaml.cpp
// Implementation of the Task class
//

#include "pch.h"
#include "Task.xaml.h"

using namespace GetStartedWithMobileServices;

using namespace Platform;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Interop;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

Task::Task()
{
    InitializeComponent();
    this->DataContext = this;
}

// Using a DependencyProperty as the backing store for Number.  
// This enables animation, styling, binding, etc... 
DependencyProperty^ Task::NumberProperty =
    DependencyProperty::Register(
    "Number", TypeName(int::typeid), TypeName(Task::typeid), nullptr);

// Using a DependencyProperty as the backing store for Title.  
// This enables animation, styling, binding, etc... 
DependencyProperty^ Task::TitleProperty =
    DependencyProperty::Register(
    "Title", TypeName(String::typeid), TypeName(Task::typeid), nullptr);

// Using a DependencyProperty as the backing store for Description.  
// This enables animation, styling, binding, etc... 
DependencyProperty^ Task::DescriptionProperty =
    DependencyProperty::Register(
    "Description", TypeName(String::typeid), TypeName(Task::typeid), nullptr);