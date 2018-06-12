//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved


//
// MainPage.xaml.h
// Declaration of the MainPage class.
//

#pragma once

#include "DirectXPage.g.h"

#include "DeviceResources.h"
#include "MultisampleDemoXAMLMain.h"

namespace MultisampleDemoXAML
{
	/// <summary>
	/// A page that hosts a DirectX SwapChainBackgroundPanel.
	/// This page must be the root of the Window content (it cannot be hosted on a Frame).
	/// </summary>
	public ref class DirectXPage sealed
	{
	public:
		DirectXPage();

		void SaveInternalState(Windows::Foundation::Collections::IPropertySet^ state);
		void LoadInternalState(Windows::Foundation::Collections::IPropertySet^ state);

	private:

        // For multisampling selector
        void SetupSampleSizeSlider();
        unsigned int m_sampleLookupArray[16];


		// XAML low-level rendering event handler.
		void OnRendering(Platform::Object^ sender, Platform::Object^ args);

		// Window event handlers.
		void OnVisibilityChanged(Windows::UI::Core::CoreWindow^ sender, Windows::UI::Core::VisibilityChangedEventArgs^ args);

		// Display properties event handlers.
		void OnDpiChanged(Windows::Graphics::Display::DisplayInformation^ sender, Platform::Object^ args);
		void OnOrientationChanged(Windows::Graphics::Display::DisplayInformation^ sender, Platform::Object^ args);
		void OnDisplayContentsInvalidated(Windows::Graphics::Display::DisplayInformation^ sender, Platform::Object^ args);

		// Other event handlers.
		void OnCompositionScaleChanged(Windows::UI::Xaml::Controls::SwapChainPanel^ sender, Object^ args);
		void OnSwapChainPanelSizeChanged(Platform::Object^ sender, Windows::UI::Xaml::SizeChangedEventArgs^ e);

		// Resource used to keep track of the rendering event registration.
		Windows::Foundation::EventRegistrationToken m_eventToken;

		// Resources used to render the DirectX content in the XAML page background
        std::shared_ptr<DeviceResources> m_deviceResources;
		std::unique_ptr<MultisampleDemoXAMLMain> m_main; 
		bool m_windowVisible;
        void SampleCountSlider_ValueChanged(Platform::Object^ sender, Windows::UI::Xaml::Controls::Primitives::RangeBaseValueChangedEventArgs^ e);
        void ScalingSlider_ValueChanged(Platform::Object^ sender, Windows::UI::Xaml::Controls::Primitives::RangeBaseValueChangedEventArgs^ e);
    };
}
