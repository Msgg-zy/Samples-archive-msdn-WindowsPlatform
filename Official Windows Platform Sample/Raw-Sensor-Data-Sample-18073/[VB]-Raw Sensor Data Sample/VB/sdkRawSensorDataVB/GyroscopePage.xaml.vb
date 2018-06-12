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


Partial Public Class GyroscopePage
    Inherits PhoneApplicationPage
    Private gyroscope As Gyroscope
    Private timer As DispatcherTimer

    Private currentRotationRate As Vector3 = Vector3.Zero
    Private cumulativeRotation As Vector3 = Vector3.Zero
    Private lastUpdateTime As DateTimeOffset = DateTimeOffset.MinValue
    Private isDataValid As Boolean

    ' Constructor
    Public Sub New()
        InitializeComponent()

        Application.Current.Host.Settings.EnableFrameRateCounter = False

        If Not gyroscope.IsSupported Then
            ' The device on which the application is running does not support
            ' the gyroscope sensor. Alert the user and hide the
            ' application bar.
            statusTextBlock.Text = "device does not support gyroscope"
            ApplicationBar.IsVisible = False
        Else
            ' Initialize the timer and add Tick event handler, but don't start it yet.
            timer = New DispatcherTimer()
            timer.Interval = TimeSpan.FromMilliseconds(60)
            AddHandler timer.Tick, AddressOf timer_Tick
        End If
    End Sub


    Private Sub ApplicationBarIconButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        If gyroscope IsNot Nothing AndAlso gyroscope.IsDataValid Then
            ' Stop data acquisition from the gyroscope.
            gyroscope.Stop()
            timer.Stop()
            statusTextBlock.Text = "gyroscope stopped."
        Else
            If gyroscope Is Nothing Then
                ' Instantiate the Gyroscope.
                gyroscope = New Gyroscope()

                ' Specify the desired time between updates. The sensor accepts
                ' intervals in multiples of 20 ms.
                gyroscope.TimeBetweenUpdates = TimeSpan.FromMilliseconds(20)

                ' The sensor may not support the requested time between updates.
                ' The TimeBetweenUpdates property reflects the actual rate.
                timeBetweenUpdatesTextBlock.Text = "time between updates: " & gyroscope.TimeBetweenUpdates.TotalMilliseconds & " ms"


                AddHandler gyroscope.CurrentValueChanged, AddressOf gyroscope_CurrentValueChanged
            End If

            Try
                statusTextBlock.Text = "starting gyroscope."
                gyroscope.Start()
                timer.Start()
            Catch e1 As InvalidOperationException
                statusTextBlock.Text = "unable to start gyroscope."
            End Try

        End If

    End Sub

    Private Sub gyroscope_CurrentValueChanged(ByVal sender As Object, ByVal e As SensorReadingEventArgs(Of GyroscopeReading))
        ' Note that this event handler is called from a background thread
        ' and therefore does not have access to the UI thread. To update 
        ' the UI from this handler, use Dispatcher.BeginInvoke() as shown.
        ' Dispatcher.BeginInvoke(Sub() statusTextBlock.Text = "in CurrentValueChanged")


        isDataValid = gyroscope.IsDataValid


        If lastUpdateTime.Equals(DateTimeOffset.MinValue) Then
            ' If this is the first time CurrentValueChanged was raised,
            ' only update the lastUpdateTime variable.
            lastUpdateTime = e.SensorReading.Timestamp
        Else
            ' Get the current rotation rate. This value is in 
            ' radians per second.
            currentRotationRate = e.SensorReading.RotationRate


            ' Subtract the previous timestamp from the current one
            ' to determine the time between readings
            Dim timeSinceLastUpdate As TimeSpan = e.SensorReading.Timestamp - lastUpdateTime

            ' Obtain the amount the device rotated since the last update
            ' by multiplying by the rotation rate by the time since the last update.
            ' (radians/second) * secondsSinceLastReading = radiansSinceLastReading
            cumulativeRotation += currentRotationRate * CSng(timeSinceLastUpdate.TotalSeconds)

            lastUpdateTime = e.SensorReading.Timestamp

        End If
    End Sub

    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If isDataValid Then
            statusTextBlock.Text = "receiving data from gyroscope."
        End If

        currentXTextBlock.Text = currentRotationRate.X.ToString("0.000")
        currentYTextBlock.Text = currentRotationRate.Y.ToString("0.000")
        currentZTextBlock.Text = currentRotationRate.Z.ToString("0.000")

        cumulativeXTextBlock.Text = MathHelper.ToDegrees(cumulativeRotation.X).ToString("0.00")
        cumulativeYTextBlock.Text = MathHelper.ToDegrees(cumulativeRotation.Y).ToString("0.00")
        cumulativeZTextBlock.Text = MathHelper.ToDegrees(cumulativeRotation.Z).ToString("0.00")


        Dim centerX As Double = cumulativeGrid.ActualWidth / 2.0
        Dim centerY As Double = cumulativeGrid.ActualHeight / 2.0

        currentXLine.X2 = centerX + currentRotationRate.X * 100
        currentYLine.X2 = centerX + currentRotationRate.Y * 100
        currentZLine.X2 = centerX + currentRotationRate.Z * 100

        cumulativeXLine.X2 = centerX - centerY * Math.Sin(cumulativeRotation.X)
        cumulativeXLine.Y2 = centerY - centerY * Math.Cos(cumulativeRotation.X)
        cumulativeYLine.X2 = centerX - centerY * Math.Sin(cumulativeRotation.Y)
        cumulativeYLine.Y2 = centerY - centerY * Math.Cos(cumulativeRotation.Y)
        cumulativeZLine.X2 = centerX - centerY * Math.Sin(cumulativeRotation.Z)
        cumulativeZLine.Y2 = centerY - centerY * Math.Cos(cumulativeRotation.Z)
    End Sub
End Class
