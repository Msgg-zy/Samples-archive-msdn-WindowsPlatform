//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved
// Immediately invoked function expression (née self-executing anonymous function).
// Function expression is invoked immediately upon definition. 
// JavaScript has function level scoping where all variables and functions 
// defined within an IIFE function are unavailable outside of it, 
// effectively using closure to seal function members from the outside world.
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var nav = WinJS.Navigation;
    var sched = WinJS.Utilities.Scheduler;
    var ui = WinJS.UI;
    // Used to restore app data. 
    var roamingSettings = Windows.Storage.ApplicationData.current.roamingSettings;

    // *** 
    // Uncomment the following to test roaming application data.
    // See the handleDisclaimer() function in this file.
     //Windows.Storage.ApplicationData.current.clearAsync();
    // *** 

    // When your app is launched, the activated event is raised. 
    // An app can be activated by the system, the user, and through various 
    // contracts and extensions (such as search, share, file I/O, and so on). 
    // During an initial launch, the activated event fires after 
    // DOMContentLoaded but before window.onload. It tells the app whether it was 
    // activated because the user launched it or it was launched by some other means. 
    // Use the activated event handler to check the type of activation, 
    // respond appropriately, and load any state needed for the activation. 
    // If you have code that needs to run when the app sets up 
    // its initial state, include it in the handler for the activated event. 
    // Note: Performing a lot of work during activation can make your app appear unresponsive. 
    // If possible, defer expensive operations until after your app is loaded. 
    // For an introduction to the Windows Store app lifecycle, 
    // see http://go.microsoft.com/fwlink/?LinkId=251912.
    // For guidelines on app suspend and resume,
    // see http://go.microsoft.com/fwlink/?LinkID=276670.
    // For detail on WinJS.Application.onactivated,
    // see http://go.microsoft.com/fwlink/?LinkID=299191.
     app.onactivated = function (args) {
         if (args.detail.kind === activation.ActivationKind.launch) {
             // For more info on handling app activation, see http://go.microsoft.com/fwlink/?LinkID=276675.
             // An app is launched if it is activated when the process is in 
             // the NotRunning ApplicationExecutionState. This occurs when the app 
             // is newly deployed, has crashed, or was suspended and could not be 
             // kept in memory.
             // Note: At any given point, an app is Running, NotRunning, or 
             // Suspended (other app states include Terminated and ClosedByUser).        
             // See ApplicationExecutionState enumeration at http://go.microsoft.com/fwlink/?LinkId=251913.
             if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                 // This application has been newly launched. 
                 // Initialize your application here.

             } else {
                 // This application has been reactivated from suspension.
                 // Restore application state here.
                 // App data persists across sessions and must always be accessible to the user. 
                 // Session data is temporary data that is relevant to the user's current session 
                 // in your app. A session ends when the user closes the app using the close gesture 
                 // or Alt + F4, reboots the computer, or logs off the computer. 
             }

             nav.history = app.sessionState.history || {};
             nav.history.current.initialPlaceholder = true;

             // Clear out the current settings handler.
             app.onsettings = null;
             // Populate settings pane and tie commands to settings flyouts.
             // See Adding app settings at http://go.microsoft.com/fwlink/?LinkID=288799.
             // Privacy statement must be included in Settings and on the app's description page.
             // When you submit your app to the Store, use the Privacy policy field in the Description step.
             // Note: The Permissions pane is system-controlled and can't be modified. 
             app.onsettings = function (e) {
                 // Get the settings labels.
                 var resSettingsHelpLabel = WinJS.Resources.getString('/help/settingsHelpLabel');
                 var resSettingsPrivacyLabel = WinJS.Resources.getString('/privacy/settingsPrivacyLabel');
                 e.detail.applicationcommands = {
                     "help": { title: resSettingsHelpLabel.value, href: "/settings/help.html" },
                     "privacy": { title: resSettingsPrivacyLabel.value, href: "/settings/privacy.html" }
                 };
                 WinJS.UI.SettingsFlyout.populateSettings(e);
             }

             // Process WinJS app controls.
             // The WinJS.UI.processAll is enclosed in a call to the setPromise method, 
             // which ensures the splash screen is displayed until the app is ready. 
             // WinJS.UI.processAll activates WinJS controls that you've declared in markup. 
             ui.disableAnimations();
             args.setPromise(ui.processAll().then(function () {
                 WinJS.Resources.processAll();
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
                 document.getElementById("contenthost").winControl.pageElement.focus();
             }));
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
        // This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. We use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to 
        // complete an asynchronous operation before your application is 
        // suspended, call args.setPromise().
        app.sessionState.history = nav.history;
    };

    // Basic application-level error handling.
    // Most errors bubble up to the application error handler.
    // • Critical blocking errors: Alert the user with a message dialog. 
    // • Informational and non-blocking errors (such as a failure to sync or obtain online data): Alert the user with a flyout or inline message.
    // • Errors that don’t affect the user experience: Handle silently.
    // Typically, you'll want to write to a log to obtain customer telemetry. 
    // In this example, we use a MessageDialog and log all errors.
    app.onerror = function (err) {
        // Use the custom error message, the standard exception message, or a default. 
        var message = err.detail.errorMessage ||
              (err.detail.exception && err.detail.exception.message) ||
              "Indeterminate error";

        var messageDialog = new Windows.UI.Popups.MessageDialog(message, "Error");

        messageDialog.showAsync();

        WinJS.Utilities.startLog({ type: "appError", tags: "App" });
        WinJS.log && WinJS.log(message, "App", "appError");

        return true;
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
        var navBar = document.getElementById("navBar").winControl;
        navBar.hide();
    }

    app.start();
})();