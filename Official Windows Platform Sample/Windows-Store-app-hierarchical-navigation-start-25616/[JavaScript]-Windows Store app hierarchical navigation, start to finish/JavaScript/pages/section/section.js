//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

// This template is intended for Windows Store apps that require a 
// hierarchical system of navigation. 
// This pattern uses a Hub navigation pattern (hub, section, and detail pages) 
// that separates content into different sections and different levels of detail.

// This pattern is best for apps with large content collections or 
// many distinct sections of content.

// Section pages are the second level of an app.
// They contain a preview, summary, or abstract for items associated with the section. 

// The Hierarchical navigation pattern (http://go.microsoft.com/fwlink/?LinkID=316374) is highlighted in 
// our App features, start to finish series (http://go.microsoft.com/fwlink/?LinkID=316376).

// The navigation structure for this template is based on a data source defined in /js/data.js.
// The data is displayed through a ListView control (http://go.microsoft.com/fwlink/?LinkID=317813).

// For an overview of navigation design in Windows Store apps, see http://go.microsoft.com/fwlink/?LinkID=276817.
// For an introduction to the Hub template, see http://go.microsoft.com/fwlink/?LinkID=286574.
// For an introduction to the Hub control, see http://go.microsoft.com/fwlink/?LinkId=232511.
// For an introduction to the Page Control template, see http://go.microsoft.com/fwlink/?LinkId=232511.
// For Avoiding common certification failures, see http://go.microsoft.com/fwlink/?LinkId=232506.

(function () {
    "use strict";

    var ui = WinJS.UI;

    ui.Pages.define("/pages/section/section.html", {
        /// <field type="WinJS.Binding.List" />
        _items: null,

        processed: function (element) {
            return WinJS.Resources.processAll(element);
        },

        // This function is called to initialize the page.
        init: function (element, options) {
            var group = Data.resolveGroupReference(options.groupKey);
            this._items = Data.getItemsFromGroup(group);
            var pageList = this._items.createGrouped(
                function groupKeySelector(item) { return group.key; },
                function groupDataSelector(item) { return group; }
            );
            this.groupDataSource = pageList.groups.dataSource;
            this.itemDataSource = pageList.dataSource;
            this.itemInvoked = ui.eventHandler(this._itemInvoked.bind(this));
        },

        // This function is called whenever a user navigates to this page.
        ready: function (element, options) {
            element.querySelector("header[role=banner] .pagetitle").textContent = options.title;

            var listView = element.querySelector(".itemslist").winControl;
            listView.element.focus();
        },

        _itemInvoked: function (args) {
            var item = this._items.getAt(args.detail.itemIndex);
            WinJS.Navigation.navigate("/pages/item/item.html", { item: Data.getItemReference(item) });
        },

        // The unload method is called when leaving page.
        unload: function (element, options) {
            this._items.dispose();
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
})();
