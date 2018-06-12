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
using WcfServiceClient.BooksService;

namespace WcfServiceClient
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


        BooksServiceClient serviceClient = new BooksServiceClient();

        private async void GetGenres_Click(object sender, RoutedEventArgs e)
        {
            var genres = await serviceClient.GetGenresAsync();
            GenresListBox.ItemsSource = genres;

            var msg = string.Join(";", genres);

            Button b = sender as Button;
            if (b != null)
            {
                rootPage.NotifyUser(msg, NotifyType.StatusMessage);
            }
        }

        private async void GenresListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GenresListBox.SelectedItem == null)
            {
                TitlesListBox.ItemsSource = null;
                return;
            }

            var titles = await serviceClient.GetBooksByGenreAsync(GenresListBox.SelectedItem.ToString());
            TitlesListBox.ItemsSource = titles.Select(book => book.Title);
        }

    }
}
