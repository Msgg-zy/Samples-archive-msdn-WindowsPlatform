//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved
//

#pragma once

#include "pch.h"

using namespace Microsoft::WRL;
using namespace Microsoft::WRL::Details;
using namespace Platform;

namespace XHRTransportHelper
{

    delegate void RequestSucceedHandler(String^);
    delegate void RequestFailHandler();

    class XMLHTTPRequest2Callback : public Microsoft::WRL::RuntimeClass<
        RuntimeClassFlags<RuntimeClassType::ClassicCom>,
        IXMLHTTPRequest2Callback>
    {
    public:
        IFACEMETHODIMP OnRedirect(__RPC__in_opt IXMLHTTPRequest2 *pXHR, __RPC__in_string const wchar_t *pwszRedirectUrl);
        IFACEMETHODIMP OnHeadersAvailable(__RPC__in_opt IXMLHTTPRequest2 *pXHR, DWORD dwStatus, __RPC__in_string const wchar_t *pwszStatus);
        IFACEMETHODIMP OnDataAvailable(__RPC__in_opt IXMLHTTPRequest2 *pXHR, __RPC__in_opt ISequentialStream *pResponseStream);
        IFACEMETHODIMP OnResponseReceived(__RPC__in_opt IXMLHTTPRequest2 *pXHR, __RPC__in_opt ISequentialStream *pResponseStream);
        IFACEMETHODIMP OnError(__RPC__in_opt IXMLHTTPRequest2 *pXHR, HRESULT hrError);

    private:

        DWORD m_dwStatus;

        RequestSucceedHandler^ m_pfnSuccessHandler;
        RequestFailHandler^ m_pfnFailureHandler;

        XMLHTTPRequest2Callback();
        ~XMLHTTPRequest2Callback();
        HRESULT Initialize(RequestSucceedHandler^ succeedHandler, RequestFailHandler^ failHandler);

        IFACEMETHODIMP RuntimeClassInitialize();
        IFACEMETHODIMP RuntimeClassInitialize(RequestSucceedHandler^ sucessHandler, RequestFailHandler^ failHandler);
        friend HRESULT Microsoft::WRL::Details::MakeAndInitialize<XMLHTTPRequest2Callback,XMLHTTPRequest2Callback, RequestSucceedHandler^, RequestFailHandler^>
            (XMLHTTPRequest2Callback **, RequestSucceedHandler^ &&, RequestFailHandler^ &&);
        friend HRESULT Microsoft::WRL::Details::MakeAndInitialize<XMLHTTPRequest2Callback,XMLHTTPRequest2Callback>(XMLHTTPRequest2Callback **);
    };
}
