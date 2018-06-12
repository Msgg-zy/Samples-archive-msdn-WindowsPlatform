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
Imports Microsoft.Phone.BackgroundAudio
Imports System.Collections.Generic

Public Class AudioPlayer
    Inherits AudioPlayerAgent
    Private Shared _classInitialized As Boolean

    ' What's the current track?
    Private Shared currentTrackNumber As Integer = 0

    ' A playlist made up of AudioTrack items.
    Private Shared _playList As New List(Of AudioTrack)() From {
        New AudioTrack(
            New Uri("Ring01.wma", UriKind.Relative), "Ringtone 1", "Windows Phone", "Windows Phone Ringtones",
            New Uri("shared/media/Ring01.jpg", UriKind.Relative)),
        New AudioTrack(
            New Uri("Ring02.wma", UriKind.Relative),
            "Ringtone 2", "Windows Phone", "Windows Phone Ringtones",
            New Uri("shared/media/Ring02.jpg", UriKind.Relative)),
        New AudioTrack(
            New Uri("Ring03.wma", UriKind.Relative),
            "Ringtone 3", "Windows Phone", "Windows Phone Ringtones",
            New Uri("shared/media/Ring03.jpg", UriKind.Relative)),
        New AudioTrack(
            New Uri("http://traffic.libsyn.com/wpradio/WPRadio_29.mp3", UriKind.Absolute),
            "Episode 29", "Windows Phone Radio",
            "Windows Phone Radio Podcast",
            New Uri("shared/media/Episode29.jpg", UriKind.Relative))}
    ' A remote URI


    ''' <remarks>
    ''' AudioPlayer instances can share the same process. 
    ''' Static fields can be used to share state between AudioPlayer instances
    ''' or to communicate with the Audio Streaming agent.
    ''' </remarks>
    Public Sub New()
        If Not _classInitialized Then
            _classInitialized = True
            ' Subscribe to the managed exception handler
            Deployment.Current.Dispatcher.BeginInvoke(Sub() AddHandler Application.Current.UnhandledException, AddressOf AudioPlayer_UnhandledException)
        End If
    End Sub

    ''' Code to execute on Unhandled Exceptions
    Private Sub AudioPlayer_UnhandledException(ByVal sender As Object, ByVal e As ApplicationUnhandledExceptionEventArgs)
        If System.Diagnostics.Debugger.IsAttached Then
            ' An unhandled exception has occurred; break into the debugger
            System.Diagnostics.Debugger.Break()
        End If
    End Sub


    ''' <summary>
    ''' Increments the currentTrackNumber and plays the correpsonding track.
    ''' </summary>
    ''' <param name="player">The BackgroundAudioPlayer</param>
    Private Sub PlayNextTrack(ByVal player As BackgroundAudioPlayer)
        currentTrackNumber += 1
        If currentTrackNumber >= _playList.Count Then
            currentTrackNumber = 0
        End If

        PlayTrack(player)
    End Sub


    ''' <summary>
    ''' Decrements the currentTrackNumber and plays the correpsonding track.
    ''' </summary>
    ''' <param name="player">The BackgroundAudioPlayer</param>
    Private Sub PlayPreviousTrack(ByVal player As BackgroundAudioPlayer)
        currentTrackNumber -= 1
        If currentTrackNumber < 0 Then
            currentTrackNumber = _playList.Count - 1
        End If

        PlayTrack(player)
    End Sub


    ''' <summary>
    ''' Plays the track in our playlist at the currentTrackNumber position.
    ''' </summary>
    ''' <param name="player">The BackgroundAudioPlayer</param>
    Private Sub PlayTrack(player As BackgroundAudioPlayer)
        If (player.Track Is Nothing) OrElse (player.Track.Title <> _playList(currentTrackNumber).Title) Then
            ' If it's a new track, set the track
            player.Track = _playList(currentTrackNumber)
        End If

        ' Play it
        If (player.Track IsNot Nothing) AndAlso (player.PlayerState <> PlayState.Playing) Then
            player.Play()
        End If

    End Sub


    ''' <summary>
    ''' Called when the playstate changes, except for the Error state (see OnError)
    ''' </summary>
    ''' <param name="player">The BackgroundAudioPlayer</param>
    ''' <param name="track">The track playing at the time the playstate changed</param>
    ''' <param name="playState">The new playstate of the player</param>
    ''' <remarks>
    ''' Play State changes cannot be cancelled. They are raised even if the application
    ''' caused the state change itself, assuming the application has opted-in to the callback.
    ''' 
    ''' Notable playstate events: 
    ''' (a) TrackEnded: invoked when the player has no current track. The agent can set the next track.
    ''' (b) TrackReady: an audio track has been set and it is now ready for playack.
    ''' 
    ''' Call NotifyComplete() only once, after the agent request has been completed, including async callbacks.
    ''' </remarks>
    Protected Overrides Sub OnPlayStateChanged(ByVal player As BackgroundAudioPlayer, ByVal track As AudioTrack, ByVal playState As PlayState)
        Select Case playState
            Case playState.TrackEnded
                PlayNextTrack(player)
        End Select

        NotifyComplete()
    End Sub


    ''' <summary>
    ''' Called when the user requests an action using application/system provided UI
    ''' </summary>
    ''' <param name="player">The BackgroundAudioPlayer</param>
    ''' <param name="track">The track playing at the time of the user action</param>
    ''' <param name="action">The action the user has requested</param>
    ''' <param name="param">The data associated with the requested action.
    ''' In the current version this parameter is only for use with the Seek action,
    ''' to indicate the requested position of an audio track</param>
    ''' <remarks>
    ''' User actions do not automatically make any changes in system state; the agent is responsible
    ''' for carrying out the user actions if they are supported.
    ''' 
    ''' Call NotifyComplete() only once, after the agent request has been completed, including async callbacks.
    ''' </remarks>
    Protected Overrides Sub OnUserAction(ByVal player As BackgroundAudioPlayer, ByVal track As AudioTrack, ByVal action As UserAction, ByVal param As Object)
        Select Case action
            Case UserAction.Play
                PlayTrack(player)

            Case UserAction.Pause
                If PlayState.Playing = player.PlayerState Then
                    player.Pause()
                End If

            Case UserAction.SkipPrevious
                PlayPreviousTrack(player)

            Case UserAction.SkipNext
                PlayNextTrack(player)
        End Select

        NotifyComplete()
    End Sub


    ''' <summary>
    ''' Called whenever there is an error with playback, such as an AudioTrack not downloading correctly
    ''' </summary>
    ''' <param name="player">The BackgroundAudioPlayer</param>
    ''' <param name="track">The track that had the error</param>
    ''' <param name="error">The error that occured</param>
    ''' <param name="isFatal">If true, playback cannot continue and playback of the track will stop</param>
    ''' <remarks>
    ''' This method is not guaranteed to be called in all cases. For example, if the background agent 
    ''' itself has an unhandled exception, it won't get called back to handle its own errors.
    ''' </remarks>
    Protected Overrides Sub OnError(ByVal player As BackgroundAudioPlayer, ByVal track As AudioTrack, ByVal [error] As Exception, ByVal isFatal As Boolean)
        If isFatal Then
            Abort()
        Else
            NotifyComplete()
        End If

    End Sub

    ''' <summary>
    ''' Called when the agent request is getting cancelled
    ''' </summary>
    ''' <remarks>
    ''' Once the request is Cancelled, the agent gets 5 seconds to finish its work,
    ''' by calling NotifyComplete()/Abort().
    ''' </remarks>
    Protected Overrides Sub OnCancel()

    End Sub
End Class
