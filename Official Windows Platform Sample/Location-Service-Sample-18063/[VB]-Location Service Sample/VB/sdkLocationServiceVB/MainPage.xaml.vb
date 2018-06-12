'
'   Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
'   Use of this sample source code is subject to the terms of the Microsoft license 
'   agreement under which you licensed this sample source code and is provided AS-IS.
'   If you did not accept the terms of the license agreement, you are not authorized 
'   to use this sample source code.  For the terms of the license, please see the 
'   license agreement between you and Microsoft.
'  
'   To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
'  
'
Imports System.Device.Location

    Partial Public Class MainPage
        Inherits PhoneApplicationPage
        ''' <summary>
        ''' This sample receives data from the Location Service and displays the geographic coordinates of the device.
        ''' </summary>

        Private watcher As GeoCoordinateWatcher
        Private accuracyText As String = ""

#Region "Initialization"

        ''' <summary>
        ''' Constructor for the PhoneApplicationPage object
        ''' </summary>
        Public Sub New()
            InitializeComponent()
        End Sub

#End Region

#Region "User Interface"

        ''' <summary>
        ''' Click event handler for the low accuracy button
        ''' </summary>
        ''' <param name="sender">The control that raised the event</param>
        ''' <param name="e">An EventArgs object containing event data.</param>
        Private Sub LowButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            ' Start data acquisition from the Location Service, low accuracy
            accuracyText = "default accuracy"
            StartLocationService(GeoPositionAccuracy.Default)
        End Sub

        ''' <summary>
        ''' Click event handler for the high accuracy button
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub HighButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            ' Start data acquisition from the Location Service, high accuracy
            accuracyText = "high accuracy"
            StartLocationService(GeoPositionAccuracy.High)
        End Sub
        Private Sub StopButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            If watcher IsNot Nothing Then
                watcher.Stop()
            End If
            StatusTextBlock.Text = "location service is off"
            LatitudeTextBlock.Text = " "
            LongitudeTextBlock.Text = " "
        End Sub

#End Region

#Region "Application logic"

        ''' <summary>
        ''' Helper method to start up the location data acquisition
        ''' </summary>
        ''' <param name="accuracy">The accuracy level </param>
        Private Sub StartLocationService(ByVal accuracy As GeoPositionAccuracy)
            ' Reinitialize the GeoCoordinateWatcher
            StatusTextBlock.Text = "starting, " & accuracyText
            watcher = New GeoCoordinateWatcher(accuracy)
            watcher.MovementThreshold = 20

            ' Add event handlers for StatusChanged and PositionChanged events
            AddHandler watcher.StatusChanged, AddressOf watcher_StatusChanged
            AddHandler watcher.PositionChanged, AddressOf watcher_PositionChanged

            ' Start data acquisition
            watcher.Start()
        End Sub

        ''' <summary>
        ''' Handler for the StatusChanged event. This invokes MyStatusChanged on the UI thread and
        ''' passes the GeoPositionStatusChangedEventArgs
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub watcher_StatusChanged(ByVal sender As Object, ByVal e As GeoPositionStatusChangedEventArgs)
            Deployment.Current.Dispatcher.BeginInvoke(Sub() MyStatusChanged(e))

        End Sub
        ''' <summary>
        ''' Custom method called from the StatusChanged event handler
        ''' </summary>
        ''' <param name="e"></param>
        Private Sub MyStatusChanged(ByVal e As GeoPositionStatusChangedEventArgs)
            Select Case e.Status
                Case GeoPositionStatus.Disabled
                    ' The location service is disabled or unsupported.
                    ' Alert the user
                    StatusTextBlock.Text = "location is unsupported on this device"
                Case GeoPositionStatus.Initializing
                    ' The location service is initializing.
                    ' Disable the Start Location button
                    StatusTextBlock.Text = "initializing location service," & accuracyText
                Case GeoPositionStatus.NoData
                    ' The location service is working, but it cannot get location data
                    ' Alert the user and enable the Stop Location button
                    StatusTextBlock.Text = "data unavailable," & accuracyText
                Case GeoPositionStatus.Ready
                    ' The location service is working and is receiving location data
                    ' Show the current position and enable the Stop Location button
                    StatusTextBlock.Text = "receiving data, " & accuracyText

            End Select
        End Sub

        ''' <summary>
        ''' Handler for the PositionChanged event. This invokes MyStatusChanged on the UI thread and
        ''' passes the GeoPositionStatusChangedEventArgs
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub watcher_PositionChanged(ByVal sender As Object, ByVal e As GeoPositionChangedEventArgs(Of GeoCoordinate))
            Deployment.Current.Dispatcher.BeginInvoke(Sub() MyPositionChanged(e))
        End Sub

        ''' <summary>
        ''' Custom method called from the PositionChanged event handler
        ''' </summary>
        ''' <param name="e"></param>
        Private Sub MyPositionChanged(ByVal e As GeoPositionChangedEventArgs(Of GeoCoordinate))
            ' Update the TextBlocks to show the current location
            LatitudeTextBlock.Text = e.Position.Location.Latitude.ToString("0.000")
            LongitudeTextBlock.Text = e.Position.Location.Longitude.ToString("0.000")
        End Sub

#End Region
    End Class
