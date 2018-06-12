//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved


//-----------------------------------------------------------------------------
// File: Cube.cpp
//
// Desktop app that renders a spinning, colorful cube.
//
//-----------------------------------------------------------------------------


//-----------------------------------------------------------------------------
// Includes
//-----------------------------------------------------------------------------
#include "dxstdafx.h"
#include "resource.h"


//-----------------------------------------------------------------------------
// Per-vertex data
//-----------------------------------------------------------------------------
struct VertexPositionColor
{
    FLOAT x, y, z;    // from the D3DFVF_XYZRHW flag
    D3DCOLOR color;   // from the D3DFVF_DIFFUSE flag
};


//-----------------------------------------------------------------------------
// Forward declarations
//-----------------------------------------------------------------------------
LRESULT CALLBACK StaticWindowProc(
    HWND hWnd,
    UINT uMsg,
    WPARAM wParam,
    LPARAM lParam
    );
HRESULT CreateWindowResources();


//-----------------------------------------------------------------------------
// Direct3D device
//-----------------------------------------------------------------------------
IDirect3D9* m_pD3D;
IDirect3DDevice9* m_pd3dDevice;

//-----------------------------------------------------------------------------
// Direct3D device resources
//-----------------------------------------------------------------------------
ID3DXEffect* m_pEffect;
IDirect3DVertexBuffer9* pVertexBuffer;
IDirect3DIndexBuffer9*  pIndexBuffer;

//-----------------------------------------------------------------------------
// Global variables for rendering the cube
//-----------------------------------------------------------------------------
D3DXMATRIX m_view;
D3DXMATRIX m_projection;
UINT32 m_frameCount;

//-----------------------------------------------------------------------------
// Desktop window resources
//-----------------------------------------------------------------------------
HINSTANCE m_hInstance;
HMENU m_hMenu;
RECT m_rc;
HWND m_hWnd;


//-----------------------------------------------------------------------------
// Constructor
//-----------------------------------------------------------------------------
void Cube9()
{
    m_frameCount = 0; // init frame count
}

//-----------------------------------------------------------------------------
// Initialize Direct3D 9.
//-----------------------------------------------------------------------------
void Init()
{
    // Create a Direct3D object if one has not already been created
    if(m_pD3D == NULL)
    {
        m_pD3D = Direct3DCreate9(D3D_SDK_VERSION);
    }
}

//-----------------------------------------------------------------------------
// Create the Direct3D 9 device.
//-----------------------------------------------------------------------------
void CreateDevice()
{
    UINT32 AdapterOrdinal = 0;
    D3DDEVTYPE DeviceType = D3DDEVTYPE_HAL;
    D3DCAPS9 caps;
    m_pD3D->GetDeviceCaps(AdapterOrdinal, DeviceType, &caps); // caps bits

    D3DPRESENT_PARAMETERS params;
    ZeroMemory(&params, sizeof(D3DPRESENT_PARAMETERS));

    // Swap chain parameters:
    params.hDeviceWindow = m_hWnd;
    params.AutoDepthStencilFormat = D3DFMT_D24X8;
    params.BackBufferFormat = D3DFMT_X8R8G8B8;
    params.MultiSampleQuality = D3DMULTISAMPLE_NONE;
    params.MultiSampleType = D3DMULTISAMPLE_NONE;
    params.SwapEffect = D3DSWAPEFFECT_DISCARD;
    params.Windowed = true;
    params.PresentationInterval = 0;
    params.BackBufferCount = 2;
    params.BackBufferWidth = 0;
    params.BackBufferHeight = 0;
    params.EnableAutoDepthStencil = true;
    params.Flags = 2;

    m_pD3D->CreateDevice(
        0,
        D3DDEVTYPE_HAL,
        m_hWnd,
        64,
        &params,
        &m_pd3dDevice
        );
}

//-----------------------------------------------------------------------------
// Create shaders:
// Load D3DX effect.
//-----------------------------------------------------------------------------
void CreateShaders()
{
    // Turn off preshader optimization to keep calculations on the GPU
    DWORD dwShaderFlags = D3DXSHADER_NO_PRESHADER;
    
    // Only enable debug info when compiling for a debug target
#if defined (DEBUG) || defined (_DEBUG)
    dwShaderFlags |= D3DXSHADER_DEBUG;
#endif

    D3DXCreateEffectFromFile(
        m_pd3dDevice,
        L"CubeShaders.fx",
        NULL,
        NULL,
        dwShaderFlags,
        NULL,
        &m_pEffect,
        NULL
        );
}

//-----------------------------------------------------------------------------
// Create the cube:
// Creates the vertex buffer and index buffer.
//-----------------------------------------------------------------------------
void CreateCube()
{
    // Create cube geometry.
    VertexPositionColor CubeVertices[] =
    {
        {-0.5f,-0.5f,-0.5f, D3DCOLOR_XRGB(  0,   0,   0),},
        {-0.5f,-0.5f, 0.5f, D3DCOLOR_XRGB(  0,   0, 255),},
        {-0.5f, 0.5f,-0.5f, D3DCOLOR_XRGB(  0, 255,   0),},
        {-0.5f, 0.5f, 0.5f, D3DCOLOR_XRGB(  0, 255, 255),},

        { 0.5f,-0.5f,-0.5f, D3DCOLOR_XRGB(255,   0,   0),},
        { 0.5f,-0.5f, 0.5f, D3DCOLOR_XRGB(255,   0, 255),},
        { 0.5f, 0.5f,-0.5f, D3DCOLOR_XRGB(255, 255,   0),},
        { 0.5f, 0.5f, 0.5f, D3DCOLOR_XRGB(255, 255, 255),},
    };
    
    // Create vertex buffer:
    VOID* pVertices;
    
    // In Direct3D 9 we create the buffer, lock it, and copy the data from 
    // system memory to graphics memory.
    m_pd3dDevice->CreateVertexBuffer(
        sizeof(CubeVertices),
        0,
        D3DFVF_XYZ | D3DFVF_DIFFUSE,
        D3DPOOL_MANAGED,
        &pVertexBuffer,
        NULL);

    pVertexBuffer->Lock(
        0,
        sizeof(CubeVertices),
        &pVertices,
        0);

    memcpy(pVertices, CubeVertices, sizeof(CubeVertices));
    pVertexBuffer->Unlock();

    // Create index buffer:
    UINT16 CubeIndices [] = 
    {
        0,2,1, // -x
        1,2,3,
        
        4,5,6, // +x
        5,7,6,
        
        0,1,5, // -y
        0,5,4,
        
        2,6,7, // +y
        2,7,3,
        
        0,4,6, // -z
        0,6,2,
        
        1,3,7, // +z
        1,7,5,
    };

    VOID* pIndices;

    m_pd3dDevice->CreateIndexBuffer(
        sizeof(CubeIndices),
        0,
        D3DFMT_INDEX16,
        D3DPOOL_MANAGED,
        &pIndexBuffer,
        NULL);

    pIndexBuffer->Lock(
        0,
        sizeof(CubeIndices),
        (VOID**)&pIndices,
        0);
        
    memcpy(pIndices, CubeIndices, sizeof(CubeIndices));
    pIndexBuffer->Unlock();
}

//-----------------------------------------------------------------------------
// Create the view matrix and create the perspective matrix.
//-----------------------------------------------------------------------------
void CreateViewAndPerspective()
{
    D3DXVECTOR3 eye = D3DXVECTOR3(0.0f, 0.7f, 1.5f);
    D3DXVECTOR3 at  = D3DXVECTOR3(0.0f,-0.1f, 0.0f);
    D3DXVECTOR3 up  = D3DXVECTOR3(0.0f, 1.0f, 0.0f);

    // Use D3DX to create view and perspective matrices.
    D3DXMatrixLookAtRH(&m_view,
        &eye,
        &at,
        &up);
    
    D3DSURFACE_DESC desc;
    IDirect3DSurface9* pBackBuffer = NULL;
    m_pd3dDevice->GetBackBuffer(0, 0, D3DBACKBUFFER_TYPE_MONO, &pBackBuffer);
    pBackBuffer->GetDesc(&desc);

    D3DXMatrixPerspectiveFovRH(
        &m_projection,
        D3DXToRadian(70),
        (FLOAT)(desc.Width) / (FLOAT)(desc.Height),
        0.01f,
        100.0f);
}

//-----------------------------------------------------------------------------
// Create device-dependent resources.
//-----------------------------------------------------------------------------
void CreateDeviceResources()
{
    // Create the D3D9 device.
    CreateDevice();

    // Compile shaders using the Effects library.
    CreateShaders();

    // Load the geometry for the spinning cube.
    CreateCube();

    // Create the view matrix and the perspective matrix.
    CreateViewAndPerspective();
}

//-----------------------------------------------------------------------------
// Render the cube.
//-----------------------------------------------------------------------------
void RenderFrame()
{
    // This function primarily uses the Direct3D 9 device and the D3DX effect.
    
    // Clear the render target and the z-buffer.
    m_pd3dDevice->Clear(
        0, NULL,
        D3DCLEAR_TARGET | D3DCLEAR_ZBUFFER,
        D3DCOLOR_ARGB(0, 45, 50, 170),
        1.0f, 0
        );
    
    // Set the effect technique
    m_pEffect->SetTechnique("RenderSceneSimple");
    
    // Rotate the cube 1 degree per frame.
    D3DXMATRIX world;
    D3DXMatrixRotationY(&world, D3DXToRadian(m_frameCount++));
    
    
    // Set the matrices up using traditional functions.
    m_pEffect->SetMatrix("g_mWorld", &world);
    m_pEffect->SetMatrix("g_View", &m_view);
    m_pEffect->SetMatrix("g_Projection", &m_projection);
    
    // Render the scene using the Effects library.
    if(SUCCEEDED(m_pd3dDevice->BeginScene()))
    {
        // Begin rendering effect passes.
        UINT passes = 0;
        m_pEffect->Begin(&passes, 0);
        
        for (UINT i = 0; i < passes; i++)
        {
            m_pEffect->BeginPass(i);
            
            // Send vertex data to the pipeline.
            m_pd3dDevice->SetFVF(D3DFVF_XYZ | D3DFVF_DIFFUSE);
            m_pd3dDevice->SetStreamSource(
                0, pVertexBuffer,
                0, sizeof(VertexPositionColor)
                );
            m_pd3dDevice->SetIndices(pIndexBuffer);
            
            // Draw the cube.
            m_pd3dDevice->DrawIndexedPrimitive(
                D3DPT_TRIANGLELIST,
                0, 0, 8, 0, 12
                );
            m_pEffect->EndPass();
        }
        m_pEffect->End();
        
        // End drawing.
        m_pd3dDevice->EndScene();
    }
    
    // Present frame:
    // Show the frame on the primary surface.
    m_pd3dDevice->Present(NULL, NULL, NULL, NULL);
}

//-----------------------------------------------------------------------------
// Clean up cube resources when the Direct3D device is lost or destroyed.
//-----------------------------------------------------------------------------
void CleanupCube(void)
{
    // In Direct3D 9, we don't have the ComPtr class available, so we have to
    // release the cube buffers during cleanup.
    SAFE_RELEASE(pVertexBuffer);
    SAFE_RELEASE(pIndexBuffer);
}

//-----------------------------------------------------------------------------
// Subsequent methods are for the traditional desktop window.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Main function: Creates window, calls initialization functions, and hosts
// the render loop.
//-----------------------------------------------------------------------------
INT WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
    // Enable run-time memory check for debug builds.
#if defined(DEBUG) | defined(_DEBUG)
    _CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
#endif

    // Initialization starts here.

    // Initialize Direct3D 9
    Init();
    // Create a window
    CreateWindowResources();
    // Create device resources
    CreateDeviceResources();

    if(!IsWindowVisible(m_hWnd))
        ShowWindow(m_hWnd, SW_SHOW);

    // The render loop is controlled here.
    bool bGotMsg;
    MSG  msg;
    msg.message = WM_NULL;
    PeekMessage(&msg, NULL, 0U, 0U, PM_NOREMOVE);
    
    while(WM_QUIT != msg.message)
    {
        // Process window events.
        // Use PeekMessage() so we can use idle time to render the scene. 
        bGotMsg = (PeekMessage(&msg, NULL, 0U, 0U, PM_REMOVE) != 0);

        if(bGotMsg)
        {
            // Translate and dispatch the message
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
        else
        {
            // Render a new frame.
            // Render frames during idle time (when no messages are waiting).
            RenderFrame();
        }
    }

    // Clean up Direct3D 9 resource pointers before exiting.
    CleanupCube();

    return S_OK;
}

//-----------------------------------------------------------------------------
// Create a window for our Direct3D viewport.
//-----------------------------------------------------------------------------
HRESULT CreateWindowResources()
{
    // Window resources are dealt with here.
    
    if(m_hInstance == NULL) 
        m_hInstance = (HINSTANCE)GetModuleHandle(NULL);

    HICON hIcon = NULL;
    WCHAR szExePath[MAX_PATH];
        GetModuleFileName(NULL, szExePath, MAX_PATH);
    
    // If the icon is NULL, then use the first one found in the exe
    if(hIcon == NULL)
        hIcon = ExtractIcon(m_hInstance, szExePath, 0); 

    // Register the windows class
    WNDCLASS wndClass;
    wndClass.style = CS_DBLCLKS;
    wndClass.lpfnWndProc = StaticWindowProc;
    wndClass.cbClsExtra = 0;
    wndClass.cbWndExtra = 0;
    wndClass.hInstance = m_hInstance;
    wndClass.hIcon = hIcon;
    wndClass.hCursor = LoadCursor(NULL, IDC_ARROW);
    wndClass.hbrBackground = (HBRUSH)GetStockObject(BLACK_BRUSH);
    wndClass.lpszMenuName = NULL;
    wndClass.lpszClassName = L"Direct3DWindowClass";

    if(!RegisterClass(&wndClass))
    {
        DWORD dwError = GetLastError();
        if(dwError != ERROR_CLASS_ALREADY_EXISTS)
            return HRESULT_FROM_WIN32(dwError);
    }

    m_rc;
    int x = CW_USEDEFAULT;
    int y = CW_USEDEFAULT;

    // This example uses a non-resizable 640 by 480 viewport for simplicity.
    int nDefaultWidth = 640;
    int nDefaultHeight = 480;
    SetRect(&m_rc, 0, 0, nDefaultWidth, nDefaultHeight);        
    AdjustWindowRect(
        &m_rc,
        WS_OVERLAPPEDWINDOW,
        (m_hMenu != NULL) ? true : false
        );

    // Create the window for our viewport.
    m_hWnd = CreateWindow(
        L"Direct3DWindowClass",
        L"Cube9",
        WS_OVERLAPPEDWINDOW,
        x, y,
        (m_rc.right-m_rc.left), (m_rc.bottom-m_rc.top),
        0,
        m_hMenu,
        m_hInstance,
        0
        );

    if(m_hWnd == NULL)
    {
        DWORD dwError = GetLastError();
        return HRESULT_FROM_WIN32(dwError);
    }

    return S_OK;
}

//-----------------------------------------------------------------------------
// Process windows messages. This looks for window close events, letting us
// exit out of the sample.
//-----------------------------------------------------------------------------
LRESULT CALLBACK StaticWindowProc(
    HWND hWnd,
    UINT uMsg,
    WPARAM wParam,
    LPARAM lParam
    )
{
    switch(uMsg)
    {
        case WM_CLOSE:
        {
            HMENU hMenu;
            hMenu = GetMenu(hWnd);
            if(hMenu != NULL)
                DestroyMenu(hMenu);
            DestroyWindow(hWnd);
            UnregisterClass(L"Direct3DWindowClass", m_hInstance);
            return 0;
        }

        case WM_DESTROY:
            PostQuitMessage(0);
            break;
    }
    
    return DefWindowProc(hWnd, uMsg, wParam, lParam);
}