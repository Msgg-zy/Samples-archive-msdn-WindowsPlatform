//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
//*********************************************************

using MediaPlaybackStartToFinish.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Resources;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

namespace MediaPlaybackStartToFinish
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        ResourceLoader resourceLoader = new ResourceLoader();

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
            // SDK Disclaimer
            ShowDisclaimer();

            // Settings Flyouts
            SettingsPane.GetForCurrentView().CommandsRequested += OnCommandsRequested;


#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                //Associate the frame with a SuspensionManager key                                
                SuspensionManager.RegisterFrame(rootFrame, "AppFrame");

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

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                if (!rootFrame.Navigate(typeof(MainPage), e.Arguments))
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
            var deferral = e.SuspendingOperation.GetDeferral();
            await SuspensionManager.SaveAsync();
            deferral.Complete();
        }

        /// <summary>
        /// Show a standard app usage disclaimer popup the first time 
        /// the user starts the app.
        /// </summary>
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

                // Get disclaimer text. 
                var resDisclaimer = resourceLoader.GetString("disclaimer").Replace(@"\n", Environment.NewLine);          
                if (String.IsNullOrEmpty(resDisclaimer))
                {
                    // Default to English if the call to GetString fails
                    resDisclaimer = "Disclaimer.";
                }

                // Get disclaimer title text.
                var resDisclaimerTitle = resourceLoader.GetString("disclaimerTitle");
                if (String.IsNullOrEmpty(resDisclaimerTitle))
                {
                    // Default to English if the call to GetString fails
                    resDisclaimerTitle = "Disclaimer";
                }

                // Get disclaimer Accept button text
                var resDisclaimerButton = resourceLoader.GetString("disclaimerButton");
                if (String.IsNullOrEmpty(resDisclaimerButton)) 
                {
                    resDisclaimerButton = "Accept";
                } 

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

        /// <summary>
        /// Add entries to the settings flyout that is displayed
        /// after the user clicks the Settings charm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCommandsRequested(SettingsPane sender,
            SettingsPaneCommandsRequestedEventArgs args)
        {
            var privacyLabel = resourceLoader.GetString("settingsPrivacyLabel");
            var helpLabel = resourceLoader.GetString("settingsHelpLabel");
            var audioLabel = resourceLoader.GetString("settingsAudioLabel");
            var videoLabel = resourceLoader.GetString("settingsVideoLabel");

            args.Request.ApplicationCommands.Add(new SettingsCommand(
                "Privacy", privacyLabel, _ => ShowPrivacySettingsFlyout()));
            args.Request.ApplicationCommands.Add(new SettingsCommand(
                "Help", helpLabel, _ => ShowHelpSettingsFlyout()));
            args.Request.ApplicationCommands.Add(new SettingsCommand("Audio", audioLabel, _ => ShowAudioSettingsFlyout()));
            args.Request.ApplicationCommands.Add(new SettingsCommand("Video", videoLabel, _ => ShowVideoSettingsFlyout()));
        }

        /// <summary>
        /// Shows the Privacy settings flyout.
        /// </summary>
        public void ShowPrivacySettingsFlyout()
        {
            PrivacySettings privacySettingsFlyout = new PrivacySettings();
            privacySettingsFlyout.Show();
        }

        /// <summary>
        /// Shows the Help settings flyout.
        /// </summary>
        public void ShowHelpSettingsFlyout()
        {
            HelpSettings helpSettingsFlyout = new HelpSettings();
            helpSettingsFlyout.Show();
        }

        /// <summary>
        /// Shows the Audio settings flyout.
        /// </summary>
        public void ShowAudioSettingsFlyout()
        {
            AudioSettings audioSettingsFlyout = new AudioSettings();
            audioSettingsFlyout.Show();
        }

        /// <summary>
        /// Shows the Video settings flyout.
        /// </summary>
        public void ShowVideoSettingsFlyout()
        {
            VideoSettings videoSettingsFlyout = new VideoSettings();
            videoSettingsFlyout.Show();
        }
    }
}
