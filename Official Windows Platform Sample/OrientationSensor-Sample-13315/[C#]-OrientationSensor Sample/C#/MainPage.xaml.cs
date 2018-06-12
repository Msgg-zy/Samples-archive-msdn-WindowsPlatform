// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Microsoft.Samples.Devices.Sensors.OrientationSample
{
    partial class MainPage
    {

        private OrientationSensor _sensor;
        private CoreDispatcher _cd;

        public MainPage()
        {
            InitializeComponent();
            ScenarioList.SelectionChanged += new SelectionChangedEventHandler(ScenarioList_SelectionChanged);

            // Check for a previous selection
            ListBoxItem startingScenario = null;
            if (SuspensionManager.SessionState.ContainsKey("SelectedScenario"))
            {
                String selectedScenarioName = SuspensionManager.SessionState["SelectedScenario"] as string;
                startingScenario = this.FindName(selectedScenarioName) as ListBoxItem;
            }

            ScenarioList.SelectedItem = startingScenario != null ? startingScenario : Scenario1;

            Windows.UI.ViewManagement.ApplicationLayout.GetForCurrentView().LayoutChanged += new TypedEventHandler<Windows.UI.ViewManagement.ApplicationLayout, Windows.UI.ViewManagement.ApplicationLayoutChangedEventArgs>(MainPage_LayoutChanged);
            DisplayProperties.OrientationChanged += new DisplayPropertiesEventHandler(DisplayProperties_OrientationChanged);

            _sensor = OrientationSensor.GetDefault();
            _cd = Window.Current.CoreWindow.Dispatcher;
        }

        private void DisplayError(string errorText)
        {
            ResetAll();

            ErrorOutputText.Text = errorText;
            ErrorOutput.Visibility = Visibility.Visible;
        }

        #region Scenario Specific Code

        private void ReadingChanged(object sender, OrientationSensorReadingChangedEventArgs e)
        {
            _cd.InvokeAsync(CoreDispatcherPriority.Normal, (s, a) =>
            {
                OrientationSensorReading reading = (a.Context as OrientationSensorReadingChangedEventArgs).Reading;

                // Quaternion values
                Scenario1Output_X.Text = String.Format("{0,8:0.00000}", reading.Quaternion.X);
                Scenario1Output_Y.Text = String.Format("{0,8:0.00000}", reading.Quaternion.Y);
                Scenario1Output_Z.Text = String.Format("{0,8:0.00000}", reading.Quaternion.Z);
                Scenario1Output_W.Text = String.Format("{0,8:0.00000}", reading.Quaternion.W);

                // Rotation Matrix values
                Scenario1Output_M11.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M11);
                Scenario1Output_M12.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M12);
                Scenario1Output_M13.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M13);
                Scenario1Output_M21.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M21);
                Scenario1Output_M22.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M22);
                Scenario1Output_M23.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M23);
                Scenario1Output_M31.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M31);
                Scenario1Output_M32.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M32);
                Scenario1Output_M33.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M33);
            }, this, e);
        }

        protected void Scenario1Enable(object sender, RoutedEventArgs e)
        {
            if (_sensor != null)
            {
                _sensor.ReadingChanged += new TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs>(ReadingChanged);
                Scenario1EnableButton.IsEnabled = false;
                Scenario1DisableButton.IsEnabled = true;
            }
            else
            {
                DisplayError("No orientation sensor found");
            }
        }

        protected void Scenario1Disable(object sender, RoutedEventArgs e)
        {
            _sensor.ReadingChanged -= new TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs>(ReadingChanged);
            Scenario1EnableButton.IsEnabled = true;
            Scenario1DisableButton.IsEnabled = false;
        }

        protected void Scenario2Get(object sender, RoutedEventArgs e)
        {
            if (_sensor != null)
            {
                OrientationSensorReading reading = _sensor.GetCurrentReading();

                // Quaternion values
                Scenario2Output_X.Text = String.Format("{0,8:0.00000}", reading.Quaternion.X);
                Scenario2Output_Y.Text = String.Format("{0,8:0.00000}", reading.Quaternion.Y);
                Scenario2Output_Z.Text = String.Format("{0,8:0.00000}", reading.Quaternion.Z);
                Scenario2Output_W.Text = String.Format("{0,8:0.00000}", reading.Quaternion.W);

                // Rotation Matrix values
                Scenario2Output_M11.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M11);
                Scenario2Output_M12.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M12);
                Scenario2Output_M13.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M13);
                Scenario2Output_M21.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M21);
                Scenario2Output_M22.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M22);
                Scenario2Output_M23.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M23);
                Scenario2Output_M31.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M31);
                Scenario2Output_M32.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M32);
                Scenario2Output_M33.Text = String.Format("{0,8:0.00000}", reading.RotationMatrix.M33);
            }
            else
            {
                DisplayError("No orientation sensor found");
            }
        }

        void Scenario1Reset()
        {
            if (Scenario1DisableButton.IsEnabled)
            {
                _sensor.ReadingChanged -= new TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs>(ReadingChanged);
                Scenario1EnableButton.IsEnabled = true;
                Scenario1DisableButton.IsEnabled = false;
            }
        }

        void Scenario2Reset()
        {

        }

        #endregion

        void ScenarioList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResetAll();
            if (ScenarioList.SelectedItem == Scenario1)
            {
                Scenario1Input.Visibility = Visibility.Visible;
                Scenario1Output.Visibility = Visibility.Visible;
            }
            else if (ScenarioList.SelectedItem == Scenario2)
            {
                Scenario2Input.Visibility = Visibility.Visible;
                Scenario2Output.Visibility = Visibility.Visible;
            }

            if (ScenarioList.SelectedItem != null)
            {
                ListBoxItem selectedListBoxItem = ScenarioList.SelectedItem as ListBoxItem;
                SuspensionManager.SessionState["SelectedScenario"] = selectedListBoxItem.Name;
            }
        }

        public void ResetAll()
        {

            ErrorOutput.Visibility = Visibility.Collapsed;
            
            Scenario1Input.Visibility = Visibility.Collapsed;
            Scenario1Output.Visibility = Visibility.Collapsed;
            Scenario1Reset();
            Scenario2Input.Visibility = Visibility.Collapsed;
            Scenario2Output.Visibility = Visibility.Collapsed;
            Scenario2Reset();
        }

        void DisplayProperties_OrientationChanged(object sender)
        {
            if (DisplayProperties.CurrentOrientation == DisplayOrientations.Portrait || DisplayProperties.CurrentOrientation == DisplayOrientations.PortraitFlipped)
            {
                VisualStateManager.GoToState(this, "Portrait", false);
            }
        }

        void MainPage_LayoutChanged(Windows.UI.ViewManagement.ApplicationLayout sender, Windows.UI.ViewManagement.ApplicationLayoutChangedEventArgs args)
        {
            switch (args.Layout)
            {
                case Windows.UI.ViewManagement.ApplicationLayoutState.Filled:
                    VisualStateManager.GoToState(this, "Fill", false);
                    break;
                case Windows.UI.ViewManagement.ApplicationLayoutState.FullScreen:
                    VisualStateManager.GoToState(this, "Full", false);
                    break;
                case Windows.UI.ViewManagement.ApplicationLayoutState.Snapped:
                    VisualStateManager.GoToState(this, "Snapped", false);
                    break;
                default:
                    break;
            }
        }

        void Footer_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchDefaultProgram(new Uri(((HyperlinkButton)sender).Tag.ToString()));
        }

    }
}
