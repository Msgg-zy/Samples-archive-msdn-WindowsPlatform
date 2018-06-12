// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

//
// MainPage.xaml.h
// Declaration of the MainPage.xaml class.
//

#pragma once

#include "pch.h"
#include "MainPage.g.h"

namespace OrientationCPP
{
    public ref class MainPage
    {
    public:
        MainPage();
        ~MainPage();

    private:
        void ScenarioList_SelectionChanged(Platform::Object^ sender, Windows::UI::Xaml::Controls::SelectionChangedEventArgs^ e);
        void Footer_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
        void Page_LayoutChanged(Windows::UI::ViewManagement::ApplicationLayout^ sender, Windows::UI::ViewManagement::ApplicationLayoutChangedEventArgs^ e);
        void Page_OrientationChanged(Platform::Object^ sender);

        void ReadingChanged(Windows::Devices::Sensors::OrientationSensor^ sender, Windows::Devices::Sensors::OrientationSensorReadingChangedEventArgs^ e);
        void Scenario1Enable(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
        void Scenario1Disable(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
        void Scenario1Reset();
        void Scenario2Get(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
        void Scenario2Reset();
        void ResetAll();
        void DisplayError(Platform::String^ errorText);

        Windows::Devices::Sensors::OrientationSensor^ sensor;
        Windows::Foundation::EventRegistrationToken listenerToken;
    };
}
