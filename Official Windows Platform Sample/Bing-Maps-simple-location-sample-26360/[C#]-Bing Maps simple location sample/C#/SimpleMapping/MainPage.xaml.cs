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

using Windows.Devices.Geolocation;
using System.Threading;
using System.Threading.Tasks;
using Bing.Maps;



namespace SimpleMapping
{
    /// <summary>
    /// Display a location on a Bing Map.  The Bing Maps SDK for Windows Store apps must be installed to use this sample.
    /// A Bing Maps key for the map control should be placed in the Map control credentials.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private Geolocator _geolocator = null;
        private CancellationTokenSource _cts = null;

        // Icon to display when accuracy is at 10m or less.
        LocationIcon10m _locationIcon10m;
        // Icon to display when accuracy is at 100m or less.
        LocationIcon100m _locationIcon100m;


        public MainPage()
        {
            this.InitializeComponent();
            _geolocator = new Geolocator();
            _locationIcon10m = new LocationIcon10m();
            _locationIcon100m = new LocationIcon100m();

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Set the state of our buttons.
            MapLocationButton.IsEnabled = true;
            CancelGetLocationButton.IsEnabled = false;
            MessageTextbox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

        }

        /// <summary>
        /// Invoked when the user clicks the "Map Current Location" button.
        /// </summary>
        async private void MapLocationButton_Click(object sender, RoutedEventArgs e)
        {
            // Change the state of our buttons.
            MapLocationButton.IsEnabled = false;
            CancelGetLocationButton.IsEnabled = true;
            MessageTextbox.Visibility = Windows.UI.Xaml.Visibility.Visible;

            // Remove any previous location icon.
            if (Map.Children.Count > 0)
            {
                Map.Children.RemoveAt(0);
            }

            try
            {
                // Get the cancellation token.
                _cts = new CancellationTokenSource();
                CancellationToken token = _cts.Token;

                MessageTextbox.Text = "Waiting for update...";

                // Get the location.
                Geoposition pos = await _geolocator.GetGeopositionAsync().AsTask(token);

                MessageTextbox.Text = "";

                Location location = new Location(pos.Coordinate.Point.Position.Latitude, pos.Coordinate.Point.Position.Longitude);

                // Now set the zoom level of the map based on the accuracy of our location data.
                // Default to IP level accuracy. We only show the region at this level - No icon is displayed.
                double zoomLevel = 13.0f;

                // if we have GPS level accuracy
                if (pos.Coordinate.Accuracy <= 10)
                {
                    // Add the 10m icon and zoom closer.
                    Map.Children.Add(_locationIcon10m);
                    MapLayer.SetPosition(_locationIcon10m, location);
                    zoomLevel = 15.0f;
                }
                // Else if we have Wi-Fi level accuracy.
                else if (pos.Coordinate.Accuracy <= 100)
                {
                    // Add the 100m icon and zoom a little closer.
                    Map.Children.Add(_locationIcon100m);
                    MapLayer.SetPosition(_locationIcon100m, location);
                    zoomLevel = 14.0f;
                }

                // Set the map to the given location and zoom level.
                Map.SetView(location, zoomLevel);

                // Display the location information in the textboxes.
                LatitudeTextbox.Text = pos.Coordinate.Point.Position.Latitude.ToString();
                LongitudeTextbox.Text = pos.Coordinate.Point.Position.Longitude.ToString();
                AccuracyTextbox.Text = pos.Coordinate.Accuracy.ToString();
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageTextbox.Text = "Location disabled.";

                LatitudeTextbox.Text = "No data";
                LongitudeTextbox.Text = "No data";
                AccuracyTextbox.Text = "No data";
            }
            catch (TaskCanceledException)
            {
                MessageTextbox.Text = "Operation canceled.";
            }
            finally
            {
                _cts = null;
            }

            // Reset the buttons.
            MapLocationButton.IsEnabled = true;
            CancelGetLocationButton.IsEnabled = false;
            MessageTextbox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

        }

        /// <summary>
        /// Invoked when the user clicks the "Cancel" button.
        /// </summary>
        private void CancelGetLocationButton_Click(object sender, RoutedEventArgs e)
        {
            // Request to cancel the cancellation token.
            if (_cts != null)
            {
                _cts.Cancel();
                _cts = null;
            }

            // Reset the buttons.
            MapLocationButton.IsEnabled = true;
            CancelGetLocationButton.IsEnabled = false;
            MessageTextbox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

        }

        /// <summary>
        /// Invoked if the user navigates away from this page.
        /// </summary>
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            // Request to cancel the cancellation token.
            if (_cts != null)
            {
                _cts.Cancel();
                _cts = null;
            }

            base.OnNavigatingFrom(e);
        }




    }
}
