//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

// The code-behind file for home.html.

(function () {
    "use strict";
    // For Page Control methods, see WinJS.UI.Pages.IPageControlMembers interface 
    // at http://go.microsoft.com/fwlink/?LinkID=320074.
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
        // The processed method receives the result from the promise in the init method. 
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

            setupMixer(element.querySelector("#colorMixer"));
            element.querySelector("#buttonRed").addEventListener("click", colorChangeHandler, false);
            element.querySelector("#buttonGreen").addEventListener("click", colorChangeHandler, false);
            element.querySelector("#buttonBlue").addEventListener("click", colorChangeHandler, false);
            element.querySelector("#listViewColor").winControl.addEventListener("iteminvoked", colorChangeHandler, false);
            element.querySelector("#radioRed").addEventListener("click", colorChangeHandler, false);
            element.querySelector("#radioGreen").addEventListener("click", colorChangeHandler, false);
            element.querySelector("#radioBlue").addEventListener("click", colorChangeHandler, false);
            element.querySelector("#listColor").addEventListener("click", colorChangeHandler, false);

            element.querySelector("#rangeRotation").addEventListener("change", rotationChangeHandler, false);

            element.querySelector("#textColor").addEventListener("focus", textFocusHandler, false);
            element.querySelector("#textRotation").addEventListener("focus", textFocusHandler, false);

            element.querySelector("form").addEventListener("submit", formSubmitHandler, false);

            element.querySelector("a").addEventListener("click", linkClickHandler, false);
            element.querySelector("a").addEventListener("keydown", linkClickHandler, false);
            Windows.UI.ViewManagement.InputPane.getForCurrentView().addEventListener("showing", onInputPaneShowing);
            Windows.UI.ViewManagement.InputPane.getForCurrentView().addEventListener("hiding", onInputPaneHiding);

            // The text change event handlers specified here are provided for demonstration purposes only.
            // They show one way to override the platform validation UI and constrain input in 
            // a text field to valid values only, based on a regular expression pattern.
            // This example uses the Input event of the text fields to check the validity of the current
            // string before enabling the submit button.
            //element.querySelector("#textColor").addEventListener("input", colorTextChangeHandler, false);
            //element.querySelector("#textRotation").addEventListener("input", rotationTextChangeHandler, false);
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

    // The click event handler for links. 
    // Don't use a button when the action is to go to another page; use a link instead. 
    // See Guidelines and checklist for buttons at http://go.microsoft.com/fwlink/?LinkID=313598
    // and Quickstart: Using single-page navigation at http://go.microsoft.com/fwlink/?LinkID=320288.
    function linkClickHandler(eventInfo) {
        var link = eventInfo.target;
        if (eventInfo.srcElement && (
            (eventInfo.type === "click") ||
            (eventInfo.type === "keydown" && (
            eventInfo.keyCode === WinJS.Utilities.Key.enter ||
            eventInfo.keyCode === WinJS.Utilities.Key.space)))) {
            eventInfo.preventDefault();
            if (link.href.indexOf("ms-appx") > -1) {
                WinJS.Navigation.navigate(link.href);
            }
            else if (link.href.indexOf("http") > -1) {
                // Create a Uri object from a URI string 
                var uri = new Windows.Foundation.Uri(link.href);
                var options = new Windows.System.LauncherOptions();
                // Launch the URI with a warning prompt
                options.treatAsUntrusted = true;
                // Launch the URI
                Windows.System.Launcher.launchUriAsync(uri, options);
            }
        }
    }

    // Handler for the touch keyboard showing event.
    // The form is long and requires panning to 
    // display and access all controls.
    // For touch input, we compress the form by removing 
    // all non-text input fields from the layout when 
    // the touch keyboard is displayed. 
    // This is one way to reduce the off and on display 
    // of the touch keyboard when traversing the form.
    function onInputPaneShowing(e) {
        var occludedRect = e.occludedRect;
        // For this example, 400 pixels is the minimum height 
        // that will work for the current layout. 
        // When the app gets the InputPaneShowing message, the pane display animation is beginning.
        if (occludedRect.height < 400) {
            // Query all non-text input controls and use the WinJS collapse animation to hide them.
            var extraneousElements = document.querySelectorAll(".Extraneous");
            for (var i = 0; i < extraneousElements.length ; i++) {
                collapse(extraneousElements[i], document.querySelectorAll(".affectedItem"));
            }
        }
        // This developer doesn't want the framework’s focused element visibility
        // code/animation to override the custom logic.
        //e.ensuredFocusedElementInView = true;
    }

    function collapse(element, affected) {
        // Create collapse animation.
        var collapseAnimation = WinJS.UI.Animation.createCollapseAnimation(element, affected);

        // Execute collapse animation.
        collapseAnimation.execute().done(
            // After animation is complete, remove from display.
            function () { element.style.display = "none"; }
        );
    }

    // Handler for the touch keyboard hiding event.
    // The form is long and requires panning to 
    // display and access all controls.
    // For touch input, we compress the form by removing 
    // all non-text input fields from the layout when 
    // the touch keyboard is displayed. Here we re-display them.
    // This is one way to reduce the off and on display 
    // of the touch keyboard when traversing the form.
    function onInputPaneHiding(e) {
        // In this case, the Input Pane is dismissing. The developer can use 
        // this message to start animations.
        var extraneousElements = document.querySelectorAll(".Extraneous");
        for (var i = 0; i < extraneousElements.length ; i++) {
            expand(extraneousElements[i], document.querySelectorAll(".affectedItem"));
        }

        // Don't use framework scroll- or visibility-related 
        // animations that might conflict with the app's logic.
        e.ensuredFocusedElementInView = true;
    }

    function expand(element, affected) {
        // Create expand animation.
        var expandAnimation = WinJS.UI.Animation.createExpandAnimation(element, affected);

        // Execute expand animation.
        expandAnimation.execute().done(
            // After animation is complete, remove from display.
            function () { element.style.display = ""; }
            );
    }

    // Data object for tracking color-specific values.
    //   level: The color level (r, g, or b)
    //   rotation: The rotation value used to calculate color level.
    //   matrix: The transform matrix of the target.
    function colorInfo(level, rotation, matrix, selected) {
        this.level = level;
        this.rotation = rotation;
        this.matrix = matrix;
        this.selected = selected;
    }

    var redValue, greenValue, blueValue;
    var initialTransform;

    // Initialize the color mixer object.
    function setupMixer(mixer) {
        initialTransform =
            (new MSCSSMatrix()).translate(
            (mixer.parentElement.clientWidth - parseInt(mixer.clientWidth)) / 2.0,
            (mixer.parentElement.clientHeight - parseInt(mixer.clientHeight)) / 2.0);

        mixer.style.msTransform = initialTransform;

        // Set up our transform matrix and individual color values.
        redValue = new colorInfo(0, 0, mixer.style.msTransform, false);
        greenValue = new colorInfo(0, 0, mixer.style.msTransform, false);
        blueValue = new colorInfo(0, 0, mixer.style.msTransform, false);
    }

    function colorChangeHandler(e) {
        redValue.selected = false;
        greenValue.selected = false;
        blueValue.selected = false;
        var selectedColor;
        if (e.currentTarget.winControl) {
            e.detail.itemPromise.done(function (invokedItem) {
                // Access item data from the itemPromise
                selectedColor = invokedItem.data.value;
            });
        }
        else {
            selectedColor = e.currentTarget.value;
        }
        setColor(selectedColor);
    }

    function setColor(selectedColor) {
        redValue.selected = false;
        greenValue.selected = false;
        blueValue.selected = false;
        switch (selectedColor.toUpperCase()) {
            case "RED":
                redValue.selected = true;
                Rotate(redValue.rotation);
                document.querySelector("#textRotation").value = redValue.rotation;
                document.querySelector("#rangeRotation").value = redValue.rotation;
                document.querySelector("#rangeCurrent").innerText = redValue.rotation;
                break;
            case "GREEN":
                greenValue.selected = true;
                Rotate(greenValue.rotation);
                document.querySelector("#textRotation").value = greenValue.rotation;
                document.querySelector("#rangeRotation").value = greenValue.rotation;
                document.querySelector("#rangeCurrent").innerText = greenValue.rotation;
                break;
            case "BLUE":
                blueValue.selected = true;
                Rotate(blueValue.rotation);
                document.querySelector("#textRotation").value = blueValue.rotation;
                document.querySelector("#rangeRotation").value = blueValue.rotation;
                document.querySelector("#rangeCurrent").innerText = blueValue.rotation;
                break;
        }
    }

    // Handler for Color text field input.
    // Provided as an example only.
    // This effectively overrides the platform validation UI 
    // by disabling the form submit button until text value is valid.
    function colorTextChangeHandler(e) {
        document.querySelector("#applyColor").disabled = true;
        if (e.target.value.length > 0) {
            if (e.target.checkValidity()) {
                document.querySelector("#applyColor").disabled = false;
            }
            else {
                document.querySelector("#applyColor").disabled = true;
            }
        }
    }
    // Handler for Rotation text field input.
    // Provided as an example only.
    // This effectively overrides the platform validation UI 
    // by disabling the form submit button until text value is valid.
    function rotationTextChangeHandler(e) {
        document.querySelector("#applyRotation").disabled = true;
        if (e.target.value.length > 0) {
            if (e.target.checkValidity()) {
                document.querySelector("#applyRotation").disabled = false;
            }
            else {
                document.querySelector("#applyRotation").disabled = true;
            }
        }
    }

    function rotationChangeHandler(e) {
        //rotationTextChangeHandler(e);
        Rotate(e.target.value);
    }

    var formField = null;

    function textFocusHandler(e) {
        formField = e.target.id;
    }

    function formSubmitHandler(e) {
        e.preventDefault();
        switch (formField) {
            case "textColor":
                // Expando property added to event arg for colorChangeHandler().
                e.target.value = document.querySelector("#textColor").value;
                colorChangeHandler(e);
                break;
            case "textRotation":
                // Expando property added to event arg for rotationChangeHandler().
                e.target.value = document.querySelector("#textRotation").value === "" ? 0 : document.querySelector("#textRotation").value;
                rotationChangeHandler(e);
                break;
        }
    }

    // Rotate function.
    // Rotates the color mixer and adjusts color levels based on rotation value.
    function Rotate(degrees) {
        document.querySelector("#rangeRotation").innerText = degrees;
        document.querySelector("#textRotation").value = degrees;
        document.querySelector("#rangeCurrent").innerText = degrees;
        // Get the matrix transform for the target.
        var matrix;
        var element = document.getElementById("colorMixer");
        if (redValue.selected) {
            redValue.rotation = degrees;
            // Process rotation.
            matrix = (new MSCSSMatrix(initialTransform)).rotate(degrees);
            element.style.msTransform = matrix;
            // Store new transform matrix data.
            redValue.matrix = matrix;
            // Set red level.
            if (redValue.rotation >= 0) {
                redValue.level = parseInt(Math.abs(redValue.rotation) * (256 / 360));
            }
        }
        else if (greenValue.selected) {
            greenValue.rotation = degrees;
            // Process rotation.
            matrix = (new MSCSSMatrix(initialTransform)).rotate(degrees);
            element.style.msTransform = matrix;
            // Store new transform matrix data.
            greenValue.matrix = matrix;
            // Set red level.
            if (greenValue.rotation >= 0) {
                greenValue.level = parseInt(Math.abs(greenValue.rotation) * (256 / 360));
            }
        }
        else if (blueValue.selected) {
            blueValue.rotation = degrees;
            // Process rotation.
            matrix = (new MSCSSMatrix(initialTransform)).rotate(degrees);
            element.style.msTransform = matrix;
            // Store new transform matrix data.
            blueValue.matrix = matrix;
            // Set red level.
            if (blueValue.rotation >= 0) {
                blueValue.level = parseInt(Math.abs(blueValue.rotation) * (256 / 360));
            }
        }
        else {
            // Process rotation.
            matrix = (new MSCSSMatrix(initialTransform)).rotate(degrees);
            element.style.msTransform = matrix;
        }
        element.style.backgroundColor = "rgb(" + redValue.level + ", " + greenValue.level + ", " + blueValue.level + ")";
    }

})();
