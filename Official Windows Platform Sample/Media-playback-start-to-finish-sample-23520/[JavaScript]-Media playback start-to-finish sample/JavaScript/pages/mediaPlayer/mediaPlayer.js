//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved
////
// For an introduction to the Page Control template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232511
(function () {
    "use strict";

    var app = WinJS.Application;

    // Var to hold the <video> object
    var media;

    // System Media Trasport Controls
    var systemMediaControls;

    // For supported audio and video formats for Windows Store apps, see:
    //     http://msdn.microsoft.com/en-us/library/windows/apps/hh986969.aspx
    var supportedAudioFormats = [
        ".3g2", ".3gp2", ".3gp", ".3gpp", ".m4a", ".mp4", ".asf", ".wma", ".aac", ".adt", ".adts", ".mp3", ".wav", ".ac3", ".ec3",
    ];

    var supportedVideoFormats = [
        ".3g2", ".3gp2", ".3gp", ".3gpp", ".m4v", ".mp4v", ".mp4", ".mov", ".m2ts", ".asf", ".wmv", ".avi",
    ];

    // First time app is run, or if there is not a saved media source, play a OneDevMinute video.
    var initialVideoPath = "http://go.microsoft.com/fwlink/p/?LinkID=272585";

    // Variables for keeping the display on during video playback. 
    // Used in the setScreenDimming which is called from UpdateMediaState().
    // 
    // Note when media enters and leaves Full Window rendering, by either the Full Window button on
    // the built in transport controls or by setting full screen mode by calling msRequestFullscreen, 
    // the DisplayRequest is automatically handled by the system. So if your app does not need to disable screen dimming
    // when not in full window you do not need to manage this manually.
    var displayRequestManager = new Windows.System.Display.DisplayRequest;
    var displayRequestRequested = false;

    WinJS.UI.Pages.define("/pages/mediaPlayer/mediaPlayer.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            // Event handler to listen for when apps resume after being suspended.  
            // Most cases this is not needed, but here we listen to it so we can trun the screen dimming back off if the media is playing
            Windows.UI.WebUI.WebUIApplication.addEventListener("resuming", appResumingFromSuspend, false);

            WinJS.Resources.processAll();

            // Get the video object.
            media = document.getElementById("mediaVideo");

            // media events
            media.addEventListener("loadeddata", mediaLoaded, false);
            media.addEventListener("volumechange", mediaVolumeChanged, false);
            media.addEventListener("pause", mediaPaused, false);
            media.addEventListener("ended", mediaEnded, false);
            media.addEventListener("playing", mediaPlaying, false);

            // Retrieve the standard app bar.
            var appBarBottom = document.getElementById("appBarBottom").winControl;
            var appBarTop = document.getElementById("appBarTop").winControl;

            // Attach event handlers to the command buttons and media object
            var helpButton = appBarTop.getCommandById("helpButton");
            helpButton.addEventListener("click", showHelp, false);

            var txtSourceInput = document.getElementById("txtSourceInput");
            txtSourceInput.addEventListener("keyup", txtSourceInputKeyUp, false);

            var browseButton = document.getElementById("browseButton");
            browseButton.addEventListener("click", setMediaSourceFromFilePicker, false);

            var playButton = appBarBottom.getCommandById("playButton");
            playButton.addEventListener("click", playMedia, false);

            var pauseButton = appBarBottom.getCommandById("pauseButton");
            pauseButton.addEventListener("click", pauseMedia, false);

            var rewindButton = appBarBottom.getCommandById("rewindButton");
            rewindButton.addEventListener("click", rewindMedia, false);

            var fastForwardButton = appBarBottom.getCommandById("fastForwardButton");
            fastForwardButton.addEventListener("click", fastforwardMedia, false);

            var previousButton = appBarBottom.getCommandById("previousButton");
            previousButton.addEventListener("click", skipMediaBackwards, false);

            var nextButton = appBarBottom.getCommandById("nextButton");
            nextButton.addEventListener("click", skipMediaForward, false);

            var zoomButton = appBarBottom.getCommandById("zoomButton");
            zoomButton.addEventListener("click", zoomMedia, false);

            var fullScreenButton = appBarBottom.getCommandById("fullScreenButton");
            fullScreenButton.addEventListener("click", fullScreenMedia, false);

            var muteButton = appBarBottom.getCommandById("muteButton");
            muteButton.addEventListener("click", muteMedia, false);

            var repeatButton = appBarBottom.getCommandById("repeatButton");
            repeatButton.addEventListener("click", loopMedia, false);

            var trackDropDown = document.getElementById("audioTracksSelect");
            trackDropDown.addEventListener("change", audioTrackChanged, false);

            var volumeSlider = document.getElementById("volumeInputRange");
            volumeSlider.addEventListener("change", volumeSliderChange, false);
            
            var bottomAppBar = document.getElementById("appBarBottom");
            appBarBottom.addEventListener("beforeshow", bottomAppBarShowing, false);
            
            // Set up the media transport contols.
            setupSystemMediaTransportControls();

            // Restore the media src.  If this is the first time the app is played, initialVideoPath is loaded.
            restoreMediaSource();
            
            // Change page layout, depending on screen width.
            changeLayout();
        },

        unload: function () {
            // TODO: Respond to navigations away from this page.
        },

        updateLayout: function (element) {
            // Change page layout, depending on screen width.
            changeLayout();
        }
    });

    // Save media state when app is suspended/terminated
    app.oncheckpoint = function (args) {
        // This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. We use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to 
        // complete an asynchronous operation before your application is 
        // suspended, call args.setPromise().
        var roamingSettings = Windows.Storage.ApplicationData.current.roamingSettings;

        // Save media state.     
        roamingSettings.values["media.activeAudioTrack"] = getActiveAudioTrack(media);
        roamingSettings.values["media.loop"] = media.loop;
        roamingSettings.values["media.muted"] = media.muted;

        // If the media is ended the current position may not be 0, so save the current position as 0. 
        // Otherwise, use currentTime.
        if (media.ended) {
            roamingSettings.values["media.currentTime"] = 0;
        }
        else {
            roamingSettings.values["media.currentTime"] = media.currentTime;
        }

        // Save the playing state of the media.
        if (!media.paused && !media.ended) {
            roamingSettings.values["media.playing"] = true;
        }
        else {
            roamingSettings.values["media.playing"] = false;
        }

        // If screen dimming was turned off, turn it back on.
        if (displayRequestRequested) {
            setScreenDimming(true);
        }
    };

    // Restores the state of the media.  
    // This is called in the mediaLoaded event handler if the app is resuming from a terminated state.  
    // The state is restored after the media is loaded because some of the properties, such as currentTime, 
    //  must be set after the media is loaded.
    function restoreMediaState() {
        var roamingSettings = Windows.Storage.ApplicationData.current.roamingSettings;

        // Restore the media position.
        // If setting key does not exist, the default video settings will be used.
        if (roamingSettings.values.hasKey("media.currentTime")) {
            media.currentTime = roamingSettings.values["media.currentTime"];
        }

        // Restore the active audio track. 
        // If setting key does not exist, the default video settings will be used.
        if (roamingSettings.values.hasKey("media.activeAudioTrack")) {
            setActiveAudioTrack(roamingSettings.values["media.activeAudioTrack"]);
        }

        // Set the media loop property.
        // If setting key does not exist, the default video settings will be used.
        if (roamingSettings.values.hasKey("media.loop")) {
            media.loop = roamingSettings.values["media.loop"];
        }

        // Set the media mute property.
        // If setting key does not exist, the default video settings will be used.
        if (roamingSettings.values.hasKey("media.muted")) {
            media.muted = roamingSettings.values["media.muted"];
        }

        // Set the playing state.
        // If setting key does not exist, the default video settings will be used.
        if (roamingSettings.values.hasKey("media.playing")) {
            if (roamingSettings.values["media.playing"]) {
                playMedia();
            }
        }
    }

    // Event handler for the resuming event.  
    // This will be called when the app is restored from a suspend state.
    function appResumingFromSuspend()
    {
        // Turn off screen dimming if the media is set to play on resume. 
        // We check that both the paused and ended properties are false, because if ended is true, paused can still be false. 
        if(!media.paused && !media.ended)
        {
            setScreenDimming(false);
        }
    }

    // Loads the media source.
    // Sets the contents of the "Source" text box to the path of the media source.
    function restoreMediaSource() {
        var roamingSettings = Windows.Storage.ApplicationData.current.roamingSettings;
        var txtSourceInput = document.getElementById("txtSourceInput");

        // Check if there is a media source saved and update the media source text box.
        // If there is not a saved media source, use the default media source.
        if (roamingSettings.values.hasKey("media.source")) {
            txtSourceInput.value = roamingSettings.values["media.source"];
        }
        else {
            txtSourceInput.value = initialVideoPath;
        }

        // Load the media source.
        if (txtSourceInput.value !== "") {
            setMediaSourceFromTextBox();
        }
    }

    // <summary>
    // Enables and Disables screen dimming.
    // Screen dimming should be reenabled whenever the media is not playing in order to preserve battery life.
    // 
    // The Windows.System.Display.DisplayRequest class provides functions for requesting to turn on and off
    // the system screen dimming. See the MSDN reference page for more info:
    // http://msdn.microsoft.com/en-us/library/windows/apps/windows.system.display.displayrequest.aspx
    //
    // Note, when media enters and leaves Full Window rendering, by either the Full Screen button on
    // the built in transport controls or by calling media.msRequestFullscreen(), the DisplayRequest
    // is automatically handled by the system. So if your app does not need to disable screen dimming
    // when not in full window, you do not need to manage this manually. 
    // For more info, see http://msdn.microsoft.com/en-us/library/windows/apps/jj152725.aspx
    // </summary>
    // <param name="enableDimming">true to turn screen dimming back on. false to turn screen dimming off.</param>
    function setScreenDimming(enableDimming) {
        if (enableDimming) {
            // DisplayRequest is cumulative. So to simplify ref counting, we will only call requestActive/requestRelease once.
            // The displayRequestRequested flag keeps track if there is an acttive DisplayRequest.requestActive call.
            if (displayRequestRequested) {
                // Unset the requested flag.
                displayRequestRequested = false;

                // Release the display request.
                displayRequestManager.requestRelease();
            }
        }
        else {
            if (!displayRequestRequested) {
                // Set requested flag.
                displayRequestRequested = true;

                // Request screen dimming to be disabled for this app.
                displayRequestManager.requestActive();
            }
        }
    }

    // Invoked from this Page's "ready" method.  Retrieve and initialize the 
    // SystemMediaTransportControls object.
    // See the System media transport controls sample: http://go.microsoft.com/fwlink/p/?LinkID=309020
    function setupSystemMediaTransportControls() {
        // Retrieve the SystemMediaTransportControls object associated with the current app view
        // (ie. window).  There is exactly one instance of the object per view, instantiated by
        // the system the first time getForCurrentView() is called for the view.  All subsequent 
        // calls to getForCurrentView() from the same view (eg. from different scenario pages in 
        // this sample) will return the same instance of the object.
        systemMediaControls = Windows.Media.SystemMediaTransportControls.getForCurrentView();

        // To receive notifications for the user pressing media keys (eg. "Stop") on the keyboard, or 
        // clicking/tapping on the equivalent software buttons in the system media transport controls UI, 
        // all of the following needs to be true:
        //     1. Register for buttonpressed event on the SystemMediaTransportControls object.
        //     2. isEnabled property must be true to enable SystemMediaTransportControls itself.
        //        [Note: isEnabled is initialized to true when the system instantiates the
        //         SystemMediaTransportControls object for the current app view.]
        //     3. For each button you want notifications from, set the corresponding property to true to
        //        enable the button.  For example, set isPlayEnabled to true to enable the "Play" button 
        //        and media key.
        //        [Note: the individual button-enabled properties are initialized to false when the
        //         system instantiates the SystemMediaTransportControls object for the current app view.] 
        systemMediaControls.addEventListener("buttonpressed", systemMediaControlsButtonPressed, false);

        // Note: one of the prerequisites for an app to be allowed to play audio while in background, 
        // is to enable handling Play and Pause buttonpressed events from SystemMediaTransportControls.
        systemMediaControls.isPlayEnabled = true;
        systemMediaControls.isPauseEnabled = true;
        systemMediaControls.isStopEnabled = true;
        systemMediaControls.playbackStatus = Windows.Media.MediaPlaybackStatus.closed;
    }

    // Event handler for SystemMediaTransportControls' buttonpressed event
    function systemMediaControlsButtonPressed(eventIn) {

        var mediaButton = Windows.Media.SystemMediaTransportControlsButton;

        switch (eventIn.button) {
            case mediaButton.play:
                WinJS.log && WinJS.log("Play pressed", "sample", "status");
                playMedia();

                // The SystemMediaTransportControl state is updated in the mediaStarted event handler.
                break;

            case mediaButton.pause:
                WinJS.log && WinJS.log("Pause pressed", "sample", "status");
                pauseMedia();

                // The SystemMediaTransportControl state is updated in the mediaPaused event handler.
                break;

            case mediaButton.stop:
                WinJS.log && WinJS.log("Stop pressed", "sample", "status");
                stopMedia();

                // The SystemMediaTransportControl state is updated in the mediaEnded event handler.
                break;

                // Insert additional case statements for other buttons you want to handle in your app.
                // Remember that you also need to first enable those buttons via the corresponding
                // is****Enabled property on the SystemMediaTransportControls object.
        }
    }

    // The media Play event handler.
    function mediaPlaying() {
        // Update the SystemMediaTransportControl state.
        systemMediaControls.playbackStatus = Windows.Media.MediaPlaybackStatus.playing;

        // Disable screen dimming
        setScreenDimming(false);
    }

    // The media Pause event handler.
    function mediaPaused() {
        // Update the SystemMediaTransportControl state.
        systemMediaControls.playbackStatus = Windows.Media.MediaPlaybackStatus.paused;

        // Re-enable screen dimming.
        setScreenDimming(true);
    }

    // The media Ended event handler.
    function mediaEnded() {
        // Update the SystemMediaTransportControl state.
        systemMediaControls.playbackStatus = Windows.Media.MediaPlaybackStatus.stopped;

        // Re-enable screen dimming.
        setScreenDimming(true);
    }

    // The media Onloadeddata event handler.
    function mediaLoaded() {
        // Populate the audio track drop down list with the audio track languages.
        populateAudioTracksList();

        // Some media state can only be restored until after the media has loaded
        if (resumeFromTerminatedState) {
            restoreMediaState();
            resumeFromTerminatedState = false;
        }
    }

    // The media volume changed event handler.
    function mediaVolumeChanged() {
        var volumeSlider = document.getElementById("volumeInputRange");

        volumeSlider.value = media.volume;
    }

    // The OnChange event handler for the volume input range.
    function volumeSliderChange() {
        var volumeSlider = document.getElementById("volumeInputRange");

        media.volume = volumeSlider.value;
    }

    // Plays the media.
    function playMedia() {
        media.play();
    }

    // Pauses the media.
    function pauseMedia() {
        media.pause();
    }

    // Stops the media and resets the position back to 0.
    function stopMedia() {
        media.pause();
        media.currentTime = 0;     
    }

    // Rewind AppBarButton Click handler.
    // Rewinds the media by setting the playbackRate to -2.
    function rewindMedia() {
        media.playbackRate = -2;
    }

    // Fastforward AppBarButton Click handler.
    // Fastforwards the media by setting the playbackRate to 2.
    function fastforwardMedia() {
        media.playbackRate = 2;
    }

    // Skip forwards AppBarButton Click handler.
    // Jumps the currentTime forwards 5 seconds.
    function skipMediaForward() {
        if ((media.currentTime + 5) < media.duration) {
            media.currentTime += 5;
        }
        else {
            // If at the end of the media, reset to the start position.
            media.currentTime = 0;
        }
    }

    // Skip backwards AppBarButton Click handler.
    // Jumps the currentTime backwards 5 seconds.
    function skipMediaBackwards() {
        if (media.currentTime > 5) {
            media.currentTime -= 5;
        }
        else {
            media.currentTime = 0;
        }
    }

    // Zoom AppBarButton Click handler.
    // Magnifies the media.
    // video.msZoom magnifies just enough to remove letterboxing or pillarboxing
    function zoomMedia() {
        media.msZoom = !media.msZoom;

        // Note you can also set the zoom style on the element to change the magnification.
        // For example, this will increase the zoom magnification by a factor of 2:
        // media.style["zoom"] = 2.0
    }

    // Full window AppBarButton Click handler.
    // Enables and disables full window rendering.
    // Note the built-in transport controls on the video object have a full window button.
    // We are doing this here to show to how to enable full window programatically. 
    function fullScreenMedia() {
        media.msRequestFullscreen();
    }

    // Mute AppBarButton Click handler.
    // Toggles the mute state of the media.
    function muteMedia() {
        media.muted = !media.muted;
    }

    // Loop AppBarButton Click handler.
    // Toggles the loop state of the media.
    function loopMedia() {
       media.loop = !media.loop;
    }

    // Populates the audio track drop down list with the audio track languages.
    function populateAudioTracksList() {
        var trackSelect = document.getElementById("audioTracksSelect");

        // Clear previous options if there are any.
        trackSelect.options.length = 0;

        // Create a list item for each language
        for (var x = 0; x < media.audioTracks.length ; x++) {
            var track = document.createElement("option");
            track.text = media.audioTracks[x].language;
            trackSelect.add(track, null);
        }
    }

    // The change event for the Select object that lists the audio tracks.
    function audioTrackChanged() {
        var select = document.getElementById("audioTracksSelect");
        setActiveAudioTrack(select.selectedIndex);
    }

    // Sets the active audio track on the media to the specified track index.
    function setActiveAudioTrack(trackIndex) {
        // Verify trackIndex is in bounds of the array of audio tracks.
        if (media.audioTracks.length > trackIndex) {

            // Enable the traget audio track.
            media.audioTracks[trackIndex].enabled = true;

            // Disable all the other audio tracks.
            for (var x = 0; x < media.audioTracks.length ; x++) {
                if (x !== trackIndex) {
                    media.audioTracks[x].enabled = false;
                }
            }
        }
    }

    // Gets the audio track is that active. 
    function getActiveAudioTrack(media) {
        var activeTrack = 0;

        // Iterate through all the audio tracks and look for the one that is enabled.
        for (var x = 0; x < media.audioTracks.length ; x++) {
            if (media.audioTracks[x].enabled === true) {
                activeTrack = x;
            }
        }

        return activeTrack;
    }

    // Sets media source based on what the user enters in the "Source" text box.
    function txtSourceInputKeyUp(e) {
        if (e.keyCode === Windows.System.VirtualKey.enter) {
            setMediaSourceFromTextBox();
        }
    }

    // Sets the media source from the path that is specified in the "Source" text box.
    function setMediaSourceFromTextBox() {
        var txtSourceInput = document.getElementById("txtSourceInput");
        var path = String(txtSourceInput.value);

        if (path !== null && path !== "") {
            // Check if the media is loaded from the network. 
            // Otherwise, load the media from the file system.
            if (path.toLowerCase().substring(0, 5) === "http:" ||
                path.toLowerCase().substring(0, 6) === "https:") {

                setMediaSourceFromPath(path);
            }
            else {
                // Note, this operation will fail if the file has not already been opened by the FileOpenPicker
                // and saved to the Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.
                // We add files that are opened in setMediaSourceFromFilePicker to this list.
                Windows.Storage.StorageFile.getFileFromPathAsync(path).done(
                    function (path) {
                        setMediaSourceFromFile(path.path, URL.createObjectURL(path));
                    },
                    function (error) {
                        showDialog("Error: Could not load file: " + path);
                    }
                );
            }
        }
    }

    // Sets the media source to the file that the user chooses from the FileOpenPicker.
    function setMediaSourceFromFilePicker() {
        // Create file picker.
        var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

        // Set suggested file locaiton.
        openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;

        // Add video and audio file types to display.
        openPicker.fileTypeFilter.replaceAll(supportedVideoFormats.concat(supportedAudioFormats));

        // Open file picker and get file.
        openPicker.pickSingleFileAsync().then(
            function (file) {
                if (file) {
                    // The Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList enables you
                    // to save a list of files the user has opened with the file picker so you can open then at a later date.  
                    // Normally, the system will throw an exception is you attempt to open a file from the file system without
                    // going through the file picker or setting the appropriate library capabilities. 
                    Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.add(file);

                    // Set the media source to the file returned from the file picker.
                    setMediaSourceFromFile(file.path, URL.createObjectURL(file));
                }
            }
        );
    }

    // Sets and loads the media from a network file path.
    function setMediaSourceFromPath(filePath) {
        var txtSourceInput = document.getElementById("txtSourceInput");
        var roamingSettings = Windows.Storage.ApplicationData.current.roamingSettings;

        // The name of the file path that is displayed.
        txtSourceInput.value = filePath;

        // Set the media source.
        media.src = filePath;

        // Save the media source to local storage so we can load it later.
        roamingSettings.values["media.source"] = filePath;
    }

    // Sets and loads the media from a file that is in the file system
    function setMediaSourceFromFile(filePath, url) {
        var txtSourceInput = document.getElementById("txtSourceInput");
        var roamingSettings = Windows.Storage.ApplicationData.current.roamingSettings;

        // The friendly name of the file path that is displayed.
        txtSourceInput.value = filePath;

        // Set the source to the data blob that points to the file in the file system.
        media.src = url;

        // Save the media source to local storage so we can load it later.
        roamingSettings.values["media.source"] = filePath;
    }

    // General message dialog display function.
    function showDialog(message) {
        var messageDialog = new Windows.UI.Popups.MessageDialog(message);
        messageDialog.showAsync();
    }

    // Changes controls layout, depending on screen width.
    function changeLayout() {
        // Narrow layout.
        if (document.documentElement.offsetWidth < 500) {
            changeToNarrowLayout();
        }
            // Portait layout.
        else if (document.documentElement.offsetWidth < document.documentElement.offsetHeight) {
            changeToPortaitLayout();
        }
            // Landscape layout.
        else {
            changeToLandscapeLayout();
        }
    }

    // Screen width is less than 500 pixels (narrow layout).
    function changeToNarrowLayout() {
        // Set media element parent container to 75% of the window's height and width.
        resizeMediaElement();

        // Hide top app bar.
        hideTopAppBar();

        // Hide all bottom app bar buttons, except for play/pause and stop.
        updateBottomAppBar(AppBarStateOperationEnum.hideAll);
    }

    // Screen width is less than screen height (portait layout).
    function changeToPortaitLayout() {
        // Set media element parent container to 75% of the window's height and width.
        resizeMediaElement();

        // Show top app bar.
        showTopAppBar();

        // Hide some app bar buttons.
        updateBottomAppBar(AppBarStateOperationEnum.hideSome);
    }

    // Screen width is greater than or equal to 500 pixels (landscape layout).
    function changeToLandscapeLayout() {
        // Set media element parent container to 75% of the window's height and width.
        resizeMediaElement();

        // Show top app bar.
        showTopAppBar();

        // Show all app bar buttons.
        updateBottomAppBar(AppBarStateOperationEnum.showAll);
    }

    // Set the media element's parent container to 75% of the window's height and width.
    function resizeMediaElement() {
        media.height = document.documentElement.offsetHeight * 0.75;
        media.width = document.documentElement.offsetWidth * 0.75;
    }

    // Show top app bar.
    function showTopAppBar() {
        var appBarTop = document.getElementById("appBarTop").winControl;
        appBarTop.disabled = false;
    }

    // Hide top app bar.
    function hideTopAppBar() {
        var appBarTop = document.getElementById("appBarTop").winControl;
        appBarTop.disabled = true;
    }

    // Enum that defines the different states to put the BottomBar into.
    var AppBarStateOperationEnum = Object.freeze({"showAll":1, "hideSome":2, "hideAll":3})

    // Updates the state of the BottomAppBar based on the specifiy input parameter.
    // Params: AppBarStateOperationEnum appBarState
    function updateBottomAppBar(appBarState) {
        // AppBar Buttons to show/hide.
        var previousButton = document.getElementById("previousButton");
        var nextButton = document.getElementById("nextButton");
        var rewindButton = document.getElementById("rewindButton");
        var fastForwardButton = document.getElementById("fastForwardButton");
        var zoomButton = document.getElementById("zoomButton");
        var fullScreenButton = document.getElementById("fullScreenButton");
        var repeatButton = document.getElementById("repeatButton");
        var muteButton = document.getElementById("muteButton");
        var volumeButton = document.getElementById("volumeButton");
        var audioTracksButton = document.getElementById("audioTracksButton");

        // Bottom AppBar.
        var appBarBottom = document.getElementById("appBarBottom").winControl;

        switch (appBarState) {
            // Show all of the Bottom Appbar buttons.
            case AppBarStateOperationEnum.showAll:
                appBarBottom.showCommands([
                    rewindButton,
                    fastForwardButton,
                    previousButton,
                    nextButton,
                    zoomButton,
                    fullScreenButton,
                    repeatButton,
                    muteButton,
                    volumeButton,
                    audioTracksButton,
                ], true);
                break;
            // Hide some of the Bottom Appbar buttons.
            case AppBarStateOperationEnum.hideSome:
                appBarBottom.hideCommands([
                    previousButton,
                    nextButton,
                    zoomButton,
                    fullScreenButton,
                    repeatButton,
                ], true);

                appBarBottom.showCommands([
                    rewindButton,
                    fastForwardButton,
                    muteButton,
                    volumeButton,
                    audioTracksButton,
                ], true);
                break;
            // Hide all of the Bottom Appbar buttons.
            case AppBarStateOperationEnum.hideAll:
                appBarBottom.hideCommands([
                    rewindButton,
                    fastForwardButton,
                    previousButton,
                    nextButton,
                    zoomButton,
                    fullScreenButton,
                    repeatButton,
                    muteButton,
                    volumeButton,
                    audioTracksButton,
                ], true);
                break;
            default:
                break;
        }
    }

    // Show the settings pane help page from app bar.
    function showHelp(eventInfo) {
        eventInfo.preventDefault();
        WinJS.UI.SettingsFlyout.showSettings("help", "/settings/help.html");
        // Dismiss the nav and app bars. Light dismiss doesn't execute.
        var appBar = document.getElementById("appBarBottom").winControl;
        appBar.hide();
    }

    // The AppBar beforeshow event handler.
    function bottomAppBarShowing() {
        // set state of toggle buttons in case the state was changed 
        var muteButton = document.getElementById("muteButton").winControl;
        var repeatButton = document.getElementById("repeatButton").winControl;
        var volumeSlider = document.getElementById("volumeInputRange");

        muteButton.selected = media.muted;
        repeatButton.selected = media.loop;
        volumeSlider.value = media.volume;
    }
})();

