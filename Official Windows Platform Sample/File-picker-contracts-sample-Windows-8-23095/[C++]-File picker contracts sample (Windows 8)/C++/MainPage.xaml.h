//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

//
// MainPage.xaml.h
// Declaration of the MainPage.xaml class.
//

#pragma once

#include "pch.h"
#include "MainPage.g.h"
#include "Common\LayoutAwarePage.h" // Required by generated header
#include "Constants.h"

namespace SDKSample
{
    [Windows::Foundation::Metadata::WebHostHidden]
    public ref class MainPage sealed
    {
    public:
        MainPage();
        static property Platform::String^ FEATURE_NAME
        {
            Platform::String^ get()
            {
                return ref new Platform::String(L"File picker contracts C++ sample");
            }
        }

        static property Platform::Array<Scenario>^ scenarios
        {
            Platform::Array<Scenario>^ get()
            {
                return scenariosInner;
            }
        }

    internal:
        property bool AutoSizeInputSectionWhenSnapped
        {
            bool get()
            {
                return autoSizeInputSectionWhenSnapped;
            }

            void set(bool value)
            {
                autoSizeInputSectionWhenSnapped = value;
            }
        }

        property Windows::ApplicationModel::Activation::LaunchActivatedEventArgs^ LaunchArgs
       {
            Windows::ApplicationModel::Activation::LaunchActivatedEventArgs^ get()
            {
                return safe_cast<App^>(App::Current)->LaunchArgs;
            }
        }

        bool EnsureUnsnapped();
        void ResetScenarioOutput(Windows::UI::Xaml::Controls::TextBlock^ textblock);
        void NotifyUser(Platform::String^ strMessage, NotifyType type);
        void LoadScenario(Platform::String^ scenarioName);
        event Windows::Foundation::EventHandler<Platform::Object^>^ ScenarioLoaded;
        event Windows::Foundation::EventHandler<PageSizeChangedEventArgs^>^ PageResized;

    private:
        void PopulateScenarios();
        void InvalidateSize();
        void InvalidateViewState();
        void Footer_Click(Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);

        Platform::Collections::Vector<Object^>^ ScenarioList;
        Windows::UI::Xaml::Controls::Frame^ HiddenFrame;
        bool autoSizeInputSectionWhenSnapped;
        static Platform::Array<Scenario>^ scenariosInner;
    
    protected:
        void MainPage_SizeChanged(Object^ sender, Windows::UI::Xaml::SizeChangedEventArgs^ e);
        void Scenarios_SelectionChanged(Object^ sender, Windows::UI::Xaml::Controls::SelectionChangedEventArgs^ e);
        virtual void LoadState(Platform::Object^ navigationParameter,
        Windows::Foundation::Collections::IMap<Platform::String^, Platform::Object^>^ pageState) override;
        virtual void SaveState(Windows::Foundation::Collections::IMap<Platform::String^, Platform::Object^>^ pageState) override;

    internal:
        static MainPage^ Current;
    };
}
