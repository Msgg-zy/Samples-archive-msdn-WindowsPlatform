// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

//
// MainPage.xaml.cpp
// Implementation of the MainPage.xaml class.
//

#include "pch.h"
#include "MainPage.xaml.h"

using namespace Windows::Graphics::Display;
using namespace Windows::UI::ViewManagement;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::System;
using namespace Windows::Foundation;
using namespace Platform;
using namespace Windows::Devices::Sensors;
using namespace OrientationCPP;
using namespace CppSamplesUtils;

MainPage::MainPage()
{
    InitializeComponent();

    ScenarioList->SelectionChanged += ref new SelectionChangedEventHandler(this, &MainPage::ScenarioList_SelectionChanged);

    // Check for a previous selection
    ListBoxItem^ startingScenario = nullptr;

    auto ps = SuspensionManager::SessionState();
    if (ps->HasKey("SelectedScenario"))
    {
        PropertyValue^ pv;
        String^ item = dynamic_cast<String^>(ps->Lookup("SelectedScenario"));   
        startingScenario = dynamic_cast<ListBoxItem^>(this->FindName(item));                 
    }

    ScenarioList->SelectedItem = startingScenario != nullptr ? startingScenario : Scenario1;

    DisplayProperties::OrientationChanged += ref new DisplayPropertiesEventHandler(this, &MainPage::Page_OrientationChanged);
    ApplicationLayout::GetForCurrentView()->LayoutChanged += ref new TypedEventHandler<ApplicationLayout^,ApplicationLayoutChangedEventArgs^>(this, &MainPage::Page_LayoutChanged);

    sensor = OrientationSensor::GetDefault();
}

MainPage::~MainPage()
{
}

void MainPage::DisplayError(String^ errorText)
{
    ResetAll();

    ErrorOutputText->Text = errorText;
    ErrorOutput->Visibility = Windows::UI::Xaml::Visibility::Visible;
}

void MainPage::ReadingChanged(OrientationSensor^ /* sender */, OrientationSensorReadingChangedEventArgs^ e)
{
    OrientationSensorReading^ reading = e->Reading;

    // Quaternion values
    Scenario1Output_X->Text = reading->Quaternion->X.ToString();
    Scenario1Output_Y->Text = reading->Quaternion->Y.ToString();
    Scenario1Output_Z->Text = reading->Quaternion->Z.ToString();
    Scenario1Output_W->Text = reading->Quaternion->W.ToString();

    // Rotation Matrix values
    Scenario1Output_M11->Text = reading->RotationMatrix->M11.ToString();
    Scenario1Output_M12->Text = reading->RotationMatrix->M12.ToString();
    Scenario1Output_M13->Text = reading->RotationMatrix->M13.ToString();
    Scenario1Output_M21->Text = reading->RotationMatrix->M21.ToString();
    Scenario1Output_M22->Text = reading->RotationMatrix->M22.ToString();
    Scenario1Output_M23->Text = reading->RotationMatrix->M23.ToString();
    Scenario1Output_M31->Text = reading->RotationMatrix->M31.ToString();
    Scenario1Output_M32->Text = reading->RotationMatrix->M32.ToString();
    Scenario1Output_M33->Text = reading->RotationMatrix->M33.ToString();
}

void MainPage::Scenario1Enable(Object^ /* sender */, RoutedEventArgs^ /* e */)
{
    if (sensor != nullptr)
    {
        listenerToken = sensor->ReadingChanged::add(ref new TypedEventHandler<OrientationSensor^, OrientationSensorReadingChangedEventArgs^>(this, &MainPage::ReadingChanged));
        Scenario1EnableButton->IsEnabled = false;
        Scenario1DisableButton->IsEnabled = true;
    }
    else
    {
        DisplayError("No orientation sensor found");
    }
}

void MainPage::Scenario1Disable(Object^ sender, RoutedEventArgs^ e)
{
    sensor->ReadingChanged::remove(listenerToken);
    Scenario1EnableButton->IsEnabled = true;
    Scenario1DisableButton->IsEnabled = false;
}

void MainPage::Scenario1Reset()
{
    if (Scenario1DisableButton->IsEnabled)
    {
        sensor->ReadingChanged::remove(listenerToken);
        Scenario1EnableButton->IsEnabled = true;
        Scenario1DisableButton->IsEnabled = false;
    }
}

void MainPage::Scenario2Get(Object^ /* sender */, RoutedEventArgs^ e)
{
    if (sensor != nullptr)
    {
        OrientationSensorReading^ reading = sensor->GetCurrentReading();

        // Quaternion values
        Scenario2Output_X->Text = reading->Quaternion->X.ToString();
        Scenario2Output_Y->Text = reading->Quaternion->Y.ToString();
        Scenario2Output_Z->Text = reading->Quaternion->Z.ToString();
        Scenario2Output_W->Text = reading->Quaternion->W.ToString();

        // Rotation Matrix values
        Scenario2Output_M11->Text = reading->RotationMatrix->M11.ToString();
        Scenario2Output_M12->Text = reading->RotationMatrix->M12.ToString();
        Scenario2Output_M13->Text = reading->RotationMatrix->M13.ToString();
        Scenario2Output_M21->Text = reading->RotationMatrix->M21.ToString();
        Scenario2Output_M22->Text = reading->RotationMatrix->M22.ToString();
        Scenario2Output_M23->Text = reading->RotationMatrix->M23.ToString();
        Scenario2Output_M31->Text = reading->RotationMatrix->M31.ToString();
        Scenario2Output_M32->Text = reading->RotationMatrix->M32.ToString();
        Scenario2Output_M33->Text = reading->RotationMatrix->M33.ToString();
    }
    else
    {
        DisplayError("No orientation sensor found");
    }
}

void MainPage::Scenario2Reset()
{
}

void MainPage::ResetAll()
{
    ErrorOutput->Visibility = Windows::UI::Xaml::Visibility::Collapsed;

    Scenario1Input->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    Scenario1Output->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    Scenario1Reset();
    Scenario2Input->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    Scenario2Output->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    Scenario2Reset();
}

void MainPage::ScenarioList_SelectionChanged(Object^ sender, SelectionChangedEventArgs^ e)
{
    ResetAll();

    ListBoxItem^ selectedListBoxItem = dynamic_cast<ListBoxItem^>(ScenarioList->SelectedItem);
    SuspensionManager::SessionState()->Insert("SelectedScenario", selectedListBoxItem->Name);

    if (ScenarioList->SelectedIndex == 0)
    {
        Scenario1Input->Visibility = Windows::UI::Xaml::Visibility::Visible;
        Scenario1Output->Visibility = Windows::UI::Xaml::Visibility::Visible;
    }
    else if (ScenarioList->SelectedIndex == 1)
    {
        Scenario2Input->Visibility = Windows::UI::Xaml::Visibility::Visible;
        Scenario2Output->Visibility = Windows::UI::Xaml::Visibility::Visible;
    }
}

void MainPage::Footer_Click(Object^ sender, RoutedEventArgs^ e)
{
    auto _hyperlinkButton = (HyperlinkButton^)sender;
    Windows::System::Launcher::LaunchDefaultProgram(ref new Windows::Foundation::Uri((String^)_hyperlinkButton->Tag));
}

void MainPage::Page_LayoutChanged(ApplicationLayout^ sender, ApplicationLayoutChangedEventArgs^ e)
{
    switch (e->Layout)
    {
    case ApplicationLayoutState::Filled:
        VisualStateManager::GoToState(this, "Fill", false);
        break;
    case ApplicationLayoutState::FullScreen:
        VisualStateManager::GoToState(this, "Full", false);
        break;
    case ApplicationLayoutState::Snapped:
        VisualStateManager::GoToState(this, "Snapped", false);
        break;
    }
}

void MainPage::Page_OrientationChanged(Object^ sender)
{
    if (DisplayProperties::CurrentOrientation == DisplayOrientations::Portrait ||
        DisplayProperties::CurrentOrientation == DisplayOrientations::PortraitFlipped)
    {
        VisualStateManager::GoToState(this, "Portrait", false);
    }
}
