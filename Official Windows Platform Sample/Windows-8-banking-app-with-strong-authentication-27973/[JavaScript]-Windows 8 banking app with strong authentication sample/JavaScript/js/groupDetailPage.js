﻿(function () {
    "use strict";

    WinJS.UI.Pages.define("/html/groupDetailpage.html", {
        /// <field type="WinJS.Binding.List" />
        _items: null,

        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            var listView = element.querySelector(".itemslist").winControl;
            var group = (options && options.groupKey) ? Data.resolveGroupReference(options.groupKey) : Data.groups.getAt(0);
            this._items = Data.getItemsFromGroup(group);
            var pageList = this._items.createGrouped(
                function groupKeySelector(/*@override*/item) { return group.key; },
                function groupDataSelector(/*@override*/item) { return group; }
            );

            element.querySelector("header[role=banner] .pagetitle").textContent = group.title;

            listView.itemDataSource = pageList.dataSource;
            listView.itemTemplate = element.querySelector(".itemtemplate");
            listView.groupDataSource = pageList.groups.dataSource;
            listView.groupHeaderTemplate = element.querySelector(".headertemplate");
            listView.oniteminvoked = this._itemInvoked.bind(this);

            listView.element.focus();
        },

        unload: function () {
            this._items.dispose();
        },

        updateLayout: function (element, viewState, lastViewState) {
            /// <param name="element" domElement="true" />

            // TODO: Respond to changes in viewState.
        },

        _itemInvoked: function (e) {
            var /*@override*/ item = Data.groups.getAt(e.detail.itemIndex);
            switch (e.detail.itemIndex) {
                case 0:
                    Windows.Storage.ApplicationData.current.localSettings.values["scenarioId"] = "0";
                    checkCert(e.detail.itemIndex, item);
                    break;
                case 1:
                    Windows.Storage.ApplicationData.current.localSettings.values["scenarioId"] = "1";
                    checkCert(e.detail.itemIndex, item);
                    break;
                default:
                    goError("Unknown scenario!!!");
                    break;
            }
        }
    });

    //check user credential
    function checkCredential() {
        var vault = new Windows.Security.Credentials.PasswordVault();
        var creds = vault.retrieveAll();
        for (var i = 0; i < creds.size; i++) {
            if (creds.getAt(i).resource === "WoodGrove-Bank-usercred") {
                return true;
            }
        }
        return false;
    }

    //check certificate enrollment
    function checkEnrollment() {
        if (Windows.Storage.ApplicationData.current.localSettings.values["EnrollCertificate"]) {
            return true;
        }
        return false;
    }

    //check certification
    function checkCert(senario, scenarioitem) {
        var params = "";
        WinJS.xhr({
            type: "POST",
            url: "Your URL",    //Please provide the server url here. For example:
            //url: "https://WoodGrove-Bank/bankserver2/renewal/CheckCert",
            headers: { "Content-type": "application/x-www-form-urlencoded" },
            data: params
        }).done(
            function (request) {
                var obtainedData = window.JSON.parse(request.responseText);
                if (obtainedData.hasCert === true) {
                    if (obtainedData.renew === true) {
                        if (obtainedData.pfx === true) {
                            doPFXRenewal(obtainedData.user);
                        }
                        else {
                            doPKCS10Renewal(obtainedData.user);
                        }
                    }
                    else {
                        var /*@override*/ item = {
                            title: "Account Page",
                            content: "",
                            backgroundColor: 'rgba(25,50,200,1)',
                            navigate: "sign-out"
                        };
                        WinJS.Navigation.navigate('/html/account.html', { item: item });
                    }
                }
                else {
                    switch (senario) {
                        case 0:
                            if (checkCredential()) {
                                var item2 = {
                                    title: "Account Page",
                                    content: "<strong>(Please upgrade to strong authentication if you need full access to your account. <br>"
                                            + "If you already upgraded to use strong authentication, please sign out and launch the app again and sign-in.)</strong>",
                                    backgroundColor: 'rgba(191, 84, 46, 1)',
                                    navigate: "groupeditemsPage"
                                };
                                WinJS.Navigation.navigate('/html/account.html', { item: item2 });
                            } else {
                                WinJS.Navigation.navigate('/html/scenario0.html', { item: scenarioitem });
                            }
                            break;
                        case 1:
                            if (checkCredential() && !checkEnrollment()) {
                                WinJS.Navigation.navigate('/html/enrollment.html', { item: scenarioitem });
                            }
                            else if (!checkEnrollment()) {
                                WinJS.Navigation.navigate('/html/scenario1.html', { item: scenarioitem });
                            }
                            else {
                                var item3 = {
                                    title: "Account Page",
                                    content: "<strong>(You already upgraded to use strong authentication. Please sign out and launch the app again and sign-in.)</strong>",
                                    backgroundColor: 'rgba(191, 84, 46, 1)',
                                    navigate: "sign-out"
                                };
                                WinJS.Navigation.navigate('/html/account.html', { item: item3 });
                            }
                            break;
                        default:
                            goError("unknown scenario!!!");
                            break;
                    }
                }
                return false;
            },
            function (request) {
                goError("(The error was: <strong>" + request.message + "</strong>) <br>" + "The server URL you are using may not be valid. <br>"
                      + "Please contact your bank server service, "
                      + "or refer to the bank server walk through document for instructions to setup your own server.");
                return false;
            }
        );
    }

    //pkcs10 certificate renewal
    function createRequestBlobAndEnroll(user) {
        var encoded;
        try {
            //WinRT APIs for creating a certficate request
            var request = new Windows.Security.Cryptography.Certificates.CertificateRequestProperties;
            request.subject = user;
            request.friendlyName = user + "'s WoodGrove Bank Certificate";
            request.keyProtectionLevel = Windows.Security.Cryptography.Certificates.KeyProtectionLevel.noConsent;
            Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.createRequestAsync(request).done(
                function (requestResult) {
                    encoded = requestResult;
                    // No username or password required in this case - we already have a
                    // client-authenticated SSL connection
                    var installOption = 0; //Windows.Security.Cryptography.Certificates.InstallOptions.none;
                    var params = "request=" + encodeURIComponent(encoded);
                    WinJS.xhr({
                        type: "POST",
                        url: "Your URL",    //Please provide the server url here. For example:
                        //url: "https://WoodGrove-Bank/bankserver2/renewal/renewP10",
                        headers: { "Content-type": "application/x-www-form-urlencoded" },
                        data: params
                    }).done(
                        function (/*@override*/request) {
                            var obtainedData = window.JSON.parse(request.responseText);
                            // We do not need to remove the previous certificate first -
                            // Win8 filtering will take care of it.
                            try {
                                Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.installCertificateAsync(obtainedData.certificate, installOption).done(
                                function () {
                                    var /*@override*/ item = {
                                        title: "Account Page",
                                        content: "",
                                        backgroundColor: 'rgba(25,50,200,1)',
                                        navigate: "sign-out"
                                    };
                                    WinJS.Navigation.navigate('/html/account.html', { item: item });
                                },
                                function (installError) {
                                    goError("(The error was: <strong>" + intallError.message + "</strong>)");
                                    return false;
                                });
                            } catch (err) {
                                var /*@override*/ message = '';
                                for (var /*@override*/ f in err) {
                                    message += f;
                                    message += ':';
                                    message += err[f];
                                    message += ' ';
                                };
                                goError(message);
                                return false;
                            };
                        },
                        function (/*@override*/request) {
                            goError("(The error was: <strong>" + request.message + "</strong>) <br>" + "The server URL you are using may not be valid. <br>"
                            + "Please contact your bank server service, "
                            + "or refer to the bank server walk through document for instructions to setup your own server.");
                            return false;
                        });
                },
                function (requestError) {
                    goError("(The error was: <strong>" + requestError.message + "</strong>)");
                    return false;
                });
        }
        catch (err) {
            var message = '';
            for (var f in err) {
                message += f;
                message += ':';
                message += err[f];
                message += ' ';
            }
            goError(message);
            return false;
        };
    }

    function doPKCS10Renewal(user) {
        try {
            createRequestBlobAndEnroll(user);
        } catch (err) {
            var message = '';
            for (var f in err) {
                message += f;
                message += ':';
                message += err[f];
                message += ' ';
            };
            goError(message);
            return false;
        }
    }

    //pfx certificate renewal
    function doPFXRenewal(user) {
        var exportable = Windows.Security.Cryptography.Certificates.ExportOption.exportable;
        var consent = Windows.Security.Cryptography.Certificates.KeyProtectionLevel.noConsent;
        var installOption = 0; //Windows.Security.Cryptography.Certificates.InstallOptions.none;
        var params = "username=" + user;
        WinJS.xhr({
            type: "POST",
            url: "Your URL",    //Please provide the server url here. For example:
            //url: "https://WoodGrove-Bank/bankserver2/enrollment/getPFX",
            headers: { "Content-type": "application/x-www-form-urlencoded" },
            data: params
        }).done(
            function (request) {
                var obtainedData = window.JSON.parse(request.responseText);
                // We do not need to remove the previous certificate first -
                // Win8 filtering will take care of it.
                try {
                    // No need to remove old cert, Windows will filter.
                    Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.importPfxDataAsync(obtainedData.pfx, obtainedData.password, exportable, consent, installOption, obtainedData.friendlyName).done(
                        function () {
                            var /*@override*/ item = {
                                title: "Account Page",
                                content: "",
                                backgroundColor: 'rgba(25,50,200,1)',
                                navigate: "sign-out"
                            };
                            WinJS.Navigation.navigate('/html/account.html', { item: item });
                        },
                        function (importError) {
                            goError("(The error was: <strong>" + importError.message + "</strong>)");
                            return false;
                        });
                } catch (err) {
                    var message = '';
                    for (var f in err) {
                        message += f;
                        message += ':';
                        message += err[f];
                        message += ' ';
                    };
                    goError(message);
                    return false;
                }

            },
            function (request) {
                goError("(The error was: <strong>" + request.message + "</strong>) <br>" + "The server URL you are using may not be valid. <br>"
                      + "Please contact your bank server service, "
                      + "or refer to the bank server walk through document for instructions to setup your own server.");
                return false;
            }
        );
    }

    //error handler
    function goError(message) {
        var /*@override*/ item = {
            content: message
        };
        WinJS.Navigation.navigate('/html/error.html', { item: item });
    }
})();
