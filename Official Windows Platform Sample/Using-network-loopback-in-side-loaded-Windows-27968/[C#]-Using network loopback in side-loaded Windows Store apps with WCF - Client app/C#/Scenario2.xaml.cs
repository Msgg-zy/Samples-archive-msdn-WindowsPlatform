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

namespace WcfServiceClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario2
    {
        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;

        public Scenario2()
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

        NorthwindService.NorthwindServiceClient nwindClient = new NorthwindService.NorthwindServiceClient();

        private async void GetCategories_Click(object sender, RoutedEventArgs e)
        {
            var categories = await nwindClient.GetCategoriesAsync();
            CategoriesListBox.ItemsSource = categories;
        }

        private async void CategoriesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoriesListBox.SelectedItem == null)
            {
                ProductsListBox.ItemsSource = null;
                return;
            }

            var products = await nwindClient.GetProductsByCategoryAsync(CategoriesListBox.SelectedItem.ToString());
            ProductsListBox.ItemsSource = products.Select(p => p.Name);
        }

    }
}
