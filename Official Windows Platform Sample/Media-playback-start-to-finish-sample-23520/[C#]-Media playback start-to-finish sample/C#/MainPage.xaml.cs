//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
//*********************************************************

using MediaPlaybackStartToFinish.Common;
using System;
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.System.Display;
using Windows.Media;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Popups;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace MediaPlaybackStartToFinish
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region Global fields/properties for MainPage

        // Flag to indicate that the Media souce states need to be restored. 
        // This flag is set in the NavigationHelper_LoadState event handler when the MediaElement
        // state is being restored.  This should only happen on unsuspen from termination state.
        // The media state retore happens in Media_MediaOpened event handler.
        private bool restoreMediaSourceSettings = false;

        // Navigation helper
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        // Global variable for keeping the display on during video playback. 
        // Used in the DisableScreenDimming which is called from UpdateMediaState().
        // 
        // Note when media enters and leaves Full Window rendering, by either the Full Window button on
        // the built in transport controls or by setting MediaElement.IsFullWindow, the DisplayRequest
        // is automatically handled by the system. So if your app does not need to disable screen dimming
        // when not in full window you do not need to manage this manually.
        private DisplayRequest displayRequestManager = null;
        private bool displayRequestRequested = false;

        // System media transport control manager.
        private SystemMediaTransportControls systemControls;

        // Used to load MessageDialog display strings. 
        private ResourceLoader resourceLoader = new ResourceLoader();

        // Used with the custom progress slider.
        private bool sliderPressed = false;
        private bool sliderPausedMedia = false;
        private DispatcherTimer sliderTimer;

        // App settings used for saving application state.
        private ApplicationDataContainer roamingSettings = ApplicationData.Current.RoamingSettings;

        // First time app is run, or if there is not a saved media source, play a OneDevMinute video.
        private const string initialVideoPath = @"http://go.microsoft.com/fwlink/p/?LinkID=272585";

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        #endregion

        public MainPage()
        {
            this.InitializeComponent();

            // Nagivation and Load/Save state handlers.
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += NavigationHelper_LoadState;
            this.navigationHelper.SaveState += NavigationHelper_SaveState;

            // App storage for saving app state
            roamingSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

            // Custom Balance and Volume slider binding defined in XAML.
            DefaultViewModel["media"] = media;

            // Setup system media transport controls
            // Register for the Play, Pause and buttons on the System media transport controls.
            // This is required for Background Audio. For other requirements for background audio see:
            // 1) MediaElement.AudioCategory in MainPage.xaml.
            // 2) The Package.appxmanifest Declarations section: BackgroundTasks->Audio.
            systemControls = SystemMediaTransportControls.GetForCurrentView();
            systemControls.ButtonPressed += SystemControls_ButtonPressed;
            systemControls.IsPlayEnabled = true;
            systemControls.IsPauseEnabled = true;
            systemControls.IsStopEnabled = true;

            systemControls.IsEnabled = true;

            // The Window resize event
            Window.Current.SizeChanged += Current_SizeChanged;

            // Create DisplayRequest object
            displayRequestManager = new DisplayRequest();
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

        #region App and MedieElement State: Save and Restore

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
            // Save MediaElement state info.
            roamingSettings.Values["media.Stretch"] = media.Stretch.ToString();
            roamingSettings.Values["media.AutoPlay"] = media.AutoPlay.ToString();
            roamingSettings.Values["media.IsLooping"] = media.IsLooping.ToString();
            roamingSettings.Values["media.Position"] = media.Position.Seconds;
            roamingSettings.Values["media.AudioStreamIndex"] = media.AudioStreamIndex;
            roamingSettings.Values["media.CurrentState"] = media.CurrentState.ToString();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // If there is a saved media source, load it.
            if (roamingSettings.Values.ContainsKey("media.Source"))
            {
                // Media state will be restored in RestoreMediaSourceState() which is called from the 
                // MediaOpened event handler. This is becuase Media.Position cannot be set  
                // until the  MediaElement is loaded.  Position cannot be greater than NaturalDuration.
                // To keep things organized, all the MediaElement state is restored in RestoreMediaSourceState.
                restoreMediaSourceSettings = true;

                // Get the path of the media source from the saved state.
                String mediaPath = (string)roamingSettings.Values["media.Source"];

                // Set the source of the MediaElement.
                SetMediaSource(mediaPath);

                // Update TextBox in AppBar with the path to media.
                appBarTextBoxFilePath.Text = mediaPath;
            }
            else
            {
                // No saved state data. Set the source to the default One Dev Minute video.
                SetMediaSourceFromPath(initialVideoPath);
                appBarTextBoxFilePath.Text = initialVideoPath;
            }
        }

        /// <summary>
        /// Restores the MediaElement state form app storage. This method is called from
        /// Media_MediaOpened, if restoreMediaSourceSettings is true. The MediaElement state is 
        /// restored here becuase Media.Position cannot be set until the  MediaElement is loaded.  
        /// Position cannot be greater than NaturalDuration.
        /// To keep things organized, all the MediaElement state is restored here.
        /// </summary>
        private void RestoreMediaSourceState()
        {
            // Restore media position.
            if (roamingSettings.Values.ContainsKey("media.Position"))
            {
                int seconds = (int)roamingSettings.Values["media.Position"];

                if (media.CanSeek)
                {
                    media.Position = new TimeSpan(0, 0, seconds);
                }
            }

            // Restore audio track index.
            if (roamingSettings.Values.ContainsKey("media.AudioStreamIndex"))
            {
                int audioIndex = (int)roamingSettings.Values["media.AudioStreamIndex"];

                if (media.AudioStreamCount >= audioIndex - 1)
                {
                    media.AudioStreamIndex = audioIndex;
                }
            }

            // Restore playing state.
            if (roamingSettings.Values.ContainsKey("media.CurrentState"))
            {
                MediaElementState state = (MediaElementState)Enum.Parse(typeof(MediaElementState), (string)roamingSettings.Values["media.CurrentState"], true);
                switch (state)
                {
                    case MediaElementState.Playing:
                        PlayMedia();
                        break;
                    case MediaElementState.Stopped:
                        StopMedia();
                        break;
                    case MediaElementState.Paused:
                        PauseMedia();
                        break;
                    default:
                        break;
                }
            }

            // Restore Stretch state.
            if (roamingSettings.Values.ContainsKey("media.Stretch"))
            {
                media.Stretch = (Stretch)Enum.Parse(typeof(Stretch), (string)roamingSettings.Values["media.Stretch"], true);
            }

            // Restore AutoPlay state.
            if (roamingSettings.Values.ContainsKey("media.AutoPlay"))
            {
                media.AutoPlay = Convert.ToBoolean(roamingSettings.Values["media.AutoPlay"]);
            }

            // Restore Looping state.
            if (roamingSettings.Values.ContainsKey("media.IsLooping"))
            {
                media.IsLooping = Convert.ToBoolean(roamingSettings.Values["media.IsLooping"]);
            }
        }
        #endregion

        #region MediaElement Media Event Handlers

        /// <summary>
        /// Loaded event handler for the parent container of the MediaElement.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MediaContainer_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the initial size of the MediaElement container.
            UpdateAppSize();
        }

        /// <summary>
        /// Window Resize Event Handler
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        void Current_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            UpdateAppSize();
        }

        /// <summary>
        /// Resizes the MediaElement Container on Window resize.
        /// </summary>
        private void UpdateAppSize()
        {
            // Set size of the MediaElement parent container to 75% of the window
            MediaContainer.Width = Window.Current.Bounds.Width * .75;
            MediaContainer.Height = Window.Current.Bounds.Height * .75;

            // Hide or Unhide AppBar buttons depending on the width of the window.
            // stackPanelAppbarCenter, which contains the Play/Pause and Stop buttons, is never hidden.
            if (Window.Current.Bounds.Width >= 750)
            {
                // Top AppBar.
                if (stackPanelTopAppBarLeft.Visibility != Visibility.Visible)
                {
                    stackPanelTopAppBarLeft.Visibility = Visibility.Visible;
                }

                // Bottom AppBar.
                if (stackPanelAppbarLeft.Visibility != Visibility.Visible)
                {
                    stackPanelAppbarLeft.Visibility = Visibility.Visible;
                }
                if (stackPanelAppbarRight.Visibility != Visibility.Visible)
                {
                    stackPanelAppbarRight.Visibility = Visibility.Visible;
                }
            }
            else if (Window.Current.Bounds.Width >= 500)
            {
                // Top AppBar.
                if (stackPanelTopAppBarLeft.Visibility != Visibility.Visible)
                {
                    stackPanelTopAppBarLeft.Visibility = Visibility.Visible;
                }

                // Bottom AppBar.
                if (stackPanelAppbarLeft.Visibility != Visibility.Visible)
                {
                    stackPanelAppbarLeft.Visibility = Visibility.Visible;
                }

                if (stackPanelAppbarRight.Visibility != Visibility.Collapsed)
                {
                    stackPanelAppbarRight.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                // Top AppBar.
                if (stackPanelTopAppBarLeft.Visibility != Visibility.Collapsed)
                {
                    stackPanelTopAppBarLeft.Visibility = Visibility.Collapsed;
                }

                // Bottom AppBar.
                if (stackPanelAppbarLeft.Visibility != Visibility.Collapsed)
                {
                    stackPanelAppbarLeft.Visibility = Visibility.Collapsed;
                }

                if (stackPanelAppbarRight.Visibility != Visibility.Collapsed)
                {
                    stackPanelAppbarRight.Visibility = Visibility.Collapsed;
                }
            }
        }

        /// <summary>
        /// The MediaEnded event handler. 
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments</param>
        private void Media_MediaEnded(object sender, RoutedEventArgs e)
        {
            // Stop the custom timeline position slider if the media is not looping.
            if (!media.IsLooping)
            {
                StopTimelineTimer();
                timelineSlider.Value = 0.0;
            }
        }

        /// <summary>
        /// The MediaFailed event handler.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments</param>
        private void Media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            // Handle media failed event appropriately. Get HRESULT from event args which can be logged.
            string hr = GetHresultFromErrorMessage(e);
        }

        /// <summary>
        /// MediaOpened event handler.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e"></param>
        private void Media_MediaOpened(object sender, RoutedEventArgs e)
        {
            // Populate Combobox for selecting multiple audio tracks.
            PopulateAudioTracksComboBox();

            // Initiazlie custom timeline slider.
            double absvalue = (int)Math.Round(media.NaturalDuration.TimeSpan.TotalSeconds, MidpointRounding.AwayFromZero);
            timelineSlider.Maximum = absvalue;
            timelineSlider.StepFrequency = SliderFrequency(media.NaturalDuration.TimeSpan);
            SetupTimelineTimer();

            // Retore MediaElement state if restoreMediaSourceSettings flag is set. 
            // This will happen if the App retores from termination state.
            if (restoreMediaSourceSettings == true)
            {
                RestoreMediaSourceState();
                restoreMediaSourceSettings = false;
            }

            // Set initial volume settting.
            media.Volume = .3;

            // Pre-roll video if this is the default video and the Position is ~ 0
            // pre-roll the One-Dev-Minute to the first second.
            // If the media source is a file, the Source URI could be null.
            if (null != media.Source)
            {
                if (media.Source.AbsoluteUri == initialVideoPath && Math.Round(media.Position.TotalSeconds, 0) == 0)
                {
                    media.Position = new TimeSpan(0, 0, 1);
                }
            }
        }

        /// <summary>
        /// The MediaElement CurrentStateChagned event handler.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        void Media_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            // Updates the media state for the SystemMediaTransportControls.
            // Updates button states for Play/Pause and Stop.
            UpdateMediaState();
        }

        /// <summary>
        /// Media PlaybackRate event handler.
        /// Sets the shared Play/Pause button state.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Media_RateChanged(object sender, RateChangedRoutedEventArgs e)
        {
            // Update the state of the shared Play/Pause button furing fastforward and rewind.  
            if (media.PlaybackRate != 1.0)
            {
                SetPlayPauseButton(PlayPauseButtonState.Play);
            }
            else
            {
                SetPlayPauseButton(PlayPauseButtonState.Pause);
            }
        }

        #endregion

        #region Disable Screen Dimming: DisplayRequest

        /// <summary>
        /// Enables and Disables screen dimming.
        /// Screen dimming should be reenabled whenever the media is not playing in order to preserver battery life.
        /// UpdateMediaState() manages when this method is called.
        /// 
        /// Note, when media enters and leaves Full Window rendering, by either the Full Window button on
        /// the built in transport controls or by setting MediaElement.IsFullWindow, the DisplayRequest
        /// is automatically handled by the system. So if your app does not need to disable screen dimming
        /// when not in full window, you do not need to manage this manually. 
        /// For more info, see http://msdn.microsoft.com/en-us/library/windows/apps/br241816.aspx
        /// </summary>
        /// <param name="enableDimming">true to enable screen dimming. False to turnscreen dimming on</param>
        public void DisableScreenDimming(bool enableDimming)
        {
            if (null != displayRequestManager)
            {
                if (enableDimming)
                {
                    // DisplayRequest is cumulative. So to simplify, we will only set this one time.
                    if (!displayRequestRequested)
                    {
                        // Set requested flag.
                        displayRequestRequested = true;

                        // Request screen dimming to be disabled for this app.
                        displayRequestManager.RequestActive();
                    }
                }
                else
                {
                    // Make sure DisplayRequest has been requested.  
                    if (displayRequestRequested)
                    {
                        // Reset requested flag.
                        displayRequestRequested = false;

                        // Release the display request.
                        displayRequestManager.RequestRelease();
                    }
                }
            }
        }
        #endregion

        #region Media Element and SystemMediaTransportControls State

        /// <summary>
        /// Updates the MediaElement state when system media transport control button is pressed.
        /// Handles play, stop, and pause.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments</param>
        void SystemControls_ButtonPressed(SystemMediaTransportControls sender, SystemMediaTransportControlsButtonPressedEventArgs e)
        {
            switch (e.Button)
            {
                case SystemMediaTransportControlsButton.Play:
                    PlayMedia();
                    break;
                case SystemMediaTransportControlsButton.Stop:
                    StopMedia();
                    break;
                case SystemMediaTransportControlsButton.Pause:
                    PauseMedia();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Called when the media state changes. 
        /// 1) SystemMediaTransportControls.PlaybackStatus is set to keep the controls in sync with the media.
        /// 2) AppBarButtons are enabled/disabled depending on state.
        /// 3) DisableScreenDimming is enabled/disabled depending on the state. This requests or releases the
        ///    DisplayReqeust object.  To conserve power, this should be released whenever the media is not playing.
        /// </summary>
        void UpdateMediaState()
        {
            switch (media.CurrentState)
            {
                case MediaElementState.Playing:
                    // Update SystemMediaTransportControls to keep them in sync with the MediaElement.
                    systemControls.PlaybackStatus = MediaPlaybackStatus.Playing;

                    // Set AppBar button state
                    // Note, for fast-forward and rewind, the Play/Plause button state is changed in the
                    // MediaElement.RateChanged event handler which is called when MediaElement.PlaybackRate is changed.
                    if (media.PlaybackRate == 1.0)
                    {
                        SetPlayPauseButton(PlayPauseButtonState.Pause);
                    }

                    appBarButtonStop.IsEnabled = true;
                    appBarFastForward.IsEnabled = true;
                    appBarButtonRewind.IsEnabled = true;

                    // Disable screen dimming
                    if (!media.IsAudioOnly)
                    {
                        DisableScreenDimming(true);
                    }

                    // Update custom timeline position slider state
                    UpdateSliderTimer();
                    break;
                case MediaElementState.Paused:
                    // Update SystemMediaTransportControls to keep them in sync with the MediaElement.
                    systemControls.PlaybackStatus = MediaPlaybackStatus.Paused;

                    // Set AppBar button state
                    SetPlayPauseButton(PlayPauseButtonState.Play);
                    appBarButtonStop.IsEnabled = true;
                    appBarFastForward.IsEnabled = false;
                    appBarButtonRewind.IsEnabled = false;

                    // Re-enable screen dimming.
                    if (!media.IsAudioOnly)
                    {
                        DisableScreenDimming(false);
                    }

                    // Update custom timeline position slider state
                    UpdateSliderTimer();
                    break;
                case MediaElementState.Stopped:
                    // Update SystemMediaTransportControls to keep them in sync with the MediaElement.
                    systemControls.PlaybackStatus = MediaPlaybackStatus.Stopped;

                    // Set AppBar button state.
                    SetPlayPauseButton(PlayPauseButtonState.Play);
                    appBarButtonStop.IsEnabled = false;
                    appBarFastForward.IsEnabled = false;
                    appBarButtonRewind.IsEnabled = false;

                    // Re-enable screen dimming.
                    if (!media.IsAudioOnly)
                    {
                        DisableScreenDimming(false);
                    }

                    // Update custom timeline position slider state
                    UpdateSliderTimer();
                    break;
                case MediaElementState.Closed:
                    // Update SystemMediaTransportControls to keep them in sync with the MediaElement.
                    systemControls.PlaybackStatus = MediaPlaybackStatus.Closed;

                    // Set AppBar button state.
                    SetPlayPauseButton(PlayPauseButtonState.Play);
                    appBarButtonStop.IsEnabled = false;
                    appBarFastForward.IsEnabled = false;
                    appBarButtonRewind.IsEnabled = false;

                    // Re-enable screen dimming.
                    if (!media.IsAudioOnly)
                    {
                        DisableScreenDimming(false);
                    }

                    // Update custom timeline position slider state
                    UpdateSliderTimer();
                    break;
                case MediaElementState.Buffering:
                    // Handle buffering state tasks.
                    break;
                case MediaElementState.Opening:
                    // Handle Opening state tasks.
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Sets the Play/Pause button on the AppBar. Play and Pause share one button.
        /// </summary>
        /// <param name="buttonState">The button to change the AppBar Button to</param>
        private void SetPlayPauseButton(PlayPauseButtonState buttonState)
        {
            // The text name of the bottom and tooltip.
            string buttonName;

            switch (buttonState)
            {
                case PlayPauseButtonState.Play:
                    
                    // Update button icon.
                    appBarButtonPlay.Icon = new SymbolIcon(Symbol.Play);

                    // Update button text.
                    buttonName = resourceLoader.GetString("playSharedButton");
                    appBarButtonPlay.Label = buttonName;
                    ToolTipService.SetToolTip(appBarButtonPlay, buttonName);
                    break;
                case PlayPauseButtonState.Pause:

                    // Update button icon.
                    appBarButtonPlay.Icon = new SymbolIcon(Symbol.Pause);

                    // Update button text.
                    buttonName = resourceLoader.GetString("pauseSharedButton");
                    appBarButtonPlay.Label = buttonName;
                    ToolTipService.SetToolTip(appBarButtonPlay, buttonName);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Plays the media. Marshals call onto the UI thread's dispatcher.
        /// </summary>
        async void PlayMedia()
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                // If the Play button is pressed while the media is fast-forwarding or rewinding,
                // reset the PlaybackRate to the normal rate.
                media.PlaybackRate = 1.0;

                media.Play();
            });
        }

        /// <summary>
        /// Pauses the media. Marshals call onto the UI thread's dispatcher. 
        /// </summary>
        async void PauseMedia()
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                media.Pause();
            });
        }

        /// <summary>
        /// Stops the media. Marshals call onto the UI thread's dispatcher. 
        /// </summary>
        async void StopMedia()
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                media.Stop();
            });
        }

        #endregion

        #region Audio Methods

        /// <summary>
        /// Populates the AudioTracks ComboBox with the available tracks from the media source.
        /// </summary>
        private void PopulateAudioTracksComboBox()
        {
            // Clear out CombooBox from previous media
            audioTracksComboBox.Items.Clear();

            // Create ComboBox items for each language
            for (int track = 0; track < media.AudioStreamCount; track++)
            {
                string trackLanguage = media.GetAudioStreamLanguage(track);

                audioTracksComboBox.Items.Add(trackLanguage);
            }

            // Set the selected combobox item.
            // If AudioStreamIndex has a value, simply use that.
            // But if AudioStreamIndex does not have a value , attempt to get the default language
            // defined by the content and set the index to that. If that fails, set it to the first track.
            if (!media.AudioStreamIndex.HasValue)
            {
                // Set the track to the default language defined by the content.
                string language = media.GetAudioStreamLanguage(null);

                for (int x = 0; x < media.AudioStreamCount; x++)
                {
                    if (media.GetAudioStreamLanguage(x) == language)
                    {
                        media.AudioStreamIndex = x;
                        break;
                    }
                }

                if (media.AudioStreamCount > 0 && !media.AudioStreamIndex.HasValue)
                {
                    media.AudioStreamIndex = 0;
                }
            }

            audioTracksComboBox.SelectedIndex = media.AudioStreamIndex.Value;
        }

        /// <summary>
        /// When the user selects an available audio track, change the video's
        /// current audio track to match the selected audio track.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e"></param>
        private void AudioTracksComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox tracksCheckBox = sender as ComboBox;

            if (null != tracksCheckBox)
            {
                media.AudioStreamIndex = tracksCheckBox.SelectedIndex;
            }
        }
        #endregion

        #region Media Files: Set source
        
        /// <summary>
        /// Called when the text changes in the file path text box.
        /// When the user presses the Enter key, load the media file specified 
        /// in the path given in the text box.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e"></param>
        private void AppBarTextBoxFilePath_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                SetMediaSource(appBarTextBoxFilePath.Text);
            }
        }

        /// <summary>
        /// The Media source TextBox LostFocus event handler. 
        /// If the user types in the TextBox but does not hit Enter, we still try to load
        /// the path that is in the TextBox when focus is lost.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e"></param>
        void AppBarTextBoxFilePath_LostFocus(object sender, RoutedEventArgs e)
        {
            string mediaSourcePath = string.Empty;

            // Get the path of the current media source from app storage.
            if (roamingSettings.Values.ContainsKey("media.Source"))
            {
                mediaSourcePath = (string)roamingSettings.Values["media.Source"];
            }

            // If the text is not Empty and not equal to the current media source.
            if (!string.IsNullOrWhiteSpace(appBarTextBoxFilePath.Text) &&
                appBarTextBoxFilePath.Text != mediaSourcePath)
            {
                SetMediaSourceFromPath(appBarTextBoxFilePath.Text);
            }
        }

        /// <summary>
        /// Click event handler for the Browse source button.
        /// Launches the FileOpenPicker to get a media file to set the MediaElement.Source to.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e"></param>
        private async void BrowseForMediaFile_Click(object sender, RoutedEventArgs e)
        {
            // Create file picker.
            FileOpenPicker fileOpenPicker = new FileOpenPicker();

            // Set view mode.
            fileOpenPicker.ViewMode = PickerViewMode.Thumbnail;

            // Add media file types to display.
            fileOpenPicker.FileTypeFilter.Add(".wmv");
            fileOpenPicker.FileTypeFilter.Add(".mp4");
            fileOpenPicker.FileTypeFilter.Add(".wma");
            fileOpenPicker.FileTypeFilter.Add(".mp3");

            // Set suggested file locaiton.
            fileOpenPicker.SuggestedStartLocation = PickerLocationId.VideosLibrary;

            // Open file picker and get file.
            StorageFile file = await fileOpenPicker.PickSingleFileAsync();

            if (null != file)
            {
                // Cache the file permission token so we can open file later.
                Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList.Add(file);

                // Set the source of the MediaElement to the file returned from the file picker.
                SetMediaSourceFromFile(file);
            }
        }

        /// <summary>
        /// Determines if the media source is a local file or from the network 
        /// and calls the approriate method to set the source.
        /// </summary>
        /// <param name="path"></param>
        async private void SetMediaSource(string path)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {
                // Check if the media source is a http or https network source
                if (path.ToLower().StartsWith("http:") || 
                    path.ToLower().StartsWith("https:")) 
                {
                    // Media source is from the internet.
                    SetMediaSourceFromPath(path);
                }
                else
                {
                    // Media source is a local file.
                    try
                    {
                        StorageFile file = await StorageFile.GetFileFromPathAsync(path);
                        SetMediaSourceFromFile(file);
                    }
                    catch(Exception ex)
                    {
                        if (ex is FormatException || ex is ArgumentException)
                        {
                            ShowFileErrorMsg();
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Set the source of the MediaElement from a file.
        /// </summary>
        /// <param name="file">The media source file.</param>
        async private void SetMediaSourceFromFile(StorageFile file)
        {
            try
            {
                // Get the media source as a stream.
                IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read);

                // Update the TextBox with the path of the file.
                appBarTextBoxFilePath.Text = file.Path;

                // Set the MediaElement.Source to the file stream.
                media.SetSource(stream, file.ContentType);

                // Save the path of the source to app storage so it can be retrieved on app restore.
                roamingSettings.Values["media.Source"] = file.Path;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    ShowFileErrorMsg();
                }
            }
        }

        /// <summary>
        /// Set the source of the MediaElement from a network path.
        /// </summary>
        /// <param name="path">Path to the media source.</param>
        private void SetMediaSourceFromPath(string path)
        {
            try
            {
                // Create a URI to set the source to.
                Uri pathUri = new Uri(path);

                // Set the MediaElement.Source to the path of the media.
                media.Source = pathUri;

                // Save the path of the source to app storage so it can be retrieved on app restore.
                roamingSettings.Values["media.Source"] = path;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    ShowFileErrorMsg();
                }
            }
        }
        #endregion

        #region AppBar Event Handlers

        /// <summary>
        /// Help AppBarButton click event handler. Launches the Help SettingsFlyout.
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">The event arguments</param>
        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpSettings helpSettingsFlyout = new HelpSettings();

            // Launch the Help SettingsFlyout.
            helpSettingsFlyout.Show();

            // Close the AppBars.
            topAppBar.IsOpen = false;
            bottomAppBar.IsOpen = false;
        }

        /// <summary>
        /// Play/Pause AppBarButton event handler. 
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">The event arguments</param>
        private void PlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (media.CurrentState == MediaElementState.Playing && media.PlaybackRate == 1.0)
            {
                PauseMedia();
            }
            else
            {
                PlayMedia();
            }
        }

        /// <summary>
        /// Stop AppBarButton event handler.
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">The event arguments</param>
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            StopMedia();
        }

        /// <summary>
        /// Previous AppBarButton Click handler.
        /// Jumps the MediaElement.Position back 5 seconds.
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">The event arguments</param>
        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            if (media.CanSeek)
            {
                if (media.Position.TotalSeconds > 5)
                {
                    media.Position = media.Position.Subtract(new TimeSpan(0, 0, 5));
                }
                else
                {
                    media.Position = new TimeSpan(0, 0, 0);
                }

                // Update custom timeline position slider.
                ForceTimelineSliderUpdate();
            }
        }

        /// <summary>
        /// Next AppBarButton Click handler.
        /// Jumps the MediaElement.Position forward 5 seconds
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">Event arguments</param>
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (media.CanSeek)
            {
                if ((media.Position.TotalSeconds + 5) < media.NaturalDuration.TimeSpan.TotalSeconds)
                {
                    media.Position = media.Position.Add(new TimeSpan(0, 0, 5));
                }
                else
                {
                    // If at the end of the media, reset to the start position.
                    media.Position = new TimeSpan(0, 0, 0);
                }

                // Update custom timeline slider.
                ForceTimelineSliderUpdate();
            }
        }

        /// <summary>
        /// FastFroward AppBarButton Click handler.
        /// Increases the MediaElement.PlayRate from 1.0, 1.5, 2.0, and back to 1.0.
        /// The shared Play/Pause button UI is updated in the RateChanged event handler 
        /// which is called when PlaybackRate is changed.
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">Event arguments</param>
        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            if (Math.Round(media.PlaybackRate, 1) == 1.0)
            {
                media.PlaybackRate = 1.5;
            }
            else if (Math.Round(media.PlaybackRate, 1) == 1.5)
            {
                media.PlaybackRate = 2.0;
            }
            else
            {
                media.PlaybackRate = 1.0;
            }

            DisplayMessage(string.Format("x{0}", Math.Round(media.PlaybackRate, 1)));
        }

        /// <summary>
        /// Revwind AppBarButton Click handler.
        /// Decreases the MediaElement.PlayRate from 1.0, -1.5, -2.0, and back to 1.0.
        /// The shared Play/Pause button UI is updated in the RateChanged event handler 
        /// which is called when PlaybackRate is changed.
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">Event arguments</param>
        private void Rewind_Click(object sender, RoutedEventArgs e)
        {
            if (Math.Round(media.PlaybackRate, 1) == 1.0)
            {
                media.PlaybackRate = -1.5;
            }
            else if (Math.Round(media.PlaybackRate, 1) == -1.5)
            {
                media.PlaybackRate = -2.0;
            }
            else
            {
                media.PlaybackRate = 1.0;
            }

            DisplayMessage(string.Format("x{0}", Math.Round(media.PlaybackRate, 1)));
        }

        /// <summary>
        /// Mute AppBarButton Click handler.
        /// Enables and disables the mute state on the MediaElement.
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">Event arguments</param>
        private void Mute_Click(object sender, RoutedEventArgs e)
        {
            media.IsMuted = !media.IsMuted;
        }

        /// <summary>
        /// Full window AppBarButton Click handler.
        /// Enables and disables full window rendering.
        /// Note the built-in transport controls on the MediaElement have a full window button.
        /// We are doing this here to show to how to enable full window programatically. 
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">Event arguments</param>
        private void FullWindow_Click(object sender, object e)
        {
            media.IsFullWindow = !media.IsFullWindow;
        }

        /// <summary>
        /// PictureSize AppBarButton Click handler.
        /// Changes the picture size using the MediaElement.Stretch property.
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">event args</param>
        private void PictureSize_Click(object sender, RoutedEventArgs e)
        {
            switch (media.Stretch)
            {
                case Stretch.Fill:
                    DisplayMessage("none");
                    media.Stretch = Stretch.None;
                    break;
                case Stretch.None:
                    DisplayMessage("uniform");
                    media.Stretch = Stretch.Uniform;
                    break;
                case Stretch.Uniform:
                    DisplayMessage("uniform to fill");
                    media.Stretch = Stretch.UniformToFill;
                    break;
                case Stretch.UniformToFill:
                    DisplayMessage("fill");
                    media.Stretch = Stretch.Fill;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Zoom AppBarButton Click handler
        /// Magnifies the MediaElement using the ScrollViewer.ChangeView property.
        /// Zoom from a ZoomFactor of 1.0, 1.4, 2.0, 3.0, and back to 1.0.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments</param>
        private void Zoom_Click(object sender, RoutedEventArgs e)
        {
            if (MediaScrollViewer.ZoomFactor == 1.0F)
            {
                MediaScrollViewer.ChangeView(0, 0, 1.4F);
                DisplayMessage("zoom 1.4");
            }
            else if (MediaScrollViewer.ZoomFactor == 1.4F)
            {
                MediaScrollViewer.ChangeView(0, 0, 2.0F);
                DisplayMessage("zoom 2.0");
            }
            else if (MediaScrollViewer.ZoomFactor == 2.0F)
            {
                MediaScrollViewer.ChangeView(0, 0, 3.0F);
                DisplayMessage("zoom 3.0");
            }
            else
            {
                MediaScrollViewer.ChangeView(0, 0, 1.0F);
                DisplayMessage("zoom 1.0");
            }
        }

        /// <summary>
        /// Repeat AppBarButton Click handler.
        /// Toggles the MediaElement.IsLooping property.
        /// Enables media to conintue to play after it has reached the end.
        /// </summary>
        /// <param name="sender">Object that raised the event</param>
        /// <param name="e">The event arguments</param>
        private void Repeat_Click(object sender, RoutedEventArgs e)
        {
            media.IsLooping = !media.IsLooping;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Helper method to display a message to the screen.
        /// The message is displayed in the TextBlock named txtDisplay.
        /// The textFade animation fades the text after a few seconds.
        /// </summary>
        /// <param name="msg">Message to display</param>
        private void DisplayMessage(string msg)
        {
            txtDisplay.Text = msg;
            textFade.Begin();
        }

        /// <summary>
        /// Helper method to convert an HRESULT into an error string.
        /// </summary>
        /// <param name="e">The Exception event arguments</param>
        /// <returns>The error string.</returns>
        private string GetHresultFromErrorMessage(ExceptionRoutedEventArgs e)
        {
            String hr = String.Empty;
            String token = "HRESULT - ";
            const int hrLength = 10;     // eg "0xFFFFFFFF"

            int tokenPos = e.ErrorMessage.IndexOf(token, StringComparison.Ordinal);
            if (tokenPos != -1)
            {
                hr = e.ErrorMessage.Substring(tokenPos + token.Length, hrLength);
            }

            return hr;
        }

        /// <summary>
        /// Displays an error message to the user regarding an invalid media file.
        /// </summary>
        async void ShowFileErrorMsg()
        {
            try
            {
                MessageDialog messageDialog = new MessageDialog(resourceLoader.GetString("exBadFileOrPathName"));
                await messageDialog.ShowAsync();
            }
            catch (Exception)
            {
                // handle exception
            }
        }

        #endregion

        #region Custom Timeline Slider for MediaElement Position
        //******************************************************
        // Custom timeline position slider control code
        //******************************************************

        /// <summary>
        /// Loaded event handler for the root Page.  
        /// Sets up the timelineSlider event handlers to control setting the MediaElement Position
        /// through the Slider control.
        /// </summary>
        private void PageRoot_Loaded(object sender, RoutedEventArgs e)
        {
            // Sets up the custom Slider control on the AppBar
            timelineSlider.ValueChanged += TimelineSlider_ValueChanged;

            PointerEventHandler pointerPressedHandler = new PointerEventHandler(TimelineSlider_PointerEntered);    
            timelineSlider.AddHandler(Control.PointerPressedEvent, pointerPressedHandler, true);

            PointerEventHandler pointerReleasedHandler = new PointerEventHandler(TimelineSlider_PointerCaptureLost);
            timelineSlider.AddHandler(Control.PointerCaptureLostEvent, pointerReleasedHandler, true);
        }

        /// <summary>
        /// The PointerEntered event handler for the timeline Slider.
        /// Sets the sliderpressed flag so the timer does not continue to update the Slider while the user
        /// is interacting with it.
        /// </summary>
        void TimelineSlider_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            sliderPressed = true;

            // If media is playing, pause it while the slider control is being used.
            if (media.CurrentState == MediaElementState.Playing)
            {
                sliderPausedMedia = true;
                PauseMedia();
            }
        }

        /// <summary>
        /// The PointerCaptureLost event handler for the timeline position Slider.
        /// Sets the MediaElement.Position to Slider.Value and unsets the sliderpressed flag 
        /// which enables the timer to continue to update the slider position.
        /// </summary>
        void TimelineSlider_PointerCaptureLost(object sender, PointerRoutedEventArgs e)
        {
            media.Position = TimeSpan.FromSeconds(timelineSlider.Value);
            sliderPressed = false;

            // If the media was paused during slider manipulation, un-pause it.
            if (sliderPausedMedia)
            {
                sliderPausedMedia = false;
                PlayMedia();
            }
        }

        /// <summary>
        /// AppBar.Opened event handler for the bottom AppBar.  
        /// If the Appbar is open, turn the timeline position slider timer on so the slider can be udpated.
        /// </summary>
        private void BottomAppBar_Opened(object sender, object e)
        {
            // Set timeline Silder position since it has not been updating while the appbar is cloed. 
            timelineSlider.Value = media.Position.TotalSeconds;

            // Update slider.
            UpdateSliderTimer();
        }

        /// <summary>
        /// AppBar.Closed event for the bottom AppBar.  
        /// If the Appbar is closed, turn off the timer, since we don't need to update the 
        /// slider value when it is not visible.
        /// </summary>
        private void BottomAppBar_Closed(object sender, object e)
        {
            // Clean up timeline position Slider.
            if(sliderPausedMedia)
            {
                // If the media was stopped by the slider but not restarted, restart it.
                sliderPausedMedia = false;
                PlayMedia();
            }
            
            if (sliderPressed)
            {
                // Reset slider pressed flag if still set.
                sliderPressed = false;
            }

            // Turn off slider when AppBar is closed to conserve resources.
            UpdateSliderTimer();
        }

        /// <summary>
        /// Sets the step frequency of the Slider control which is also used from the 
        /// timer tick interval.  
        /// </summary>
        /// <param name="timevalue"></param>
        /// <returns></returns>
        private double SliderFrequency(TimeSpan timevalue)
        {
            double stepfrequency = -1;

            double absvalue = (int)Math.Round(
                timevalue.TotalSeconds, MidpointRounding.AwayFromZero);

            stepfrequency = (int)(Math.Round(absvalue / 100));

            if (timevalue.TotalMinutes >= 10 && timevalue.TotalMinutes < 30)
            {
                stepfrequency = 10;
            }
            else if (timevalue.TotalMinutes >= 30 && timevalue.TotalMinutes < 60)
            {
                stepfrequency = 30;
            }
            else if (timevalue.TotalHours >= 1)
            {
                stepfrequency = 60;
            }

            if (stepfrequency == 0) stepfrequency += 1;

            if (stepfrequency == 1)
            {
                stepfrequency = absvalue / 100;
            }

            return stepfrequency;
        }

        /// <summary>
        /// Initiazlie the slider timer.
        /// </summary>
        private void SetupTimelineTimer()
        {
            sliderTimer = new DispatcherTimer();
            sliderTimer.Interval = TimeSpan.FromSeconds(timelineSlider.StepFrequency);
            sliderTimer.Tick += TimelineSlider_Tick;

            // Note, the timer is started in UpdateSliderTimer()
        }

        /// <summary>
        /// Timer.Tick event handler. This updates the Slider.Value with the current position
        /// of the MediaElement, if the Slider is not being chagned by the user.
        /// </summary>
        private void TimelineSlider_Tick(object sender, object e)
        {
            if (!sliderPressed)
            {
                timelineSlider.Value = media.Position.TotalSeconds;
            }
        }

        /// <summary>
        /// Forece an update on the slider.  
        /// </summary>
        private void ForceTimelineSliderUpdate()
        {
            timelineSlider.Value = media.Position.TotalSeconds;
        }

        /// <summary>
        /// Start the timeline position slider timer.
        /// </summary>
        private void StartTimelineTimer()
        {
            sliderTimer.Start();
        }

        /// <summary>
        /// Stop the timeline position slider timer.
        /// </summary>
        private void StopTimelineTimer()
        {
            sliderTimer.Stop();
        }

        /// <summary>
        /// The timeline position Slider ValueChanged event handler. 
        /// When the slider value is changed, update the MediaElement.Position.
        /// </summary>
        void TimelineSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (!sliderPressed)
            {
                media.Position = TimeSpan.FromSeconds(e.NewValue);
            }
        }

        /// <summary>
        /// Starts and stops the timeline position slider timer depending on different app and media states.
        /// </summary>
        void UpdateSliderTimer()
        {
            // Timer not set up
            if (null != sliderTimer)
            {
                // Start timer if media is playing and AppBar is open.
                if (media.CurrentState == MediaElementState.Playing && bottomAppBar.IsOpen)
                {
                    if (sliderPressed)
                    {
                        StopTimelineTimer();
                    }
                    else
                    {
                        StartTimelineTimer();
                    }
                }

                // Stop timer if media is stopped or paused or appbar is closed.
                if (media.CurrentState == MediaElementState.Paused ||
                    media.CurrentState == MediaElementState.Stopped ||
                    !bottomAppBar.IsOpen)
                {
                    // Stop timer.
                    StopTimelineTimer();

                    if (media.CurrentState == MediaElementState.Stopped)
                    {
                        timelineSlider.Value = 0;
                    }
                }
            }
        }

        #endregion
    }
}

