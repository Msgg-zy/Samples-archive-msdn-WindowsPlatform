﻿//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";
    var book = {
        type: "http://schema.org/Book",
        properties: {
            image: "http://sourceurl.com/catcher-in-the-rye-book-cover.jpg",
            name: "The Catcher in the Rye",
            bookFormat: "http://schema.org/Paperback",
            author: "http://sourceurl.com/author/jd_salinger.html",
            numberOfPages: 224,
            publisher: "Little, Brown, and Company",
            datePublished: "1991-05-01",
            inLanguage: "English",
            isbn: "0316769487"
        }
    };

    var page = WinJS.UI.Pages.define("/html/custom.html", {
        ready: function (element, options) {
            var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
            dataTransferManager.addEventListener("datarequested", dataRequested);
            document.getElementById("shareButton").addEventListener("click", showShareUI, false);
        },
        processed: function () {
            document.getElementById("customData").innerText = JSON.stringify(book, null, 4);
        },
        unload: function () {
            var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
            dataTransferManager.removeEventListener("datarequested", dataRequested);
        }
    });

    function dataRequested(e) {
        var request = e.request;

        // Title is required
        var dataPackageTitle = document.getElementById("titleInputBox").value;
        if ((typeof dataPackageTitle === "string") && (dataPackageTitle !== "")) {
            var dataFormat = document.getElementById("dataFormatInputBox").value;
            if ((typeof dataFormat === "string") && (dataFormat !== "")) {
                request.data.properties.title = dataPackageTitle;

                // The description is optional.
                var dataPackageDescription = document.getElementById("descriptionInputBox").value;
                if ((typeof dataPackageDescription === "string") && (dataPackageDescription !== "")) {
                    request.data.properties.description = dataPackageDescription;
                }
                request.data.setData(dataFormat, JSON.stringify(book));
            } else {
                request.failWithDisplayText("Enter a custom data format and try again.");
            }
        } else {
            request.failWithDisplayText(SdkSample.missingTitleError);
        }
    }

    function showShareUI() {
        Windows.ApplicationModel.DataTransfer.DataTransferManager.showShareUI();
    }
})();
