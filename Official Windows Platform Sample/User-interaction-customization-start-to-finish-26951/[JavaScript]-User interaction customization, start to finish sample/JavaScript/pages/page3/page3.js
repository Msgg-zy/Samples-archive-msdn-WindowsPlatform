//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

// NOTE: 
// For this sample, page3.html is provided as a standalone, localized HTML file.
// (The rich HTML content can be easily edited in an HTML or text editor.)
// If possible, avoid localizing app code and use standard string resources in .resjson files.
(function () {
    "use strict";
    // For Page Control methods, see WinJS.UI.Pages.IPageControlMembers interface at http://go.microsoft.com/fwlink/?LinkID=320074.
    WinJS.UI.Pages.define("/pages/page3/page3.html", {
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
            WinJS.Resources.processAll(element)
            WinJS.UI.processAll(element);

            // Create simple DOM gesture recognizer for the color selector.
            // Tap sets the color.
            // Press and hold displays the current color value.
            var colorSelector = document.getElementById("colorSelector");
            // Declare event handlers.
            colorSelector.addEventListener("pointerdown", this.pointerDown, false);
            colorSelector.addEventListener("pointerup", this.pointerUp, false);
            colorSelector.addEventListener("MSGestureTap", this.msGestureTap, false);
            colorSelector.addEventListener("MSGestureHold", this.msGestureHold, false);
            colorSelector.addEventListener("keydown", this.keyDown, false);
        },

        // Basic page-level error handling.
        // Typically, you'll want to write to a log to obtain customer telemetry. 
        // In this example, we use a MessageDialog and log all errors.
        error: function (err) {
            WinJS.Utilities.startLog({ type: "pageError", tags: "Page" });
            WinJS.log && WinJS.log(err.message, "Page", "pageError");
        },

        // The unload method is called when leaving page.
        unload: function (element, options) {
            var colorMixer = document.getElementById("colorMixer").winControl;
            colorMixer.disposeColorMixer();
        },

        // Key down handler. 
        // Here, we attach a Spacebar or Enter key to activation.
        // Key down handler. 
        // Here, we attach a Spacebar or Enter key to activation.
        keyDown: function (eventInfo) {
            if (eventInfo.srcElement &&
                (eventInfo.keyCode === WinJS.Utilities.Key.enter ||
                eventInfo.keyCode === WinJS.Utilities.Key.space)) {

                var colorMixer = document.getElementById("colorMixer").winControl;
                colorMixer.focus();
                // Get the collection of RGB color divs.
                var colors = WinJS.Utilities.query(".Color");

                // Iterate and highlight selected color.
                for (var color = 0; color < colors.length; color++) {
                    if (colors[color].id === eventInfo.target.id) {
                        colors[color].style.opacity = "1";
                        // Add the selected color to the color mixer.
                        colorMixer.selectedColor = colors[color].id;
                    } else {
                        colors[color].style.opacity = ".25";
                    }
                }
            }
        },
        // Pointer down handler. 
        // Here, we attach the pointer to a simple DOM gesture object.
        // This is sufficient because we're handling only static gestures in the color selector.
        pointerDown: function (eventInfo) {
            var colorGesture = new MSGesture();
            colorGesture.target = eventInfo.target;
            colorGesture.addPointer(eventInfo.pointerId);
        },

        pointerUp: function (eventInfo) {
            var colorMixer = document.getElementById("colorMixer").winControl;
            colorMixer.focus();
        },

        // Tap gesture handler: Display event.
        // Fires on user interaction through a touch, mouse click, or pen tap. 
        // The touch language described in Touch interaction design (http://go.microsoft.com/fwlink/?LinkID=268162),
        // specifies that the tap gesture should invoke an elements primary action 
        // (such as launching an application or executing a command). 
        // Here, we pick the color for the color mixer.
        msGestureTap: function (eventInfo) {
            var colorMixer = document.getElementById("colorMixer").winControl;
            // Get the collection of RGB color divs.
            var colors = WinJS.Utilities.query(".Color");

            // Iterate and highlight selected color.
            for (var color = 0; color < colors.length; color++) {
                if (colors[color].id === eventInfo.target.id) {
                    //colors[color].style.backgroundColor = colors[color].id;
                    colors[color].style.opacity = "1";
                    // Add the selected color to the color mixer.
                    colorMixer.selectedColor = colors[color].id;
                } else {
                    colors[color].style.opacity = ".25";
                }
            }
        },

        // Hold gesture handler: Display event.
        // The touch language described in Touch interaction design (http://go.microsoft.com/fwlink/?LinkID=268162),
        // specifies that the press and hold gesture should aid learning or exploration 
        // (such as showing context menus or flyouts). 
        // Here, we display the current color levels in a flyout.
        msGestureHold: function (eventInfo) {
            var colorMixer = document.getElementById("colorMixer").winControl;
            var x = colorMixer.redValue;
            var flyout = document.getElementById("flyout").winControl;
            var flyoutContent = document.getElementById("flyoutContent");
            flyoutContent.innerHTML = "R: " + colorMixer.redValue.level + " G: " + colorMixer.greenValue.level + " B: " + colorMixer.blueValue.level;
            flyout.show(eventInfo.target);
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

    function highlightColor(color) {
        color.style.backgroundColor = "black";
    }


})();
