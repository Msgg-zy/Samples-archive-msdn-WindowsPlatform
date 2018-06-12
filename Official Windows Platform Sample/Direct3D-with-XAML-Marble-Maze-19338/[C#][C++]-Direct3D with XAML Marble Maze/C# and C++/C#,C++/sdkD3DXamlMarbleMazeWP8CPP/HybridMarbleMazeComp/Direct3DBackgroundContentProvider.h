#pragma once

#include "pch.h"
#include <wrl/module.h>
#include <Windows.Phone.Graphics.Interop.h>
#include <DrawingSurfaceNative.h>

#include "Direct3DInterop.h"

class Direct3DBackgroundContentProvider : public Microsoft::WRL::RuntimeClass<
        Microsoft::WRL::RuntimeClassFlags<Microsoft::WRL::WinRtClassicComMix>,
        ABI::Windows::Phone::Graphics::Interop::IDrawingSurfaceBackgroundContentProvider,
        IDrawingSurfaceBackgroundContentProviderNative>
{
public:
    Direct3DBackgroundContentProvider(HybridMarbleMazeComp::Direct3DInterop^ controller);

    // IDrawingSurfaceContentProviderNative
    HRESULT STDMETHODCALLTYPE Connect(_In_ IDrawingSurfaceRuntimeHostNative* host, _In_ ID3D11Device1* device);
    void STDMETHODCALLTYPE Disconnect();

    HRESULT STDMETHODCALLTYPE PrepareResources(_In_ const LARGE_INTEGER* presentTargetTime, _Inout_ DrawingSurfaceSizeF* desiredRenderTargetSize);
    HRESULT STDMETHODCALLTYPE Draw(_In_ ID3D11Device1* device, _In_ ID3D11DeviceContext1* context, _In_ ID3D11RenderTargetView* renderTargetView);

private:
    HybridMarbleMazeComp::Direct3DInterop^ m_controller;
    Microsoft::WRL::ComPtr<IDrawingSurfaceRuntimeHostNative> m_host;
};