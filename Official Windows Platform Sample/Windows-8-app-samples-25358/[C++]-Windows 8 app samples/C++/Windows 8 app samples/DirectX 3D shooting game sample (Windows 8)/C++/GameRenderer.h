//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

#pragma once

// GameRenderer:
// This is the renderer for the game.  It derives from DirectXBase.
// It is responsble for creating and maintaining all the D3D11 and D2D objects
// used to generate the game visuals.  It maintains a reference to the Simple3DGame
// object to retrieve the list of objects to render as well as status of the 
// game for the Heads Up Display (HUD).
//
// The renderer is designed to use a standard vertex layout across all objects.  This 
// simplifies the shader design and allows for easy changes between shaders independent
// of the objects' geometry.  Each vertex is defined by a position, a normal and one set of
// 2D texture coordinates.  The shaders all expect one 2D texture and 4 constant buffers:
//     m_constantBufferNeverChanges - general parameters that are set only once.  This includes
//         all the lights used in scene generation.
//     m_constantBufferChangeOnResize - the projection matrix.  It is typically only changed when
//         the window is resized, however it will be changed 2x per frame when rendering
//         in 3D stereo.
//     m_constantBufferChangesEveryFrame - the view transformation matrix.  This is set once per frame.
//     m_constantBufferChangesEveryPrim - the parameters for each object.  It includes the object to world
//         transformation matrix as well as material properties like color and specular exponent for lighting
//         calculations.
//
// The renderer also maintains a set of texture resources that will be associated with particular game objects.
// It knows which textures are to be associated with which objects and will do that association once the 
// textures have been loaded.
//
// The renderer provides a set of methods to allow for a "standard" sequence to be executed for loading general
// game resources and for level specific resources.  Because D3D11 allows free threaded creation of objects,
// textures will be loaded asynchronously and in parallel, however D3D11 does not allow for multiple threads to
// be using the DeviceContext at the same time.
//
// The pattern is:
//     create_task([this]()
//     {
//         // create/load device resources
//     }).then([this]()
//     {
//         // create/load device context resources
//     }, task_continuation_context::use_current());

#include "DirectXBase.h"
#include "GameInfoOverlay.h"
#include "GameHud.h"
#include "Simple3DGame.h"

ref class Simple3DGame;
ref class GameHud;

ref class GameRenderer : public DirectXBase
{
internal:
    GameRenderer();

    virtual void Initialize(
        _In_ Windows::UI::Core::CoreWindow^ window,
        float dpi
        ) override;

    virtual void CreateDeviceIndependentResources() override;
    virtual void CreateDeviceResources() override;
    virtual void UpdateForWindowSizeChange() override;
    virtual void Render() override;
    virtual void HandleDeviceLost() override;
    virtual void SetDpi(float dpi) override;

    concurrency::task<void> CreateGameDeviceResourcesAsync(_In_ Simple3DGame^ game);
    void FinalizeCreateGameDeviceResources();
    concurrency::task<void> LoadLevelResourcesAsync();
    void FinalizeLoadLevelResources();

    GameInfoOverlay^ InfoOverlay()  { return m_gameInfoOverlay; };

    DirectX::XMFLOAT2 GameInfoOverlayUpperLeft()
    {
        return DirectX::XMFLOAT2(
            (m_windowBounds.Width  - GameInfoOverlayConstant::Width) / 2.0f,
            (m_windowBounds.Height - GameInfoOverlayConstant::Height) / 2.0f
            );
    };
    DirectX::XMFLOAT2 GameInfoOverlayLowerRight()
    {
        return DirectX::XMFLOAT2(
            (m_windowBounds.Width  - GameInfoOverlayConstant::Width) / 2.0f + GameInfoOverlayConstant::Width,
            (m_windowBounds.Height - GameInfoOverlayConstant::Height) / 2.0f + GameInfoOverlayConstant::Height
            );
    };

#if defined(_DEBUG)
    void ReportLiveDeviceObjects();
#endif

protected private:
    bool                                                m_initialized;
    bool                                                m_gameResourcesLoaded;
    bool                                                m_levelResourcesLoaded;
    GameInfoOverlay^                                    m_gameInfoOverlay;
    GameHud^                                            m_gameHud;
    Simple3DGame^                                       m_game;

    Microsoft::WRL::ComPtr<ID3D11ShaderResourceView>    m_sphereTexture;
    Microsoft::WRL::ComPtr<ID3D11ShaderResourceView>    m_cylinderTexture;
    Microsoft::WRL::ComPtr<ID3D11ShaderResourceView>    m_ceilingTexture;
    Microsoft::WRL::ComPtr<ID3D11ShaderResourceView>    m_floorTexture;
    Microsoft::WRL::ComPtr<ID3D11ShaderResourceView>    m_wallsTexture;

    Microsoft::WRL::ComPtr<ID3D11Buffer>                m_constantBufferNeverChanges;
    Microsoft::WRL::ComPtr<ID3D11Buffer>                m_constantBufferChangeOnResize;
    Microsoft::WRL::ComPtr<ID3D11Buffer>                m_constantBufferChangesEveryFrame;
    Microsoft::WRL::ComPtr<ID3D11Buffer>                m_constantBufferChangesEveryPrim;
    Microsoft::WRL::ComPtr<ID3D11SamplerState>          m_samplerLinear;
    Microsoft::WRL::ComPtr<ID3D11VertexShader>          m_vertexShader;
    Microsoft::WRL::ComPtr<ID3D11VertexShader>          m_vertexShaderFlat;
    Microsoft::WRL::ComPtr<ID3D11PixelShader>           m_pixelShader;
    Microsoft::WRL::ComPtr<ID3D11PixelShader>           m_pixelShaderFlat;
    Microsoft::WRL::ComPtr<ID3D11InputLayout>           m_vertexLayout;
};
