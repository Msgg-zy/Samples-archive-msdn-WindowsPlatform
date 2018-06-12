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
Imports System.Windows.Navigation
Imports Microsoft.Phone.BackgroundAudio

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Constructor
    Public Sub New()
        InitializeComponent()
        AddHandler BackgroundAudioPlayer.Instance.PlayStateChanged, AddressOf Instance_PlayStateChanged
    End Sub


    ''' <summary>
    ''' Checks to see if the BackgroundAudioPlayer is already playing.
    ''' Initializes the UI controls accordingly.
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnNavigatedTo(ByVal e As NavigationEventArgs)
        If PlayState.Playing = BackgroundAudioPlayer.Instance.PlayerState Then
            playButton.Content = "| |" ' Change to pause button
            txtCurrentTrack.Text = BackgroundAudioPlayer.Instance.Track.Title & " by " & BackgroundAudioPlayer.Instance.Track.Artist

        Else
            playButton.Content = ">" ' Change to play button
            txtCurrentTrack.Text = ""
        End If
    End Sub


    ''' <summary>
    ''' Updates the UI with the current song data.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Instance_PlayStateChanged(ByVal sender As Object, ByVal e As EventArgs)
        Select Case BackgroundAudioPlayer.Instance.PlayerState
            Case PlayState.Playing
                playButton.Content = "| |" ' Change to pause button
                prevButton.IsEnabled = True
                nextButton.IsEnabled = True

            Case PlayState.Paused, PlayState.Stopped
                playButton.Content = ">" ' Change to play button
        End Select

        If Nothing IsNot BackgroundAudioPlayer.Instance.Track Then
            txtCurrentTrack.Text = BackgroundAudioPlayer.Instance.Track.Title & " by " & BackgroundAudioPlayer.Instance.Track.Artist
        End If
    End Sub


#Region "Button Click Event Handlers"

    ''' <summary>
    ''' Tells the background audio agent to skip to the previous track.
    ''' </summary>
    ''' <param name="sender">The button</param>
    ''' <param name="e">Click event args</param>
    Private Sub prevButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        BackgroundAudioPlayer.Instance.SkipPrevious()

        ' Prevent the user from repeatedly pressing the button and causing 
        ' a backlong of button presses to be handled. This button is re-eneabled 
        ' in the TrackReady Playstate handler.
        prevButton.IsEnabled = False
    End Sub


    ''' <summary>
    ''' Tells the background audio agent to play the current 
    ''' track or to pause if we're already playing.
    ''' </summary>
    ''' <param name="sender">The button</param>
    ''' <param name="e">Click event args</param>
    Private Sub playButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If PlayState.Playing = BackgroundAudioPlayer.Instance.PlayerState Then
            BackgroundAudioPlayer.Instance.Pause()
        Else
            BackgroundAudioPlayer.Instance.Play()
        End If

    End Sub

    ''' <summary>
    ''' Tells the background audio agent to skip to the next track.
    ''' </summary>
    ''' <param name="sender">The button</param>
    ''' <param name="e">Click event args</param>
    Private Sub nextButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        BackgroundAudioPlayer.Instance.SkipNext()

        ' Prevent the user from repeatedly pressing the button and causing 
        ' a backlong of button presses to be handled. This button is re-eneabled 
        ' in the TrackReady Playstate handler.
        nextButton.IsEnabled = False
    End Sub

#End Region ' Button Click Event Handlers
End Class
