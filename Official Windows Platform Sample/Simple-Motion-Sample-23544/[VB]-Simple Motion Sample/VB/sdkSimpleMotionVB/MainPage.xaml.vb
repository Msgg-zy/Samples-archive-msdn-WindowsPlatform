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
Imports Microsoft.Devices.Sensors
Imports Microsoft.Xna.Framework


Partial Public Class MainPage
    Inherits PhoneApplicationPage
    Private motion As Motion

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        ' Check to see if the Motion API is supported on the device.
        If Not motion.IsSupported Then
            MessageBox.Show("the Motion API is not supported on this device.")
            Return
        End If

        ' If the Motion object is null, initialize it and add a CurrentValueChanged
        ' event handler.
        If motion Is Nothing Then
            motion = New Motion()
            motion.TimeBetweenUpdates = TimeSpan.FromMilliseconds(20)
            AddHandler motion.CurrentValueChanged, AddressOf motion_CurrentValueChanged
        End If

        ' Try to start the Motion API.
        Try
            motion.Start()
        Catch e1 As Exception
            MessageBox.Show("unable to start the Motion API.")
        End Try
    End Sub

    Private Sub motion_CurrentValueChanged(ByVal sender As Object, ByVal e As SensorReadingEventArgs(Of MotionReading))
        ' This event arrives on a background thread. Use BeginInvoke to call
        ' CurrentValueChanged on the UI thread.
        Dispatcher.BeginInvoke(Sub() CurrentValueChanged(e.SensorReading))
    End Sub
    Private Sub CurrentValueChanged(ByVal e As MotionReading)
        If motion.IsDataValid Then
            ' Show the numeric values for attitude
            yawTextBlock.Text = "YAW: " & MathHelper.ToDegrees(e.Attitude.Yaw).ToString("0") & "°"
            pitchTextBlock.Text = "PITCH: " & MathHelper.ToDegrees(e.Attitude.Pitch).ToString("0") & "°"
            rollTextBlock.Text = "ROLL: " & MathHelper.ToDegrees(e.Attitude.Roll).ToString("0") & "°"

            ' Set the Angle of the triangle RenderTransforms to the attitude of the device
            CType(yawtriangle.RenderTransform, RotateTransform).Angle = MathHelper.ToDegrees(e.Attitude.Yaw)
            CType(pitchtriangle.RenderTransform, RotateTransform).Angle = MathHelper.ToDegrees(e.Attitude.Pitch)
            CType(rolltriangle.RenderTransform, RotateTransform).Angle = MathHelper.ToDegrees(e.Attitude.Roll)

            ' Show the numeric values for acceleration
            xTextBlock.Text = "X: " & e.DeviceAcceleration.X.ToString("0.00")
            yTextBlock.Text = "Y: " & e.DeviceAcceleration.Y.ToString("0.00")
            zTextBlock.Text = "Z: " & e.DeviceAcceleration.Z.ToString("0.00")

            ' Show the acceleration values graphically
            xLine.X2 = xLine.X1 + e.DeviceAcceleration.X * 100
            yLine.Y2 = yLine.Y1 - e.DeviceAcceleration.Y * 100
            zLine.X2 = zLine.X1 - e.DeviceAcceleration.Z * 50
            zLine.Y2 = zLine.Y1 + e.DeviceAcceleration.Z * 50
        End If
    End Sub
End Class
