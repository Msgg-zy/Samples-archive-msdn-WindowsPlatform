//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

// <SnippetNamespaces>
using Windows.ApplicationModel.Core;
using Windows.System.Threading;
using Windows.UI.Core;
// </SnippetNamespaces>

namespace ThreadPoolQuickstart
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private IAsyncAction m_workItem;

        public MainPage()
        {
            this.InitializeComponent();

            Reset();
        }

        public void Reset()
        {
            Console.Text = "Output:\n\n";

            // Start the work item demonstration.
            Primes();
        }

        private void Primes()
        {
            // <SnippetCreateWorkItem>
            // The nth prime number to find.
            const uint n = 9999;

            // A shared pointer to the result.
            // We use a shared pointer to keep the result alive until the 
            // thread is done.
            ulong nthPrime = 0;

            // Simulates work by searching for the nth prime number. Uses a
            // naive algorithm and counts 2 as the first prime number.
            IAsyncAction asyncAction = Windows.System.Threading.ThreadPool.RunAsync(
                (workItem) =>
            {
                uint  progress = 0; // For progress reporting.
                uint  primes = 0;   // Number of primes found so far.
                ulong i = 2;        // Number iterator.

                if ((n >= 0) && (n <= 2))
                {
                    nthPrime = n;
                    return;
                }

                while (primes < (n - 1))
                {
                    // <SnippetCancellationCheck>
                    if (workItem.Status == AsyncStatus.Canceled)
                    {
                        break;
                    }
                    // </SnippetCancellationCheck>

                    // Go to the next number.
                    i++;

                    // Check for prime.
                    bool prime = true;
                    for (uint j = 2; j < i; ++j)
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
                        uint temp = progress;
                        progress = (uint)(10.0*primes/n);

                        if (progress != temp)
                        {
                            String updateString;
                            updateString = "Progress to " + n + "th prime: "
                                + (10 * progress) + "%\n";

                            // Update the UI thread with the CoreDispatcher.
                            CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(
                                CoreDispatcherPriority.High,
                                new DispatchedHandler(() =>
                            {
                                UpdateUI(updateString);
                            }));
                        }
                    }
                }

                // Return the nth prime number.
                nthPrime = i;
            });

            // A reference to the work item is cached so that we can trigger a
            // cancellation when the user presses the Cancel button.
            m_workItem = asyncAction;
            // </SnippetCreateWorkItem>

            // <SnippetCompletedHandler>
            asyncAction.Completed = new AsyncActionCompletedHandler(
                (IAsyncAction asyncInfo, AsyncStatus asyncStatus) =>
            {
                // <SnippetCancellationHandler>
                if (asyncStatus == AsyncStatus.Canceled)
                {
                    return;
                }
                // </SnippetCancellationHandler>

                String updateString;
                updateString = "\n" + "The " + n + "th prime number is " 
                    + nthPrime + ".\n";

                // Update the UI thread with the CoreDispatcher.
                CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(
                    CoreDispatcherPriority.High,
                    new DispatchedHandler(()=>
                {
                    UpdateUI(updateString);
                }));
            });
            // </SnippetCompletedHandler>
        }

        // <SnippetUpdateUIMethod>
        // For illustration, this sample prints the message to an on-screen console.
        // Your app would update the page's UI.
        private void UpdateUI(String s)
        {
            Console.Text += s;
        }
        // </SnippetUpdateUIMethod>

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // <SnippetCancellationHandler>
            if (m_workItem != null)
            {
                m_workItem.Cancel();
            }
            // </SnippetCancellationHandler>

            Reset();
        }
    }
}
