//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved


//-----------------------------------------------------------------------------
// File: Cube.cpp
//
// Windows Store app that renders a spinning, colorful cube.
//
//-----------------------------------------------------------------------------


//-----------------------------------------------------------------------------
// Includes
//-----------------------------------------------------------------------------
#include "pch.h"
#include "BasicReaderWriter.h"
#include "DirectXHelper.h"

using namespace Windows::ApplicationModel::Core;
using namespace Windows::ApplicationModel::Activation;
using namespace Windows::UI::Core;
using namespace Windows::Foundation;
using namespace Microsoft::WRL;
using namespace DirectX;


//-----------------------------------------------------------------------------
// Constant buffer data
//-----------------------------------------------------------------------------
struct ModelViewProjectionConstantBuffer
{
    DirectX::XMFLOAT4X4 model;
    DirectX::XMFLOAT4X4 view;
    DirectX::XMFLOAT4X4 projection;
};

//-----------------------------------------------------------------------------
// Per-vertex data
//-----------------------------------------------------------------------------
struct VertexPositionColor
{
    DirectX::XMFLOAT3 pos;
    DirectX::XMFLOAT3 color;
};


//-----------------------------------------------------------------------------
// Class declaration
//-----------------------------------------------------------------------------
ref class Cube11 sealed : public Windows::ApplicationModel::Core::IFrameworkView
{

private:
    //-----------------------------------------------------------------------------
    // Direct3D device
    // Also Direct3D device context and DXGI swap chain.
    //-----------------------------------------------------------------------------
    Microsoft::WRL::ComPtr<ID3D11Device1>           m_d3dDevice;
    Microsoft::WRL::ComPtr<ID3D11DeviceContext1>    m_d3dContext;
    Microsoft::WRL::ComPtr<IDXGISwapChain1>         m_swapChain;

    //-----------------------------------------------------------------------------
    // Direct3D device resources
    //-----------------------------------------------------------------------------
    Microsoft::WRL::ComPtr<ID3D11PixelShader>       m_pixelShader;
    Microsoft::WRL::ComPtr<ID3D11VertexShader>      m_vertexShader;
    Microsoft::WRL::ComPtr<ID3D11Buffer>            m_vertexBuffer;
    Microsoft::WRL::ComPtr<ID3D11Buffer>            m_indexBuffer;
    Microsoft::WRL::ComPtr<ID3D11InputLayout>       m_inputLayout;
    Microsoft::WRL::ComPtr<ID3D11Buffer>            m_constantBuffer;
    Microsoft::WRL::ComPtr<ID3D11RenderTargetView>  m_renderTargetView;

    //-----------------------------------------------------------------------------
    // Global variables for rendering the cube
    //-----------------------------------------------------------------------------
    ModelViewProjectionConstantBuffer m_constantBufferData;
    uint32 m_frameCount;
    uint32 m_indexCount;

public:

//-----------------------------------------------------------------------------
// Constructor
//-----------------------------------------------------------------------------
Cube11() :
    m_frameCount(0) // init frame count
{
}

//-----------------------------------------------------------------------------
// Create the Direct3D 11 device and device context.
//-----------------------------------------------------------------------------
void CreateDevice()
{
    // This flag adds support for surfaces with a different color channel 
    // ordering than the API default. It is required for compatibility with
    // Direct2D.
    UINT creationFlags = D3D11_CREATE_DEVICE_BGRA_SUPPORT;

#if defined(_DEBUG)
    // If the project is in a debug build, enable debugging via SDK Layers.
    creationFlags |= D3D11_CREATE_DEVICE_DEBUG;
#endif

    // This example only uses feature level 9.1.
    D3D_FEATURE_LEVEL featureLevels[] = 
    {
        D3D_FEATURE_LEVEL_9_1
    };

    // Create the Direct3D 11 API device object and a corresponding context.
    ComPtr<ID3D11Device> device;
    ComPtr<ID3D11DeviceContext> context;
    D3D11CreateDevice(
        nullptr, // Specify nullptr to use the default adapter.
        D3D_DRIVER_TYPE_HARDWARE,
        nullptr,
        creationFlags,
        featureLevels,
        ARRAYSIZE(featureLevels),
        D3D11_SDK_VERSION, // Windows Store apps must set this to D3D11_SDK_VERSION.
        &device, // Returns the Direct3D device created.
        nullptr,
        &context // Returns the device immediate context.
        );
    
    // Store pointers to the Direct3D 11.2 API device and immediate context.
    device.As(&m_d3dDevice);
    
    context.As(&m_d3dContext);
}

//-----------------------------------------------------------------------------
// Create the swap chain, back buffer and viewport.
//-----------------------------------------------------------------------------
void Cube11::CreateWindowSizeDependentResources(CoreWindow^ window)
{
    if(m_swapChain != nullptr)
    {
        // If the swap chain already exists, resize it.
        m_swapChain->ResizeBuffers(
            2, // Double-buffered swap chain.
            0,
            0,
            DXGI_FORMAT_B8G8R8A8_UNORM,
            0
            );
    }
    else
    {
        // Otherwise, create a new one using the same adapter as the existing
        // Direct3D device.
        DXGI_SWAP_CHAIN_DESC1 swapChainDesc = {0};

        // Swap chain parameters:
        swapChainDesc.Format = DXGI_FORMAT_B8G8R8A8_UNORM;
        swapChainDesc.Stereo = false;
        swapChainDesc.SampleDesc.Count = 1; // No multisampling
        swapChainDesc.SampleDesc.Quality = 0;
        swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL; //required
        // Make sure the resource is flagged for use as a render target.
        swapChainDesc.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;
        swapChainDesc.BufferCount = 2; // Double-buffering
        swapChainDesc.Width = 0; // Auto size
        swapChainDesc.Height = 0;
        swapChainDesc.Scaling = DXGI_SCALING_NONE; // Back buffer scaling
        
        // This sequence obtains the DXGI factory.
        // First, the DXGI interface for the Direct3D device:
        ComPtr<IDXGIDevice2> dxgiDevice;
        m_d3dDevice.As(&dxgiDevice);
        
        // Then, the adapter hosting the device;
        ComPtr<IDXGIAdapter> dxgiAdapter;
        dxgiDevice->GetAdapter(&dxgiAdapter);
        
        // Then, the factory that created the adapter interface:
        ComPtr<IDXGIFactory2> dxgiFactory;
        dxgiAdapter->GetParent(
            __uuidof(IDXGIFactory2),
            &dxgiFactory
            );
        
        // Finally, use the factory to create the swap chain interface:
        ComPtr<IDXGISwapChain1> swapChain;
        dxgiFactory->CreateSwapChainForCoreWindow(
            m_d3dDevice.Get(),
            reinterpret_cast<IUnknown*>(window),
            &swapChainDesc,
            nullptr,
            &swapChain
            );
        swapChain.As(&m_swapChain);
                    
        // Ensure that DXGI does not queue more than one frame at a time. This both 
        // reduces latency and ensures that the application will only render 
        // after each VSync, minimizing power consumption.
        dxgiDevice->SetMaximumFrameLatency(1);
    }
    
    // Get the back buffer resource.
    ComPtr<ID3D11Texture2D> backBuffer;
    m_swapChain->GetBuffer(
        0,
        __uuidof(ID3D11Texture2D),
        &backBuffer
        );

    // Create a render target view on the back buffer.
    m_d3dDevice->CreateRenderTargetView(
        backBuffer.Get(),
        nullptr,
        &m_renderTargetView
        );
    
    // Set the rendering viewport to target the entire window.
    D3D11_TEXTURE2D_DESC backBufferDesc = {0};
    backBuffer->GetDesc(&backBufferDesc);

    CD3D11_VIEWPORT viewport(
        0.0f,
        0.0f,
        static_cast<float>(backBufferDesc.Width),
        static_cast<float>(backBufferDesc.Height)
        );

    m_d3dContext->RSSetViewports(1, &viewport);
    
    // The perspective matrix depends on the viewport aspect ratio.
    CreatePerspectiveMatrix(
        static_cast<float>(backBufferDesc.Width),
        static_cast<float>(backBufferDesc.Height)
        );    
}

//-----------------------------------------------------------------------------
// Create shaders:
// Load compiled shader objects.
//-----------------------------------------------------------------------------
void CreateShaders()
{
    // BasicReaderWriter is a tested file loader used in SDK samples.
    BasicReaderWriter^ readerWriter = ref new BasicReaderWriter();


    // Load vertex shader:
    Platform::Array<byte>^ vertexShaderData =
        readerWriter->ReadData("CubeVertexShader.cso");
    
    // This call allocates a device resource, validates the vertex shader 
    // with the device feature level, and stores the vertex shader bits in 
    // graphics memory.
    m_d3dDevice->CreateVertexShader(
        vertexShaderData->Data,
        vertexShaderData->Length,
        nullptr,
        &m_vertexShader
        );
    
    
    // Create input layout:
    const D3D11_INPUT_ELEMENT_DESC vertexDesc[] = 
    {
        { "POSITION", 0, DXGI_FORMAT_R32G32B32_FLOAT,
            0, 0,  D3D11_INPUT_PER_VERTEX_DATA, 0 },

        { "COLOR",    0, DXGI_FORMAT_R32G32B32_FLOAT, 
            0, 12, D3D11_INPUT_PER_VERTEX_DATA, 0 },
    };

    // This call allocates a device resource and stores the input layout in 
    // graphics memory.
    m_d3dDevice->CreateInputLayout(
        vertexDesc,
        ARRAYSIZE(vertexDesc),
        vertexShaderData->Data,
        vertexShaderData->Length,
        &m_inputLayout
        );


    // Create constant buffer:
    CD3D11_BUFFER_DESC constantBufferDesc(
        sizeof(ModelViewProjectionConstantBuffer),
        D3D11_BIND_CONSTANT_BUFFER
        );

    // This call allocates a device resource to store constant data for the 
    // vertex shader. The actual constant buffer data will be sent later.
    m_d3dDevice->CreateBuffer(
        &constantBufferDesc,
        nullptr,
        &m_constantBuffer
        );


    // Load pixel shader:
    Platform::Array<byte>^ pixelShaderData =
        readerWriter->ReadData("CubePixelShader.cso");

    // This call allocates a device resource and stores the pixel shader bits
    // in graphics memory.
    m_d3dDevice->CreatePixelShader(
        pixelShaderData->Data,
        pixelShaderData->Length,
        nullptr,
        &m_pixelShader
        );
    
}


//-----------------------------------------------------------------------------
// Create the cube:
// Creates the vertex buffer and index buffer.
// Note that these buffers are device resources.
//-----------------------------------------------------------------------------
void CreateCube()
{
    // Create vertex buffer to store cube geometry:
    VertexPositionColor CubeVertices[] = 
    {
        {XMFLOAT3(-0.5f, -0.5f, -0.5f), XMFLOAT3(0.0f, 0.0f, 0.0f)},
        {XMFLOAT3(-0.5f, -0.5f,  0.5f), XMFLOAT3(0.0f, 0.0f, 1.0f)},
        {XMFLOAT3(-0.5f,  0.5f, -0.5f), XMFLOAT3(0.0f, 1.0f, 0.0f)},
        {XMFLOAT3(-0.5f,  0.5f,  0.5f), XMFLOAT3(0.0f, 1.0f, 1.0f)},

        {XMFLOAT3( 0.5f, -0.5f, -0.5f), XMFLOAT3(1.0f, 0.0f, 0.0f)},
        {XMFLOAT3( 0.5f, -0.5f,  0.5f), XMFLOAT3(1.0f, 0.0f, 1.0f)},
        {XMFLOAT3( 0.5f,  0.5f, -0.5f), XMFLOAT3(1.0f, 1.0f, 0.0f)},
        {XMFLOAT3( 0.5f,  0.5f,  0.5f), XMFLOAT3(1.0f, 1.0f, 1.0f)},
    };
    
    // The buffer description tells Direct3D how to create this buffer.
    D3D11_SUBRESOURCE_DATA vertexBufferData = {0};
    vertexBufferData.pSysMem = CubeVertices;
    vertexBufferData.SysMemPitch = 0;
    vertexBufferData.SysMemSlicePitch = 0;
    CD3D11_BUFFER_DESC vertexBufferDesc(
        sizeof(CubeVertices),
        D3D11_BIND_VERTEX_BUFFER);
  
    // This call allocates a device resource for the vertex buffer and copies
    // in the data.
    m_d3dDevice->CreateBuffer(
        &vertexBufferDesc,
        &vertexBufferData,
        &m_vertexBuffer
        );
    

    // Create index buffer:
    unsigned short cubeIndices[] = 
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

    m_indexCount = ARRAYSIZE(cubeIndices);

    D3D11_SUBRESOURCE_DATA indexBufferData = {0};
    indexBufferData.pSysMem = cubeIndices;
    indexBufferData.SysMemPitch = 0;
    indexBufferData.SysMemSlicePitch = 0;
    CD3D11_BUFFER_DESC indexBufferDesc(
        sizeof(cubeIndices),
        D3D11_BIND_INDEX_BUFFER);
    
    // This call allocates a device resource for the index buffer and copies
    // in the data.
    m_d3dDevice->CreateBuffer(
        &indexBufferDesc,
        &indexBufferData,
        &m_indexBuffer
        );
}

//-----------------------------------------------------------------------------
// Create the view matrix.
//-----------------------------------------------------------------------------
void CreateViewMatrix()
{
    // Create the constant buffer data in system memory.
    XMVECTOR eye = XMVectorSet(0.0f, 0.7f, 1.5f, 0.0f);
    XMVECTOR at = XMVectorSet(0.0f, -0.1f, 0.0f, 0.0f);
    XMVECTOR up = XMVectorSet(0.0f, 1.0f, 0.0f, 0.0f);

    XMStoreFloat4x4(
        &m_constantBufferData.view, 
        XMMatrixTranspose(XMMatrixLookAtRH(eye, at, up))
        );
}

//-----------------------------------------------------------------------------
// Create the perspective matrix.
//-----------------------------------------------------------------------------
void CreatePerspectiveMatrix(float width, float height)
{
    // Set up the perspective matrix with the correct aspect ratio.
    float aspectRatio = width / height;
    float fovAngleY = 70.0f * XM_PI / 180.0f;

    XMStoreFloat4x4(
        &m_constantBufferData.projection,
        XMMatrixTranspose(
            XMMatrixPerspectiveFovRH(
                fovAngleY,
                aspectRatio,
                0.01f,
                100.0f
                )
            )
        );
}


//-----------------------------------------------------------------------------
// Create device-dependent resources.
//-----------------------------------------------------------------------------
void CreateDeviceResources()
{
    // Create the D3D11 device and context.
    CreateDevice();

    // Load shader binaries.
    CreateShaders();

    // Load the geometry for the spinning cube.
    CreateCube();

    // Create the view matrix.
    CreateViewMatrix();

    // Since the perspective matrix depends on the viewport aspect ratio, it is
    // created by CreateWindowSizeDependentResources().
}

//-----------------------------------------------------------------------------
// Render the cube.
//-----------------------------------------------------------------------------
void Cube11::RenderFrame()
{
    // This function primarily uses the Direct3D 11 device context.
    
    // Clear the back buffer.
    const float midnightBlue[] = { 0.098f, 0.098f, 0.439f, 1.000f };
    m_d3dContext->ClearRenderTargetView(
        m_renderTargetView.Get(),
        midnightBlue
        );
    
    // Set the render target. This starts the drawing operation.
    m_d3dContext->OMSetRenderTargets(
        1,  // number of render target views for this drawing operation.
        m_renderTargetView.GetAddressOf(),
        nullptr
        );
    

    // Rotate the cube 1 degree per frame.
    XMStoreFloat4x4(
        &m_constantBufferData.model, 
        XMMatrixTranspose(XMMatrixRotationY(m_frameCount++ * XM_PI / 180.f))
        );
    
    // Copy the updated constant buffer from system memory to video memory.
    m_d3dContext->UpdateSubresource(
        m_constantBuffer.Get(),
        0,      // update the 0th subresource
        NULL,   // use the whole destination
        &m_constantBufferData,
        0,      // default pitch
        0       // default pitch
        );
    

    // Send vertex data to the Input Assembler stage.
    UINT stride = sizeof(VertexPositionColor);
    UINT offset = 0;

    m_d3dContext->IASetVertexBuffers(
        0,  // start with the first vertex buffer
        1,  // one vertex buffer
        m_vertexBuffer.GetAddressOf(),
        &stride,
        &offset
        );

    m_d3dContext->IASetIndexBuffer(
        m_indexBuffer.Get(),
        DXGI_FORMAT_R16_UINT,
        0   // no offset
        );

    m_d3dContext->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
    m_d3dContext->IASetInputLayout(m_inputLayout.Get());
    

    // Set the vertex shader.
    m_d3dContext->VSSetShader(
        m_vertexShader.Get(),
        nullptr,
        0
        );
    
    // Set the vertex shader constant buffer data.
    m_d3dContext->VSSetConstantBuffers(
        0,  // register 0
        1,  // one constant buffer
        m_constantBuffer.GetAddressOf()
        );
    

    // Set the pixel shader.
    m_d3dContext->PSSetShader(
        m_pixelShader.Get(),
        nullptr,
        0
        );
    

    // Draw the cube.
    m_d3dContext->DrawIndexed(
        m_indexCount,
        0,  // start with index 0
        0   // start with vertex 0
        );
    
    // Note that BeginDraw/EndDraw are replaced by setting the render target
    // and calling a draw function.
    
    
    // Present the frame by swapping the back buffer to the screen.
    m_swapChain->Present(1, 0);
}


//-----------------------------------------------------------------------------
// Subsequent methods are for the new IFrameworkView and CoreWindow.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// IFrameworkView method.
// The first method called when the IFrameworkView is being created.
// Calls initialization functions.
//-----------------------------------------------------------------------------
virtual void Initialize(CoreApplicationView^ applicationView)
{
    // Initialization starts in this function.

    // Start setting up Direct3D device-dependent resources.
    CreateDeviceResources();
}

//-----------------------------------------------------------------------------
// IFrameworkView method.
// Used to load external resources.
//-----------------------------------------------------------------------------
virtual void Load(Platform::String^ entryPoint)
{
    // Use this method to start loading assets, for example texture maps.
    // Load assets asynchronously using PPL tasks. Let this method exit while
    // the async functions are still running.
}

//-----------------------------------------------------------------------------
// IFrameworkView method.
// This method is called after the window becomes active.
// The render loop is controlled here.
//-----------------------------------------------------------------------------
virtual void Run()
{
    // Render the first frame before activating the window, or else the first
    // frame will be the background color.
    RenderFrame();

    // Call this method to dismiss the loading screen.
    CoreWindow::GetForCurrentThread()->Activate();
    
    // Main loop
    // Windows Store apps should not exit. Use app lifecycle events instead.
    while (true)
    {
        // Process window events.
        auto dispatcher = CoreWindow::GetForCurrentThread()->Dispatcher;
        dispatcher->ProcessEvents(CoreProcessEventsOption::ProcessAllIfPresent);

        // Render a new frame.
        RenderFrame();
    }
}

//-----------------------------------------------------------------------------
// IFrameworkView method.
// Called when the CoreWindow object is created (or re-created). Instead of
// creating the window, we just need to use this method to respond when the 
// CoreWindow is assigned to this app.
//-----------------------------------------------------------------------------
virtual void SetWindow(CoreWindow^ window)
{
    // Window resources are dealt with here.

    // Register event handlers with the CoreWindow object.
    window->SizeChanged += 
        ref new TypedEventHandler<CoreWindow^, WindowSizeChangedEventArgs^>(
            this,
            &Cube11::OnWindowSizeChanged
            );

    // A new CoreWindow has been provided, so create a viewport and swap chain
    // attached to the CoreWindow and sized appropriately.
    CreateWindowSizeDependentResources(window);
}


//-----------------------------------------------------------------------------
// IFrameworkView method.
// Terminate events do not cause Uninitialize to be called. It will be called
// if your IFrameworkView class is torn down while the app is in the foreground.
//-----------------------------------------------------------------------------
virtual void Uninitialize()
{
}

protected:

//-----------------------------------------------------------------------------
// CoreWindow delegate.
// This method is called in the event handler for the SizeChanged event.
//-----------------------------------------------------------------------------
void OnWindowSizeChanged(
    Windows::UI::Core::CoreWindow^ sender,                              
    Windows::UI::Core::WindowSizeChangedEventArgs^ args
    )
{
    // Set the render target to null as a signal to recreate window resources.
    m_renderTargetView = nullptr;
    CreateWindowSizeDependentResources(sender);
}

};


//-----------------------------------------------------------------------------
// This class creates our IFrameworkView.
//-----------------------------------------------------------------------------
ref class Direct3DApplicationSource sealed : 
    Windows::ApplicationModel::Core::IFrameworkViewSource
{
public:
    virtual Windows::ApplicationModel::Core::IFrameworkView^ CreateView()
    {
        return ref new Cube11();
    };
};


//-----------------------------------------------------------------------------
// Required method for a DirectX-only app.
// The main function is only used to initialize the app's IFrameworkView class.
//-----------------------------------------------------------------------------
[Platform::MTAThread]
int main(Platform::Array<Platform::String^>^)
{
    auto direct3DApplicationSource = ref new Direct3DApplicationSource();
    CoreApplication::Run(direct3DApplicationSource);
    return 0;
}