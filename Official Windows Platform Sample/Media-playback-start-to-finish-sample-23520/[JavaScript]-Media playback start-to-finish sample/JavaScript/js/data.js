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
        // Encoded placeholder images for backgroundImage property of templateSections and templateDetails.
        var darkGray = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY3B0cPoPAANMAcOba1BlAAAAAElFTkSuQmCC";
        var lightGray = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY7h4+cp/AAhpA3h+ANDKAAAAAElFTkSuQmCC";
        var mediumGray = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY5g8dcZ/AAY/AsAlWFQ+AAAAAElFTkSuQmCC";

        // Each section must have a unique key.
        var templateSections = [
            { key: "section1", title: WinJS.Resources.getString('section1Title').value, subtitle: WinJS.Resources.getString('section1SubTitle').value, backgroundImage: darkGray, description: WinJS.Resources.getString('section1Description').value },
            { key: "section2", title: WinJS.Resources.getString('section2Title').value, subtitle: WinJS.Resources.getString('section2SubTitle').value, backgroundImage: lightGray, description: WinJS.Resources.getString('section2Description').value },
            { key: "section3", title: WinJS.Resources.getString('section3Title').value, subtitle: WinJS.Resources.getString('section3SubTitle').value, backgroundImage: mediumGray, description: WinJS.Resources.getString('section3Description').value },
            { key: "section4", title: WinJS.Resources.getString('section4Title').value, subtitle: WinJS.Resources.getString('section4SubTitle').value, backgroundImage: lightGray, description: WinJS.Resources.getString('section4Description').value },
        ];

        // Each sample item must have a reference to a section.
        var templateDetails = [
            { group: templateSections[0], title: WinJS.Resources.getString('section1detail1Title').value, subtitle: WinJS.Resources.getString('section1detail1SubTitle').value, description: WinJS.Resources.getString('section1detail1Description').value, content: WinJS.Resources.getString('section1detail1Content').value, backgroundImage: lightGray },
            { group: templateSections[0], title: WinJS.Resources.getString('section1detail2Title').value, subtitle: WinJS.Resources.getString('section1detail2SubTitle').value, description: WinJS.Resources.getString('section1detail2Description').value, content: WinJS.Resources.getString('section1detail2Content').value, backgroundImage: darkGray },
            { group: templateSections[0], title: WinJS.Resources.getString('section1detail3Title').value, subtitle: WinJS.Resources.getString('section1detail3SubTitle').value, description: WinJS.Resources.getString('section1detail3Description').value, content: WinJS.Resources.getString('section1detail3Content').value, backgroundImage: mediumGray },
            { group: templateSections[0], title: WinJS.Resources.getString('section1detail4Title').value, subtitle: WinJS.Resources.getString('section1detail4SubTitle').value, description: WinJS.Resources.getString('section1detail4Description').value, content: WinJS.Resources.getString('section1detail4Content').value, backgroundImage: darkGray },
            { group: templateSections[0], title: WinJS.Resources.getString('section1detail5Title').value, subtitle: WinJS.Resources.getString('section1detail5SubTitle').value, description: WinJS.Resources.getString('section1detail5Description').value, content: WinJS.Resources.getString('section1detail5Content').value, backgroundImage: mediumGray },

            { group: templateSections[1], title: WinJS.Resources.getString('section2detail1Title').value, subtitle: WinJS.Resources.getString('section2detail1SubTitle').value, description: WinJS.Resources.getString('section2detail1Description').value, content: WinJS.Resources.getString('section2detail1Content').value, backgroundImage: darkGray },
            { group: templateSections[1], title: WinJS.Resources.getString('section2detail2Title').value, subtitle: WinJS.Resources.getString('section2detail2SubTitle').value, description: WinJS.Resources.getString('section2detail2Description').value, content: WinJS.Resources.getString('section2detail2Content').value, backgroundImage: mediumGray },
            { group: templateSections[1], title: WinJS.Resources.getString('section2detail3Title').value, subtitle: WinJS.Resources.getString('section2detail3SubTitle').value, description: WinJS.Resources.getString('section2detail3Description').value, content: WinJS.Resources.getString('section2detail3Content').value, backgroundImage: lightGray },

            { group: templateSections[2], title: WinJS.Resources.getString('section3detail1Title').value, subtitle: WinJS.Resources.getString('section3detail1SubTitle').value, description: WinJS.Resources.getString('section3detail1Description').value, content: WinJS.Resources.getString('section3detail1Content').value, backgroundImage: mediumGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3detail2Title').value, subtitle: WinJS.Resources.getString('section3detail2SubTitle').value, description: WinJS.Resources.getString('section3detail2Description').value, content: WinJS.Resources.getString('section3detail2Content').value, backgroundImage: lightGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3detail3Title').value, subtitle: WinJS.Resources.getString('section3detail3SubTitle').value, description: WinJS.Resources.getString('section3detail3Description').value, content: WinJS.Resources.getString('section3detail3Content').value, backgroundImage: darkGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3detail4Title').value, subtitle: WinJS.Resources.getString('section3detail4SubTitle').value, description: WinJS.Resources.getString('section3detail4Description').value, content: WinJS.Resources.getString('section3detail4Content').value, backgroundImage: lightGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3detail5Title').value, subtitle: WinJS.Resources.getString('section3detail5SubTitle').value, description: WinJS.Resources.getString('section3detail5Description').value, content: WinJS.Resources.getString('section3detail5Content').value, backgroundImage: mediumGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3detail6Title').value, subtitle: WinJS.Resources.getString('section3detail6SubTitle').value, description: WinJS.Resources.getString('section3detail6Description').value, content: WinJS.Resources.getString('section3detail6Content').value, backgroundImage: darkGray },
            { group: templateSections[2], title: WinJS.Resources.getString('section3detail7Title').value, subtitle: WinJS.Resources.getString('section3detail7SubTitle').value, description: WinJS.Resources.getString('section3detail7Description').value, content: WinJS.Resources.getString('section3detail7Content').value, backgroundImage: mediumGray },

            { group: templateSections[3], title: WinJS.Resources.getString('section4detail1Title').value, subtitle: WinJS.Resources.getString('section4detail1SubTitle').value, description: WinJS.Resources.getString('section4detail1Description').value, content: WinJS.Resources.getString('section4detail1Content').value, backgroundImage: darkGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4detail2Title').value, subtitle: WinJS.Resources.getString('section4detail2SubTitle').value, description: WinJS.Resources.getString('section4detail2Description').value, content: WinJS.Resources.getString('section4detail2Content').value, backgroundImage: lightGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4detail3Title').value, subtitle: WinJS.Resources.getString('section4detail3SubTitle').value, description: WinJS.Resources.getString('section4detail3Description').value, content: WinJS.Resources.getString('section4detail3Content').value, backgroundImage: darkGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4detail4Title').value, subtitle: WinJS.Resources.getString('section4detail4SubTitle').value, description: WinJS.Resources.getString('section4detail4Description').value, content: WinJS.Resources.getString('section4detail4Content').value, backgroundImage: lightGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4detail5Title').value, subtitle: WinJS.Resources.getString('section4detail5SubTitle').value, description: WinJS.Resources.getString('section4detail5Description').value, content: WinJS.Resources.getString('section4detail5Content').value, backgroundImage: mediumGray },
            { group: templateSections[3], title: WinJS.Resources.getString('section4detail6Title').value, subtitle: WinJS.Resources.getString('section4detail6SubTitle').value, description: WinJS.Resources.getString('section4detail6Description').value, content: WinJS.Resources.getString('section4detail6Content').value, backgroundImage: lightGray },
        ];

        return templateDetails;
    }

})();
