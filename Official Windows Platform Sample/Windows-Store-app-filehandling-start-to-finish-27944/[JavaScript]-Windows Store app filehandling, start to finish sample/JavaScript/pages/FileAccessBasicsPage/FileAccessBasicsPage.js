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
    WinJS.UI.Pages.define("/pages/FileAccessBasicsPage/FileAccessBasicsPage.html", {
        ready: function (element, options) {
            // Process app resources.            
            // Replace text-only strings bound to properties through data-win-res.
            WinJS.Resources.processAll(element);

            document.getElementById("EnumPictures").addEventListener("click", OnEnumPicturesClick, false);
            document.getElementById("GetFileProperties").addEventListener("click", OnGetFilePropertiesClick, false);
            document.getElementById("WriteTextToFile").addEventListener("click", OnWriteTextToFileClick, false);
            document.getElementById("ReadTextFromFile").addEventListener("click", OnReadTextFromFileClick, false);
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
        eventInfo.preventDefault();
        var link = eventInfo.target;
        WinJS.Navigation.navigate(link.href);
    }

    function OnEnumPicturesClick(mouseEvent) {
        var output = document.getElementById("Output");

        var library = Windows.Storage.KnownFolders.picturesLibrary;
        var outString = "Files in Pictures:<br/>";
        library.getFilesAsync().then(function (files) {
            files.forEach(function (file) {
                outString += file.name + "<br/>";
            });
            output.innerHTML = toStaticHTML(outString);
        });
    }

    function OnGetFilePropertiesClick(mouseEvent) {
        var output = document.getElementById("Output");

        var library = Windows.Storage.KnownFolders.picturesLibrary;
        var outString = "";
        library.getFilesAsync().then(function (files) {
            var promises = [];
            files.forEach(function (file) {
                promises.push(WinJS.Promise.as(file));
                promises.push(file.getBasicPropertiesAsync());
            })
            return WinJS.Promise.join(promises);
        })
        .done(function (results) {
            var counter = 0

            while (counter < results.length) {
                var file = results[counter];
                var props = results[counter + 1];
                outString += "File name: " + file.name + "<br/>";
                outString += "File type: " + file.fileType + "<br/>";
                outString += "File size: " + props.size + "<br/>";
                outString += "<br/>"
                counter = counter + 2;
            }

            output.innerHTML = toStaticHTML(outString);
        });
    }

    function OnWriteTextToFileClick(mouseEvent) {
        var output = document.getElementById("Output");

        Windows.Storage.KnownFolders.picturesLibrary.createFileAsync("FileHandlingJs.txt", Windows.Storage.CreationCollisionOption.replaceExisting).then(function (file) {
            if (file) {
                var now = new Date();
                var sampleFileContents = [[now.getMonth() + 1, now.getDate(), now.getFullYear()].join("/"), [now.getHours(), AddZero(now.getMinutes())].join(":"), now.getHours() >= 12 ? "PM" : "AM"].join(" ");
                Windows.Storage.FileIO.writeTextAsync(file, sampleFileContents).then(function () {
                    output.innerText = "The following text was written to '" + file.name + "': " + sampleFileContents;
                }, function (error) {
                    output.innerText = error.message;
                });
            }
            else {
                output.innerText = "createFileAsync failed to return a StorageFile object."
            }
        });
    }

    function AddZero(num) {
        return (num >= 0 && num < 10) ? "0" + num : num + "";
    }

    function OnReadTextFromFileClick(mouseEvent) {
        var output = document.getElementById("Output");
        Windows.Storage.KnownFolders.picturesLibrary.getFileAsync("FileHandlingJs.txt").then(function (file) {
            if (file) {
                Windows.Storage.FileIO.readTextAsync(file).then(function (contents) {
                    output.innerText = "The following text was read from '" + file.name + "': " + contents;
                });
            }
        }, function (error) {
            if (-1 < error.message.indexOf("The system cannot find the file specified")) {
                output.innerText = "The sample file does not exist. Click 'Write data to sample file' first.";
            }
            else {
                output.innerText = error.message;
            }
        });
    }
})();
