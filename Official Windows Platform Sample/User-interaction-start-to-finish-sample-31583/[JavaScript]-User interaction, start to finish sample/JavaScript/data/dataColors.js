//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";

    var dataArray = [
    { value: WinJS.Resources.getString('colorpickerRed').value, color: "red", src: "/images/red.png", width: "50", height: "50" },
    { value: WinJS.Resources.getString('colorpickerGreen').value, color: "green", src: "/images/green.png", width: "50", height: "50" },
    { value: WinJS.Resources.getString('colorpickerBlue').value, color: "blue", src: "/images/blue.png", width: "50", height: "50" }
    ];

    var dataList = new WinJS.Binding.List(dataArray);

    // Create a namespace to make the data publicly accessible. 
    var publicMembers =
        {
            itemList: dataList
        };
    WinJS.Namespace.define("DataColors", publicMembers);

})();