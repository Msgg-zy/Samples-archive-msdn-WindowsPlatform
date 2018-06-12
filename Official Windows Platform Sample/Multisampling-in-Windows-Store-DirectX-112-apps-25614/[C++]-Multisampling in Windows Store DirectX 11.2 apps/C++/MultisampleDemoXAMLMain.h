//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved


#pragma once

#include "Common\StepTimer.h"
#include "DeviceResources.h"
#include "Content\Sample3DSceneRenderer.h"
#include "Content\SampleFpsTextRenderer.h"

// Renders Direct2D and 3D content on the screen.
namespace MultisampleDemoXAML
{
	class MultisampleDemoXAMLMain : public IDeviceNotify
	{
	public:
		MultisampleDemoXAMLMain(const std::shared_ptr<DeviceResources>& deviceResources);
		~MultisampleDemoXAMLMain();
		void CreateWindowSizeDependentResources();
		void Update();
		bool Render();

		// IDeviceNotify
		virtual void OnDeviceLost();
		virtual void OnDeviceRecreated();

	private:
		// Cached pointer to device resources.
		std::shared_ptr<DeviceResources> m_deviceResources;

		// TODO: Replace with your own content.
		std::unique_ptr<Sample3DSceneRenderer> m_sceneRenderer;
		std::unique_ptr<SampleFpsTextRenderer> m_fpsTextRenderer;

		// Rendering loop timer.
		DX::StepTimer m_timer;
	};
}