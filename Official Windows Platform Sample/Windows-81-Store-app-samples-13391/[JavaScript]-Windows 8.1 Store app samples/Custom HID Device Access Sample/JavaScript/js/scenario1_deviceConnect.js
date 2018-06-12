﻿//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";

    var buttonNameDisconnectFromDevice = "Disconnect from device";
    var buttonNameDisableReconnectToDevice = "Do not automatically reconnect to device that was just closed";

    /// <summary>
    /// Create the DeviceWatcher object when the user navigates to this page for the first time. Since this js file never gets unloaded,
    /// events that we registered for will still call our callbacks. Before leaving this page, all events that were registered and can occur
    /// outside this page will be unregistered.
    ///
    /// To use this sample with your device:
    /// 1) Include the device in the Package.appxmanifest. For instructions, see Package.appxmanifest documentation.
    /// 2) Create a DeviceWatcher object for your device. See the InitializeDeviceWatcher method in this sample.
    /// </summary>
    var DeviceConnectClass = WinJS.Class.define(function () {
        // Initialize the desired device watchers so that we can watch for when devices are connected/removed, but
        // don't reinitialize device watchers if we already initialized them
        if (this._deviceWatchers.length === 0) {
            this._initializeDeviceWatchers();
        }
    }, {
        _listOfDevices: new WinJS.Binding.List(),
        _deviceWatchers: [],
        _watchersSuspended: false,
        _watchersStarted: false,
        _isAllDevicesEnumerated: false,
        devices: {
            get: function () {
                return this._listOfDevices;
            }
        },
        startHandlingAppEvents: function () {
            // This event is raised when the app is exited and when the app is suspended
            Windows.UI.WebUI.WebUIApplication.addEventListener("suspending", deviceConnect._onAppSuspension);

            Windows.UI.WebUI.WebUIApplication.addEventListener("resuming", deviceConnect._onAppResume);
        },
        stopHandlingAppEvents: function () {
            // This event is raised when the app is exited and when the app is suspended
            Windows.UI.WebUI.WebUIApplication.removeEventListener("suspending", deviceConnect._onAppSuspension);

            Windows.UI.WebUI.WebUIApplication.removeEventListener("resuming", deviceConnect._onAppResume);
        },
        /// <summary>
        /// Starts all device watchers including ones that have been individually stopped.
        /// </summary>
        startDeviceWatchers: function () {
            this._watchersStarted = true;
            this._isAllDevicesEnumerated = false;

            // Start all device watchers
            this._deviceWatchers.forEach(function (deviceWatcher) {
                if (deviceWatcher.status !== Windows.Devices.Enumeration.DeviceWatcherStatus.started
                    && deviceWatcher.status !== Windows.Devices.Enumeration.DeviceWatcherStatus.enumerationCompleted) {
                    deviceWatcher.start();
                }
            });
        },
        /// <summary>
        /// Stops all device watchers.
        /// </summary>
        stopDeviceWatchers: function () {
            // Stop all device watchers
            this._deviceWatchers.forEach(function (deviceWatcher) {
                // Stopping an already stopped device watcher throws an exception, so avoid it
                if (deviceWatcher.status === Windows.Devices.Enumeration.DeviceWatcherStatus.started
                    || deviceWatcher.status === Windows.Devices.Enumeration.DeviceWatcherStatus.enumerationCompleted) {
                    deviceWatcher.stop();
                }
            });

            // Clear the device list to prevent an outdated list
            this._clearDeviceEntries();

            this._watchersStarted = false;
        },
        /// <summary>
        /// Initialize device watchers to watch for the SuperMUTT.
        /// Several other ways of using a device selector to get the desired devices (the devices are really DeviceInformation objects):
        /// 1) Using only the Usage Page and the Usage Id of the device (enumerates any device with the same usage page and usage id)
        /// 2) Using the Usage Page, Usage Id, Vendor Id, Product Id (Same as above except it also matches the VIDs and PIDs)
        ///
        /// GetDeviceSelector return an AQS string that can be passed directly into DeviceWatcher.createWatcher() or  DeviceInformation.createFromIdAsync(). 
        ///
        /// In this sample, a DeviceWatcher will be used to watch for devices because we can detect surprise device removals.
        /// </summary>
        _initializeDeviceWatchers: function () {
            // SuperMutt
            var superMuttSelector = Windows.Devices.HumanInterfaceDevice.HidDevice.getDeviceSelector(
                    SdkSample.Constants.superMutt.device.usagePage,
                    SdkSample.Constants.superMutt.device.usageId,
                    SdkSample.Constants.superMutt.device.vid,
                    SdkSample.Constants.superMutt.device.pid);

            // Create a device watcher to look for instances of the SuperMUTT device
            // The createWatcher() takes a string only when you provide it two arguments, so be sure to include an array as a second 
            // parameter (JavaScript can only recognize overloaded functions with different numbers of parameters).
            var superMuttWatcher = Windows.Devices.Enumeration.DeviceInformation.createWatcher(superMuttSelector, []);

            // Allow the EventHandlerForDevice to handle device watcher events that relate to or affect our device (i.e. device removal, addition, app suspension/resume)
            this._addDeviceWatcher(superMuttWatcher, superMuttSelector);
        },
        /// <summary>
        /// Registers for Added, Removed, and Enumerated events on the provided deviceWatcher before adding it to an internal list.
        /// </summary>
        /// <param name="deviceWatcher"></param>
        /// <param name="deviceSelector">The AQS used to create the device watcher</param>
        _addDeviceWatcher: function (deviceWatcher, deviceSelector) {
            if (deviceWatcher) {
                this._deviceWatchers.push(deviceWatcher);

                deviceWatcher.addEventListener("added", function (deviceInformation) {
                    // Forward this event to a more generic event handler for added devices, but provide it with a deviceSelector that is
                    // created that device watcher
                    deviceConnect._onDeviceAdded(deviceInformation, deviceSelector);
                }, false);
                deviceWatcher.addEventListener("removed", this._onDeviceRemoved, false);
                deviceWatcher.addEventListener("enumerationcompleted", this._onDeviceEnumerationComplete, false);
            }
        },
        /// <summary>
        /// Creates a DeviceListEntry for a device and adds it to the list of devices in the UI
        /// </summary>
        /// <param name="deviceInformation">DeviceInformation on the device to be added to the list</param>
        /// <param name="deviceSelector">The AQS used to find this device</param>
        _addDeviceToList: function (deviceInformation, deviceSelector) {
            // search the device list for a device with a matching interface ID
            var match = this._findDevice(deviceInformation.id);

            // Create a new entry only if it's not in the list of devices
            if (!match) {
                // Create a new element for this device interface to be used by the UI
                match = new SdkSample.CustomHidDeviceAccess.deviceListEntry(deviceInformation, deviceSelector);

                // Add the new element to the end of the list of devices
                this._listOfDevices.push(match);
            }
        },
        _removeDeviceFromList: function (deviceId) {
            // Search the list of devices for one with a matching ID. and remove it from the list
            var deviceEntry = this._findDevice(deviceId);

            this._listOfDevices.splice(this._listOfDevices.indexOf(deviceEntry), 1);
        },
        _clearDeviceEntries: function () {
            this._listOfDevices.splice(0, this._listOfDevices.length);
        },
        /// <summary>
        /// Searches through the existing list of devices for the first DeviceListEntry that has
        /// the specified Id.
        /// </summary>
        /// <param name="deviceId">Id of the device that is being searched for</param>
        /// <returns>DeviceListEntry that has the provided Id; else a null</returns>
        _findDevice: function (deviceId) {
            if (deviceId) {
                for (var i = 0, numDeviceEntries = this._listOfDevices.length; i < numDeviceEntries; i++) {
                    if (this._listOfDevices.getAt(i).deviceInformation.id === deviceId) {
                        return this._listOfDevices.getAt(i);
                    }
                }
            }

            return null;
        },
        /// <summary>
        /// We must stop the DeviceWatchers because device watchers will continue to raise events even if
        /// the app is in suspension, which is not desired (drains battery). We resume the device watcher once the app resumes again.
        /// </summary>
        /// <param name="eventArgs"></param>
        _onAppSuspension: function (eventArgs) {
            if (deviceConnect._watchersStarted) {
                deviceConnect._watchersSuspended = true;

                deviceConnect.stopDeviceWatchers();

            } else {
                deviceConnect._watchersSuspended = false;
            }
        },
        /// <summary>
        /// See OnAppSuspension for why we are starting the device watchers again
        /// </summary>
        /// <param name="arg"></param>
        _onAppResume: function (arg) {
            if (deviceConnect._watchersSuspended) {
                deviceConnect._watchersSuspended = false;

                deviceConnect.startDeviceWatchers();
            }
        },
        /// <summary>
        /// Will remove the device from the UI
        /// </summary>
        /// <param name="deviceInformationUpdate"></param>
        _onDeviceRemoved: function (deviceInformationUpdate) {
            WinJS.log && WinJS.log(deviceInformationUpdate.id + " was removed.", "sample", "status");

            deviceConnect._removeDeviceFromList(deviceInformationUpdate.id);
        },
        /// <summary>
        /// This function will add the device to the DeviceList so that it shows up in the UI
        /// </summary>
        /// <param name="deviceInformation"></param>
        /// <param name="deviceSelector">AQS that was used to find this device</param>
        _onDeviceAdded: function (deviceInformation, deviceSelector) {
            WinJS.log && WinJS.log(deviceInformation.id + " was added.", "sample", "status");

            deviceConnect._addDeviceToList(deviceInformation, deviceSelector);
        },
        /// <summary>
        /// Notify the UI whether or not we are connected to a device
        /// </summary>
        /// <param name="args"></param>
        _onDeviceEnumerationComplete: function (args) {
            deviceConnect._isAllDevicesEnumerated = true;

            // If we finished enumerating devices and the device has not been connected yet, the OnDeviceConnected method
            // is responsible for selecting the device in the device list (UI); otherwise, this method does that.
            if (SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.isDeviceConnected) {
                selectDeviceInList(SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.deviceInformation.id);

                window.buttonDisconnectFromDevice.textContent = buttonNameDisconnectFromDevice;

                WinJS.log && WinJS.log("Currently connected to: " + SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.deviceInformation.id,
                    "sample", "status");
            } else if (SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.isEnabledAutoReconnect
                && SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.deviceInformation !== null) {
                // We will be reconnecting to a device
                window.buttonDisconnectFromDevice.textContent = buttonNameDisableReconnectToDevice;

                WinJS.log && WinJS.log("Waiting to reconnect to device: " + SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.deviceInformation.id, "sample", "status");
            } else {
                WinJS.log && WinJS.log("No devices currently selected.", "sample", "status");
            }
        },
        /// <summary>
        /// If all the devices have been enumerated, select the device in the list we connected to. Otherwise let the EnumerationComplete event
        /// from the device watcher handle the device selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="deviceInformation"></param>
        _onDeviceConnected: function (deviceInformation) {
            // Find and select our connected device
            if (deviceConnect._isAllDevicesEnumerated) {
                selectDeviceInList(SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.deviceInformation.id);

                window.buttonDisconnectFromDevice.textContent = buttonNameDisconnectFromDevice;
            }

            WinJS.log && WinJS.log("Currently connected to: " + SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.deviceInformation.id,
                "sample", "status");
        },
        /// <summary>
        /// The device was closed. If we will autoreconnect to the device, reflect that in the UI
        /// </summary>
        /// <param name="deviceInformation"></param>
        _onDeviceClosing: function (deviceInformation) {
            // We were connected to the device that was unplugged, so change the "Disconnect from device" button
            // to "Do not reconnect to device"
            if (!window.buttonDisconnectFromDevice.disabled && SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.isEnabledAutoReconnect) {
                window.buttonDisconnectFromDevice.textContent = buttonNameDisableReconnectToDevice;
            }
        }
    },
    null);

    // Will be defined when the page is initialized, otherwise we won't be able to find element
    var deviceListViewControl = null;

    // Instance of deviceConnectClass
    var deviceConnect = new DeviceConnectClass();

    // Bind the list of devices to the UI
    window.deviceList = deviceConnect.devices;

    var page = WinJS.UI.Pages.define("/html/scenario1_deviceConnect.html", {
        processed: function (element, arg) {
            // During an initial activation, this event is called before the system splash screen is torn down.
            // The arg parameter will contain device id if either is passed to navigation
            // in the activated event handler. Otherwise, arg will be null.
        },
        ready: function (element, options) {
            deviceListViewControl = document.getElementById("deviceListView").winControl;

            // If we are connected to the device or planning to reconnect, we should disable the list of devices
            // to prevent the user from opening a device without explicitly closing or disabling the auto reconnect
            if (SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.isDeviceConnected
                || (SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.isEnabledAutoReconnect
                && SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.deviceInformation)) {
                updateConnectDisconnectButtonsAndList(false);

                // These notifications will occur if we are waiting to reconnect to device when we start the page
                SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.onDeviceConnectedCallback = deviceConnect._onDeviceConnected;
                SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.onDeviceCloseCallback = deviceConnect._onDeviceClosing;
            } else {
                updateConnectDisconnectButtonsAndList(true);
            }

            // Begin watching out for events
            deviceConnect.startHandlingAppEvents();
            deviceConnect.startDeviceWatchers();

            // Button listeners
            document.getElementById("buttonConnectToDevice").addEventListener("click", connectToDeviceClick, false);
            document.getElementById("buttonDisconnectFromDevice").addEventListener("click", disconnectFromDeviceClick, false);
        },
        unload: function () {
            deviceConnect.stopDeviceWatchers();
            deviceConnect.stopHandlingAppEvents();

            // We no longer care about the device being connected
            SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.onDeviceConnectedCallback = null;
            SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.onDeviceCloseCallback = null;
        }
    });

    function connectToDeviceClick(eventArgs) {
        deviceListViewControl.selection.getItems().done(function (items) {
            if (items.length > 0) {
                // We only expect one item because we don't allow multiple selections
                var entry = items[0].data;

                // Create an EventHandlerForDevice to watch for the device we are connecting to
                SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.createNewEventHandlerForDevice();

                // Get notified when the device was successfully connected to or about to be closed
                SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.onDeviceConnectedCallback = deviceConnect._onDeviceConnected;
                SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.onDeviceCloseCallback = deviceConnect._onDeviceClosing;

                SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.openDeviceAsync(entry.deviceInformation, entry.deviceSelector).done(function (openDeviceSuccess) {
                    // Disable connect button if we connected to the device
                    updateConnectDisconnectButtonsAndList(!openDeviceSuccess);
                });
            }
        });
    }

    function disconnectFromDeviceClick(eventArgs) {
        deviceListViewControl.selection.getItems().done(function (items) {
            // Prevent auto reconnect because we are voluntarily closing it
            // Re-enable the ConnectDevice list and ConnectToDevice button if the connected/opened device was removed.
            SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.isEnabledAutoReconnect = false;

            if (items.length > 0) {
                // We only expect one item because we don't allow multiple selections
                var entry = items[0].data;

                SdkSample.CustomHidDeviceAccess.eventHandlerForDevice.current.closeDevice();
            }

            updateConnectDisconnectButtonsAndList(true);
        });

    }

    /// <summary>
    /// Selects the item in the UI's listbox that corresponds to the provided device id. If there are no
    /// matches, we will deselect anything that is selected.
    /// </summary>
    /// <param name="deviceIdToSelect">The device id of the device to select on the list box</param>
    function selectDeviceInList(deviceIdToSelect) {
        deviceListViewControl.selection.set(-1);

        for (var i = 0, numDevices = deviceConnect.devices.length; i < numDevices; i++) {
            if (deviceConnect.devices.getAt(i).deviceInformation.id === deviceIdToSelect) {
                deviceListViewControl.selection.set(i);

                break;
            }
        }
    }

    /// <summary>
    /// When ButtonConnectToDevice is disabled, ConnectDevices list will also be disabled.
    /// </summary>
    /// <param name="enableConnectButton">The state of ButtonConnectToDevice</param>
    function updateConnectDisconnectButtonsAndList(enableConnectButton) {
        window.buttonConnectToDevice.disabled = !enableConnectButton;
        window.buttonDisconnectFromDevice.disabled = !window.buttonConnectToDevice.disabled;

        if (window.buttonConnectToDevice.disabled) {
            deviceListViewControl.tapBehavior = WinJS.UI.TapBehavior.none;
            deviceListViewControl.selectionMode = WinJS.UI.SelectionMode.none;
        } else {
            deviceListViewControl.tapBehavior = WinJS.UI.TapBehavior.directSelect;
            deviceListViewControl.selectionMode = WinJS.UI.SelectionMode.single;
        }
    }

    WinJS.Namespace.define(SdkSample.Constants.sampleNamespace, {
        deviceConnect: deviceConnect
    });
})();
