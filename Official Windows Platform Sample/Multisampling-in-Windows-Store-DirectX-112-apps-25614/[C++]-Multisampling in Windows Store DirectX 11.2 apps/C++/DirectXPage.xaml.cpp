//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved


//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "DirectXPage.xaml.h"

using namespace MultisampleDemoXAML;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Graphics::Display;
using namespace Windows::System::Threading;
using namespace Windows::UI::Core;
using namespace Windows::UI::Input;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

DirectXPage::DirectXPage():
	m_windowVisible(true)
{
	InitializeComponent();

	// Register event handlers for page lifecycle.
	CoreWindow^ window = Window::Current->CoreWindow;

	window->VisibilityChanged +=
		ref new TypedEventHandler<CoreWindow^, VisibilityChangedEventArgs^>(this, &DirectXPage::OnVisibilityChanged);

	DisplayInformation^ currentDisplayInformation = DisplayInformation::GetForCurrentView();

	currentDisplayInformation->DpiChanged +=
		ref new TypedEventHandler<DisplayInformation^, Object^>(this, &DirectXPage::OnDpiChanged);

	currentDisplayInformation->OrientationChanged +=
		ref new TypedEventHandler<DisplayInformation^, Object^>(this, &DirectXPage::OnOrientationChanged);

	DisplayInformation::DisplayContentsInvalidated +=
		ref new TypedEventHandler<DisplayInformation^, Object^>(this, &DirectXPage::OnDisplayContentsInvalidated);

	swapChainPanel->CompositionScaleChanged += 
		ref new TypedEventHandler<SwapChainPanel^, Object^>(this, &DirectXPage::OnCompositionScaleChanged);

	swapChainPanel->SizeChanged +=
		ref new SizeChangedEventHandler(this, &DirectXPage::OnSwapChainPanelSizeChanged);


	// Register the rendering event, called every time XAML renders the screen.
	m_eventToken = CompositionTarget::Rendering::add(ref new EventHandler<Object^>(this, &DirectXPage::OnRendering));

	// Whenever this screen is not being used anymore, you can unregister this event with the following line:
	// CompositionTarget::Rendering::remove(m_eventToken);

	// Disable all pointer visual feedback for better performance when touching.
	auto pointerVisualizationSettings = PointerVisualizationSettings::GetForCurrentView();
	pointerVisualizationSettings->IsContactFeedbackEnabled = false; 
	pointerVisualizationSettings->IsBarrelButtonFeedbackEnabled = false;

	// At this point we have access to the device. 
	// We can create the device-dependent resources.
	m_deviceResources = std::make_shared<DeviceResources>();
	m_deviceResources->SetWindow(Window::Current->CoreWindow, swapChainPanel);

    // Adjust slider to reflect multisampling support of the device
    SetupSampleSizeSlider();

	m_main = std::unique_ptr<MultisampleDemoXAMLMain>(new MultisampleDemoXAMLMain(m_deviceResources));
}

// Sets up an array to translate linear XAML slider values into a non-linear 
// list of sample sizes.
void DirectXPage::SetupSampleSizeSlider()
{
    MultisamplingSupportInfo^ samplingInfo = m_deviceResources->GetMultisamplingSupportInfo();
    unsigned int maxArraySize = samplingInfo->GetLargestSampleSize();
    unsigned int currentSampleSize = m_deviceResources->GetSampleSize();

    ZeroMemory(&m_sampleLookupArray, sizeof(m_sampleLookupArray));
    unsigned int maxSampleSize = 0;
    unsigned int numberOfSampleSizesSupported = 0;

    unsigned int format = samplingInfo->GetFormat();

    for (int i = 0; i < 129; i++)
    {
        if (samplingInfo->GetSampleSize(format, i) == 1)
        {
            maxSampleSize = i;
            m_sampleLookupArray[numberOfSampleSizesSupported] = i;

            if (i == (currentSampleSize))
            {
                SampleCountSlider->Value = numberOfSampleSizesSupported;
                CurrentSampleCount->Text = i.ToString();
            }

            numberOfSampleSizesSupported++;
        }
    }

    SampleCountSlider->Minimum = 0;
    SampleCountSlider->Maximum = numberOfSampleSizesSupported - 1;
}

// Saves the current state of the app for suspend and terminate events.
void DirectXPage::SaveInternalState(IPropertySet^ state)
{
	m_deviceResources->Trim();

	// Put code to save app state here.
}

// Loads the current state of the app for resume events.
void DirectXPage::LoadInternalState(IPropertySet^ state)
{
	// Put code to load app state here.
}

// Called every time XAML decides to render a frame.
void DirectXPage::OnRendering(Object^ sender, Object^ args)
{
	if (m_windowVisible)
	{
		m_main->Update();

		if (m_main->Render())
		{
			m_deviceResources->Present();
		}
	}
}

// Window event handlers.

void DirectXPage::OnVisibilityChanged(CoreWindow^ sender, VisibilityChangedEventArgs^ args)
{
	m_windowVisible = args->Visible;
}

// Display properties event handlers.

void DirectXPage::OnDpiChanged(DisplayInformation^ sender, Object^ args)
{
	m_deviceResources->SetDpi(sender->LogicalDpi);
}


void DirectXPage::OnOrientationChanged(DisplayInformation^ sender, Object^ args)
{
	m_deviceResources->UpdateForWindowSizeChange();
	m_main->CreateWindowSizeDependentResources();
}


void DirectXPage::OnDisplayContentsInvalidated(DisplayInformation^ sender, Object^ args)
{
	m_deviceResources->ValidateDevice();
}

void DirectXPage::OnCompositionScaleChanged(SwapChainPanel^ sender, Object^ args)
{
	m_deviceResources->CreateWindowSizeDependentResources();
	m_main->CreateWindowSizeDependentResources();
}

void DirectXPage::OnSwapChainPanelSizeChanged(Object^ sender, SizeChangedEventArgs^ e)
{
    m_deviceResources->UpdateForWindowSizeChange();
	m_main->CreateWindowSizeDependentResources();
}


void MultisampleDemoXAML::DirectXPage::SampleCountSlider_ValueChanged(Platform::Object^ sender, Windows::UI::Xaml::Controls::Primitives::RangeBaseValueChangedEventArgs^ e)
{
    if (m_deviceResources == nullptr) return;

    unsigned int newValue = static_cast<unsigned int>(e->NewValue);

    unsigned int newSampleSize = m_sampleLookupArray[newValue];

    m_deviceResources->SetMultisampling(newSampleSize, D3D11_STANDARD_MULTISAMPLE_PATTERN);

    CurrentSampleCount->Text = newSampleSize.ToString();
}


void MultisampleDemoXAML::DirectXPage::ScalingSlider_ValueChanged(Platform::Object^ sender, Windows::UI::Xaml::Controls::Primitives::RangeBaseValueChangedEventArgs^ e)
{
    if (m_deviceResources == nullptr) return;

    m_deviceResources->SetScalingFactor(static_cast<float>(e->NewValue));

    CurrentScaling->Text = e->NewValue.ToString();
}
