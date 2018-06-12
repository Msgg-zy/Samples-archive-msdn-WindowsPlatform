//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";
    // Constants
    var mixerSideLength = 400;
    // Set rotation origin to center of color mixer.
    var transformOrigin = "50% 50%";
    var mixerBGColor = "black";
    var mixerBorderColor = "white";
    var mixerBorderWidth = "thick";
    var mixerBorderStyle = "solid";
    var mixerMinRotationValue = 0;
    var mixerMaxRotationValue = 359;
    var rotatorWidth = 50;
    var rotatorHeight = 100;
    // Container must accomodate rotating color mixer and pen/mouse click UI.
    var containerSideLength = mixerSideLength * Math.sqrt(2) + (3 * rotatorWidth);

    // Data object for tracking color-specific values.
    //   level: The color level (r, g, or b)
    //   rotation: The rotation value used to calculate color level.
    //   matrix: The transform matrix of the target.
    function colorInfo(level, rotation, matrix) {
        this.level = level;
        this.rotation = rotation;
        this.matrix = matrix;
    }

    var ColorMixer = WinJS.Class.define(
    // Constructor
        function ColorMixer_ctor(target, options) {
            // Store the container element in an instance field.
            // Create host div if control instantiated through new in JS (imperatively).
            // Otherwise, control instantated through data-win-control in HTML (declaratively).
            // For this sample, we declare the ColorMixer in HTML using a data-win-control.
            this._container = target || document.createElement("div");
            // Set class name for the color mixer container.
            WinJS.Utilities.addClass(this._container, "Container");
            // If control created imperatively, set a data-win-control reference to 
            // this instance on the JavaScript object. 
            // In this way, you can query the DOM (element.winControl) to find the JavaScript object or 
            // get the DOM element from the JavaScript object that created it (this.element).
            this._container.winControl = this;

            WinJS.Utilities.addClass(target, "win-disposable");

            // Initialize object properties from options or defaults.
            // ***Container
            this._container.style.width = containerSideLength + "px";
            this._container.style.height = containerSideLength + "px";
            this._container.style.position = "absolute";
            this._container.style.msTransformOrigin = transformOrigin;
            this._container.style.msTransform = (new MSCSSMatrix()).translate(
                (this._container.parentElement.clientWidth - parseInt(containerSideLength)) / 2.0,
                (this._container.parentElement.clientHeight - parseInt(containerSideLength)) / 2.0);

            // Create the color mixer child element.
            this._element = document.createElement("div");
            // Set class name for the color mixer.
            WinJS.Utilities.addClass(this._element, "ColorMixer");
            this._container.appendChild(this._element);
            this._element.style.position = "absolute";

            // ***Color mixer
            // Set accessibility attributes.
            // Use these Accessible Rich Internet Applications (WAI-ARIA) attributes to expose 
            // associated values important to understanding the state of the UI element.
            // For example, a JavaScript control with a role set to "slider", "progressbar", or "spinbutton", 
            // must expose the aria-valuemax, aria-valuemin, and aria-valuenow attributes. 
            // Dynamically set the aria-valuenow attribute to reflect changes to the element. 
            // Use the aria-valuetext attribute when the value cannot be represented as a number. 
            this._element.setAttribute("aria-valuemin", mixerMinRotationValue);
            this._element.setAttribute("aria-valuemax", mixerMaxRotationValue);
            this._element.setAttribute("aria-valuenow", mixerMinRotationValue);
            // Set announcement priority.
            // Announcing changes immediately can be disorienting for users. 
            // Most updates should be announced only when the user is idle. 
            // off:         Default. Updates should not be announced. 
            // polite:      Updates should only be announced if the user is idle. 
            // assertive:   Updates should be announced to the user as soon as possible. 
            // rude:        Updates should be announced immediately, interrupting the user if necessary.
            this._element.setAttribute("aria-live", "assertive");
            this._element.style.width = (options.width || mixerSideLength) + "px";
            this._element.style.height = (options.height || mixerSideLength) + "px";
            this._borderColor = options.borderColor || mixerBorderColor;
            this._element.style.borderColor = this._borderColor;
            this._borderWidth = options.borderWidth || mixerBorderWidth;
            this._element.style.borderWidth = this._borderWidth;
            this._borderStyle = options.borderStyle || mixerBorderStyle;
            this._element.style.borderStyle = this._borderStyle;
            this._backgroundColor = options.backgroundColor || mixerBGColor;
            this._element.style.backgroundColor = this._backgroundColor;
            this._transformOrigin = options.transformOrigin || transformOrigin;
            this._element.style.msTransformOrigin = this._transformOrigin;
            this._originalTransform = options.transform ||
                (new MSCSSMatrix()).translate(
                (this._element.parentElement.clientWidth - parseInt(mixerSideLength)) / 2.0,
                (this._element.parentElement.clientHeight - parseInt(mixerSideLength)) / 2.0);
            this.transform = this._originalTransform;
            this._element.style.msTransform = this.transform;

            // ***Mouse click and pen tap UI.
            this._rotatorLeft = document.createElement("div");
            // Set class name for the left rotator.
            WinJS.Utilities.addClass(this._rotatorLeft, "RotateLeft");
            this._container.appendChild(this._rotatorLeft);
            this._rotatorLeft.style.lineHeight = rotatorHeight + "px";
            this._rotatorLeft.style.textAlign = "center";
            this._rotatorLeft.innerHTML = "-";
            // Set opacity to 0 for WinJS.UI.Animation fadeIn behavior.
            this._rotatorLeft.style.opacity = 0;
            this._rotatorLeft.style.position = "absolute";
            this._rotatorLeft.style.width = rotatorWidth + "px";
            this._rotatorLeft.style.height = rotatorHeight + "px";
            this._rotatorLeft.style.borderStyle = "solid";
            this._rotatorLeft.style.borderColor = "red";
            this._rotatorLeft.style.borderWidth = "1px";
            this._rotatorLeft.style.transformOrigin = transformOrigin;
            this._rotatorLeft.style.msTransform = (new MSCSSMatrix()).translate(
                0,
                (this._rotatorLeft.parentElement.clientHeight - parseInt(rotatorHeight)) / 2.0);
            this._rotatorRight = document.createElement("div");
            // Set class name for the right rotator.
            WinJS.Utilities.addClass(this._rotatorRight, "RotateRight");
            this._container.appendChild(this._rotatorRight);
            this._rotatorRight.style.lineHeight = rotatorHeight + "px";
            this._rotatorRight.style.textAlign = "center";
            this._rotatorRight.innerHTML = "+";
            // Set opacity to 0 for WinJS.UI.Animation fadeIn behavior.
            this._rotatorRight.style.opacity = 0;
            this._rotatorRight.style.position = "absolute";
            this._rotatorRight.style.width = rotatorWidth + "px";
            this._rotatorRight.style.height = rotatorHeight + "px";
            this._rotatorRight.style.borderStyle = "solid";
            this._rotatorRight.style.borderColor = "red";
            this._rotatorRight.style.borderWidth = "1px";
            this._rotatorRight.style.transformOrigin = transformOrigin;
            this._rotatorRight.style.msTransform = (new MSCSSMatrix()).translate(
                (this._rotatorRight.parentElement.clientWidth - parseInt(rotatorWidth)),
                (this._rotatorRight.parentElement.clientHeight - parseInt(rotatorHeight)) / 2.0);

            // Set up our transform matrix and individual color values.
            var m = new MSCSSMatrix(this.transform);
            this.redValue = new colorInfo(0, 0, m);
            this.greenValue = new colorInfo(0, 0, m);
            this.blueValue = new colorInfo(0, 0, m);

            //
            // Set event listeners.
            //
            // Get our context.
            var that = this;

            // Configure manipulation handling.
            this.manipulable = new Manipulator.ManipulationManager();
            // The configuration function can support all manipulations.
            // For this example, we limit manipulation support to rotation with inertia.
            this.manipulable.configure(false, //Scale
                                  true, // Rotate
                                  false, // Translate
                                  true, // Inertia
                                  1, // Initial scale
                                  0, // Initial rotate
                                  {
                                      x: (this._container.clientWidth - parseInt(this._element.clientWidth)) / 2.0,
                                      y: (this._container.clientHeight - parseInt(this._element.clientHeight)) / 2.0
                                  });
            this.manipulable.setElement(this._element);
            this.manipulable.setParent(this._container);
            this.manipulable.setRotators(this._rotatorLeft, this._rotatorRight);
            // Handler for transforms related to the manipulation.
            this.manipulable.registerMoveHandler({
                x: (this._container.clientWidth - parseInt(this._element.clientWidth)) / 2.0,
                y: (this._container.clientHeight - parseInt(this._element.clientHeight)) / 2.0
        }, Manipulator.ManipulationManager.FixPivot.MoveHandler);


            // Occurs when a pointer is detected within the hit test boundaries of an element. 
            // Also occurs prior to a pointerdown event for devices that do not support hover (touch). 
            // This event type is similar to pointerenter, but bubbles. 
            // We handle this pointer event in the ColorMixer UI because the sole purpose is to display the rotator UI.
            // We'll handle the pen tap/mouse click events in the input processor/manipulation manager.
            // ***Container
            this._container.addEventListener("pointerover", function onPointerOverC(eventInfo) {
                eventInfo.cancelBubble = true;
                // Attach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Check input type. No need to display mouse click and pen tap UI for any other ponter type.
                if (eventInfo.pointerType !== "pen" && eventInfo.pointerType !== "mouse") {
                    return;
                }
                // Store pointer type and id.
                // For this example, we assume a single mouse or pen pointer.
                that._pointerTypeContainer = eventInfo.pointerType;
                that._pointerIdContainer = eventInfo.pointerId;
                // Use WinJS animation to adjust opacity of mouse click and pen tap UI.
                if (that._rotatorLeft.style.opacity === "0") {
                    WinJS.UI.Animation.fadeIn(that._rotatorLeft);
                }
                if (that._rotatorRight.style.opacity === "0") {
                    WinJS.UI.Animation.fadeIn(that._rotatorRight);
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "PointerOverContainer(" + eventInfo.pointerType + " - ";
                //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
            }, false);

            // Occurs when a pointing device is detected within the hit test boundaries of an element or one of its descendants.
            // Also as a result of a pointerdown event from a device that does not support hover. 
            // This event type is similar to pointerover, but does not bubble.
            // Here, we handle the event for example purposes only. Pointer info is stored in pointerover event.
            // ***Container
            this._container.addEventListener("pointerenter", function onPointerEnterC(eventInfo) {
                // Attach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Check input type. No need to display mouse click and pen tap UI for any other ponter type.
                if (eventInfo.pointerType !== "pen" && eventInfo.pointerType !== "mouse") {
                    return;
                }
                // Use WinJS animation to adjust opacity of mouse click and pen tap UI.
                if (that._rotatorLeft.style.opacity === "0") {
                    WinJS.UI.Animation.fadeIn(that._rotatorLeft);
                }
                if (that._rotatorRight.style.opacity === "0") {
                    WinJS.UI.Animation.fadeIn(that._rotatorRight);
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "PointerEnterContainer(" + eventInfo.pointerType + " - ";
                //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
            }, false);

            // Occurs when a pointer moves out of the hit test boundaries of an element, 
            // after a pointerup event for a device that does not support hover, and after a pointercancel event.
            // This event type is similar to pointerleave, but bubbles. 
            // ***Container
            this._container.addEventListener("pointerout", function onPointerOutC(eventInfo) {
                eventInfo.cancelBubble = true;
                // Detach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Use WinJS animation to adjust opacity of mouse click and pen tap UI.
                if (that._rotatorLeft.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorLeft);
                }
                if (that._rotatorRight.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorRight);
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "PointerOutContainer(" + eventInfo.pointerType + " - ";
                //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
            }, false);

            // Add event listener for custom rotate event on the object.
            this.manipulable.addEventListener("rotate", function onRotation(eventInfo) {
                _Rotate(eventInfo.detail.angle_of_rotation);
            });

            // Occurs when a pointer moves out of the hit test boundaries of an element, 
            // after a pointerup event for a device that does not support hover, and after a pointercancel event.
            // This event type is similar to pointerout, but does not bubble. 
            // Here, we handle the event for example purposes only. Pointer info is processed in pointerout event.
            // ***Container
            this._container.addEventListener("pointerleave", function onPointerLeaveC(eventInfo) {
                // Detach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Use WinJS animation to adjust opacity of mouse click and pen tap UI.
                if (that._rotatorLeft.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorLeft);
                }
                if (that._rotatorRight.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorRight);
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "PointerLeaveContainer(" + eventInfo.pointerType + " - ";
                //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
            }, false);

            // Occurs when 
            //   (1) the system has determined that a pointer is unlikely to continue to produce events (for example, due to a hardware event), or 
            //   (2) after having fired the pointerdown event, the pointer is subsequently used to manipulate the page viewport (for example, panning or zooming). 
            // The app won’t receive subsequent events for that pointer, including pointerup. 
            // For the color mixer, we cleanup by removing the pointer from our pointer list. 
            // ***Container
            this._container.addEventListener("pointercancel", function onPointerCancelC(eventInfo) {
                // Release pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Use WinJS animation to adjust opacity of mouse click and pen tap UI.
                if (that._rotatorLeft.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorLeft);
                }
                if (that._rotatorRight.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorRight);
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "PointerCancelContainer(" + eventInfo.pointerType + " - ";
                //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
            }, false);

            // Rotate function.
            // Rotates the color mixer and adjusts color levels based on rotation value.
            function _Rotate(increment) {
                // Get the matrix transform for the target.
                //var matrix = new MSCSSMatrix(that._originalTransform);

                // Mix the colors based on rotation value.
                switch (that.selectedColor) {
                    case "red":
                        that.redValue.rotation += increment;
                        that.redValue.rotation = that.redValue.rotation % 360;
                        that.redValue.matrix = that.manipulable.getCurrentTransform();
                        // Set red level.
                        if (that.redValue.rotation >= 0) {
                            that.redValue.level = parseInt(Math.abs(that.redValue.rotation) * (256 / 360));
                        }
                        else {
                            that.redValue.level = parseInt((360 - Math.abs(that.redValue.rotation)) * (256 / 360));
                        }
                        that._element.setAttribute("aria-valuenow", that.redValue.rotation);
                        // Event tracking.
                        //document.getElementById("status").innerHTML += "keydown :: " + that.redValue.rotation;
                        break;
                    case "green":
                        that.greenValue.rotation += increment;
                        that.greenValue.rotation = that.greenValue.rotation % 360;
                        that.greenValue.matrix = that.manipulable.getCurrentTransform();
                        // Set green level.
                        if (that.greenValue.rotation >= 0) {
                            that.greenValue.level = parseInt(Math.abs(that.greenValue.rotation) * (256 / 360));
                        }
                        else {
                            that.greenValue.level = parseInt((360 - Math.abs(that.greenValue.rotation)) * (256 / 360));
                        }
                        that._element.setAttribute("aria-valuenow", that.greenValue.rotation);
                        // Event tracking.
                        //document.getElementById("status").innerHTML += "keydown :: " + that.greenValue.rotation;
                        break;
                    case "blue":
                        that.blueValue.rotation += increment;
                        that.blueValue.rotation = that.blueValue.rotation % 360;
                        that.blueValue.matrix = that.manipulable.getCurrentTransform();
                        // Set blue level.
                        if (that.blueValue.rotation >= 0) {
                            that.blueValue.level = parseInt(Math.abs(that.blueValue.rotation) * (256 / 360));
                        }
                        else {
                            that.blueValue.level = parseInt((360 - Math.abs(that.blueValue.rotation)) * (256 / 360));
                        }
                        that._element.setAttribute("aria-valuenow", that.blueValue.rotation);
                        // Event tracking.
                        //document.getElementById("status").innerHTML += "keydown :: " + that.blueValue.rotation;
                        break;
                }
                that._element.style.backgroundColor = "rgb(" + that.redValue.level + ", " + that.greenValue.level + ", " + that.blueValue.level + ")";
            };

            // Focus function.
            // Animate color mixer when focus received.
            this._element.addEventListener("focus", function onFocusE(eventInfo) {
                // Process focus only if color selected.
                if (!that._selectedColor) {
                    return;
                }
                that._focus = true;
                // For this example, we animate the control ourselves.
                // You could also use the WinJS.UI.Animation APIs.
                // Note: The animation APIs use a scale transform that can 
                // interfere with CSS positioning.
                that._borderStyle = "double";
                that._element.style.borderStyle = that._borderStyle;
                // Event tracking.
                //document.getElementById("status").innerHTML += "focus :: ";
            }, false);

            // Blur function.
            // Animate color mixer when focus lost.
            this._element.addEventListener("blur", function onBlurE(eventInfo) {
                // Process blur only if color selected.
                if (!that._selectedColor) {
                    return;
                }
                that._focus = false;
                // For this example, we animate the control ourselves.
                // You could also use the WinJS.UI.Animation APIs.
                // Note: The animation APIs use a scale transform that can 
                // interfere with CSS positioning.
                that._borderStyle = mixerBorderStyle;
                that._element.style.borderStyle = that._borderStyle;
                // Event tracking.
                //document.getElementById("status").innerHTML += "blur :: ";
            }, false);
        },

        // Instance members
        {
            //Private
            _redValue: null,
            _greenValue: null,
            _blueValue: null,

            // Public
            selectedColor: {
                get: function () { return this._selectedColor; },
                set: function (value) {
                    this._borderColor = value;
                    this._element.style.borderColor = value;
                    this._selectedColor = value;
                    this.manipulable.setActiveTarget(true);
                    // Mix the colors based on rotation value.
                    switch (value) {
                        case "red":
                            this._element.style.msTransform = this.redValue.matrix;
                            this.manipulable.setCurrentTransform(this.redValue.matrix);
                            break;
                        case "green":
                            this._element.style.msTransform = this.greenValue.matrix;
                            this.manipulable.setCurrentTransform(this.greenValue.matrix);
                            break;
                        case "blue":
                            this._element.style.msTransform = this.blueValue.matrix;
                            this.manipulable.setCurrentTransform(this.blueValue.matrix);
                            break;
                    }
                }
            },
            redValue: {
                get: function () {
                    return this._redValue;
                },
                set: function (colorInfo) {
                    this._redValue = colorInfo;
                }
            },
            greenValue: {
                get: function () {
                    return this._greenValue;
                },
                set: function (colorInfo) {
                    this._greenValue = colorInfo;
                }
            },
            blueValue: {
                get: function () {
                    return this._blueValue;
                },
                set: function (colorInfo) {
                    this._blueValue = colorInfo;
                }
            },

            focus: function () {
                /// <summary> 
                /// Sets the focus to the color mixer.
                /// </summary>
                this._element.focus();
                this._focus = true;
            },

            // Release all of the references to internal objects.
            disposeColorMixer: function () {
                // Remove the event handlers from all elements.
                this._element.removeEventListener("focus", this._element.onFocusE);
                this._element.removeEventListener("blur", this._element.onBlurE);
                this._container.removeEventListener("pointerover", this._container.onPointerOverC);
                this._container.removeEventListener("pointerenter", this._container.onPointerEnterC);
                this._container.removeEventListener("pointerout", this._container.onPointerOutC);
                this._container.removeEventListener("pointerleave", this._containeronPointerLeaveC);
                this._container.removeEventListener("pointercancel", this._containeronPointerCancelC);
                this.manipulable.removeEventListener("rotate", this.manipulable.onRotation);
                // Dispose of all the child controls of this element.
                WinJS.Utilities.disposeSubTree(this._container);
                // Release memory from all of the class fields.
                this._container = null;
                this._element = null;
                this._rotatorLeft = null;
                this._rotatorRight = null;
                this.manipulable = null;
            }
        },
        // Static members
        {
        });

    /// Define the namespace for the ColorMixer object.  
    WinJS.Namespace.define("Target", {
        ColorMixer: ColorMixer
    });
})();