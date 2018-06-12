//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF 
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A 
//// PARTICULAR PURPOSE. 
//// 
//// Copyright (c) Microsoft Corporation. All rights reserved 

// This template is intended for Windows Store apps that require a flat system of navigation.  

// The flat navigation pattern is often seen in games, browsers, or document creation apps, where the user can  
// move quickly between a small number of pages, tabs, or modes that all reside at the same hierarchical level.  


// The Flat navigation pattern (http://go.microsoft.com/fwlink/?LinkID=327893) is highlighted in  
// our App features, start to finish series (http://go.microsoft.com/fwlink/?LinkID=316376). 
// 
// For an overview of navigation design in Windows Store apps, see http://go.microsoft.com/fwlink/?LinkID=276817. 
// For an introduction to the Navigation template, see http://go.microsoft.com/fwlink/?LinkId=259438. 
// For an introduction to the Page Control template, see http://go.microsoft.com/fwlink/?LinkID=390090. 
// For Avoiding common certification failures, see http://go.microsoft.com/fwlink/?LinkId=268354. 

// Image resources: 
// Visual assets are specified on the Application UI tab of the application manifest. 
// Note: Basic images have been provided for this template. 
// See Choosing your app images at http://go.microsoft.com/fwlink/?LinkID=275415. 
// See Guidelines and checklist for tiles and badges at http://go.microsoft.com/fwlink/?LinkID=286753. 
// See Badge overview at http://go.microsoft.com/fwlink/?LinkID=275433. 
// See Adding a splash screen at http://go.microsoft.com/fwlink/?LinkID=390091. 
// For information on background tasks, such as live tiles and notifications, 
// see Introduction to Background Tasks at http://go.microsoft.com/fwlink/?LinkID=279549. 
// 
// For demonstration purposes, additional images to support accessibility   
// (contrast settings) and localization (fr-FR) have been included with  
// this template.  
// Note: Localizing images can be costly. We recommend avoiding this, if possible. 
//  
// See Localizing the package manifest at  http://go.microsoft.com/fwlink/?LinkID=275431. 
// See Globalization and accessibility for tile and toast notifications  
// at http://go.microsoft.com/fwlink/?LinkID=279750. 

using ColorMixer.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace ColorMixer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            if (b != null && b.Tag != null)
            {
                Type pageType = Type.GetType(b.Tag.ToString());

                // Make sure the page type exists, but don't navigate to it if it's already the current page.
                if (pageType != null && rootFrame.CurrentSourcePageType != pageType)
                {
                    (App.Current as App).Navigate(pageType);
                }
                else if (pageType == null)
                {
                    // TODO: Optional - Do something if page not found.
                }
            }
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.HelpSettings helpSettingsFlyout = new Settings.HelpSettings();
            // When the settings flyout is opened from the app bar instead of from
            // the setting charm, use the ShowIndependent() method.
            helpSettingsFlyout.ShowIndependent();
            topAppBar.IsOpen = false;
            bottomAppBar.IsOpen = false;
        }
    }
}
