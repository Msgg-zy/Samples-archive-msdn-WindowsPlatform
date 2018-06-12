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
    var mixerTransformOrigin = "50% 50%";
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
            this._container.style.msTransformOrigin = mixerTransformOrigin;
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
            this._transformOrigin = options.transformOrigin || mixerTransformOrigin;
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
            this._rotatorLeft.style.transformOrigin = mixerTransformOrigin;
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
            this._rotatorRight.style.transformOrigin = mixerTransformOrigin;
            this._rotatorRight.style.msTransform = (new MSCSSMatrix()).translate(
                (this._rotatorRight.parentElement.clientWidth - parseInt(rotatorWidth)),
                (this._rotatorRight.parentElement.clientHeight - parseInt(rotatorHeight)) / 2.0);

            // Set up our transform matrix and individual color values.
            var m = new MSCSSMatrix(this.transform);
            this.redValue = new colorInfo(0, 0, m);
            this.greenValue = new colorInfo(0, 0, m);
            this.blueValue = new colorInfo(0, 0, m);

            // Create persistent DOM gesture recognizers and set the targets.
            // We must handle a pointer down event to attach an MSGesture object to a target.
            var msGesture_ColorMixer = new MSGesture();
            msGesture_ColorMixer.target = this._element;

            //
            // Set event listeners.
            //
            // Get our context.
            var that = this;

            // Occurs when a pointer is detected within the hit test boundaries of an element. 
            // Also occurs prior to a pointerdown event for devices that do not support hover (touch). 
            // This event type is similar to pointerenter, but bubbles. 
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
            // ***Color mixer
            this._element.addEventListener("pointerover", function onPointerOverE(eventInfo) {
                eventInfo.cancelBubble = true;
                // Attach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Attach first contact and track input device type.
                if (!that._pointerType) {
                    msGesture_ColorMixer.addPointer(eventInfo.pointerId);
                    that._pointerType = eventInfo.pointerType;
                }
                // Attach subsequent contacts.
                else {
                    msGesture_ColorMixer.addPointer(eventInfo.pointerId);
                }
                // Store pointer type and id.
                that._pointerType = eventInfo.pointerType;
                that._pointerId.push(eventInfo.pointerId);
                // Use WinJS animation to adjust opacity of mouse click and pen tap UI.
                if (that._rotatorLeft.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorLeft);
                }
                if (that._rotatorRight.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorRight);
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "PointerOverMixer(" + eventInfo.pointerType + " - ";
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
            // ***Color mixer
            this._element.addEventListener("pointerenter", function onPointerEnterE(eventInfo) {
                // Attach pointer only if color selected.
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
                //document.getElementById("status").innerHTML += "PointerEnterMixer(" + eventInfo.pointerType + " - ";
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
            // ***Color mixer
            this._element.addEventListener("pointerout", function onPointerOutE(eventInfo) {
                eventInfo.cancelBubble = true;
                // Detach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                that._pointerType = null;
                // Event tracking.
                //document.getElementById("status").innerHTML += "PointerOutMixer(" + eventInfo.pointerType + " - ";
                //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
            }, false);

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
            // ***Color mixer
            this._element.addEventListener("pointerleave", function onPointerLeaveE(eventInfo) {
                // Detach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "PointerLeaveMixer(" + eventInfo.pointerType + " - ";
                //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
            }, false);

            // Occurs for mouse when at least one button pressed or for touch and pen when there is physical contact with the digitizer
            // For input devices that do not support hover, the pointerover event is fired immediately before the pointerdown event. 
            // Here, we attach the pointer to the DOM gesture recognizer.
            // We filter pointer input based on the first pointer type detected for the duration of the gesture.
            // ***Mouse click and pen tap UI 
            this._rotatorLeft.addEventListener("pointerdown", function onPointerDownRL(eventInfo) {
                // Attach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Attach the pointer to an MSGesture object.
                if (!eventInfo.target.gestureObject) {
                    eventInfo.target.gestureObject = new MSGesture();
                    eventInfo.target.gestureObject.target = eventInfo.target;
                    eventInfo.target.gestureObject.addPointer(eventInfo.pointerId);
                    eventInfo.target.addEventListener("MSGestureTap", _rotatorMSGestureTap, false);
                }
                else
                    eventInfo.target.gestureObject.addPointer(eventInfo.pointerId);
            }, false);
            this._rotatorRight.addEventListener("pointerdown", function onPointerDownRR(eventInfo) {
                // Attach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                if (!eventInfo.target.gestureObject) {
                    eventInfo.target.gestureObject = new MSGesture();
                    eventInfo.target.gestureObject.target = eventInfo.target;
                    eventInfo.target.gestureObject.addPointer(eventInfo.pointerId);
                    eventInfo.target.addEventListener("MSGestureTap", _rotatorMSGestureTap, false);
                }
                else
                    eventInfo.target.gestureObject.addPointer(eventInfo.pointerId);
            }, false);
            // ***Color mixer
            this._element.addEventListener("pointerdown", function onPointerDownE(eventInfo) {
                // Attach pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                if (eventInfo.target === msGesture_ColorMixer.target) {
                    // For this example, we animate the control ourselves.
                    // You could also use the WinJS.UI.Animation APIs.
                    // Note: The animation APIs use a scale transform that can 
                    // interfere with CSS positioning.
                    that._borderStyle = "double";
                    that._element.style.borderStyle = that._borderStyle;
                    that._pointerCount.push(eventInfo.pointerId);

                    // Attach first contact and track input device type.
                    if (!that._pointerType) {
                        msGesture_ColorMixer.addPointer(eventInfo.pointerId);
                        that._pointerType = eventInfo.pointerType;
                    }
                    // Attach subsequent contacts from same input device type.
                    else {
                        msGesture_ColorMixer.addPointer(eventInfo.pointerId);
                    }
                    // Event tracking.
                    //document.getElementById("status").innerHTML += "PointerDownMixer(" + eventInfo.pointerType + " - ";
                    //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
                }
            }, false);

            // Occurs for mouse at transition from at least one button pressed to no buttons pressed, or for touch and pen when physical contact is removed from the digitizer
            // For input devices that do not support hover, the pointerout event is fired immediately after the pointerup event. 
            // ***Color mixer
            this._element.addEventListener("pointerup", function onPointerUpE(eventInfo) {
                // Release pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                eventInfo.target.releasePointerCapture(eventInfo.pointerId);
                // For this example, we animate the control ourselves.
                // You could also use the WinJS.UI.Animation APIs.
                // Note: The animation APIs use a scale transform that can 
                // interfere with CSS positioning.
                var i = that._pointerCount.indexOf(eventInfo.pointerId);
                if (i !== -1) {
                    that._pointerCount.splice(i, 1);
                }
                if (that._pointerCount.length <= 0) {
                    that._borderStyle = mixerBorderStyle;
                    that._element.style.borderStyle = that._borderStyle;
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "PointerUpMixer(" + eventInfo.pointerType + " - ";
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
            // ***Color mixer
            this._element.addEventListener("pointercancel", function onPointerCancelE(eventInfo) {
                // Release pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                if (eventInfo.target === msGesture_ColorMixer.target) {
                    eventInfo.target.releasePointerCapture(eventInfo.pointerId);
                    // For this example, we animate the control ourselves.
                    // You could also use the WinJS.UI.Animation APIs.
                    // Note: The animation APIs use a scale transform that can 
                    // interfere with CSS positioning.
                    var i = that._pointerCount.indexOf(eventInfo.pointerId);
                    if (i !== -1) {
                        that._pointerCount.splice(i, 1);
                    }
                    if (that._pointerCount.length <= 0) {
                        that._borderStyle = mixerBorderStyle;
                        that._element.style.borderStyle = that._borderStyle;
                    }
                    // Use WinJS animation to adjust opacity of mouse click and pen tap UI.
                    if (that._rotatorLeft.style.opacity > "0") {
                        WinJS.UI.Animation.fadeOut(that._rotatorLeft);
                    }
                    if (that._rotatorRight.style.opacity > "0") {
                        WinJS.UI.Animation.fadeOut(that._rotatorRight);
                    }
                    // Event tracking.
                    //document.getElementById("status").innerHTML += "PointerCancelMixer(" + eventInfo.pointerType + " - ";
                    //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
                }
            }, false);

            // Occurs after pointer capture is released for a pointer. 
            // We only set pointer capture on the color mixer, not the container.
            this._element.addEventListener("lostpointercapture", function onLostPointerCaptureE(eventInfo) {
                // Release pointer only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // For this example, we animate the control ourselves.
                // You could also use the WinJS.UI.Animation APIs.
                // Note: The animation APIs use a scale transform that can 
                // interfere with CSS positioning.
                var i = that._pointerCount.indexOf(eventInfo.pointerId);
                if (i !== -1) {
                    that._pointerCount.splice(i, 1);
                }
                if (that._pointerCount.length <= 0) {
                    that._borderStyle = mixerBorderStyle;
                    that._element.style.borderStyle = that._borderStyle;
                }
                // Use WinJS animation to adjust opacity of mouse click and pen tap UI.
                if (that._rotatorLeft.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorLeft);
                }
                if (that._rotatorRight.style.opacity > "0") {
                    WinJS.UI.Animation.fadeOut(that._rotatorRight);
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "LostPointerCaptureMixer(" + eventInfo.pointerType + " - ";
                //document.getElementById("status").innerHTML += eventInfo.pointerId + ") :: ";
            }, false);

            // Fires on user interaction through a touch, mouse click, or pen tap. 
            // The touch language described in Touch interaction design (http://go.microsoft.com/fwlink/?LinkID=268162),
            // specifies that the tap gesture should invoke the primary action of an element
            // (such as launching an application or executing a command). 
            // Here we don't do much.
            this._element.addEventListener("MSGestureTap", function onMSGestureTapE(eventInfo) {
                // Process gesture only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "MSGestureTap :: " + eventInfo.target.id;
            }, false);

            // Hold gesture handler: Display event.
            // The touch language described in Touch interaction design (http://go.microsoft.com/fwlink/?LinkID=268162),
            // specifies that the press and hold gesture should aid learning or exploration 
            // (such as showing context menus or flyouts). 
            // Here, we display the current color.
            this._element.addEventListener("MSGestureHold", function onMSGestureHoldE(eventInfo) {
                // Process gesture only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "MSGestureHold :: " + eventInfo.target.id;
            }, false);

            // Gesture end handler. 
            // This event fires only for manipulation gestures.
            // Here, we clean up our UI when gesture is complete.
            this._element.addEventListener("MSGestureEnd", function onMSGestureEndE(eventInfo) {
                // Process gesture only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Event tracking.
                //document.getElementById("status").innerHTML += "MSGestureEnd :: " + eventInfo.target.id;
            }, false);

            // Key down handler. 
            // Take input from only the left and right arrow keys.
            // Left: counter-clockwise rotation.
            // Right: clockwise rotation.
            this._element.addEventListener("keydown", function onKeyDownE(eventInfo) {
                // Process keystroke only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                if (eventInfo.target === msGesture_ColorMixer.target) {
                    if (that._focus === false) {
                        return;
                    }
                    // Set increment or decrement value based on key pressed.
                    var increment;
                    if (eventInfo.keyCode === WinJS.Utilities.Key.leftArrow) {
                        increment = -1;
                    }
                    else if (eventInfo.keyCode === WinJS.Utilities.Key.rightArrow) {
                        increment = 1;
                    }
                    else return;

                    // Attach first contact and track input device type.
                    if (!that._pointerType) {
                        that._pointerType = "keyboard";
                    }
                    // Rotate the color mixer.
                    _Rotate(increment);
                    // Event tracking.
                    //document.getElementById("status").innerHTML += "keydown :: " + eventInfo.keyCode;
                }
            }, false);

            this._element.addEventListener("wheel", function onWheelE(eventInfo) {
                /// <summary> 
                /// Handles the mouse wheel event.
                /// </summary>
                /// <param name="that" type="Object">
                /// The InputProcessor object handling this event
                /// </param>
                /// <param name="evt" type="Event">
                /// The event object
                /// </param>
                // Process wheel input only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // The mouse language described in Responding to mouse interactions (http://go.microsoft.com/fwlink/?LinkID=328207),
                // specifies that rotation with mouse wheel requires the SHIFT and CTRL keyboard modifiers. 
                if (eventInfo.target === msGesture_ColorMixer.target && eventInfo.ctrlKey && eventInfo.shiftKey) {
                    // Attach first contact and track input device type.
                    if (!that._pointerType) {
                        that._pointerType = "mousewheel";
                    }
                    // Get a pointerpoint from the wheel input.
                    // Use getCurrentPoint to ensure the coordinate space is in relation to the target.
                    var pp = eventInfo.getCurrentPoint(msGesture_ColorMixer.target);
                    // Attach subsequent contacts from same input device type "mouse".
                    msGesture_ColorMixer.addPointer(pp.pointerId);

                    // Set increment or decrement value based on wheel direction.
                    // For this example we ignore mouse wheel settings and use
                    // each mouse wheel detent as one degree of rotation. 
                    var increment;
                    var deltaY = eventInfo.deltaY;
                    // increment = 0 if deltaY = 0, null, NaN, undefined.
                    // increment = -1 if deltaY < 0.
                    // increment = 1 if deltaY > 0.
                    var increment = deltaY ? deltaY < 0 ? -1 : 1 : 0;

                    // Rotate the color mixer.
                    _Rotate(increment);
                    // Event tracking.
                    //document.getElementById("status").innerHTML += "MouseWheel(" + deltaY + " :: ";
                    //document.getElementById("status").innerHTML += pp.pointerId + ") :: ";
                }
            }, false);

            // Handler for taps on rotator UI.
            function _rotatorMSGestureTap(eventInfo) {
                // Process gesture only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Set increment or decrement value based on rotator tapped.
                var increment;
                if (eventInfo.target.className === "RotateLeft") {
                    increment = -1;
                }
                else if (eventInfo.target.className === "RotateRight") {
                    increment = 1;
                }
                else return;
                // Rotate the color mixer.
                _Rotate(increment);
                // Event tracking.
                //document.getElementById("status").innerHTML += "Rotator(" + eventInfo.target.className + ") :: ";
            };

            // Gesture change handler: Process gestures for translation, rotation, and scaling.
            // For this example, we don't track pointer movements.
            this._element.addEventListener("MSGestureChange", function onMSGestureChangeE(eventInfo) {
                // Process gesture only if color selected.
                if (!that.selectedColor) {
                    return;
                }
                // Mouse wheel also triggers this event.
                // No need to process mouse wheel input here.
                if (that._pointerType === "mousewheel") {
                    return;
                }
                var increment = (eventInfo.rotation * 180 / Math.PI);
                // Rotate the color mixer.
                _Rotate(increment);
                // Event tracking.
                //document.getElementById("status").innerHTML += "Touch(" + eventInfo.rotation + ") :: ";
            }, false);

            // Rotate function.
            // Rotates the color mixer and adjusts color levels based on rotation value.
            function _Rotate(increment) {
                // Get the matrix transform for the target.
                var matrix = new MSCSSMatrix(that._originalTransform);

                // Mix the colors based on rotation value.
                switch (that.selectedColor) {
                    case "red":
                        that.redValue.rotation += increment;
                        that.redValue.rotation = that.redValue.rotation % 360;
                        // Process rotation gesture.
                        that.transform = matrix.rotate(that.redValue.rotation);
                        // Store new transform matrix data.
                        that.redValue.matrix = that.transform;
                        // Set red level.
                        if (that.redValue.rotation >= 0) {
                            that.redValue.level = parseInt(Math.abs(that.redValue.rotation) * (256 / 360));
                        }
                        else {
                            that.redValue.level = parseInt((360 - Math.abs(that.redValue.rotation)) * (256 / 360));
                        }
                        // Event tracking.
                        //document.getElementById("status").innerHTML += "keydown :: " + that.redValue.rotation;
                        that._element.setAttribute("aria-valuenow", that.redValue.rotation);
                        break;
                    case "green":
                        that.greenValue.rotation += increment;
                        that.greenValue.rotation = that.greenValue.rotation % 360;
                        // Process rotation gesture.
                        that.transform = matrix.rotate(that.greenValue.rotation);
                        // Store new transform matrix data.
                        that.greenValue.matrix = that.transform;
                        // Set green level.
                        if (that.greenValue.rotation >= 0) {
                            that.greenValue.level = parseInt(Math.abs(that.greenValue.rotation) * (256 / 360));
                        }
                        else {
                            that.greenValue.level = parseInt((360 - Math.abs(that.greenValue.rotation)) * (256 / 360));
                        }
                        // Event tracking.
                        //document.getElementById("status").innerHTML += "keydown :: " + that.greenValue.rotation;
                        that._element.setAttribute("aria-valuenow", that.greenValue.rotation);
                        break;
                    case "blue":
                        that.blueValue.rotation += increment;
                        that.blueValue.rotation = that.blueValue.rotation % 360;
                        // Process rotation gesture.
                        that.transform = matrix.rotate(that.blueValue.rotation);
                        // Store new transform matrix data.
                        that.blueValue.matrix = that.transform;
                        // Set blue level.
                        if (that.blueValue.rotation >= 0){
                            that.blueValue.level = parseInt(Math.abs(that.blueValue.rotation) * (256 / 360));
                        }
                        else {
                            that.blueValue.level = parseInt((360 - Math.abs(that.blueValue.rotation)) * (256 / 360));
                        }
                        // Event tracking.
                        //document.getElementById("status").innerHTML += "keydown :: " + that.blueValue.rotation;
                        that._element.setAttribute("aria-valuenow", that.blueValue.rotation);
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
            _element: null,
            _pointerType: null,
            _pointerTypeContainer: null,
            _pointerId: [],
            _pointerIdContainer: null,
            _pointerCount: [],
            _focus: null,
            _transform: null,
            _selectedColor: null,
            _redValue: null,
            _greenValue: null,
            _blueValue: null,

            // Public
            pointerId: {
                get: function (index) { return this._pointerId[index]; },
            },
            transform: {
                get: function () { return this._transform; },
                set: function (value) {
                    this._transform = value;
                    this._element.style.msTransform = value;
                }
            },
            selectedColor: {
                get: function () { return this._selectedColor; },
                set: function (value) {
                    this._borderColor = value;
                    this._element.style.borderColor = value;
                    this._selectedColor = value;
                    // Mix the colors based on rotation value.
                    switch (value) {
                        case "red":
                            this._element.style.msTransform = this.redValue.matrix;
                            break;
                        case "green":
                            this._element.style.msTransform = this.greenValue.matrix;
                            break;
                        case "blue":
                            this._element.style.msTransform = this.blueValue.matrix;
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
                this._container.removeEventListener("pointerover", this._container.onPointerOverC);
                this._element.removeEventListener("pointerover", this._element.onPointerOverE);
                this._container.removeEventListener("pointerenter", this._container.onPointerEnterC);
                this._element.removeEventListener("pointerenter", this._element.onPointerEnterE);
                this._container.removeEventListener("pointerout", this._container.onPointerOutC);
                this._element.removeEventListener("pointerout", this._element.onPointerOutE);
                this._container.removeEventListener("pointerleave", this._container.onPointerLeaveC);
                this._element.removeEventListener("pointerleave", this._element.onPointerLeaveE);
                this._rotatorLeft.removeEventListener("pointerdown", this._rotatorLeft.onPointerDownRL);
                this._rotatorRight.removeEventListener("pointerdown", this._rotatorLeft.onPointerDownRR);
                this._element.removeEventListener("pointerdown", this._element.onPointerDownE);
                this._element.removeEventListener("pointerup", this._element.onPointerUpE);
                this._container.removeEventListener("pointercancel", this._container.onPointerCancelC);
                this._element.removeEventListener("pointercancel", this._element.onPointerCancelE);
                this._element.removeEventListener("lostpointercapture", this._element.onLostPointerCaptureE);
                this._element.removeEventListener("MSGestureTap", this._element.onMSGestureTapE);
                this._element.removeEventListener("MSGestureHold", this._element.onMSGestureHoldE);
                this._element.removeEventListener("MSGestureEnd", this._element.onMSGestureEndE);
                this._element.removeEventListener("keydown", this._element.onKeyDownE);
                this._element.removeEventListener("wheel", this._element.onWheelE);
                this._element.removeEventListener("MSGestureChange", this._element.onMSGestureChangeE);
                this._element.removeEventListener("focus", this._element.onFocusE);
                this._element.removeEventListener("blur", this._element.onBlurE);
                // Dispose of all the child controls of this element.
                WinJS.Utilities.disposeSubTree(this._container);
                // Release memory from all of the class fields.
                this._container = null;
                this._element = null;
                this._rotatorLeft = null;
                this._rotatorRight = null;
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