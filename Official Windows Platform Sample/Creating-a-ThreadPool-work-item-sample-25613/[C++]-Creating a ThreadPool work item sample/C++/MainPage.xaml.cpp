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
#include "MainPage.xaml.h"

using namespace ThreadPoolQuickstart;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

// <SnippetNamespaces>
using namespace std;
using namespace Platform;
using namespace Windows::ApplicationModel::Core;
using namespace Windows::System::Threading;
using namespace Windows::UI::Core;
// </SnippetNamespaces>

MainPage::MainPage()
{
	InitializeComponent();

    Reset();
}

void MainPage::Reset()
{
    Console->Text = "Output:\n\n";

    // Start the work item demonstration.
    Primes();
}

// Creates a work item and handles its completion.
void MainPage::Primes()
{
    // <SnippetCreateWorkItem>
    // The nth prime number to find.
    const unsigned int n = 9999;

    // A shared pointer to the result.
    // We use a shared pointer to keep the result alive until the 
    // thread is done.
    std::shared_ptr<unsigned long> nthPrime = make_shared<unsigned long int>(0);

    // Simulates work by searching for the nth prime number. Uses a
    // naive algorithm and counts 2 as the first prime number.
    auto workItem = ref new WorkItemHandler(
        [this, n, nthPrime](IAsyncAction^ workItem)
    {
        unsigned int progress = 0; // For progress reporting.
        unsigned int primes = 0;   // Number of primes found so far.
        unsigned long int i = 2;   // Number iterator.

        if ((n >= 0) && (n <= 2))
        {
            *nthPrime = n;
            return;
        }

        while (primes < (n - 1))
        {
            // <SnippetCancellationCheck>
            if (workItem->Status == AsyncStatus::Canceled)
            {
                break;
            }
            // </SnippetCancellationCheck>

            // Go to the next number.
            i++;

            // Check for prime.
            bool prime = true;
            for (unsigned int j = 2; j < i; ++j)
            {
                if ((i % j) == 0)
                {
                    prime = false;
                    break;
                }
            };

            if (prime)
            {
                // Found another prime number.
                primes++;

                // Report progress at every 10 percent.
                unsigned int temp = progress;
                progress = static_cast<unsigned int>(10.f*primes / n);

                if (progress != temp)
                {
                    String^ updateString;
                    updateString = "Progress to " + n + "th prime: "
                        + (10 * progress).ToString() + "%\n";

                    // Update the UI thread with the CoreDispatcher.
                    CoreApplication::MainView->CoreWindow->Dispatcher->RunAsync(
                        CoreDispatcherPriority::High,
                        ref new DispatchedHandler([this, updateString]()
                    {
                        UpdateUI(updateString);
                    }));
                }
            }
        }

        // Return the nth prime number.
        *nthPrime = i;
    });

    auto asyncAction = ThreadPool::RunAsync(workItem);

    // A reference to the work item is cached so that we can trigger a 
    // cancellation when the user presses the Cancel button.
    m_workItem = asyncAction;
    // </SnippetCreateWorkItem>

    // <SnippetCompletedHandler>
    asyncAction->Completed = ref new AsyncActionCompletedHandler(
        [this, n, nthPrime](IAsyncAction^ asyncInfo, AsyncStatus asyncStatus)
    {
        // <SnippetCancellationHandler>
        if (asyncStatus == AsyncStatus::Canceled)
        {
            return;
        }
        // </SnippetCancellationHandler>
        
        String^ updateString;
        updateString = "\n" + "The " + n + "th prime number is " 
            + (*nthPrime).ToString() + ".\n";

        // Update the UI thread with the CoreDispatcher.
        CoreApplication::MainView->CoreWindow->Dispatcher->RunAsync(
            CoreDispatcherPriority::High,
            ref new DispatchedHandler([this, updateString]()
        {
            UpdateUI(updateString);
        }));
    });
    // </SnippetCompletedHandler>
}

// <SnippetUpdateUIMethod>
// For illustration, this sample prints the message to an on-screen console.
// Your app would update the page's UI.
void MainPage::UpdateUI(String^ s)
{
    Console->Text += s;
}
// </SnippetUpdateUIMethod>

/// <summary>
/// Invoked when this page is about to be displayed in a Frame.
/// </summary>
/// <param name="e">Event data that describes how this page was reached.  The Parameter
/// property is typically used to configure the page.</param>
void MainPage::OnNavigatedTo(NavigationEventArgs^ e)
{
	(void) e;	// Unused parameter
}


void ThreadPoolQuickstart::MainPage::Button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    // <SnippetCancellationHandler>
    if (m_workItem != nullptr)
    {
        m_workItem->Cancel();
    }
    // </SnippetCancellationHandler>

    Reset();
}
