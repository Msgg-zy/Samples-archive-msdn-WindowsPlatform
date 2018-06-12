//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

/// <summary> 
/// InputProcessor is a thin wrapper for pointer event handling and gesture detection.
/// Defines an InputProcessor class that takes all pointer event data and feeds it to
/// a GestureRecognizer for processing of the manipulation gestures 
/// as configured in ManipulationManager.js.
/// For this example, we only process rotation.
/// </summary>
(function () {
    "use strict";
    var InputProcessor = WinJS.Class.define(
    // Constructor
    function InputProcessor_ctor() {
        this._gestureRecognizer = new Windows.UI.Input.GestureRecognizer();
        this._downPoint = null;
        this._lastState = null;
    }, {
        // Instance members.
        element: {
            /// <summary> 
            /// The manipulable element.
            /// </summary>
            get: function () {
                if (!this._element) {
                    return null;
                }
                return this._element;
            },
            set: function (value) {
                this._element = value;
                this._setupElement();
            }
        },
        parent: {
            /// <summary> 
            /// The container that defines the coordinate space used
            /// for transformations during manipulation of the target.
            /// </summary>
            get: function () {
                if (!this._parent) {
                    return null;
                }
                return this._parent;
            },
            set: function (value) {
                this._parent = value;
            }
        },
        rotatorLeft: {
            /// <summary> 
            /// The mouse click and pen tap UI for manipulation of the target.
            /// </summary>
            set: function (value) {
                this._rotator = value;
                this._setupRotator();
            }
        },
        rotatorRight: {
            /// <summary> 
            /// The mouse click and pen tap UI for manipulation of the target.
            /// </summary>
            set: function (value) {
                this._rotator = value;
                this._setupRotator();
            }
        },
        getRecognizer: function () {
            /// <summary>
            /// The gesture recognition object.
            /// </summary>
            return this._gestureRecognizer;
        },
        getDown: function () {
            /// <summary>
            /// The pointer data for the pointerdown event.
            /// </summary>
            return this._downPoint;
        },
        _setupElement: function () {
            /// <summary> 
            /// Declare the event listeners for the pointer events on the target.
            /// </summary>
            var that = this;
            this._element.addEventListener("pointerdown",
                function (evt) { Manipulator.InputProcessor._handleDown(that, evt); },
                false);
            this._element.addEventListener("pointermove",
                function (evt) { Manipulator.InputProcessor._handleMove(that, evt); },
                false);
            this._element.addEventListener("pointerup",
                function (evt) { Manipulator.InputProcessor._handleUp(that, evt); },
                false);
            this._element.addEventListener("pointercancel",
                function (evt) { Manipulator.InputProcessor._handleCancel(that, evt); },
                false);
            this._element.addEventListener("wheel",
                function (evt) { Manipulator.InputProcessor._handleMouseWheel(that, evt); },
                false);
            this._element.addEventListener("keydown",
                function (evt) { Manipulator.InputProcessor._handleKeyboard(that, evt); })
        },
        _setupRotator: function () {
            /// <summary> 
            /// Declare the event listeners for pointer events on the parent.
            /// </summary>
            var that = this;
            this._rotator.addEventListener("pointerdown",
                function (evt) { Manipulator.InputProcessor._handleRotatorDown(that, evt); })
        }
    }, {
        // Static members.
        _handleDown: function (that, evt) {
            /// <summary> 
            /// Handler for the pointerdown event.
            /// </summary>
            /// <param name="that" type="Object">
            /// The InputProcessor object handling this event.
            /// </param>
            /// <param name="evt" type="Event">
            /// The event object.
            /// </param>
            var pp = evt.getCurrentPoint(that._parent);
            that._element.setPointerCapture(pp.pointerId);
            that._gestureRecognizer.processDownEvent(pp);

            // Prevent propagation of this event to additional event handlers.
            evt.stopImmediatePropagation();

            // Capture the pointer location for this event.
            that._downPoint = { x: pp.position.x, y: pp.position.y };
        },
        _handleMove: function (that, evt) {
            /// <summary> 
            /// Handler for the pointermove event.
            /// </summary>
            /// <param name="that" type="Object">
            /// The InputProcessor object handling this event.
            /// </param>
            /// <param name="evt" type="Event">
            /// The event object.
            /// </param>
            var pps = evt.getIntermediatePoints(that._parent);
            that._gestureRecognizer.processMoveEvents(pps);

            // Prevent propagation of this event to additional event handlers.
            evt.stopImmediatePropagation();
        },
        _handleUp: function (that, evt) {
            /// <summary> 
            /// Handler for the pointerup event.
            /// </summary>
            /// <param name="that" type="Object">
            /// The InputProcessor object handling this event.
            /// </param>
            /// <param name="evt" type="Event">
            /// The event object.
            /// </param>
            var pp = evt.getCurrentPoint(that._parent);
            that._gestureRecognizer.processUpEvent(pp);

            // Prevent propagation of this event to additional event handlers.
            evt.stopImmediatePropagation();
        },
        _handleCancel: function (that, evt) {
            /// <summary> 
            /// Handler for the pointercancel event.
            /// </summary>
            /// <param name="that" type="Object">
            /// The InputProcessor object handling this event.
            /// </param>
            /// <param name="evt" type="Event">
            /// The event object.
            /// </param>
            that._gestureRecognizer.completeGesture();

            // Prevent propagation of this event to additional event handlers.
            evt.stopImmediatePropagation();
        },
        _handleMouseWheel: function (that, evt) {
            /// <summary> 
            /// Handler for the mouse wheel event.
            /// </summary>
            /// <param name="that" type="Object">
            /// The InputProcessor object handling this event.
            /// </param>
            /// <param name="evt" type="Event">
            /// The event object.
            /// </param>
            var pp = evt.getCurrentPoint(that._parent);
            that._gestureRecognizer.processMouseWheelEvent(pp, evt.shiftKey, evt.ctrlKey);

            // Prevent propagation of this event to additional event handlers.
            evt.stopImmediatePropagation();
            evt.preventDefault();
        },
        _handleKeyboard: function (that, evt) {
            /// <summary> 
            /// Handler for the keydown event.
            /// </summary>
            /// <param name="that" type="Object">
            /// The InputProcessor object handling this event.
            /// </param>
            /// <param name="evt" type="Event">
            /// The event object.
            /// </param>

            // Set increment or decrement value based on key pressed.
            var increment;
            if (evt.keyCode === WinJS.Utilities.Key.leftArrow || evt.keyCode === WinJS.Utilities.Key.rightArrow) {
                // Prevent propagation of this event to additional event handlers.
                evt.stopImmediatePropagation();
                evt.preventDefault();
                var increment = evt.keyCode === WinJS.Utilities.Key.leftArrow ? -1 : 1;
                // Define a custom event that is raised on Left arrow or Right arrow key down.
                // The increment is passed as the delta for the angle of rotation in the event argument.
                that.dispatchEvent("indirect_rotate", {
                    delta: increment
                });
            }
        },
        _handleRotatorDown: function (that, evt) {
            /// <summary> 
            /// Handler for the keydown event.
            /// </summary>
            /// <param name="that" type="Object">
            /// The InputProcessor object handling this event.
            /// </param>
            /// <param name="evt" type="Event">
            /// The event object.
            /// </param>
            // Prevent propagation of this event to additional event handlers.
            evt.stopImmediatePropagation();
            evt.preventDefault();

            // Set increment or decrement value based on key pressed.
            var increment;
            if (evt.target.className === "RotateLeft" || evt.target.className === "RotateRight") {
                var increment = evt.target.className === "RotateLeft" ? -1 : 1;
                // Define a custom event that is raised on Left rotator or Right rotator pointer down.
                // The increment is passed as the delta for the angle of rotation in the event argument.
                that.dispatchEvent("indirect_rotate", {
                    delta: increment
                });
            }
        }
    });

    WinJS.Namespace.define("Manipulator", {
        InputProcessor: InputProcessor
    });

    // Set up event handlers for the control
    WinJS.Class.mix(Manipulator.InputProcessor, WinJS.Utilities.eventMixin);
    WinJS.Class.mix(Manipulator.InputProcessor, WinJS.Utilities.createEventProperties("indirect_rotate"));

})();
