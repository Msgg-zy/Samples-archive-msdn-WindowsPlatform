// <Include>
///////////////////////////////////////////////////////////////////////////////
//
// THIS FILE IS AUTOMATICALLY GENERATED.  DO NOT MODIFY IT BY HAND.
//
///////////////////////////////////////////////////////////////////////////////
// </Include>

// <LiteralInclude>
#include <wsdapi.h>
// </LiteralInclude>

// <LiteralInclude>
#include "FileService.h"
// </LiteralInclude>

// <LiteralInclude>
#include "FileServiceTypes.h"
// </LiteralInclude>

// <LiteralInclude>
#include "FileServiceProxy.h"
// </LiteralInclude>

// <ProxyBuilderImplementations>
HRESULT CreateCFileServiceProxy(
                LPCWSTR pszDeviceAddress,
                LPCWSTR pszLocalAddress,
                CFileServiceProxy** ppProxyOut,
                IWSDXMLContext** ppContextOut)
{
    HRESULT hr = S_OK;
    IWSDXMLContext* pContext = NULL;
    IWSDDeviceProxy* pDeviceProxy = NULL;
    IWSDServiceProxy* pServiceProxy = NULL;
    CFileServiceProxy* pProxy = NULL;

    // 
    // Validate parameters
    // 
    if( NULL == pszDeviceAddress )
    {
        return E_INVALIDARG;
    }

    if( NULL == pszLocalAddress )
    {
        return E_INVALIDARG;
    }

    if( NULL == ppProxyOut )
    {
        return E_POINTER;
    }

    // ppContextOut is optional

    *ppProxyOut = NULL;
    if( NULL != ppContextOut )
    {
        *ppContextOut = NULL;
    }

    // 
    // Create XML context for namespace and type registration
    // 
    hr = WSDXMLCreateContext(&pContext);

    // 
    // Register types used by the service
    // 
    if( S_OK == hr )
    {
        hr = FileServiceRegisterTypes(pContext);
    }

    // 
    // Register namespaces used by the service
    // 
    if( S_OK == hr )
    {
        hr = FileServiceRegisterNamespaces(pContext);
    }

    // 
    // Create a proxy for the device host
    // 
    if( S_OK == hr )
    {
        hr = WSDCreateDeviceProxy(pszDeviceAddress, pszLocalAddress, pContext, &pDeviceProxy);
    }

    // 
    // Create a proxy for the service
    // 
    if( S_OK == hr )
    {
        hr = pDeviceProxy->GetServiceProxyByType(&Names_FileService[5], &pServiceProxy);
    }

    // 
    // Create a proxy for the port type
    // 
    if( S_OK == hr )
    {
        pProxy = new CFileServiceProxy();
        if( NULL == pProxy )
        {
            hr = E_OUTOFMEMORY;
        }
    }

    if( S_OK == hr )
    {
        hr = pProxy->Init(pServiceProxy);
    }

    // 
    // Cleanup
    // 
    if( NULL != pServiceProxy )
    {
        pServiceProxy->Release();
    }

    if( NULL != pDeviceProxy )
    {
        pDeviceProxy->Release();
    }

    if( S_OK == hr && ppContextOut )
    {
        *ppContextOut = pContext;
    }
    else
    {
        if( NULL != pContext )
        {
            pContext->Release();
        }
    }

    if( S_OK == hr )
    {
        *ppProxyOut = pProxy;
    }
    else
    {
        if( NULL != pProxy )
        {
            pProxy->Release();
        }
    }

    return hr;
}

HRESULT CreateCFileServiceProxyById(
                LPCWSTR pszDeviceAddress,
                LPCWSTR pszServiceId,
                LPCWSTR pszLocalAddress,
                CFileServiceProxy** ppProxyOut,
                IWSDXMLContext** ppContextOut)
{
    HRESULT hr = S_OK;
    IWSDXMLContext* pContext = NULL;
    IWSDDeviceProxy* pDeviceProxy = NULL;
    IWSDServiceProxy* pServiceProxy = NULL;
    CFileServiceProxy* pProxy = NULL;

    // 
    // Validate parameters
    // 
    if( NULL == pszDeviceAddress )
    {
        return E_INVALIDARG;
    }

    if( NULL == pszServiceId )
    {
        return E_INVALIDARG;
    }

    if( NULL == pszLocalAddress )
    {
        return E_INVALIDARG;
    }

    if( NULL == ppProxyOut )
    {
        return E_POINTER;
    }

    // ppContextOut is optional

    *ppProxyOut = NULL;
    if( NULL != ppContextOut )
    {
        *ppContextOut = NULL;
    }

    // 
    // Create XML context for namespace and type registration
    // 
    hr = WSDXMLCreateContext(&pContext);

    // 
    // Register types used by the service
    // 
    if( S_OK == hr )
    {
        hr = FileServiceRegisterTypes(pContext);
    }

    // 
    // Register namespaces used by the service
    // 
    if( S_OK == hr )
    {
        hr = FileServiceRegisterNamespaces(pContext);
    }

    // 
    // Create a proxy for the device host
    // 
    if( S_OK == hr )
    {
        hr = WSDCreateDeviceProxy(pszDeviceAddress, pszLocalAddress, pContext, &pDeviceProxy);
    }

    // 
    // Create a proxy for the service
    // 
    if( S_OK == hr )
    {
        hr = pDeviceProxy->GetServiceProxyById(pszServiceId, &pServiceProxy);
    }

    // 
    // Create a proxy for the port type
    // 
    if( S_OK == hr )
    {
        pProxy = new CFileServiceProxy();
        if( NULL == pProxy )
        {
            hr = E_OUTOFMEMORY;
        }
    }

    if( S_OK == hr )
    {
        hr = pProxy->Init(pServiceProxy);
    }

    // 
    // Cleanup
    // 
    if( NULL != pServiceProxy )
    {
        pServiceProxy->Release();
    }

    if( NULL != pDeviceProxy )
    {
        pDeviceProxy->Release();
    }

    if( S_OK == hr && ppContextOut )
    {
        *ppContextOut = pContext;
    }
    else
    {
        if( NULL != pContext )
        {
            pContext->Release();
        }
    }

    if( S_OK == hr )
    {
        *ppProxyOut = pProxy;
    }
    else
    {
        if( NULL != pProxy )
        {
            pProxy->Release();
        }
    }

    return hr;
}

// </ProxyBuilderImplementations>

// <CDATA>

CFileServiceProxy::CFileServiceProxy() :
    m_cRef(1), m_genericProxy(NULL)
{
}

CFileServiceProxy::~CFileServiceProxy() 
{
    if ( NULL != m_genericProxy )
    {
        m_genericProxy->Release();
        m_genericProxy = NULL;
    }
};

HRESULT STDMETHODCALLTYPE CFileServiceProxy::Init(
    /* [in] */ IWSDServiceProxy* pIWSDServiceProxy )
{
    if( NULL == pIWSDServiceProxy )
    {
        return E_INVALIDARG;
    }

    m_genericProxy = pIWSDServiceProxy;
    m_genericProxy->AddRef();

    return S_OK;
}

// </CDATA>

// <IUnknownDefinitions>
HRESULT STDMETHODCALLTYPE CFileServiceProxy::QueryInterface(REFIID riid, void **ppvObject)
{
    if (NULL == ppvObject)
    {
        return E_POINTER;
    }

    HRESULT hr = S_OK;
    *ppvObject = NULL;

    if (__uuidof(IUnknown) == riid)
    {
        *ppvObject = (IUnknown *)this;
    }
    else if (__uuidof(IFileService) == riid)
    {
        *ppvObject = (IFileService *)this;
    }
    else if (__uuidof(IFileServiceProxy) == riid)
    {
        *ppvObject = (IFileServiceProxy *)this;
    }
    else
    {
        hr = E_NOINTERFACE;
    }

    if (SUCCEEDED(hr))
    {
        ((LPUNKNOWN)*ppvObject)->AddRef();
    }

    return hr;
}

ULONG STDMETHODCALLTYPE CFileServiceProxy::AddRef()
{
    ULONG ulNewRefCount = (ULONG)InterlockedIncrement((LONG *)&m_cRef);
    return ulNewRefCount;
}

ULONG STDMETHODCALLTYPE CFileServiceProxy::Release()
{
    ULONG ulNewRefCount = (ULONG)InterlockedDecrement((LONG *)&m_cRef);

    if (0 == ulNewRefCount)
    {
        delete this;
    }

    return ulNewRefCount;
}
// </IUnknownDefinitions>

// <ProxyFunctionImplementations>
HRESULT STDMETHODCALLTYPE
CFileServiceProxy::GetFileList
(   /* [out] */ GET_FILE_LIST_RESPONSE** parametersOut
)
{
    HRESULT hr = S_OK;

    // Initialize Output Pointers
    if( NULL != parametersOut )
    {
        *parametersOut = NULL;
    }

    // Validate Response Parameters
    if( NULL == parametersOut )
    {
        hr = E_POINTER;
        return hr;
    }

    if( NULL == m_genericProxy )
    {
        hr = E_ABORT;
        return hr;
    }

    IWSDEndpointProxy* ep = NULL;
    hr = m_genericProxy->GetEndpointProxy(&ep);
    if( FAILED(hr) || NULL == ep )
    {
        hr = E_ABORT;
        return hr;
    }

    WSD_SYNCHRONOUS_RESPONSE_CONTEXT context;
    ::ZeroMemory(&context, sizeof(context));
    context.eventHandle = ::CreateEvent(NULL, FALSE, FALSE, NULL);
    if (NULL == context.eventHandle)
    {
        DWORD dw = ::GetLastError();
        hr = HRESULT_FROM_WIN32(dw);
        ep->Release();
        return hr;
    }
    hr = 
        ep->SendTwoWayRequest
        (   NULL
        ,   &Operations_FileService[0]
        ,   &context
        );

    if (SUCCEEDED(hr))
    {
        if ( WAIT_FAILED == ::WaitForSingleObject(context.eventHandle, INFINITE) )
        {
             DWORD dw = ::GetLastError();
             hr = HRESULT_FROM_WIN32(dw);
        }
    }

    ::CloseHandle(context.eventHandle);
    context.eventHandle = NULL;

    if (SUCCEEDED(hr))
    {
        if (SUCCEEDED(context.hr))
        {
            if( NULL != context.results )
            {
                RESPONSEBODY_FileService_GetFileList* response = reinterpret_cast<RESPONSEBODY_FileService_GetFileList*>(context.results);

                WSDDetachLinkedMemory( (void*) response->parameters );
                *parametersOut = response->parameters;

                WSDFreeLinkedMemory( context.results );
                context.results = NULL;
            }
            else
            {
                hr = E_FAIL;
            }
        }
        else
        {
            hr = context.hr;
            if( context.results )
            {
                ep->ProcessFault( (const WSD_SOAP_FAULT*)context.results );
            }
        }
    }

    if ( NULL != context.messageParameters )
    {
        context.messageParameters->Release();
        context.messageParameters = NULL;
    }

    ep->Release();
    return hr;
}

HRESULT STDMETHODCALLTYPE
CFileServiceProxy::GetFile
(   /* [in] */ GET_FILE_REQUEST* parameters
,   /* [out] */ GET_FILE_RESPONSE** parametersOut
)
{
    HRESULT hr = S_OK;

    // Initialize Output Pointers
    if( NULL != parametersOut )
    {
        *parametersOut = NULL;
    }

    // Validate Request Parameters
    if( NULL == parameters )
    {
        hr = E_INVALIDARG;
        return hr;
    }

    // Validate Response Parameters
    if( NULL == parametersOut )
    {
        hr = E_POINTER;
        return hr;
    }

    REQUESTBODY_FileService_GetFile request;

    request.parameters = parameters;

    if( NULL == m_genericProxy )
    {
        hr = E_ABORT;
        return hr;
    }

    IWSDEndpointProxy* ep = NULL;
    hr = m_genericProxy->GetEndpointProxy(&ep);
    if( FAILED(hr) || NULL == ep )
    {
        hr = E_ABORT;
        return hr;
    }

    WSD_SYNCHRONOUS_RESPONSE_CONTEXT context;
    ::ZeroMemory(&context, sizeof(context));
    context.eventHandle = ::CreateEvent(NULL, FALSE, FALSE, NULL);
    if (NULL == context.eventHandle)
    {
        DWORD dw = ::GetLastError();
        hr = HRESULT_FROM_WIN32(dw);
        ep->Release();
        return hr;
    }
    hr = 
        ep->SendTwoWayRequest
        (   &request
        ,   &Operations_FileService[1]
        ,   &context
        );

    if (SUCCEEDED(hr))
    {
        if ( WAIT_FAILED == ::WaitForSingleObject(context.eventHandle, INFINITE) )
        {
             DWORD dw = ::GetLastError();
             hr = HRESULT_FROM_WIN32(dw);
        }
    }

    ::CloseHandle(context.eventHandle);
    context.eventHandle = NULL;

    if (SUCCEEDED(hr))
    {
        if (SUCCEEDED(context.hr))
        {
            if( NULL != context.results )
            {
                RESPONSEBODY_FileService_GetFile* response = reinterpret_cast<RESPONSEBODY_FileService_GetFile*>(context.results);

                WSDDetachLinkedMemory( (void*) response->parameters );
                *parametersOut = response->parameters;

                WSDFreeLinkedMemory( context.results );
                context.results = NULL;
            }
            else
            {
                hr = E_FAIL;
            }
        }
        else
        {
            hr = context.hr;
            if( context.results )
            {
                ep->ProcessFault( (const WSD_SOAP_FAULT*)context.results );
            }
        }
    }

    if ( NULL != context.messageParameters )
    {
        context.messageParameters->Release();
        context.messageParameters = NULL;
    }

    ep->Release();
    return hr;
}

// </ProxyFunctionImplementations>

// <ProxyFunctionImplementations>
HRESULT STDMETHODCALLTYPE
CFileServiceProxy::BeginGetFileList
(   /* [in] */ IUnknown* AsyncState
,   /* [in] */ IWSDAsyncCallback* AsyncCallback
,   /* [out] */ IWSDAsyncResult** AsyncResultOut
)
{
    HRESULT hr = S_OK;

    // Initialize Output Pointers
    if( NULL != AsyncResultOut )
    {
        *AsyncResultOut = NULL;
    }

    if( NULL == m_genericProxy )
    {
        hr = E_ABORT;
        return hr;
    }

    IWSDEndpointProxy* ep = NULL;
    hr = m_genericProxy->GetEndpointProxy(&ep);
    if( FAILED(hr) || NULL == ep )
    {
        hr = E_ABORT;
        return hr;
    }

#pragma prefast( suppress: 6387, "Ignoring warnings from generated code." )
    hr = 
        ep->SendTwoWayRequestAsync
        (   NULL
        ,   &Operations_FileService[0]
        ,   AsyncState
        ,   AsyncCallback
        ,   AsyncResultOut
        );

    ep->Release();
    return hr;
}

HRESULT STDMETHODCALLTYPE
CFileServiceProxy::EndGetFileList
(   /* [in] */ IWSDAsyncResult* AsyncResult
,   /* [out] */ GET_FILE_LIST_RESPONSE** parametersOut
)
{
    WSD_EVENT ev;
    HRESULT hr = S_OK;


    // Initialize Output Pointers
    if( NULL != parametersOut )
    {
        *parametersOut = NULL;
    }
    if( NULL == AsyncResult )
    {
        hr = E_INVALIDARG;
        return hr;
    }

    // Validate Response Parameters
    if( NULL == parametersOut )
    {
        hr = E_POINTER;
        return hr;
    }

    ::ZeroMemory(&ev, sizeof(ev));
    hr = AsyncResult->GetEvent( &ev );
    if( S_OK != hr )
    {
        return hr;
    }

    if( ev.EventType == WSDET_INCOMING_MESSAGE )
    {
        void* results = ev.Soap->Body;
        if( NULL != results )
        {
            RESPONSEBODY_FileService_GetFileList* response = reinterpret_cast<RESPONSEBODY_FileService_GetFileList*>(results);

            WSDDetachLinkedMemory( (void*) response->parameters );
            *parametersOut = response->parameters;

            WSDFreeLinkedMemory( (void*) response );
        }
    }
    else if( ev.EventType == WSDET_INCOMING_FAULT )
    {
        void* results = ev.Soap->Body;

        if( NULL == m_genericProxy )
        {
            hr = E_ABORT;
            return hr;
        }

        IWSDEndpointProxy* ep = NULL;
        hr = m_genericProxy->GetEndpointProxy(&ep);
        if( FAILED(hr) || NULL == ep )
        {
            hr = E_ABORT;
            return hr;
        }

        hr = E_FAIL;
        if( results )
        {
            ep->ProcessFault( (const WSD_SOAP_FAULT*)results );
        }
        ep->Release();
    }
    else
    {
        hr = ( (S_OK == ev.Hr) ? E_FAIL : ev.Hr );
    }

    return hr;
}

HRESULT STDMETHODCALLTYPE
CFileServiceProxy::BeginGetFile
(   /* [in] */ GET_FILE_REQUEST* parameters
,   /* [in] */ IUnknown* AsyncState
,   /* [in] */ IWSDAsyncCallback* AsyncCallback
,   /* [out] */ IWSDAsyncResult** AsyncResultOut
)
{
    HRESULT hr = S_OK;

    // Initialize Output Pointers
    if( NULL != AsyncResultOut )
    {
        *AsyncResultOut = NULL;
    }

    // Validate Request Parameters
    if( NULL == parameters )
    {
        hr = E_INVALIDARG;
        return hr;
    }

    REQUESTBODY_FileService_GetFile request;

    request.parameters = parameters;

    if( NULL == m_genericProxy )
    {
        hr = E_ABORT;
        return hr;
    }

    IWSDEndpointProxy* ep = NULL;
    hr = m_genericProxy->GetEndpointProxy(&ep);
    if( FAILED(hr) || NULL == ep )
    {
        hr = E_ABORT;
        return hr;
    }

#pragma prefast( suppress: 6387, "Ignoring warnings from generated code." )
    hr = 
        ep->SendTwoWayRequestAsync
        (   &request
        ,   &Operations_FileService[1]
        ,   AsyncState
        ,   AsyncCallback
        ,   AsyncResultOut
        );

    ep->Release();
    return hr;
}

HRESULT STDMETHODCALLTYPE
CFileServiceProxy::EndGetFile
(   /* [in] */ IWSDAsyncResult* AsyncResult
,   /* [out] */ GET_FILE_RESPONSE** parametersOut
)
{
    WSD_EVENT ev;
    HRESULT hr = S_OK;


    // Initialize Output Pointers
    if( NULL != parametersOut )
    {
        *parametersOut = NULL;
    }
    if( NULL == AsyncResult )
    {
        hr = E_INVALIDARG;
        return hr;
    }

    // Validate Response Parameters
    if( NULL == parametersOut )
    {
        hr = E_POINTER;
        return hr;
    }

    ::ZeroMemory(&ev, sizeof(ev));
    hr = AsyncResult->GetEvent( &ev );
    if( S_OK != hr )
    {
        return hr;
    }

    if( ev.EventType == WSDET_INCOMING_MESSAGE )
    {
        void* results = ev.Soap->Body;
        if( NULL != results )
        {
            RESPONSEBODY_FileService_GetFile* response = reinterpret_cast<RESPONSEBODY_FileService_GetFile*>(results);

            WSDDetachLinkedMemory( (void*) response->parameters );
            *parametersOut = response->parameters;

            WSDFreeLinkedMemory( (void*) response );
        }
    }
    else if( ev.EventType == WSDET_INCOMING_FAULT )
    {
        void* results = ev.Soap->Body;

        if( NULL == m_genericProxy )
        {
            hr = E_ABORT;
            return hr;
        }

        IWSDEndpointProxy* ep = NULL;
        hr = m_genericProxy->GetEndpointProxy(&ep);
        if( FAILED(hr) || NULL == ep )
        {
            hr = E_ABORT;
            return hr;
        }

        hr = E_FAIL;
        if( results )
        {
            ep->ProcessFault( (const WSD_SOAP_FAULT*)results );
        }
        ep->Release();
    }
    else
    {
        hr = ( (S_OK == ev.Hr) ? E_FAIL : ev.Hr );
    }

    return hr;
}

// </ProxyFunctionImplementations>

// <SubscriptionProxyFunctionImplementations>
HRESULT STDMETHODCALLTYPE
CFileServiceProxy::SubscribeToFileChangeEvent
(    IFileServiceEventNotify* eventSink
)
{
    HRESULT hr = S_OK;

    hr = m_genericProxy->SubscribeToOperation(&Operations_FileService[2],eventSink,NULL,NULL);

    return hr;
}

HRESULT STDMETHODCALLTYPE
CFileServiceProxy::UnsubscribeToFileChangeEvent
(    void
)
{
    HRESULT hr = S_OK;

    hr = m_genericProxy->UnsubscribeToOperation(&Operations_FileService[2]);

    return hr;
}

// </SubscriptionProxyFunctionImplementations>

// <EventSourceBuilderImplementations>
HRESULT CreateCFileServiceEventSource(IWSDDeviceHost* pHost, LPCWSTR pszServiceId, CFileServiceEventSource** ppEventSourceOut)
{
    HRESULT hr = S_OK;
    CFileServiceEventSource* pEventSource = NULL;

    // 
    // Validate parameters
    // 
    if( NULL == pHost )
    {
        return E_INVALIDARG;
    }

    if( NULL == pszServiceId )
    {
        return E_INVALIDARG;
    }

    if( NULL == ppEventSourceOut )
    {
        return E_POINTER;
    }

    *ppEventSourceOut = NULL;

    // 
    // Create event source object
    // 
    if( S_OK == hr )
    {
        pEventSource = new CFileServiceEventSource();
        if( NULL == pEventSource )
        {
            hr = E_OUTOFMEMORY;
        }
    }

    // 
    // Initialize event source with host
    // 
    if( S_OK == hr )
    {
        hr = pEventSource->Init(pHost, pszServiceId);
    }

    // 
    // Cleanup
    // 
    if( S_OK == hr )
    {
        *ppEventSourceOut = pEventSource;
    }
    else
    {
        if( NULL != pEventSource )
        {
            pEventSource->Release();
        }
    }

    return hr;
}

// </EventSourceBuilderImplementations>

// <CDATA>

CFileServiceEventSource::CFileServiceEventSource() :
    m_cRef(1), m_host(NULL)
{
}

CFileServiceEventSource::~CFileServiceEventSource() 
{
    if ( NULL != m_host )
    {
        m_host->Release();
        m_host = NULL;
    }
};

HRESULT STDMETHODCALLTYPE CFileServiceEventSource::Init(
    /* [in] */ IWSDDeviceHost* pIWSDDeviceHost,
    /* [in] */ const WCHAR* serviceId )
{
    if( NULL == pIWSDDeviceHost )
    {
        return E_INVALIDARG;
    }

    m_serviceId = serviceId;

    m_host = pIWSDDeviceHost;
    m_host->AddRef();

    return S_OK;
}

// </CDATA>

// <IUnknownDefinitions>
HRESULT STDMETHODCALLTYPE CFileServiceEventSource::QueryInterface(REFIID riid, void **ppvObject)
{
    if (NULL == ppvObject)
    {
        return E_POINTER;
    }

    HRESULT hr = S_OK;
    *ppvObject = NULL;

    if (__uuidof(IUnknown) == riid)
    {
        *ppvObject = (IUnknown *)this;
    }
    else if (__uuidof(IFileServiceEventNotify) == riid)
    {
        *ppvObject = (IFileServiceEventNotify *)this;
    }
    else
    {
        hr = E_NOINTERFACE;
    }

    if (SUCCEEDED(hr))
    {
        ((LPUNKNOWN)*ppvObject)->AddRef();
    }

    return hr;
}

ULONG STDMETHODCALLTYPE CFileServiceEventSource::AddRef()
{
    ULONG ulNewRefCount = (ULONG)InterlockedIncrement((LONG *)&m_cRef);
    return ulNewRefCount;
}

ULONG STDMETHODCALLTYPE CFileServiceEventSource::Release()
{
    ULONG ulNewRefCount = (ULONG)InterlockedDecrement((LONG *)&m_cRef);

    if (0 == ulNewRefCount)
    {
        delete this;
    }

    return ulNewRefCount;
}
// </IUnknownDefinitions>

// <ProxyFunctionImplementations>
HRESULT STDMETHODCALLTYPE
CFileServiceEventSource::FileChangeEvent
(   /* [in] */ FILE_CHANGE_EVENT* result
)
{
    HRESULT hr = S_OK;

    // Validate Request Parameters
    if( NULL == result )
    {
        hr = E_INVALIDARG;
        return hr;
    }

    RESPONSEBODY_FileService_FileChangeEvent request;

    request.result = result;

    hr =
        m_host->SignalEvent
        (   m_serviceId
        ,   &request
        ,   &Operations_FileService[2]
        );

    return hr;
}

// </ProxyFunctionImplementations>

