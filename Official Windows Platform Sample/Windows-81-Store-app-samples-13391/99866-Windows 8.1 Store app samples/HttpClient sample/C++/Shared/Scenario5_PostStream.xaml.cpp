﻿//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

//
// Scenario5.xaml.cpp
// Implementation of the Scenario5 class
//

#include "pch.h"
#include <assert.h>
#include <robuffer.h>
#include "Scenario5_PostStream.xaml.h"

using namespace SDKSample::HttpClientSample;

using namespace concurrency;
using namespace Microsoft::WRL;
using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Storage::Streams;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Navigation;
using namespace Windows::Web::Http;

Scenario5::Scenario5()
{
    InitializeComponent();
}

/// <summary>
/// Invoked when this page is about to be displayed in a Frame.
/// </summary>
/// <param name="e">Event data that describes how this page was reached.  The Parameter
/// property is typically used to configure the page.</param>
void Scenario5::OnNavigatedTo(NavigationEventArgs^ e)
{
    // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
    // as NotifyUser()
    rootPage = MainPage::Current;

    httpClient = Helpers::CreateHttpClient();
    cancellationTokenSource = cancellation_token_source();
}

void Scenario5::Start_Click(Object^ sender, RoutedEventArgs^ e)
{
    Helpers::ScenarioStarted(StartButton, CancelButton, OutputField);
    rootPage->NotifyUser("In progress", NotifyType::StatusMessage);

    // 'AddressField' is a disabled text box, so the value is considered trusted input. When enabling the
    // text box make sure to validate user input (e.g., by catching exceptions with TryGetUri as shown in scenario 1).
    Uri^ resourceAddress = ref new Uri(AddressField->Text);

    const unsigned int contentLength = 1000;

    // Create a sample stream. We need to use use_current() with the continuations since the tasks are completed on
    // background threads and we need to run on the UI thread to update the UI.
    create_task(GenerateSampleStreamAsync(contentLength, cancellationTokenSource.get_token())).then(
        [=](IRandomAccessStream^ stream)
    {
        // If the stream does not implement the IRandomAccessStream interface,
        // chunked transfer encoding is used during the request.
        HttpStreamContent^ streamContent = ref new HttpStreamContent(stream);

        HttpRequestMessage^ request = ref new HttpRequestMessage(HttpMethod::Post, resourceAddress);
        request->Content = streamContent;

        // Do an asynchronous POST.
        return create_task(httpClient->SendRequestAsync(request), cancellationTokenSource.get_token());

        // The above lines could be replaced by the following lines if you know the content-length in advance
        // and chunked transfer encoding will not be used during the request.
        // streamContent->Headers->ContentLength = ref new Box<UINT64>(contentLength);
        // return create_task(
        //     httpClient->PostAsync(resourceAddress, streamContent),
        //     cancellationTokenSource.get_token());
    }, task_continuation_context::use_current()).then([this](HttpResponseMessage^ response)
    {
        return Helpers::DisplayTextResultAsync(response, OutputField, cancellationTokenSource.get_token());
    }, task_continuation_context::use_current()).then([=](task<HttpResponseMessage^> previousTask)
    {
        try
        {
            // Check if any previous task threw an exception.
            previousTask.get();

            rootPage->NotifyUser("Completed", NotifyType::StatusMessage);
        }
        catch (const task_canceled&)
        {
            rootPage->NotifyUser("Request canceled.", NotifyType::ErrorMessage);
        }
        catch (Exception^ ex)
        {
            rootPage->NotifyUser("Error: " + ex->Message, NotifyType::ErrorMessage);
        }

        Helpers::ScenarioCompleted(StartButton, CancelButton);
    }, task_continuation_context::use_current());
}

task<IRandomAccessStream^> Scenario5::GenerateSampleStreamAsync(
    unsigned int size,
    cancellation_token token)
{
    return create_task([=]()
    {
        Buffer^ buffer = ref new Buffer(size);
        buffer->Length = size;

        ComPtr<IBufferByteAccess> bufferByteAccess;
        HRESULT hr = reinterpret_cast<IUnknown*>(buffer)->QueryInterface(IID_PPV_ARGS(&bufferByteAccess));
        if (FAILED(hr))
        {
            throw ref new Exception(hr);
        }

        byte* rawBuffer;
        hr = bufferByteAccess->Buffer(&rawBuffer);
        if (FAILED(hr))
        {
            throw ref new Exception(hr);
        }

        // Generate sample data.
        for (unsigned int i = 0; i < size; i++)
        {
            rawBuffer[i] = '@';
        }

        IRandomAccessStream^ stream = ref new InMemoryRandomAccessStream();
        task<unsigned int> writeTask(stream->WriteAsync(buffer), token);
        writeTask.wait();
        assert(writeTask.get() == size);

        // Rewind stream.
        stream->Seek(0);

        return stream;
    });
}

void Scenario5::Cancel_Click(Object^ sender, RoutedEventArgs^ e)
{
    cancellationTokenSource.cancel();

    // Re-create the CancellationTokenSource.
    cancellationTokenSource = cancellation_token_source();
}
