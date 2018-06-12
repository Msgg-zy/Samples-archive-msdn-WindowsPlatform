//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved
// NOTE: 
// For this sample, home.htmlis provided as a standalone, localized HTML file.
// (The rich HTML content can be easily edited in an HTML or text editor.)
// If possible, avoid localizing app code and use standard string resources in .resjson files.
(function () {
    "use strict";
    // For Page Control methods, see WinJS.UI.Pages.IPageControlMembers interface at http://go.microsoft.com/fwlink/?LinkID=320074.
    WinJS.UI.Pages.define("/pages/home/home.html", {
        // First method called in the page life cycle.
        // The load method retrieves the information from the uri provided. 
        // The default implementation calls the low level fragment loader to 
        // retrieve the content. Override to take control of the loading process.
        // This result of the promise is received in the render method.
        //
        // Typically, this overload is used to generate your content 
        // through another mechanism such as a JavaScript templating library.
        //
        // For the purposes of this sample, we don't do anything.
        //load: function (uri) {
        //},

        // Second method called in the page lifecycle.
        // Initializes the page before content is set.
        //
        // The init method can return a promise that completes when init is finished.
        // This result of the promise is received in the processed method.
        // Typically, this method is used to initiate lengthy async processes.
        //
        // For the purposes of this sample, this method doesn't return anything.
        //init: function (element, options) {
        //},

        // Third method called in the page lifecycle. 
        // The render method receives the result from the promise in the load method. 
        // This result is inserted into the DOM.
        // You typically don't need to override this method.
        //
        // In this case, we do nothing.
        //render: function (element, options, loadResult) {
        //},

        // Fourth method called in the page lifecycle.
        // Initializes the page after the content is set.
        // The processed method is called after the render method is finished and
        // the system has called WinJS.UI.processAll on the page content.
        // The render method receives the result from the promise in the init method. 
        //
        // You can return a promise here, that will delay the rest of the
        // process until the promise completes.
        //
        // For the purposes of this sample, this method doesn't return anything.
        //processed: function (element) {
        //},

        // Fifth and final method called in the page lifecycle.
        // The ready method is called after the DOM is finalized
        // and controls are processed. 
        //
        // In most cases, this is the only method you'll need.
        ready: function (element, options) {
            // Process app resources.            
            // Replace text-only strings bound to properties through data-win-res.
            WinJS.Resources.processAll();

            // Retrieve the page 2 link and register the event handler. 
            // Don't use a button when the action is to go to another page; use a link instead. 
            // See Guidelines and checklist for buttons at http://go.microsoft.com/fwlink/?LinkID=313598
            // and Quickstart: Using single-page navigation at http://go.microsoft.com/fwlink/?LinkID=320288.
            WinJS.Utilities.query("a").listen("click", linkClickHandler, false);
            WinJS.Utilities.query("a").listen("keydown", linkClickHandler, false);
        },

        // Basic page-level error handling.
        // Called when an error occurs during page load.
        // Error still bubbles to the app error handler unless canceled in navigator.js error handler.
        // Typically, you'll want to write to a log to obtain customer telemetry. 
        // In this example, we log all errors.
        error: function (err) {
            WinJS.Utilities.startLog({ type: "pageError", tags: "Page" });
            WinJS.log && WinJS.log(err.message, "Page", "pageError");
        },

        // The unload method is called when leaving page.
        unload: function (element, options) {
        },

        // This function is called by _contextChanged event handler in navigator.js when 
        // a resource qualifier (language, scale, contrast, and so on) changes. 
        // The element passed is the root of this page. 
        updateResources: function (element, e) {
            // Will filter for changes to specific qualifiers.
            if (e.detail.qualifier === "Language" || e.detail.qualifier === "Scale" || e.detail.qualifier === "Contrast") {
                // Process app resources.            
                // Replace text-only strings bound to properties through data-win-res.
                WinJS.Resources.processAll(element);
                // Update app bar elements.
                WinJS.Resources.processAll(document.getElementById("appBar"));

                // Images with variants from the app package are automatically reloaded 
                // by the platform when a resource context qualifier has changed. 
                // However, this is not done for img elements on a page. 
                // Here, we ensure they are updated.
                var imageElements = document.getElementsByTagName("img");
                for (var i = 0, l = imageElements.length; i < l; i++) {
                    var previousSource = imageElements[i].src;
                    var uri = new Windows.Foundation.Uri(document.location, previousSource);
                    if (uri.schemeName === "ms-appx") {
                        imageElements[i].src = "";
                        imageElements[i].src = previousSource;
                    }
                }
            }
        },

        // Here's a basic framework for customizing responses to changes in layout. 
        // Layout changes are managed in navigator.js and the window.onresize event handler. 
        // At run time, the onresize event calls this updateLayout function when the app switches 
        // between portrait, snapped, full screen, and filled view states.
        // See Handling view state at http://go.microsoft.com/fwlink/?LinkID=314251.
        // For this example, we use media attributes in default.css to demonstrate basic layouts.
        updateLayout: function (element, viewState, lastViewState) {
            /// <param name="element" domElement="true" />
            /// <param name="viewState" value="Windows.UI.ViewManagement.ApplicationViewState" />
            /// <param name="lastViewState" value="Windows.UI.ViewManagement.ApplicationViewState" />

            // TODO: Respond to changes in viewState.
        }
    });

    function linkClickHandler(eventInfo) {
        var link = eventInfo.target;
        if ((eventInfo.srcElement && eventInfo.type === "keydown") &&
            (eventInfo.keyCode !== WinJS.Utilities.Key.enter &&
            eventInfo.keyCode !== WinJS.Utilities.Key.space)) {
            return;
        }
        if (link.href.indexOf("ms-appx") > -1) {
            WinJS.Navigation.navigate(link.href);
        }
        if (link.href.indexOf("http") > -1) {
            // Create a Uri object from a URI string 
            var uri = new Windows.Foundation.Uri(link.href);
            var options = new Windows.System.LauncherOptions();
            // Launch the URI with a warning prompt
            options.treatAsUntrusted = true;
            // Launch the URI
            Windows.System.Launcher.launchUriAsync(uri, options);
        }
    }

})();
