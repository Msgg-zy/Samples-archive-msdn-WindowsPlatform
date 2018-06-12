//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

// This Windows Store app uses a flat system of navigation. 
// The flat navigation pattern is often seen in games, browsers, or 
// document creation apps, where the user can move quickly between a small 
// number of pages, tabs, or modes that all reside at the same hierarchical level. 

(function () {
    "use strict";

    var activation = Windows.ApplicationModel.Activation;
    var app = WinJS.Application;
    var nav = WinJS.Navigation;
    var sched = WinJS.Utilities.Scheduler;
    var ui = WinJS.UI;

    // *** 
    // Roaming application data.
    var roamingSettings = Windows.Storage.ApplicationData.current.roamingSettings;
    // See the handleDisclaimer() function in this file.
    // Test roaming application data by (un)commenting this line.
    Windows.Storage.ApplicationData.current.clearAsync();
    // *** 

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. 
                // Initialize your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }

            nav.history = app.sessionState.history || {};
            nav.history.current.initialPlaceholder = true;

            // Optimize the load of the application and, while the splash screen 
            // is shown, execute high priority scheduled work.
            ui.disableAnimations();
            var p = ui.processAll().then(function () {
                // Retrieve the standard app bar.
                var appBar = document.getElementById("appBar").winControl;
                // Attach event handlers to the command buttons.
                var helpButton = appBar.getCommandById("helpButton");
                helpButton.addEventListener("click", showHelp, false);
                return nav.navigate(nav.location || Application.navigator.home, nav.state);
            }).then(function () {
                return sched.requestDrain(sched.Priority.aboveNormal + 1);
            }).then(function () {
                ui.enableAnimations();
            });

            args.setPromise(p);
        }
    };

    // When your app is launched, this event occurs after both the loaded and activated events.
    // See WinJS.Application.onready at http://go.microsoft.com/fwlink/?LinkID=299192.
    app.onready = function (args) {
        // Show disclaimer regardless of how the app has been activated,
        // unless disclaimer already accepted.
        var disclaimer = roamingSettings.values["disclaimer"];
        // If no disclaimer response, show disclaimer.
        if (!disclaimer) {
            // Get disclaimer resources.
            // See Globalizing your app at http://go.microsoft.com/fwlink/?LinkId=258266.
            var resDisclaimerTitle = WinJS.Resources.getString('disclaimerTitle');
            var resDisclaimer = WinJS.Resources.getString('disclaimer');
            var resDisclaimerButton = WinJS.Resources.getString('disclaimerButton');
            // Create a disclaimer message dialog and set its content.
            // A message dialog can support up to three commands. 
            // If no commands are specified, a close command is provided by default.
            // If specifying your own commmands, set the command that will be invoked by default.
            // For example, msg.defaultCommandIndex = 1;
            // Note: Message dialogs should be used sparingly, and only for messages or 
            // questions critical to the continued use of your app.
            // See Adding message dialogs at http://go.microsoft.com/fwlink/?LinkID=275116.
            var msg = new Windows.UI.Popups.MessageDialog(resDisclaimer.value, resDisclaimerTitle.value);
            // Handler for disclaimer.
            // For this example, we use the disclaimer to demonstrate roaming app data.
            msg.commands.append(new Windows.UI.Popups.UICommand(resDisclaimerButton.value, handleDisclaimer));

            // Show the message dialog
            msg.showAsync();
        }
    };

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. If you need to 
        // complete an asynchronous operation before your application is 
        // suspended, call args.setPromise().
        app.sessionState.history = nav.history;
    };

    // Store the disclaimer response.
    // For this example, we use the disclaimer to demonstrate roaming app data.
    // See Roaming application data at http://go.microsoft.com/fwlink/?LinkID=313894.
    function handleDisclaimer(eventInfo) {
        var appData = Windows.Storage.ApplicationData.current;
        var roamingSettings = appData.roamingSettings;
        roamingSettings.values["disclaimer"] = true;
    }

    // Show the settings pane help page from app bar.
    function showHelp(eventInfo) {
        eventInfo.preventDefault();
        WinJS.UI.SettingsFlyout.showSettings("help", "/settings/help.html");
        // Dismiss the nav and app bars. Light dismiss doesn't execute.
        var appBar = document.getElementById("appBar").winControl;
        appBar.hide();
    }

    app.start();
})();
