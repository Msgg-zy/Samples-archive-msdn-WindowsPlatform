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

Partial Public Class CompassPage
    Inherits PhoneApplicationPage
    Private compass As Compass
    Private timer As DispatcherTimer

    Private magneticHeading As Double
    Private trueHeading As Double
    Private headingAccuracy As Double
    Private rawMagnetometerReading As Vector3
    Private isDataValid As Boolean

    Private calibrating As Boolean = False

    Private accelerometer As Accelerometer

    ' Constructor
    Public Sub New()
        InitializeComponent()

        Application.Current.Host.Settings.EnableFrameRateCounter = False


        If Not compass.IsSupported Then
            ' The device on which the application is running does not support
            ' the compass sensor. Alert the user and hide the
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
        If compass IsNot Nothing AndAlso compass.IsDataValid Then
            ' Stop data acquisition from the compass.
            compass.Stop()
            timer.Stop()
            statusTextBlock.Text = "compass stopped."

            ' Detect compass axis
            accelerometer.Stop()
        Else
            If compass Is Nothing Then
                ' Instantiate the compass.
                compass = New Compass()


                ' Specify the desired time between updates. The sensor accepts
                ' intervals in multiples of 20 ms.
                compass.TimeBetweenUpdates = TimeSpan.FromMilliseconds(20)

                ' The sensor may not support the requested time between updates.
                ' The TimeBetweenUpdates property reflects the actual rate.
                timeBetweenUpdatesTextBlock.Text = compass.TimeBetweenUpdates.TotalMilliseconds & " ms"


                AddHandler compass.CurrentValueChanged, AddressOf compass_CurrentValueChanged
                AddHandler compass.Calibrate, AddressOf compass_Calibrate
            End If

            Try
                statusTextBlock.Text = "starting compass."
                compass.Start()
                timer.Start()

                ' Start accelerometer for detecting compass axis
                accelerometer = New Accelerometer()
                AddHandler accelerometer.CurrentValueChanged, AddressOf accelerometer_CurrentValueChanged
                accelerometer.Start()
            Catch e1 As InvalidOperationException
                statusTextBlock.Text = "unable to start compass."
            End Try

        End If

    End Sub

    Private Sub compass_CurrentValueChanged(ByVal sender As Object, ByVal e As SensorReadingEventArgs(Of CompassReading))
        ' Note that this event handler is called from a background thread
        ' and therefore does not have access to the UI thread. To update 
        ' the UI from this handler, use Dispatcher.BeginInvoke() as shown.
        ' Dispatcher.BeginInvoke(Sub() statusTextBlock.Text = "in CurrentValueChanged")


        isDataValid = compass.IsDataValid

        trueHeading = e.SensorReading.TrueHeading
        magneticHeading = e.SensorReading.MagneticHeading
        headingAccuracy = Math.Abs(e.SensorReading.HeadingAccuracy)
        rawMagnetometerReading = e.SensorReading.MagnetometerReading

    End Sub

    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If Not calibrating Then
            If isDataValid Then
                statusTextBlock.Text = "receiving data from compass."
            End If

            ' Update the textblocks with numeric heading values
            magneticTextBlock.Text = magneticHeading.ToString("0.0")
            trueTextBlock.Text = trueHeading.ToString("0.0")
            accuracyTextBlock.Text = headingAccuracy.ToString("0.0")

            ' Update the line objects to graphically display the headings
            Dim centerX As Double = headingGrid.ActualWidth / 2.0
            Dim centerY As Double = headingGrid.ActualHeight / 2.0
            magneticLine.X2 = centerX - centerY * Math.Sin(MathHelper.ToRadians(CSng(magneticHeading)))
            magneticLine.Y2 = centerY - centerY * Math.Cos(MathHelper.ToRadians(CSng(magneticHeading)))
            trueLine.X2 = centerX - centerY * Math.Sin(MathHelper.ToRadians(CSng(trueHeading)))
            trueLine.Y2 = centerY - centerY * Math.Cos(MathHelper.ToRadians(CSng(trueHeading)))

            ' Update the textblocks with numeric raw magnetometer readings
            xTextBlock.Text = rawMagnetometerReading.X.ToString("0.00")
            yTextBlock.Text = rawMagnetometerReading.Y.ToString("0.00")
            zTextBlock.Text = rawMagnetometerReading.Z.ToString("0.00")

            ' Update the line objects to graphically display raw data
            xLine.X2 = xLine.X1 + rawMagnetometerReading.X * 4
            yLine.X2 = yLine.X1 + rawMagnetometerReading.Y * 4
            zLine.X2 = zLine.X1 + rawMagnetometerReading.Z * 4
        Else
            If headingAccuracy <= 10 Then
                calibrationTextBlock.Foreground = New SolidColorBrush(Colors.Green)
                calibrationTextBlock.Text = "Complete!"
            Else
                calibrationTextBlock.Foreground = New SolidColorBrush(Colors.Red)
                calibrationTextBlock.Text = headingAccuracy.ToString("0.0")
            End If
        End If
    End Sub

    Private Sub compass_Calibrate(ByVal sender As Object, ByVal e As CalibrationEventArgs)
        Dispatcher.BeginInvoke(Sub() calibrationStackPanel.Visibility = Visibility.Visible)
        calibrating = True

    End Sub


    Private Sub calibrationButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        calibrationStackPanel.Visibility = Visibility.Collapsed
        calibrating = False
    End Sub

    '        
    '         * Determine compass axis
    '         *
    Private Sub accelerometer_CurrentValueChanged(ByVal sender As Object, ByVal e As SensorReadingEventArgs(Of AccelerometerReading))
        Dim v As Vector3 = e.SensorReading.Acceleration

        Dim isCompassUsingNegativeZAxis As Boolean = False

        If Math.Abs(v.Z) < Math.Cos(Math.PI / 4) AndAlso (v.Y < Math.Sin(7 * Math.PI / 4)) Then
            isCompassUsingNegativeZAxis = True
        End If

        Dispatcher.BeginInvoke(Sub() orientationTextBlock.Text = If(isCompassUsingNegativeZAxis, "portrait mode", "flat mode"))
    End Sub
End Class
