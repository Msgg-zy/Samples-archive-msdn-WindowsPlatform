' 
'    Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
'    Use of this sample source code is subject to the terms of the Microsoft license 
'    agreement under which you licensed this sample source code and is provided AS-IS.
'    If you did not accept the terms of the license agreement, you are not authorized 
'    to use this sample source code.  For the terms of the license, please see the 
'    license agreement between you and Microsoft.
'  
'    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
'  
'
Imports Microsoft.Devices.Sensors
Imports Microsoft.Xna.Framework
Imports System.Windows.Threading


Partial Public Class AccelerometerPage
    Inherits PhoneApplicationPage
    Private accelerometer As Accelerometer
    Private timer As DispatcherTimer
    Private acceleration As Vector3
    Private isDataValid As Boolean

    Public Sub New()
        InitializeComponent()

        If Not accelerometer.IsSupported Then
            ' The device on which the application is running does not support
            ' the accelerometer sensor. Alert the user and hide the
            ' application bar.
            statusTextBlock.Text = "device does not support compass"
            ApplicationBar.IsVisible = False
        Else
            ' Initialize the timer and add Tick event handler, but don't start it yet.
            timer = New DispatcherTimer()
            timer.Interval = TimeSpan.FromMilliseconds(30)
            AddHandler timer.Tick, AddressOf timer_Tick
        End If
    End Sub

    Private Sub ApplicationBarIconButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        If accelerometer IsNot Nothing AndAlso accelerometer.IsDataValid Then
            ' Stop data acquisition from the accelerometer.
            accelerometer.Stop()
            timer.Stop()
            statusTextBlock.Text = "accelerometer stopped."

        Else
            If accelerometer Is Nothing Then
                ' Instantiate the accelerometer.
                accelerometer = New Accelerometer()


                ' Specify the desired time between updates. The sensor accepts
                ' intervals in multiples of 20 ms.
                accelerometer.TimeBetweenUpdates = TimeSpan.FromMilliseconds(20)

                ' The sensor may not support the requested time between updates.
                ' The TimeBetweenUpdates property reflects the actual rate.
                timeBetweenUpdatesTextBlock.Text = accelerometer.TimeBetweenUpdates.TotalMilliseconds & " ms"


                AddHandler accelerometer.CurrentValueChanged, AddressOf accelerometer_CurrentValueChanged
            End If

            Try
                statusTextBlock.Text = "starting accelerometer."
                accelerometer.Start()
                timer.Start()
            Catch e1 As InvalidOperationException
                statusTextBlock.Text = "unable to start accelerometer."
            End Try

        End If

    End Sub

    Private Sub accelerometer_CurrentValueChanged(ByVal sender As Object, ByVal e As SensorReadingEventArgs(Of AccelerometerReading))
        ' Note that this event handler is called from a background thread
        ' and therefore does not have access to the UI thread. To update 
        ' the UI from this handler, use Dispatcher.BeginInvoke() as shown.
        ' Dispatcher.BeginInvoke(Sub() statusTextBlock.Text = "in CurrentValueChanged")


        isDataValid = accelerometer.IsDataValid

        acceleration = e.SensorReading.Acceleration
    End Sub

    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If isDataValid Then
            statusTextBlock.Text = "receiving data from accelerometer."

            ' Show the numeric values
            xTextBlock.Text = "X: " & acceleration.X.ToString("0.00")
            yTextBlock.Text = "Y: " & acceleration.Y.ToString("0.00")
            zTextBlock.Text = "Z: " & acceleration.Z.ToString("0.00")

            ' Show the values graphically
            xLine.X2 = xLine.X1 + acceleration.X * 100
            yLine.Y2 = yLine.Y1 - acceleration.Y * 100
            zLine.X2 = zLine.X1 - acceleration.Z * 50
            zLine.Y2 = zLine.Y1 + acceleration.Z * 50
        End If
    End Sub
End Class
