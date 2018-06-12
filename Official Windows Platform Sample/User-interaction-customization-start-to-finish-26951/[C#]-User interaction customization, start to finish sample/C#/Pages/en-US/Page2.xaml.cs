//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF 
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A 
//// PARTICULAR PURPOSE. 
//// 
//// Copyright (c) Microsoft Corporation. All rights reserved 

using ColorMixer.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ColorMixer.Pages
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Page2 : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Stores R, G, and B color levels and corresponding rotation angles for the mixer.
        /// </summary>
        private class ColorInfo
        {
            public Byte Level { get; set; }
            public RotateTransform Rotation { get; set; }
            public ColorInfo(Byte level, RotateTransform rotation)
            {
                Level = level;
                Rotation = rotation;
            }
        }
        private const byte initialColorLevel = 0;
        ColorInfo RedValue = new ColorInfo(initialColorLevel, new RotateTransform());
        ColorInfo GreenValue = new ColorInfo(initialColorLevel, new RotateTransform());
        ColorInfo BlueValue = new ColorInfo(initialColorLevel, new RotateTransform());

        private bool colorSelected = false;
        private enum selectedColor { Red, Green, Blue };
        private selectedColor currentColor;

        public Page2()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;

            // UI sizing.
            int rotatorWidth = 50;
            int rotatorHeight = 100;
            int mixerSideLength = 400;
            double originX = .5;
            double originY = .5;
            RotatorLeft.Width = RotatorRight.Width = rotatorWidth;
            RotatorLeft.Height = RotatorRight.Height = rotatorHeight;
            ColorMixer.Width = ColorMixer.Height = mixerSideLength;
            // Set the transform origin to the center of the object.
            ColorMixer.RenderTransformOrigin = new Point(originX, originY);
            // Container must accomodate rotating color mixer and pen/mouse click UI.
            // Formula used for diagonal of square: side * sqrt(2). 
            // Add in some buffer to accommodate the rotator UI.
            double containerSideLength = mixerSideLength * Math.Sqrt(2) + (3 * rotatorWidth);
            Container.Width = containerSideLength;
            Container.Height = containerSideLength;
            // Add handler for Pointer events on Container.
            Container.PointerEntered += Container_PointerEntered;
            Container.PointerExited += Container_PointerExited;
            Container.PointerCanceled += Container_PointerExited;
            Container.PointerReleased += Container_PointerExited;
            // Position rotator UI to the left and right of the container.
            Canvas.SetLeft(RotatorLeft, 0);
            Canvas.SetLeft(RotatorRight, (Container.Width - RotatorRight.Width));
            Canvas.SetTop(RotatorLeft, (Container.Height - RotatorLeft.Height) / 2);
            Canvas.SetTop(RotatorRight, (Container.Height - RotatorRight.Height) / 2);
            RotatorRight.Click += Rotator_Clicked;
            RotatorLeft.Click += Rotator_Clicked;

            // Position the color mixer in the center of the container.
            Canvas.SetLeft(ColorMixer, (Container.Width - ColorMixer.Width) / 2);
            Canvas.SetTop(ColorMixer, (Container.Height - ColorMixer.Height) / 2);

            // Add handler for the ManipulationDelta event
            // For this example, we are only implementing rotation.
            // For more complex composite transforms (rotate, translate, scale, skew, and so on), 
            // use TransformGroup and CompositeTransform.
            ColorMixer.ManipulationDelta += Rotate_ManipulationDelta;
            ColorMixer.PointerWheelChanged += Rotate_PointerWheelChanged;
            ColorMixer.KeyDown += ColorMixer_KeyDown;
            // Add handlers for color selectors.
            Red.Click += ColorSelector_Click;
            Green.Click += ColorSelector_Click;
            Blue.Click += ColorSelector_Click;
        }

        /// <summary>
        /// Handles flyout events for the color selector buttons.
        /// The touch language described in Touch interaction design (http://go.microsoft.com/fwlink/?LinkID=268162),
        /// specifies that the press and hold gesture should aid learning or exploration 
        /// (such as showing context menus or flyouts). 
        /// The Button control has an intrinsic Flyout property for this functionality.
        /// Here, we display the current color levels in a flyout.
        /// If you want to use the Holding event, it is not fired by default for mouse and pen input. 
        /// For mouse (and some pen devices) use the RightTapped event instead, or a custom GestureRecognizer.
        /// <param name="sender">
        /// The source of the event.
        /// </param>
        /// <param name="e">
        /// Event data.
        /// </param>
        /// </summary>
        private void flyout_Opened(object sender, object e)
        {
            Flyout f = sender as Flyout;
            if (f != null)
            {
                f.Content = new TextBlock()
                {
                    Text = string.Format("R: {0} G: {1} B: {2}", RedValue.Level, GreenValue.Level, BlueValue.Level),
                    Style = Application.Current.Resources["BaseTextBlockStyle"] as Style
                };
            }
        }

        /// <summary>
        /// Handles click events for the color selector.
        /// Focus is passed to the color mixer.
        /// <param name="sender">
        /// The source of the event.
        /// </param>
        /// <param name="e">
        /// Event data.
        /// </param>
        /// </summary>
        private void ColorSelector_Click(object sender, RoutedEventArgs e)
        {
            // Process input only if color selected.
            colorSelected = true;
            double selectedOpacity = 1.0;
            double unselectedOpacity = .25;
            switch ((sender as Button).Name)
            {
                case "Red":
                    currentColor = selectedColor.Red;
                    ColorMixer.RenderTransform = RedValue.Rotation;
                    ColorMixer.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                    Red.Opacity = selectedOpacity;
                    Green.Opacity = unselectedOpacity;
                    Blue.Opacity = unselectedOpacity;
                    break;
                case "Green":
                    currentColor = selectedColor.Green;
                    ColorMixer.RenderTransform = GreenValue.Rotation;
                    ColorMixer.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
                    Red.Opacity = unselectedOpacity;
                    Green.Opacity = selectedOpacity;
                    Blue.Opacity = unselectedOpacity;
                    break;
                case "Blue":
                    currentColor = selectedColor.Blue;
                    ColorMixer.RenderTransform = BlueValue.Rotation;
                    ColorMixer.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Blue);
                    Red.Opacity = unselectedOpacity;
                    Green.Opacity = unselectedOpacity;
                    Blue.Opacity = selectedOpacity;
                    break;
            }
            ColorMixer.Focus(FocusState.Programmatic);
        }

        /// <summary>
        /// Handles key down events for the color mixer.
        /// Only Left and Right arrow keys are valid.
        /// <param name="sender">
        /// The source of the event.
        /// </param>
        /// <param name="e">
        /// Event data.
        /// </param>
        /// </summary>
        void ColorMixer_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            // Process input only if color selected.
            if (colorSelected && (e.Key == Windows.System.VirtualKey.Left || e.Key == Windows.System.VirtualKey.Right))
            {
                e.Handled = true;
                // Set increment or decrement value based on key pressed.
                Rotate((e.Key == Windows.System.VirtualKey.Left) ? -1 : 1);
            }
        }

        /// <summary>
        /// Handles pointer wheel events for the color mixer.
        /// Only Left and Right arrow keys are valid.
        /// <param name="sender">
        /// The source of the event.
        /// </param>
        /// <param name="e">
        /// Event data.
        /// </param>
        /// </summary>
        private void Rotate_PointerWheelChanged(object sender, PointerRoutedEventArgs e)
        {
            // The mouse language described in Responding to mouse interactions (http://go.microsoft.com/fwlink/?LinkID=328207),
            // specifies that rotation with mouse wheel requires the SHIFT and CTRL keyboard modifiers. 
            bool Shift = (e.KeyModifiers & Windows.System.VirtualKeyModifiers.Shift) ==
                Windows.System.VirtualKeyModifiers.Shift;
            bool Ctrl = (e.KeyModifiers & Windows.System.VirtualKeyModifiers.Control) ==
                Windows.System.VirtualKeyModifiers.Control;
            // Process input only if color selected.
            if (colorSelected && (Shift && Ctrl))
            { 
                e.Handled = true;
                // Set increment or decrement value based on wheel direction.
                // For this example we ignore mouse wheel settings and use
                // each mouse wheel detent as one degree of rotation. 
                Windows.UI.Input.PointerPoint p = e.GetCurrentPoint(ColorMixer);
                Windows.UI.Input.PointerPointProperties pp = p.Properties;
                // Rotate the color mixer.
                Rotate((pp.MouseWheelDelta < 0) ? -1 : 1);
            }
        }

        /// <summary>
        /// Handles click events for the rotator UI.
        /// Only touch, mouse, and pen input are valid.
        /// <param name="sender">
        /// The source of the event.
        /// </param>
        /// <param name="e">
        /// Event data.
        /// </param>
        /// </summary>
        private void Rotator_Clicked(object sender, RoutedEventArgs e)
        {
            // Process input only if color selected.
            if (colorSelected)
            {
                // Set increment or decrement value based on rotator tapped.
                RepeatButton Rotator = sender as RepeatButton;
                // Rotate the color mixer.
                Rotate((Rotator.Name == "RotatorLeft") ? -1 : 1);
            }
        }

        /// <summary>
        /// Handles rotate manipulation events for the color mixer.
        /// <param name="sender">
        /// The source of the event.
        /// </param>
        /// <param name="e">
        /// Event data.
        /// </param>
        /// </summary>
        void Rotate_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            // Process gesture only if color selected.
            if (colorSelected)
            {
                e.Handled = true;
                Rotate(e.Delta.Rotation);
            }
        }

        /// <summary>
        /// Rotate the color mixer and set color levels based on rotation value.
        /// <param name="increment">
        /// The rotation increment for the current input event.
        /// </param>
        /// </summary>
        private void Rotate(float increment) 
        {
            // Convert rotation angle (0 to 359.999...) to color value (0 to 255).
            // Formula used: NewValue = (((OldValue - OldMin) * (NewMax - NewMin)) / (OldMax - OldMin)) + NewMin.
            int maxRotation = 360;
            int minRotation = 0;
            byte maxColorLevel = 255;
            switch (currentColor.ToString())
            {
                case "Red":
                    RedValue.Rotation.Angle = (RedValue.Rotation.Angle + increment) % maxRotation;
                    ColorMixer.RenderTransform = RedValue.Rotation;
                    // Set red level.
                    if (RedValue.Rotation.Angle >= minRotation)
                        {
                            RedValue.Level = Convert.ToByte((RedValue.Rotation.Angle * maxColorLevel) / maxRotation);
                        }
                    else
                    {
                        RedValue.Level = Convert.ToByte(((maxRotation - Math.Abs(RedValue.Rotation.Angle)) * maxColorLevel) / maxRotation);
                    }
                    break;
                case "Green":
                    GreenValue.Rotation.Angle = (GreenValue.Rotation.Angle + increment) % maxRotation;
                    ColorMixer.RenderTransform = GreenValue.Rotation;
                    // Set green level.
                    if (GreenValue.Rotation.Angle >= minRotation)
                    {
                        GreenValue.Level = Convert.ToByte((GreenValue.Rotation.Angle * maxColorLevel) / maxRotation);
                    }
                    else
                    {
                        GreenValue.Level = Convert.ToByte(((maxRotation - Math.Abs(GreenValue.Rotation.Angle)) * maxColorLevel) / maxRotation);
                    }
                    break;
                case "Blue":
                    BlueValue.Rotation.Angle = (BlueValue.Rotation.Angle + increment) % maxRotation;
                    ColorMixer.RenderTransform = BlueValue.Rotation;
                    // Set blue level.
                    if (BlueValue.Rotation.Angle >= minRotation)
                    {
                        BlueValue.Level = Convert.ToByte((BlueValue.Rotation.Angle * maxColorLevel) / maxRotation);
                    }
                    else
                    {
                        BlueValue.Level = Convert.ToByte(((maxRotation - Math.Abs(BlueValue.Rotation.Angle)) * maxColorLevel) / maxRotation);
                    }
                    break;
            }
            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(maxColorLevel, RedValue.Level, GreenValue.Level, BlueValue.Level));
            ColorMixer.Background = mySolidColorBrush;
        }

        /// <summary>
        /// Handles pointer exited events for the color mixer container.
        /// Stops displaying the rotator UI.
        /// <param name="sender">
        /// The source of the event.
        /// </param>
        /// <param name="e">
        /// Event data.
        /// </param>
        /// </summary>
        private void Container_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            // Process input only if color selected. 
            if (colorSelected)
            {
                e.Handled = true;
                RotatorLeft.Visibility = Visibility.Collapsed;
                RotatorRight.Visibility = Visibility.Collapsed;
            }
        }

        /// <summary>
        /// Handles pointer entered events for the color mixer container.
        /// Displays the rotator UI.
        /// <param name="sender">
        /// The source of the event.
        /// </param>
        /// <param name="e">
        /// Event data.
        /// </param>
        /// </summary>
        void Container_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            // Process input only if color selected.
            // Check input type. No need to display mouse click and pen tap UI for any other ponter type.
            if (colorSelected && (e.Pointer.PointerDeviceType == PointerDeviceType.Pen || e.Pointer.PointerDeviceType == PointerDeviceType.Mouse))
            {            
                e.Handled = true;
                RotatorLeft.Visibility = Visibility.Visible;
                RotatorRight.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache. Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
// Constructor
    }
}
