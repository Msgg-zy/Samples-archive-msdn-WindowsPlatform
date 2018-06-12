//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

// For an overview of navigation design in Windows Store apps, see http://go.microsoft.com/fwlink/?LinkID=276817.
// For an introduction to the Hub template, see http://go.microsoft.com/fwlink/?LinkID=286574.
// For an introduction to the Hub control, see http://go.microsoft.com/fwlink/?LinkId=232511.
// For an introduction to the Page Control template, see http://go.microsoft.com/fwlink/?LinkId=232511.
// For Avoiding common certification failures, see http://go.microsoft.com/fwlink/?LinkId=232506.

(function () {
    "use strict";

    var nav = WinJS.Navigation;

    WinJS.Namespace.define("Application", {
        PageControlNavigator: WinJS.Class.define(
            // Define the constructor function for the PageControlNavigator.
            function PageControlNavigator(element, options) {
                this._element = element || document.createElement("div");
                this._element.appendChild(this._createPageElement());

                this.home = options.home;

                this._eventHandlerRemover = [];

                var that = this;
                function addRemovableEventListener(e, eventName, handler, capture) {
                    e.addEventListener(eventName, handler, capture);
                    that._eventHandlerRemover.push(function () {
                        e.removeEventListener(eventName, handler);
                    });
                };

                addRemovableEventListener(nav, 'navigating', this._navigating.bind(this), false);
                addRemovableEventListener(nav, 'navigated', this._navigated.bind(this), false);
                // Event listener for resource context changes.
                // If app resources get localized or variants exist for high-contrast 
                // modes or scales, then the contextChanged event will occur at runtime 
                // when language, scale, or high contrast changes. 
                addRemovableEventListener(WinJS.Resources, "contextchanged", this._contextChanged.bind(this), false);

                window.onresize = this._resized.bind(this);

                Application.navigator = this;
            }, {
                home: "",
                /// <field domElement="true" />
                _element: null,
                _lastNavigationPromise: WinJS.Promise.as(),
                _lastViewstate: 0,

                // This is the currently loaded Page object.
                pageControl: {
                    get: function () { return this.pageElement && this.pageElement.winControl; }
                },

                // This is the root element of the current page.
                pageElement: {
                    get: function () { return this._element.firstElementChild; }
                },

                // This function disposes the page navigator and its contents.
                dispose: function () {
                    if (this._disposed) {
                        return;
                    }

                    this._disposed = true;
                    WinJS.Utilities.disposeSubTree(this._element);
                    for (var i = 0; i < this._eventHandlerRemover.length; i++) {
                        this._eventHandlerRemover[i]();
                    }
                    this._eventHandlerRemover = null;
                },

                _contextChanged: function (e) {
                    /// <summary>
                    /// Responds to resource context changes and calls page-specific 
                    /// implementations of updateResources to reload app resources.
                    /// </summary>
                    if (this.pageControl && this.pageControl.updateResources) {
                        // Could test e.detail.qualifier here to filter for changes on 
                        // specific resource qualifiers (e.g., scale, language, contrast).
                        // Instead, we pass e to the page-specific implementations of 
                        // updateResources for finer control.
                        this.pageControl.updateResources.call(this.pageControl, this.pageElement, e);
                    }
                },

                // Creates a container for a new page to be loaded into.
                _createPageElement: function () {
                    var element = document.createElement("div");
                    element.setAttribute("dir", window.getComputedStyle(this._element, null).direction);
                    element.style.position = "absolute";
                    element.style.visibility = "hidden";
                    element.style.width = "100%";
                    element.style.height = "100%";
                    return element;
                },

                // Retrieves a list of animation elements for the current page.
                // If the page does not define a list, animate the entire page.
                _getAnimationElements: function () {
                    if (this.pageControl && this.pageControl.getAnimationElements) {
                        return this.pageControl.getAnimationElements();
                    }
                    return this.pageElement;
                },

                // Occurs after navigation has taken place. 
                _navigated: function () {
                    this.pageElement.style.visibility = "";
                    WinJS.UI.Animation.enterPage(this._getAnimationElements()).done();
                    // Overload light dismiss and hide the nav and app bars on page navigation.
                    var appBar = document.getElementById("appBar").winControl;
                    appBar.hide();
                },

                // Responds to navigation by adding new pages to the DOM.
                _navigating: function (args) {
                    var newElement = this._createPageElement();
                    this._element.appendChild(newElement);

                    this._lastNavigationPromise.cancel();

                    var that = this;
                    this._lastNavigationPromise = WinJS.Promise.as().then(function () {
                        return WinJS.UI.Pages.render(args.detail.location, newElement, args.detail.state);
                    }).then(function parentElement(control) {
                        var oldElement = that.pageElement;
                        // Cleanup and remove previous element
                        if (oldElement.winControl) {
                            if (oldElement.winControl.unload) {
                                oldElement.winControl.unload();
                            }
                            oldElement.winControl.dispose();
                        }
                        oldElement.parentNode.removeChild(oldElement);
                        oldElement.innerText = "";
                    });

                    args.detail.setPromise(this._lastNavigationPromise);
                },

                // Responds to resize events and call the updateLayout function
                // on the currently loaded page.
                _resized: function (args) {
                    if (this.pageControl && this.pageControl.updateLayout) {
                        this.pageControl.updateLayout.call(this.pageControl, this.pageElement);
                    }
                },
            }
        )
    });
})();
