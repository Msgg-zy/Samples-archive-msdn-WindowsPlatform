//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

/// <summary> 
/// ManipulationManager is the manipulation processing engine for the 
/// GestureRecognizer object defined in InputProcessor.js.
/// Different components and behaviors of manipulation (rotate, translate, zoom, 
/// and inertia) can be enabled, disabled, and customized as required.
/// For this example, we only process rotation.
/// </summary>
(function () {
    "use strict";
    var ManipulationManager = WinJS.Class.define(
        // Constructor.
        function ManipulationManager_ctor() {
            // Create an input processor.
            this._inputProcessor = new Manipulator.InputProcessor();
            // Initialize the manipulation movement and end handlers.
            this._endHandler = null;
            this._moveHandler = null;
            // Create the transform matrices used for manipulating
            // and resetting the target.
            this._currentTransform = new MSCSSMatrix();
            this._initialTransform = new MSCSSMatrix();
            // Process input only when target is active.
            this._activeTarget = false;
            // Initialize the transform matrices values.
            this._initialTransformParams = {
                translation: { x: 0, y: 0 },
                rotation: 0,
                scale: 1
            };
            this._currentTransformParams = {
                translation: { x: 0, y: 0 },
                rotation: 0,
                scale: 1
            };
        }, {
            // Instance members.
            configure: function (scale, rotate, translate, inertia,
                                initialScale, initialRotate, initialTranslate) {
                /// <summary> 
                /// Define the behaviors of the ManipulationManager.
                /// </summary>
                /// <param name="scale" type="Boolean">
                /// True if scaling is enabled.
                /// </param>
                /// <param name="rotate" type="Boolean">
                /// True if rotation is enabled.
                /// </param>
                /// <param name="translate" type="Boolean">
                /// True if translation is enabled.
                /// </param>
                /// <param name="inertia" type="Boolean">
                /// True if inertia is enabled.
                /// </param>
                /// <param name="initialScale" type="Number">
                /// The initial scale factor.
                /// </param>
                /// <param name="initialRotate" type="Number">
                /// The initial rotation value.
                /// </param>
                /// <param name="initialTranslate" type="Object">
                /// The initial translation values (x,y).
                /// </param>

                // Get the GestureRecognizer associated with this manipulation manager.
                var gr = this._inputProcessor.getRecognizer();
                // Set the manipulations supported by the GestureRecognizer if the
                // interaction is not already being processed.
                if (!gr.isActive) {
                    var settings = 0;
                    if (scale) {
                        settings |= Windows.UI.Input.GestureSettings.manipulationScale;
                        if (inertia) {
                            settings |= Windows.UI.Input.GestureSettings.manipulationScaleInertia;
                        }
                    }
                    if (rotate) {
                        settings |= Windows.UI.Input.GestureSettings.manipulationRotate;
                        if (inertia) {
                            settings |= Windows.UI.Input.GestureSettings.manipulationRotateInertia;
                        }
                    }
                    if (translate) {
                        settings |= Windows.UI.Input.GestureSettings.manipulationTranslateX |
                            Windows.UI.Input.GestureSettings.manipulationTranslateY;
                        if (inertia) {
                            settings |= Windows.UI.Input.GestureSettings.manipulationTranslateInertia;
                        }
                    }

                    // Cache a reference to the current object.
                    var that = this;

                    // If any manipulation is supported, declare the manipulation event listeners.
                    if (scale || rotate || translate) {
                        gr.addEventListener('manipulationstarted',
                            function (evt) { Manipulator.ManipulationManager._manipulationStarted(that, evt); },
                            false);
                        gr.addEventListener('manipulationupdated',
                            function (evt) { Manipulator.ManipulationManager._manipulationUpdated(that, evt); },
                            false);
                        gr.addEventListener('manipulationended',
                            function (evt) { Manipulator.ManipulationManager._manipulationEnded(that, evt); },
                            false);

                        // Add event listener for custom indirect rotate event on the object.
                        // Indirect rotation is processed for input from keyboard and mouse click/pen tap rotator UI.
                        // Alternatively, you could use PivotCenter and PivotRadius to support single pointer input with mouse and pen.
                        this._inputProcessor.addEventListener('indirect_rotate',
                            function onIndirectRotation(evt) {
                                if (that._activeTarget) {
                                    // Pass the event to the manipulation helper function.
                                    Manipulator.ManipulationManager._manipulationHelper(that, evt.detail);
                                }
                            }, false);
                    }

                    gr.gestureSettings = settings;

                    // Initialize the transform matrices.
                    this._currentTransformParams.scale = initialScale;
                    this._currentTransformParams.rotation = initialRotate;
                    this._currentTransformParams.translation = initialTranslate;

                    this._initialTransformParams.scale = initialScale;
                    this._initialTransformParams.rotation = initialRotate;
                    this._initialTransformParams.translation = initialTranslate;

                    // Set the transformation values.
                    if (initialRotate) {
                        this._initialTransform = this._initialTransform.rotate(initialRotate);
                    }
                    else {
                        this._currentTransformParams.rotation = 0;
                        this._initialTransformParams.rotation = 0;
                    }
                    if (initialTranslate) {
                        this._initialTransform = this._initialTransform.translate(initialTranslate.x, initialTranslate.y);
                    }
                    else {
                        this._currentTransformParams.translation = { x: 0, y: 0 };
                        this._initialTransformParams.translation = { x: 0, y: 0 };
                    }
                    if (initialScale) {
                        this._initialTransform = this._initialTransform.scale(initialScale);
                    }
                    else {
                        this._currentTransformParams.scale = 1;
                        this._initialTransformParams.scale = 1;
                    }

                    this.setCurrentTransform(this._initialTransform);
                }
            },

            getCurrentTransform: function () {
                /// <summary> 
                /// Get the current transform on the object.
                /// Public function for custom object.
                /// </summary>
                return this._currentTransform;
            },
            /// <summary> 
            /// Set the current transform on the object.
            /// Public helper function for custom object to track matrix per color.
            /// </summary>
            /// <param name="matrix" type="MSCSSMatrix">
            /// The transform matrix.
            /// </param>
            setCurrentTransform: function (matrix) {
                this._currentTransform = matrix;
            },
            /// <summary> 
            /// Set the input state of the target.
            /// Public function for custom object.
            /// </summary>
            /// <param name="active" type="Boolean">
            /// A value that indicates whether the target is active.
            /// </param>
            setActiveTarget: function (active) {
                this._activeTarget = active;
            },
            /// <summary> 
            /// Get the input state of the target.
            /// Public function for custom object.
            /// </summary>
            /// <returns>
            /// A Boolean that indicates whether the target is active.
            /// </returns>
            getActiveTarget: function () {
                return this._activeTarget;
            },
            setElement: function (elm) {
                /// <summary> 
                /// Set the manipulable object.
                /// </summary>
                /// <param name="elm" type="Object">
                /// The object that supports manipulation.
                /// </param>
                this._inputProcessor.element = elm;
                // Set the transform origin for rotation and scale manipulations.
                this._inputProcessor.element.style.msTransformOrigin = "50% 50%";
            },
            setParent: function (elm) {
                /// <summary> 
                /// Set the parent of the manipulable object.
                /// </summary>
                /// <param name="elm" type="Object">
                /// The parent of the object that supports manipulation.
                /// </param>
                this._inputProcessor.parent = elm;
            },
            setRotatorLeft: function (elm) {
                /// <summary> 
                /// Set the manipulable object.
                /// </summary>
                /// <param name="elm" type="Object">
                /// The parent of the object that supports manipulation.
                /// </param>
                this._inputProcessor.rotatorLeft = elm;
            },
            setRotatorRight: function (elm) {
                /// <summary> 
                /// Set the manipulable object.
                /// </summary>
                /// <param name="elm" type="Object">
                /// The parent of the object that supports manipulation.
                /// </param>
                this._inputProcessor.rotatorRight = elm;
            },
            setRotators: function (left, right) {
                /// <summary> 
                /// Set the manipulable objects.
                /// </summary>
                /// <param name="left" type="Object">
                /// <param name="right" type="Object">
                /// The object that supports manipulation.
                /// </param>
                this._inputProcessor.rotatorLeft = left;
                this._inputProcessor.rotatorRight = right;
            },
            registerEndHandler: function (handler) {
                /// <summary> 
                /// Register handler to be called after the manipulation is complete.
                /// </summary>
                /// <param name="handler" type="Function">
                /// The manipulationended event handler.
                /// </param>
                this._endHandler = handler;
            },
            registerMoveHandler: function (arg, handler) {
                /// <summary> 
                /// Register handler to be called when manipulation is under way.
                /// </summary>
                /// <param name="args">
                /// Arguments passed to the move handler function.
                /// </param>
                /// <param name="handler" type="Function">
                /// The manipulationupdated event handler.
                /// </param>
                this._moveHandlerArg = arg;
                this._moveHandler = handler;
            },
            resetAllTransforms: function () {
                /// <summary> 
                /// Reset the ManipulationManager object to its initial state.
                /// </summary>

                // Check that the element has been registered before before attempting to reset.
                if (this._inputProcessor.element) {
                    // Reapply the initial transform
                    this._inputProcessor.element.style.transform = this._initialTransform.toString();
                    this.setCurrentTransform(this._initialTransform);

                    // Reset the current transform parameters to their initial values.
                    this._currentTransformParams.translation = this._initialTransformParams.translation;
                    this._currentTransformParams.rotation = this._initialTransformParams.rotation;
                    this._currentTransformParams.scale = this._initialTransformParams.scale;
                }
            },

            _applyMotion: function (pivot, translation, rotation, scaling) {
                /// <summary> 
                /// Apply the manipulation transform to the target.
                /// </summary>
                /// <param name="pivot" type="Object">
                /// The X,Y values for the rotation and scaling pivot point.
                /// </param>
                /// <param name="translation" type="Object">
                /// The X,Y values for the translation delta.
                /// </param>
                /// <param name="rotation" type="Number">
                /// The angle of rotation.
                /// </param>
                /// <param name="scaling" type="Number">
                /// The scaling factor.
                /// </param>
                // Create the transform, apply parameters, and multiply by the current transform matrix.
                var transform = new MSCSSMatrix().translate(pivot.x, pivot.y).
                    translate(translation.x, translation.y).
                    rotate(rotation).
                    scale(scaling).
                    translate(-pivot.x, -pivot.y).multiply(this._currentTransform);

                this._inputProcessor.element.style.transform = transform.toString();
                this.setCurrentTransform(transform);

                // Define a custom event that is raised on rotation.
                // The angle of rotation is passed in the event argument.
                this.dispatchEvent("rotate", {
                    angle_of_rotation: rotation
                });
            },

            _updateTransformParams: function (delta) {
                /// <summary> 
                /// Update the current transformation parameters based on the new delta.
                /// </summary>
                /// <param name="that" type="Object">
                /// The change in rotation, scaling, and translation.
                /// </param>
                this._currentTransformParams.translation.x = this._currentTransformParams.translation.x + delta.translation.x;
                this._currentTransformParams.translation.y = this._currentTransformParams.translation.y + delta.translation.y;
                this._currentTransformParams.rotation = this._currentTransformParams.rotation + delta.rotation;
                this._currentTransformParams.scale = this._currentTransformParams.scale * delta.scale;
            }
        }, {
            // Static members.
            _manipulationStarted: function (that, evt) {
                /// <summary> 
                /// The manipulationstarted event handler.
                /// </summary>
                /// <param name="that" type="Object">
                /// ManipulationManager object on which the event was performed.
                /// </param>
                /// <param name="evt" type="Event">
                /// The event data.
                /// </param>
                if (that._activeTarget) {
                    Manipulator.ManipulationManager._manipulationHelper(that, evt);
                }
            },
            _manipulationUpdated: function (that, evt) {
                /// <summary> 
                /// The manipulationupdated event handler.
                /// </summary>
                /// <param name="that" type="Object">
                /// ManipulationManager object on which the event was performed.
                /// </param>
                /// <param name="evt" type="Event">
                /// The event data.
                /// </param>
                if (that._activeTarget) {
                    Manipulator.ManipulationManager._manipulationHelper(that, evt);
                }
            },
            _manipulationEnded: function (that, evt) {
                /// <summary> 
                /// The manipulationended event handler.
                /// </summary>
                /// <param name="that" type="Object">
                /// ManipulationManager object on which the event was performed.
                /// </param>
                /// <param name="evt" type="Event">
                /// The event data.
                /// </param>
                if (that._activeTarget) {
                    // Pass the event to the manipulation helper function.
                    Manipulator.ManipulationManager._manipulationHelper(that, evt);

                    // Call the manipulationended handler, if registered.
                    if (that._endHandler) {
                        that._endHandler();
                    }
                }
            },
            _manipulationHelper: function (that, evt) {
                /// <summary> 
                /// Helper function for calculating and applying the transformation parameter deltas.
                /// </summary>
                /// <param name="that" type="Object">
                /// ManipulationManager object on which the event was performed.
                /// </param>
                /// <param name="evt" type="Event">
                /// The event data.
                /// </param>

                if (evt.delta) {
                    // Rotation/scaling pivot point.
                    var pivot = evt.position !== undefined ? { x: evt.position.x, y: evt.position.y } : { x: 0, y: 0 };

                    // Translation values.
                    var translation = evt.delta.translation !== undefined ? { x: evt.delta.translation.x, y: evt.delta.translation.y } : { x: 0, y: 0 };

                    // Rotation angle.
                    //var rotation = evt.delta.rotation;
                    var rotation = evt.delta.rotation !== undefined ? evt.delta.rotation : evt.delta;

                    // Scale factor.
                    //var scale = evt.delta.scale;
                    var scale = evt.delta.scale !== undefined ? evt.delta.scale : 1;

                    // Group the transformation parameter deltas.
                    var delta = {
                        pivot: pivot,
                        translation: translation,
                        rotation: rotation,
                        scale: scale
                    };

                    // Apply the manipulation movement constraints.
                    if (that._moveHandler) {
                        delta = that._moveHandler(that._moveHandlerArg, delta, that._currentTransformParams, that._currentTransform);
                    }

                    // Update the transformation parameters with fresh deltas.
                    that._updateTransformParams(delta);

                    // Apply the transformation.
                    that._applyMotion(delta.pivot, delta.translation, delta.rotation, delta.scale);
                    
                }
            },
            FixPivot: WinJS.Class.define(function () {
                /// <summary>
                /// Constrain the center of manipulation (or pivot point) to a set of X,Y coordinates,  
                /// instead of the centroid of the pointers associated with the manipulation.
                /// <param name="pivot" type="Object">
                /// The pivot coordinates for the ManipulationManager object.
                /// </param>
                /// <param name="delta" type="Object">
                /// The transformation parameter deltas (pivot, delta, rotation, scale).
                /// </param>
                /// </summary>
            }, {
            }, {
                MoveHandler: function (pivot, delta) {
                    delta.pivot = pivot;
                    return delta;
                }
            }),
        });

    WinJS.Namespace.define("Manipulator", {
        ManipulationManager: ManipulationManager
    });
    
    // Set up event handlers for the control
    WinJS.Class.mix(Manipulator.ManipulationManager, WinJS.Utilities.eventMixin);
    WinJS.Class.mix(Manipulator.ManipulationManager, WinJS.Utilities.createEventProperties("rotate"));

})();
