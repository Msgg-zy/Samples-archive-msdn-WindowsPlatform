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
Partial Public Class MainPage
    Inherits PhoneApplicationPage
    Private SampleTileSchedule As New ShellTileSchedule()
    Private TileScheduleRunning As Boolean = False

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' Update the tile image one time only
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonOneTime_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        SampleTileSchedule.Recurrence = UpdateRecurrence.Onetime
        SampleTileSchedule.StartTime = Date.Now
        SampleTileSchedule.RemoteImageUri = New Uri("http://www.weather.gov/forecasts/graphical/images/conus/MaxT1_conus.png")
        SampleTileSchedule.Start()
        TileScheduleRunning = True
    End Sub

    ''' <summary>
    ''' Update the tile image for an indefinite period of time
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonIndefinite_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        SampleTileSchedule.Interval = UpdateInterval.EveryHour
        SampleTileSchedule.Recurrence = UpdateRecurrence.Interval
        SampleTileSchedule.RemoteImageUri = New Uri("http://www.weather.gov/forecasts/graphical/images/conus/MaxT1_conus.png")
        SampleTileSchedule.Start()
        TileScheduleRunning = True
    End Sub

    ''' <summary>
    ''' Update the tile image for a defined number of times
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonDefined_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        SampleTileSchedule.Interval = UpdateInterval.EveryHour
        SampleTileSchedule.MaxUpdateCount = 50
        SampleTileSchedule.Recurrence = UpdateRecurrence.Interval
        SampleTileSchedule.RemoteImageUri = New Uri("http://www.weather.gov/forecasts/graphical/images/conus/MaxT1_conus.png")
        SampleTileSchedule.Start()
        TileScheduleRunning = True
    End Sub

    ''' <summary>
    ''' Stop the updating of the tile image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonStop_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Attach to a shell schedule by starting it.
        If Not TileScheduleRunning Then
            buttonIndefinite_Click(sender, e)
        End If

        SampleTileSchedule.Stop()
        TileScheduleRunning = False
    End Sub

End Class
