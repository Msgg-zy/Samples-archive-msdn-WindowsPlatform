//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
//*********************************************************

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SDKTemplate;
using System;
using Microsoft.AspNet.SignalR.Client;

namespace RestServiceClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario3
    {
        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;

        public Scenario3()
        {
            this.InitializeComponent();
        }

        Connection connection;

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            connection = new Connection("http://localhost:9000/myconnection");
            connection.Received += connection_Received;
            await connection.Start();

        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if (connection != null)
            {
                connection.Received -= connection_Received;
                connection.Stop();
                connection.Dispose();
                connection = null;
            }

            base.OnNavigatedFrom(e);
        }
        
        async void connection_Received(string obj)
        {
            await Dispatcher.RunIdleAsync(args =>
            {
                rootPage.NotifyUser("Message Received: " + obj, NotifyType.StatusMessage);
            });
        }

        private async void Go_Click(object sender, RoutedEventArgs e)
        {
            var msg = MessageTextBox.Text;
            await connection.Send(msg);
        }
    }
}
