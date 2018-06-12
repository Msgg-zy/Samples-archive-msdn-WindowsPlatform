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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Resources;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using FlatNavTemplate.Common;
using FlatNavTemplate.Pages;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Markup;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

namespace FlatNavTemplate
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        ResourceLoader resourceLoader = new ResourceLoader();
        Frame rootFrame;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override async void OnLaunched(LaunchActivatedEventArgs e)
        {
            await ShowWindow(e);
            this.ShowDisclaimer();
            SettingsPane.GetForCurrentView().CommandsRequested += OnCommandsRequested;
        }

        private async Task ShowWindow(LaunchActivatedEventArgs args)
        {
            rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                // Associate the frame with a SuspensionManager key.
                SuspensionManager.RegisterFrame(rootFrame, "AppFrame");

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // Restore the saved session state only when appropriate
                    try
                    {
                        await SuspensionManager.RestoreAsync();
                    }
                    catch (SuspensionManagerException)
                    {
                        //Something went wrong restoring state.
                        //Assume there is no state and continue
                    }
                }

                // Place the main page in the current Window.
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                if (!rootFrame.Navigate(typeof(HomePage)))
                {
                    throw new Exception("Failed to create initial page");
                }
            }

            // Ensure the current window is active
            Window.Current.Activate();
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            SettingsPane.GetForCurrentView().CommandsRequested -= OnCommandsRequested;
            var deferral = e.SuspendingOperation.GetDeferral();
            //Save application state and stop any background activity
            await SuspensionManager.SaveAsync();
            deferral.Complete();
        }

        private async void ShowDisclaimer()
        {
            var roamingSettings = ApplicationData.Current.RoamingSettings;

            // Show disclaimer regardless of how the app has been activated
            // unless disclaimer already accepted.
            var disclaimer = (bool)(roamingSettings.Values["disclaimer"] ?? false);

            // If no disclaimer response, show disclaimer.
            if (!disclaimer)
            {
                // Get disclaimer resources.
                // See Globalizing your app at http://go.microsoft.com/fwlink/?LinkId=258266.
                var resDisclaimer = resourceLoader.GetString("disclaimer").Replace(@"\n", Environment.NewLine);
                if (String.IsNullOrEmpty(resDisclaimer)) resDisclaimer = "Disclaimer.";
                var resDisclaimerTitle = resourceLoader.GetString("disclaimerTitle");
                if (String.IsNullOrEmpty(resDisclaimerTitle)) resDisclaimerTitle = "Disclaimer";
                var resDisclaimerButton = resourceLoader.GetString("disclaimerButton");
                if (String.IsNullOrEmpty(resDisclaimerButton)) resDisclaimerButton = "Accept";

                // Create a disclaimer message dialog and set its content.
                // A message dialog can support up to three commands. 
                // If no commands are specified, a close command is provided by default.
                // Note: Message dialogs should be used sparingly, and only for messages or 
                // questions critical to the continued use of your app.
                // See Adding message dialogs at http://go.microsoft.com/fwlink/?LinkID=275116.
                var msg = new Windows.UI.Popups.MessageDialog(resDisclaimer, resDisclaimerTitle);

                // Handler for disclaimer.
                msg.Commands.Add(new Windows.UI.Popups.UICommand(resDisclaimerButton,
                    _ => roamingSettings.Values["disclaimer"] = true));

                // If specifying your own commmands, set the command that will be invoked by default.
                // For example, msg.defaultCommandIndex = 1;

                // Show the message dialog
                await msg.ShowAsync();
            }
        }

        private void OnCommandsRequested(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
        {
            var privacyLabel = resourceLoader.GetString("settingsPrivacyLabel");       
            var helpLabel = resourceLoader.GetString("settingsHelpLabel");
            
            args.Request.ApplicationCommands.Add(new SettingsCommand(
                "Privacy", privacyLabel, _ => ShowPrivacySettingsFlyout()));
            
            args.Request.ApplicationCommands.Add(new SettingsCommand(
                "Help", helpLabel, _ => ShowHelpSettingsFlyout()));
        }

        /// <summary>
        /// Shows the help settings flyout.
        /// </summary>
        public void ShowHelpSettingsFlyout()
        {
            Settings.HelpSettings helpSettingsFlyout = new Settings.HelpSettings();
            helpSettingsFlyout.Show();
        }

        /// <summary>
        /// Shows the privacy settings flyout.
        /// </summary>
        public void ShowPrivacySettingsFlyout()
        {
            Settings.PrivacySettings privacySettingsFlyout = new Settings.PrivacySettings();
            privacySettingsFlyout.Show();
        }
        

        public void Navigate(Type destination)
        {
            rootFrame.Navigate(destination);
            
            // Dismiss app bars on navigation.
            NavigationPage.Current.TopAppBar.IsOpen = false;
            NavigationPage.Current.BottomAppBar.IsOpen = false;
        }
    }
}
