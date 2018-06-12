//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

// The navigation structure for this template is based on a data source defined in /js/data.js.
// The data is displayed through a ListView control (http://go.microsoft.com/fwlink/?LinkID=317813).

(function () {
    "use strict";

    var list = new WinJS.Binding.List();
    var groupedItems = list.createGrouped(
        function groupKeySelector(item) { return item.group.key; },
        function groupDataSelector(item) { return item.group; }
    );

    // TODO: Replace the data with your real data.
    // You can add data from asynchronous sources whenever it becomes available.
    generateSampleData().forEach(function (item) {
        list.push(item);
    });

    WinJS.Namespace.define("Data", {
        items: groupedItems,
        groups: groupedItems.groups,
        getItemReference: getItemReference,
        getItemsFromGroup: getItemsFromGroup,
        resolveGroupReference: resolveGroupReference,
        resolveItemReference: resolveItemReference
    });

    // Get a reference for an item, using the group key and item title as a
    // unique reference to the item that can be easily serialized.
    function getItemReference(item) {
        return [item.group.key, item.title];
    }

    // This function returns a WinJS.Binding.List containing only the items
    // that belong to the provided group.
    function getItemsFromGroup(group) {
        return list.createFiltered(function (item) { return item.group.key === group.key; });
    }

    // Get the unique group corresponding to the provided group key.
    function resolveGroupReference(key) {
        return groupedItems.groups.getItemFromKey(key).data;
    }

    // Get a unique item from the provided string array, which should contain a
    // group key and an item title.
    function resolveItemReference(reference) {
        for (var i = 0; i < groupedItems.length; i++) {
            var item = groupedItems.getAt(i);
            if (item.group.key === reference[0] && item.title === reference[1]) {
                return item;
            }
        }
    }

    // Returns an array of sample data to add to the template data list. 
    // TODO: 
    //  Replace encoded images with real images.
    //  Provide localized strings in real data.
    function generateSampleData() {
        // Encoded placeholder images for backgroundImage property of templateSections and templateItems.
        var darkGray = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY3B0cPoPAANMAcOba1BlAAAAAElFTkSuQmCC";
        var lightGray = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY7h4+cp/AAhpA3h+ANDKAAAAAElFTkSuQmCC";
        var mediumGray = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY5g8dcZ/AAY/AsAlWFQ+AAAAAElFTkSuQmCC";
        //var darkGray = "/images/gray.png";
        //var lightGray = "/images/gray.png";
        //var mediumGray = "/images/gray.png";

        // Each section must have a unique key.
        var templateSections = [
            { key: "section1", title: WinJS.Resources.getString('section1Title').value, subtitle: WinJS.Resources.getString('section1SubTitle').value, backgroundImage: darkGray, description: WinJS.Resources.getString('section1Description').value },
            { key: "section2", title: WinJS.Resources.getString('section2Title').value, subtitle: WinJS.Resources.getString('section2SubTitle').value, backgroundImage: lightGray, description: WinJS.Resources.getString('section2Description').value },
            { key: "section3", title: WinJS.Resources.getString('section3Title').value, subtitle: WinJS.Resources.getString('section3SubTitle').value, backgroundImage: mediumGray, description: WinJS.Resources.getString('section3Description').value },
            { key: "section4", title: WinJS.Resources.getString('section4Title').value, subtitle: WinJS.Resources.getString('section4SubTitle').value, backgroundImage: lightGray, description: WinJS.Resources.getString('section4Description').value },
        ];

        // Each sample item must have a reference to a section.
        var templateItems = [
            { group: templateSections[0], title: WinJS.Resources.getString('section1item1Title').value, subtitle: WinJS.Resources.getString('section1item1SubTitle').value, description: WinJS.Resources.getString('section1item1Description').value, content: WinJS.Resources.getString('section1item1Content').value, backgroundImage: lightGray },
            { group: templateSections[0], title: WinJS.Resources.getString('section1item2Title').value, subtitle: WinJS.Resources.getString('section1item2SubTitle').value, description: WinJS.Resources.getString('section1item2Description').value, content: WinJS.Resources.getString('section1item2Content').value, backgroundImage: darkGray },
            { group: templateSections[0], title: WinJS.Resources.getString('section1item3Title').value, subtitle: WinJS.Resources.getString('section1item3SubTitle').value, description: WinJS.Resources.getString('section1item3Description').value, content: WinJS.Resources.getString('section1item3Content').value, backgroundImage: mediumGray },
            { group: templateSections[0], title: WinJS.Resources.getString('section1item4Title').value, subtitle: WinJS.Resources.getString('section1item4SubTitle').value, description: WinJS.Resources.getString('section1item4Description').value, content: WinJS.Resources.getString('section1item4Content').value, backgroundImage: darkGray },
            { group: templateSections[0], title: WinJS.Resources.getString('section1item5Title').value, subtitle: WinJS.Resources.getString('section1item5SubTitle').value, description: WinJS.Resources.getString('section1item5Description').value, content: WinJS.Resources.getString('section1item5Content').value, backgroundImage: mediumGray },

            { group: templateSections[1], title: WinJS.Resources.getString('section2item1Title').value, subtitle: WinJS.Resources.getString('section2item1SubTitle').value, description: WinJS.Resources.getString('section2item1Description').value, content: WinJS.Resources.getString('section2item1Content').value, backgroundImage: darkGray },
            { group: templateSections[1], title: WinJS.Resources.getString('section2item2Title').value, subtitle: WinJS.Resources.getString('section2item2SubTitle').value, description: WinJS.Resources.getString('section2item2Description').value, content: WinJS.Resources.getString('section2item2Content').value, backgroundImage: mediumGray },
            { group: templateSections[1], title: WinJS.Resources.getString('section2item3Title').value, subtitle: WinJS.Resources.getString('section2item3SubTitle').value, description: WinJS.Resources.getString('section2item3Description').value, content: WinJS.Resources.getString('section2item3Content').value, backgroundImage: lightGray },

            { group: templateSections[2], title: WinJS.Resources.getString('section3item1Title').value, subtitle: WinJS.Resources.getString('section3item1SubTitle').value, description: WinJS.Resources.getString('section3item1Description').value, content: WinJS.Resources.getString('section3item1Content').value, backgroundImage: mediumGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3item2Title').value, subtitle: WinJS.Resources.getString('section3item2SubTitle').value, description: WinJS.Resources.getString('section3item2Description').value, content: WinJS.Resources.getString('section3item2Content').value, backgroundImage: lightGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3item3Title').value, subtitle: WinJS.Resources.getString('section3item3SubTitle').value, description: WinJS.Resources.getString('section3item3Description').value, content: WinJS.Resources.getString('section3item3Content').value, backgroundImage: darkGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3item4Title').value, subtitle: WinJS.Resources.getString('section3item4SubTitle').value, description: WinJS.Resources.getString('section3item4Description').value, content: WinJS.Resources.getString('section3item4Content').value, backgroundImage: lightGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3item5Title').value, subtitle: WinJS.Resources.getString('section3item5SubTitle').value, description: WinJS.Resources.getString('section3item5Description').value, content: WinJS.Resources.getString('section3item5Content').value, backgroundImage: mediumGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3item6Title').value, subtitle: WinJS.Resources.getString('section3item6SubTitle').value, description: WinJS.Resources.getString('section3item6Description').value, content: WinJS.Resources.getString('section3item6Content').value, backgroundImage: darkGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3item7Title').value, subtitle: WinJS.Resources.getString('section3item7SubTitle').value, description: WinJS.Resources.getString('section3item7Description').value, content: WinJS.Resources.getString('section3item7Content').value, backgroundImage: mediumGray },

            { group: templateSections[3], title: WinJS.Resources.getString('section4item1Title').value, subtitle: WinJS.Resources.getString('section4item1SubTitle').value, description: WinJS.Resources.getString('section4item1Description').value, content: WinJS.Resources.getString('section4item1Content').value, backgroundImage: darkGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4item2Title').value, subtitle: WinJS.Resources.getString('section4item2SubTitle').value, description: WinJS.Resources.getString('section4item2Description').value, content: WinJS.Resources.getString('section4item2Content').value, backgroundImage: lightGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4item3Title').value, subtitle: WinJS.Resources.getString('section4item3SubTitle').value, description: WinJS.Resources.getString('section4item3Description').value, content: WinJS.Resources.getString('section4item3Content').value, backgroundImage: darkGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4item4Title').value, subtitle: WinJS.Resources.getString('section4item4SubTitle').value, description: WinJS.Resources.getString('section4item4Description').value, content: WinJS.Resources.getString('section4item4Content').value, backgroundImage: lightGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4item5Title').value, subtitle: WinJS.Resources.getString('section4item5SubTitle').value, description: WinJS.Resources.getString('section4item5Description').value, content: WinJS.Resources.getString('section4item5Content').value, backgroundImage: mediumGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4item6Title').value, subtitle: WinJS.Resources.getString('section4item6SubTitle').value, description: WinJS.Resources.getString('section4item6Description').value, content: WinJS.Resources.getString('section4item6Content').value, backgroundImage: lightGray },
        ];

        return templateItems;
    }

})();
