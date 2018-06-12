(function () {
    "use strict";

    var ui = WinJS.UI;

    var nav = WinJS.Navigation;

    WinJS.UI.Pages.define("/pages/groupedItems/groupedItems.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            var listView = element.querySelector(".groupeditemslist").winControl;
            listView.groupHeaderTemplate = element.querySelector(".headertemplate");
            listView.itemTemplate = element.querySelector(".itemtemplate");
            listView.addEventListener("groupheaderinvoked", this._groupHeaderInvoked.bind(this));
            listView.addEventListener("iteminvoked", this._itemInvoked.bind(this));
            listView.itemDataSource = Data.items.dataSource;
            listView.groupDataSource = Data.groups.dataSource;
            listView.element.focus();
            this._initializeLayout(listView);
        },

        // This function updates the page layout in response to viewState changes.
        updateLayout: function (element) {
            /// <param name="element" domElement="true" />

            var listView = element.querySelector(".groupeditemslist").winControl;

            var handler = function (e) {
                listView.removeEventListener("contentanimating", handler, false);
                e.preventDefault();
            }
            listView.addEventListener("contentanimating", handler, false);
            this._initializeLayout(listView);
        },

        // This function updates the ListView with new layouts
        _initializeLayout: function (listView) {
            /// <param name="listView" value="WinJS.UI.ListView.prototype" />

            // narrow width
            if (document.documentElement.offsetWidth < 500) {
                listView.itemDataSource = Data.groups.dataSource;
                listView.groupDataSource = null;
                listView.layout = new ui.ListLayout();
            }
            // not narrow width
            else {
                listView.itemDataSource = Data.items.dataSource;
                listView.groupDataSource = Data.groups.dataSource;
                listView.layout = new ui.GridLayout({ groupHeaderPosition: "top" });
            }
        },

        _groupHeaderInvoked: function (args) {
            var group = Data.groups.getAt(args.detail.groupHeaderIndex);
            nav.navigate("/pages/groupDetail/groupDetail.html", { groupKey: group.key });
        },

        _itemInvoked: function (args) {
            args.detail.itemPromise.then(function (item) {
                var group = Data.groups.getItemFromKey(item.key);
                if (!!group) {
                    nav.navigate("/pages/groupDetail/groupDetail.html", { groupKey: group.key });
                    return;
                }
                var item = Data.items.getAt(args.detail.itemIndex);
                nav.navigate("/pages/itemDetail/itemDetail.html", { item: Data.getItemReference(item) });
            });
        }
    });
})();
