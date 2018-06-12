'
'   Copyright (c) 2012 - 2013 Microsoft Corporation.  All rights reserved.
'   Use of this sample source code is subject to the terms of the Microsoft license 
'   agreement under which you licensed this sample source code and is provided AS-IS.
'   If you did not accept the terms of the license agreement, you are not authorized 
'   to use this sample source code.  For the terms of the license, please see the 
'   license agreement between you and Microsoft.
'  
'   To see all Code Samples for Windows Phone, visit http://code.msdn.microsoft.com/wpapps
'  
'
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Info


Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Constructor
    Public Sub New()
        InitializeComponent()

        ' Set up the event handlers
        AddHandler DeviceStatus.PowerSourceChanged, AddressOf DeviceStatus_PowerSourceChanged
        AddHandler DeviceStatus.KeyboardDeployedChanged, AddressOf DeviceStatus_KeyboardDeployedChanged

        ' Output initial values
        deviceManufacturerTextBlock.Text = DeviceStatus.DeviceManufacturer
        deviceNameTextBlock.Text = DeviceStatus.DeviceName
        deviceFirmwareVersionTextBlock.Text = DeviceStatus.DeviceFirmwareVersion
        deviceHardwareVersionTextBlock.Text = DeviceStatus.DeviceHardwareVersion
        deviceTotalMemoryTextBlock.Text = DeviceStatus.DeviceTotalMemory.ToString()
        appCurrentMemoryUsageTextBlock.Text = DeviceStatus.ApplicationCurrentMemoryUsage.ToString()
        appMemoryUsageLimitTextBlock.Text = DeviceStatus.ApplicationMemoryUsageLimit.ToString()
        appPeakMemoryUsageTextBlock.Text = DeviceStatus.ApplicationPeakMemoryUsage.ToString()
        isKeyboardPresentTextBlock.Text = DeviceStatus.IsKeyboardPresent.ToString()
        isKeyboardDeployedTextBlock.Text = DeviceStatus.IsKeyboardDeployed.ToString()
        powerSourceTextBlock.Text = DeviceStatus.PowerSource.ToString()
    End Sub

    Private Sub DeviceStatus_PowerSourceChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' The PowerSourceChanged event is not raised on the UI thread, 
        ' so the Dispatcher must be invoked to update the Text property.
        Me.Dispatcher.BeginInvoke(Sub() powerSourceTextBlock.Text = DeviceStatus.PowerSource.ToString())
    End Sub

    Private Sub DeviceStatus_KeyboardDeployedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' The KeyboardDeployedChanged event is not raised on the UI thread, 
        ' so the Dispatcher must be invoked to update the Text property.
        Me.Dispatcher.BeginInvoke(Sub() isKeyboardDeployedTextBlock.Text = DeviceStatus.IsKeyboardDeployed.ToString())
    End Sub
End Class
