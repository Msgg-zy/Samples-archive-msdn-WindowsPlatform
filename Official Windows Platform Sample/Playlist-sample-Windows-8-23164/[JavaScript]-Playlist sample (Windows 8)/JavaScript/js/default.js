﻿//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";

    var sampleTitle = "Playlists sample";

    var scenarios = [
        { url: "/html/create.html", title: "Create a playlist" },
        { url: "/html/display.html", title: "Display a playlist" },
        { url: "/html/add.html", title: "Add items to a playlist" },
        { url: "/html/remove.html", title: "Remove an item from a playlist" },
        { url: "/html/clear.html", title: "Clear a playlist" }
    ];

    var audioExtensions = [".wma", ".mp3", ".mp2", ".aac", ".adt", ".adts", ".m4a"];
    var playlistExtensions = [".m3u", ".wpl", ".zpl"];
    var playlist = null;

    var ensureUnsnapped = function () {
        var success = true;

        // Try to unsnap if we are currently snapped
        if (Windows.UI.ViewManagement.ApplicationView.value === Windows.UI.ViewManagement.ApplicationViewState.snapped) {
            success = Windows.UI.ViewManagement.ApplicationView.tryUnsnap();
        }

        if (!success) {
            WinJS.log && WinJS.log("Unable to unsnap the app.", "sample", "error");
        }

        return success;
    };

    function activated(eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            // Use setPromise to indicate to the system that the splash screen must not be torn down
            // until after processAll and navigate complete asynchronously.
            eventObject.setPromise(WinJS.UI.processAll().then(function () {
                // Navigate to either the first scenario or to the last running scenario
                // before suspension or termination.
                var url = WinJS.Application.sessionState.lastUrl || scenarios[0].url;
                return WinJS.Navigation.navigate(url);
            }));
        }
    }

    WinJS.Navigation.addEventListener("navigated", function (eventObject) {
        var url = eventObject.detail.location;
        var host = document.getElementById("contentHost");
        // Call unload method on current scenario, if there is one
        host.winControl && host.winControl.unload && host.winControl.unload();
        WinJS.Utilities.empty(host);
        eventObject.detail.setPromise(WinJS.UI.Pages.render(url, host, eventObject.detail.state).then(function () {
            WinJS.Application.sessionState.lastUrl = url;
        }));
    });

    WinJS.Namespace.define("SdkSample", {
        sampleTitle: sampleTitle,
        scenarios: scenarios,
        audioExtensions: audioExtensions,
        playlistExtensions: playlistExtensions,
        playlist: playlist,
        ensureUnsnapped: ensureUnsnapped
    });

    WinJS.Application.addEventListener("activated", activated, false);
    WinJS.Application.start();
})();
