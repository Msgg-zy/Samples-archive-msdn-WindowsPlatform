//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved
//

#include "pch.h"

using namespace XHRTransportHelper;
using namespace std;

// Simulate the functionality of DataReader.ReadString().
// This is needed because DataReader requires IRandomAccessStream and this
// code has an ISequentialStream that does not have a conversion to IRandomAccessStream like IStream does.
HRESULT ReadUtf8StringFromSequentialStream(
    ISequentialStream* readStream,
    wstring& str
)
{
    // Convert the response to Unicode wstring.
    HRESULT hr = S_OK;

    // Holds the response as a Unicode string.
    wstringstream ss;

    while (true)
    {
        ULONG cb;
        char buffer[4096];

        // Read the response as a UTF-8 string.  Since UTF-8 characters are 1-4 bytes long,
        // we need to make sure we only read an integral number of characters.  So we'll
        // start with 4093 bytes.
        hr = readStream->Read(buffer, sizeof(buffer) - 3, &cb);
        if (FAILED(hr) || (cb == 0))
        {
            break; // Error or no more data to process, exit loop.
        }

        if (cb == sizeof(buffer) - 3)
        {
            ULONG subsequentBytesRead;
            unsigned int i, cl;

            // Find the first byte of the last UTF-8 character in the buffer.
            for (i = cb - 1; (i >= 0) && ((buffer[i] & 0xC0) == 0x80); i--);

            // Calculate the number of subsequent bytes in the UTF-8 character.
            if (((unsigned char)buffer[i]) < 0x80)
            {
                cl = 1;
            }
            else if (((unsigned char)buffer[i]) < 0xE0)
            {
                cl = 2;
            }
            else if (((unsigned char)buffer[i]) < 0xF0)
            {
                cl = 3;
            }
            else
            {
                cl = 4;
            }

            // Read any remaining bytes.
            if (cb < i + cl)
            {
                hr = readStream->Read(buffer + cb, i + cl - cb, &subsequentBytesRead);
                if (FAILED(hr))
                {
                    break; // Error, exit loop.
                }
                cb += subsequentBytesRead;
            }
        }

        // First determine the size required to store the Unicode string.
        int const sizeRequired = MultiByteToWideChar(CP_UTF8, 0, buffer, cb, nullptr, 0);
        if (sizeRequired == 0)
        {
            // Invalid UTF-8.
            hr = HRESULT_FROM_WIN32(GetLastError());
            break;
        }
        unique_ptr<char16[]> wstr(new(std::nothrow) char16[sizeRequired + 1]);
        if (wstr.get() == nullptr)
        {
            hr = E_OUTOFMEMORY;
            break;
        }

        // Convert the string from UTF-8 to UTF-16LE.  This can never fail, since
        // the previous call above succeeded.
        MultiByteToWideChar(CP_UTF8, 0, buffer, cb, wstr.get(), sizeRequired);
        wstr[sizeRequired] = L'\0'; // Terminate the string.
        ss << wstr.get(); // Write the string to the stream.
    }

    str = SUCCEEDED(hr) ? ss.str() : wstring();
    return (SUCCEEDED(hr)) ? S_OK : hr; // Don't return S_FALSE.
}

XMLHTTPRequest2Callback::XMLHTTPRequest2Callback()
    : m_dwStatus(0),
      m_pfnSuccessHandler(nullptr),
      m_pfnFailureHandler(nullptr)
{

}

XMLHTTPRequest2Callback::~XMLHTTPRequest2Callback()
{
}

IFACEMETHODIMP XMLHTTPRequest2Callback::OnRedirect(
    __RPC__in_opt IXMLHTTPRequest2 *pXHR,
    __RPC__in_string const wchar_t *pwszRedirectUrl
)
{
    UNREFERENCED_PARAMETER(pXHR);
    UNREFERENCED_PARAMETER(pwszRedirectUrl);

    //
    // Real-world app should take care of this event when it sends the canary
    // request. The pwszRedirectUrl could be remembered and then use the new
    // url to do the always-connected HTTP connection.
    //

    return S_OK;
}

IFACEMETHODIMP XMLHTTPRequest2Callback::OnResponseReceived(
    __RPC__in_opt IXMLHTTPRequest2 *pXHR,
    __RPC__in_opt ISequentialStream *pResponseStream
)
{
    HRESULT hr = S_OK;
    wstring wstr;

    UNREFERENCED_PARAMETER(pXHR);

    //
    // This callack is the best place to fetch all the response data.
    // This sample assumes that responses are UTF-8 encoded text.
    //

    hr = ReadUtf8StringFromSequentialStream(pResponseStream, wstr);
    if (FAILED(hr))
    {
        if (m_pfnFailureHandler != nullptr)
        {
            try
            {
                m_pfnFailureHandler();
            }
            catch (Exception^)
            {
                // Real application should catch special exception and handle it properly.
            }
        }

        goto Exit;
    }

    if (m_pfnSuccessHandler != nullptr)
    {
        try
        {
            m_pfnSuccessHandler(ref new String(wstr.c_str()));
        }
        catch (Exception^)
        {
            // Real application should catch special exception and handle it properly.
        }
    }

Exit:

    return hr;
}

IFACEMETHODIMP XMLHTTPRequest2Callback::OnError(
    __RPC__in_opt IXMLHTTPRequest2 *pXHR,
    HRESULT hrError
)
{
    UNREFERENCED_PARAMETER(pXHR);

    if (m_pfnFailureHandler != nullptr)
    {
        try
        {
            m_pfnFailureHandler();
        }
        catch (Exception^)
        {
            // Real application should catch special exception and handle it properly.
        }
    }

    return S_OK;
}

HRESULT XMLHTTPRequest2Callback::Initialize(
    RequestSucceedHandler^ succeedHandler,
    RequestFailHandler^ failHandler
)
{
    m_pfnSuccessHandler = succeedHandler;
    m_pfnFailureHandler = failHandler;
    return S_OK;
}

IFACEMETHODIMP XMLHTTPRequest2Callback::RuntimeClassInitialize()
{
    return Initialize(nullptr, nullptr);
}

IFACEMETHODIMP XMLHTTPRequest2Callback::RuntimeClassInitialize(
    RequestSucceedHandler^ sucessHandler,
    RequestFailHandler^ failHandler
)
{
    return Initialize(sucessHandler, failHandler);
}

IFACEMETHODIMP  XMLHTTPRequest2Callback::OnHeadersAvailable(
    __RPC__in_opt IXMLHTTPRequest2 *pXHR,
    DWORD dwStatus,
    __RPC__in_string const wchar_t *pwszStatus
)
{
    UNREFERENCED_PARAMETER(pXHR);
    UNREFERENCED_PARAMETER(pwszStatus);

    m_dwStatus = dwStatus;
    return S_OK;
}

IFACEMETHODIMP XMLHTTPRequest2Callback::OnDataAvailable(
    __RPC__in_opt IXMLHTTPRequest2 *pXHR,
    __RPC__in_opt ISequentialStream *pResponseStream
)
{
    UNREFERENCED_PARAMETER(pXHR);
    UNREFERENCED_PARAMETER(pResponseStream);

    //
    // For application that needs to do a real-time chunk-by-chunk processing,
    // add the data reading in this callback. However the work must be done
    // as fast as possible, and must not block this thread, for example, waiting
    // on another event object.
    //

    return S_OK;
}
