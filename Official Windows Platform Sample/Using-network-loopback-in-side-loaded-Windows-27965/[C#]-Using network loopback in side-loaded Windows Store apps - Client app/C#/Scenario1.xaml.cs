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
using System.Linq;
using Windows.Data.Json;
using Windows.Web.Http;

namespace RestServiceClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario1
    {
        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;

        public Scenario1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        private async void GetGenres_Click(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync(new Uri("http://localhost:9000/api/genres"));

            var genres = JsonArray.Parse(json).Select(j => j.GetString());
            GenresListBox.ItemsSource = genres;
        }

        private async void GenresListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GenresListBox.SelectedItem == null)
            {
                TitlesListBox.ItemsSource = null;
                return;
            }

            var url = new Uri("http://localhost:9000/api/books/" + GenresListBox.SelectedItem.ToString());
            var client = new HttpClient();
            var json = await client.GetStringAsync(url);

            var titles = JsonArray.Parse(json).Select(jv => jv.GetObject());
            TitlesListBox.ItemsSource = titles.Select(jo => jo.GetNamedString("Title"));
        }
    }
}
