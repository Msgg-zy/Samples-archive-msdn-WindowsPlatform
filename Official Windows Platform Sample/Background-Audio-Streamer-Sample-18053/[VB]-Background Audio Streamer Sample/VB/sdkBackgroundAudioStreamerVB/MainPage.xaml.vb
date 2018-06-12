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
Imports System.Windows.Threading
Imports Microsoft.Phone.BackgroundAudio


Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Timer for updating the UI
    Private _timer As DispatcherTimer

    ' Indexes into the array of ApplicationBar.Buttons
    Private Const prevButton As Integer = 0
    Private Const playButton As Integer = 1
    Private Const pauseButton As Integer = 2
    Private Const nextButton As Integer = 3


    ' Constructor
    Public Sub New()
        InitializeComponent()
        AddHandler Loaded, AddressOf MainPage_Loaded
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Initialize a timer to update the UI every half-second.
        _timer = New DispatcherTimer()
        _timer.Interval = TimeSpan.FromSeconds(0.5)
        AddHandler _timer.Tick, AddressOf UpdateState

        AddHandler BackgroundAudioPlayer.Instance.PlayStateChanged, AddressOf Instance_PlayStateChanged

        If BackgroundAudioPlayer.Instance.PlayerState = PlayState.Playing Then
            ' If audio was already playing when the app was launched, update the UI.
            positionIndicator.IsIndeterminate = False
            positionIndicator.Maximum = BackgroundAudioPlayer.Instance.Track.Duration.TotalSeconds
            UpdateButtons(True, False, True, True)
            UpdateState(Nothing, Nothing)
        End If
    End Sub


    ''' <summary>
    ''' PlayStateChanged event handler.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Instance_PlayStateChanged(ByVal sender As Object, ByVal e As EventArgs)
        Select Case BackgroundAudioPlayer.Instance.PlayerState
            Case PlayState.Playing
                ' Update the UI.
                positionIndicator.IsIndeterminate = False
                positionIndicator.Maximum = BackgroundAudioPlayer.Instance.Track.Duration.TotalSeconds
                UpdateButtons(True, False, True, True)
                UpdateState(Nothing, Nothing)

                ' Start the timer for updating the UI.
                _timer.Start()

            Case PlayState.Paused
                ' Update the UI.
                UpdateButtons(True, True, False, True)
                UpdateState(Nothing, Nothing)

                ' Stop the timer for updating the UI.
                _timer.Stop()
        End Select
    End Sub


    ''' <summary>
    ''' Helper method to update the state of the ApplicationBar.Buttons
    ''' </summary>
    ''' <param name="prevBtnEnabled"></param>
    ''' <param name="playBtnEnabled"></param>
    ''' <param name="pauseBtnEnabled"></param>
    ''' <param name="nextBtnEnabled"></param>
    Private Sub UpdateButtons(ByVal prevBtnEnabled As Boolean, ByVal playBtnEnabled As Boolean, ByVal pauseBtnEnabled As Boolean, ByVal nextBtnEnabled As Boolean)
        ' Set the IsEnabled state of the ApplicationBar.Buttons array
        CType(ApplicationBar.Buttons(prevButton), ApplicationBarIconButton).IsEnabled = prevBtnEnabled
        CType(ApplicationBar.Buttons(playButton), ApplicationBarIconButton).IsEnabled = playBtnEnabled
        CType(ApplicationBar.Buttons(pauseButton), ApplicationBarIconButton).IsEnabled = pauseBtnEnabled
        CType(ApplicationBar.Buttons(nextButton), ApplicationBarIconButton).IsEnabled = nextBtnEnabled
    End Sub


    ''' <summary>
    ''' Updates the status indicators including the State, Track title, 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateState(ByVal sender As Object, ByVal e As EventArgs)
        txtState.Text = String.Format("State: {0}", BackgroundAudioPlayer.Instance.PlayerState)

        If BackgroundAudioPlayer.Instance.Track IsNot Nothing Then
            txtTrack.Text = String.Format("Track: {0}", BackgroundAudioPlayer.Instance.Track.Title)

            ' Set the current position on the ProgressBar.
            positionIndicator.Value = BackgroundAudioPlayer.Instance.Position.TotalSeconds

            ' Update the current playback position.
            Dim position As New TimeSpan
            position = BackgroundAudioPlayer.Instance.Position
            textPosition.Text = String.Format("{0:d2}:{1:d2}:{2:d2}", position.Hours, position.Minutes, position.Seconds)

            ' Update the time remaining digits.
            Dim timeRemaining As New TimeSpan
            timeRemaining = BackgroundAudioPlayer.Instance.Track.Duration - position
            textRemaining.Text = String.Format("-{0:d2}:{1:d2}:{2:d2}", timeRemaining.Hours, timeRemaining.Minutes, timeRemaining.Seconds)
        End If
    End Sub


    ''' <summary>
    ''' Click handler for the Skip Previous button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub prevButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Show the indeterminate progress bar.
        positionIndicator.IsIndeterminate = True

        ' Disable the button so the user can't click it multiple times before 
        ' the background audio agent is able to handle their request.
        CType(ApplicationBar.Buttons(prevButton), ApplicationBarIconButton).IsEnabled = False

        ' Tell the backgound audio agent to skip to the previous track.
        BackgroundAudioPlayer.Instance.SkipPrevious()
    End Sub


    ''' <summary>
    ''' Click handler for the Play button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub playButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Tell the backgound audio agent to play the current track.
        BackgroundAudioPlayer.Instance.Play()
    End Sub


    ''' <summary>
    ''' Click handler for the Pause button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pauseButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Tell the backgound audio agent to pause the current track.
        BackgroundAudioPlayer.Instance.Pause()
    End Sub


    ''' <summary>
    ''' Click handler for the Skip Next button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub nextButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Show the indeterminate progress bar.
        positionIndicator.IsIndeterminate = True

        ' Disable the button so the user can't click it multiple times before 
        ' the background audio agent is able to handle their request.
        CType(ApplicationBar.Buttons(nextButton), ApplicationBarIconButton).IsEnabled = False

        ' Tell the backgound audio agent to skip to the next track.
        BackgroundAudioPlayer.Instance.SkipNext()
    End Sub
End Class
