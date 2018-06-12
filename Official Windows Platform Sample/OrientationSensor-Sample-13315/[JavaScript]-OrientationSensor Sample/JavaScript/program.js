//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

/// <reference path="base-sdk.js" />

(function () {
    var orientationSensor;

    function id(elementId) {
        return document.getElementById(elementId); 
    }

    function onDataChanged(e) {
        var reading = e.reading;

        id('eventOutputQuaternion').innerHTML =
               "W: " + reading.quaternion.w.toFixed(6)
            + " X: " + reading.quaternion.x.toFixed(6)
            + " Y: " + reading.quaternion.y.toFixed(6)
            + " Z: " + reading.quaternion.z.toFixed(6);

        id('eventOutputRotationMatrix').innerHTML =
               "M11: " + reading.rotationMatrix.m11.toFixed(6)
            + " M12: " + reading.rotationMatrix.m12.toFixed(6)
            + " M13: " + reading.rotationMatrix.m13.toFixed(6)
            + " M21: " + reading.rotationMatrix.m21.toFixed(6)
            + " M22: " + reading.rotationMatrix.m22.toFixed(6)
            + " M23: " + reading.rotationMatrix.m23.toFixed(6)
            + " M31: " + reading.rotationMatrix.m31.toFixed(6)
            + " M32: " + reading.rotationMatrix.m32.toFixed(6)
            + " M33: " + reading.rotationMatrix.m33.toFixed(6);
    }

    function resetAll() {
        if (orientationSensor) {
            if (id("scenario1Open").disabled) {
                orientationSensor.removeEventListener("readingchanged", onDataChanged);
                id("scenario1Open").disabled = false;
                id("scenario1Revoke").disabled = true;
            }
        }
    }

    function enableReadingChangedScenario() {
        if (orientationSensor) {
            orientationSensor.addEventListener("readingchanged", onDataChanged);
            id("scenario1Open").disabled = true;
            id("scenario1Revoke").disabled = false;
        } else {
            sdkSample.displayError("No orientation sensor found");
        }
    }

    function disableReadingChangedScenario() {
        orientationSensor.removeEventListener("readingchanged", onDataChanged);
        id("scenario1Open").disabled = false;
        id("scenario1Revoke").disabled = true;
    }

    function invokeGetReadingScenario() {
        if (orientationSensor) {
            var reading = orientationSensor.getCurrentReading();

            id('readingOutputQuaternion').innerHTML =
                   "W: " + reading.quaternion.w.toFixed(6)
                + " X: " + reading.quaternion.x.toFixed(6)
                + " Y: " + reading.quaternion.y.toFixed(6)
                + " Z: " + reading.quaternion.z.toFixed(6);

            id('readingOutputRotationMatrix').innerHTML =
                   "M11: " + reading.rotationMatrix.m11.toFixed(6)
                + " M12: " + reading.rotationMatrix.m12.toFixed(6)
                + " M13: " + reading.rotationMatrix.m13.toFixed(6)
                + " M21: " + reading.rotationMatrix.m21.toFixed(6)
                + " M22: " + reading.rotationMatrix.m22.toFixed(6)
                + " M23: " + reading.rotationMatrix.m23.toFixed(6)
                + " M31: " + reading.rotationMatrix.m31.toFixed(6)
                + " M32: " + reading.rotationMatrix.m32.toFixed(6)
                + " M33: " + reading.rotationMatrix.m33.toFixed(6);
        } else {
            sdkSample.displayError("No orientation sensor found");
        }
    }

    function initialize() {
        id("scenario1Open").addEventListener("click", enableReadingChangedScenario, false);
        id("scenario1Revoke").addEventListener("click", disableReadingChangedScenario, false);
        id("scenario1Open").disabled = false;
        id("scenario1Revoke").disabled = true;
        id("scenario2Get").addEventListener("click", invokeGetReadingScenario, false);
        id("scenarios").addEventListener("change", resetAll, false);

        orientationSensor = Windows.Devices.Sensors.OrientationSensor.getDefault();
    }
    
    document.addEventListener("DOMContentLoaded", initialize, false);
})();