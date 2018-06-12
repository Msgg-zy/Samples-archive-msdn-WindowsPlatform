//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
(function () {
    "use strict";
    // For Page Control methods, see WinJS.UI.Pages.IPageControlMembers interface at http://go.microsoft.com/fwlink/?LinkID=320074.
    WinJS.UI.Pages.define("/pages/FilePickerPage/FilePickerPage.html", {
        ready: function (element, options) {
            // Process app resources.            
            // Replace text-only strings bound to properties through data-win-res.
            WinJS.Resources.processAll(element);

            document.getElementById("SelectSingleFile").addEventListener("click", OnSelectSingleFileClick, false);
            document.getElementById("SelectMultipleFiles").addEventListener("click", OnSelectMultipleFilesClick, false);
            document.getElementById("SelectFolder").addEventListener("click", OnSelectFolderClick, false);
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

    function OnSelectSingleFileClick(mouseEvent) {
        var output = document.getElementById("Output");

        var openPicker = new Windows.Storage.Pickers.FileOpenPicker();
        openPicker.viewMode = Windows.Storage.Pickers.PickerViewMode.thumbnail;
        openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.picturesLibrary;
        openPicker.fileTypeFilter.replaceAll([".jpg", ".jpeg", ".png"]);
        openPicker.pickSingleFileAsync().then(function (file) {
            if (file) {
                output.innerText = "Picked photo: " + file.name;
            }
            else {
                output.innerText = "Operation cancelled.";
            }
        });
    }

    function OnSelectMultipleFilesClick(mouseEvent) {
        var output = document.getElementById("Output");

        var openPicker = new Windows.Storage.Pickers.FileOpenPicker();
        openPicker.viewMode = Windows.Storage.Pickers.PickerViewMode.thumbnail;
        openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.picturesLibrary;
        openPicker.fileTypeFilter.replaceAll([".jpg", ".jpeg", ".png"]);
        openPicker.pickMultipleFilesAsync().then(function (files) {
            if (files.size > 0) {
                var outString = "Picked files:\n";
                for (var i = 0; i < files.size; i++) {
                    outString = outString + files[i].name + "\n";
                }
                output.innerText = outString;
            }
            else {
                output.innerText = "Operation cancelled.";
            }
        });
    }

    function OnSelectFolderClick(mouseEvent) {
        var output = document.getElementById("Output");

        var folderPicker = new Windows.Storage.Pickers.FolderPicker();
        folderPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.desktop;
        folderPicker.fileTypeFilter.replaceAll([".docx", ".xlsx", ".pptx"]);
        folderPicker.pickSingleFolderAsync().then(function (folder) {
            if (folder) {
                Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.addOrReplace("PickedFolderToken", folder);
                output.innerText = "Picked folder: " + folder.name;
            }
            else {
                output.innerText = "Operation cancelled.";
            }
        });
    }
})();
