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
Imports System.IO
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Threading
Imports Microsoft.Devices
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Media

Partial Public Class MainPage
    Inherits PhoneApplicationPage
#Region "MemberVariables"

    Private _playingSong As Song ' The song that is currently playing or will play when the user presses the Play button.
    Private _historyItemLaunch As Boolean ' Indicates if the app was launched from a MediaHistoryItem.
    Private Const _playSongKey As String = "playSong" ' Key for MediaHistoryItem key-value pair.

#End Region ' MemberVariables


    ' Constructor
    ''' <summary>
    ''' Initializes member variables and sets up a DispatcherTimer 
    ''' to run XNA internals because MediaPlayer is from XNA.
    ''' </summary>
    Public Sub New()
        _playingSong = Nothing
        _historyItemLaunch = False

        InitializeComponent()

        ' Timer to run the XNA internals (MediaPlayer is from XNA)
        Dim dt As New DispatcherTimer()
        dt.Interval = TimeSpan.FromMilliseconds(33)
        AddHandler dt.Tick, Sub()
                                Try
                                    FrameworkDispatcher.Update()
                                Catch
                                End Try
                            End Sub
        dt.Start()

        ' Event handler to manage button states based on whether or not a song in playing.
        AddHandler MediaPlayer.MediaStateChanged, AddressOf MediaPlayer_MediaStateChanged
    End Sub


#Region "EventHandlers"

    ''' <summary>
    ''' Sets the _playingSong member variable based on how the app was started.
    ''' If a song was already playing in the media player, set _playingSong to the currently active song.
    ''' If the app was started from a history item, set _playingSong using the data from the history token.
    ''' If no song was playing, find a random song in the media library and set _playingSong to that song.
    ''' </summary>
    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        Dim library As New MediaLibrary()

        If NavigationContext.QueryString.ContainsKey(_playSongKey) Then
            ' We were launched from a history item.
            ' Change _playingSong even if something was already playing 
            ' because the user directly chose a song history item.

            ' Use the navigation context to find the song by name.
            Dim songToPlay As String = NavigationContext.QueryString(_playSongKey)

            For Each song In library.Songs
                If 0 = String.Compare(songToPlay, song.Name) Then
                    _playingSong = song
                    Exit For
                End If
            Next song

            ' Set a flag to indicate that we were started from a 
            ' history item and that we should immediately start 
            ' playing the song once the UI has finished loading.
            _historyItemLaunch = True
        ElseIf MediaPlayer.State = MediaState.Playing Then
            ' A song was already playing when we started.
            _playingSong = MediaPlayer.Queue.ActiveSong
        Else
            ' We were launched with no NavigationContext and 
            ' there was not a song already playing, so choose 
            ' a random song from the library on this device.
            Dim rand As New Random()

            If library.Songs.Count > 0 Then
                _playingSong = library.Songs(rand.Next(library.Songs.Count))
            Else
                ' Song library is empty. 
                SongName.Text = "no songs in library"
                PlayButton.IsEnabled = False
            End If
        End If

        MyBase.OnNavigatedTo(e)
    End Sub

    ''' <summary>
    ''' Called once the UI has finished loading. Now it is safe to 
    ''' initialize the UI elements and to start playing a song, if 
    ''' we were launched from a history item.
    ''' </summary>
    Private Sub PhoneApplicationPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Set the album art and song name.
        PopulateSongMetadata()

        ' Set the IsEnabled state of the buttons.
        SetInitialButtonStates()

        If _historyItemLaunch Then
            ' We were launched from a history item, 
            ' start playing the song immediately.
            PlaySong()
        End If
    End Sub

    ''' <summary>
    ''' Start playing the song and add a history item.
    ''' </summary>
    Private Sub PlayButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        PlaySong()
        AddToHistory()
    End Sub

    ''' <summary>
    ''' Stop playing the song.
    ''' </summary>
    Private Sub StopButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        StopPlayingSong()
    End Sub

    ''' <summary>
    ''' Sets the state of the Play and Stop buttons based on the state of the MediaPlayer.
    ''' </summary>
    Private Sub MediaPlayer_MediaStateChanged(ByVal sender As Object, ByVal e As EventArgs)
        Select Case MediaPlayer.State
            Case MediaState.Playing
                PlayButton.IsEnabled = False
                StopButton.IsEnabled = True

            Case MediaState.Stopped, MediaState.Paused
                PlayButton.IsEnabled = True
                StopButton.IsEnabled = False
        End Select
    End Sub

#End Region ' EventHandlers


#Region "MediaPlayer"

    ''' <summary>
    ''' Starts playing the song and sets the button states 
    ''' to allow the user to stop playing the song.
    ''' </summary>
    Private Sub PlaySong()
        If _playingSong IsNot Nothing Then
            MediaPlayer.Play(_playingSong)
        End If
    End Sub

    ''' <summary>
    ''' Stops playing the song and sets the button states 
    ''' to allow the user to start playback again.
    ''' </summary>
    Private Sub StopPlayingSong()
        If MediaPlayer.State = MediaState.Playing Then
            MediaPlayer.Stop()
        End If
    End Sub

#End Region ' MediaPlayer


    ''' <summary>
    ''' Sets the album art and song name in the corresponding UI elements.
    ''' </summary>
    Private Sub PopulateSongMetadata()
        If _playingSong IsNot Nothing Then
            ' Initialize the SongName TextBlock found in the XAML file.
            SongName.Text = _playingSong.Name

            ' Try to get the album art.
            ' NOTE! You cannot debug this application while the Zune software 
            ' is running because the media database is locked by Zune. You will
            ' get an InvalidOperationException here if the Zune software is running.
            Dim albumArtStream As Stream = _playingSong.Album.GetAlbumArt()

            If albumArtStream Is Nothing Then
                ' No album art found, use a generic place holder image.
                Dim albumArtPlaceholder As StreamResourceInfo = Application.GetResourceStream(New Uri("AlbumArtPlaceholder.png", UriKind.Relative))
                albumArtStream = albumArtPlaceholder.Stream
            End If

            ' Initialize the Image element named 
            ' SongAblbumArtImage in the XAML file.
            Dim albumArtImage As New BitmapImage()
            albumArtImage.SetSource(albumArtStream)
            SongAlbumArtImage.Source = albumArtImage
        End If
    End Sub

    ''' <summary>
    ''' Sets the initial state of the Play and Stop buttons.
    ''' </summary>
    Private Sub SetInitialButtonStates()
        ' Initialize buttons because the MediaStateChanged 
        ' event will not occur if we are already playing.
        Select Case MediaPlayer.State
            Case MediaState.Playing
                PlayButton.IsEnabled = False
                StopButton.IsEnabled = True

            Case MediaState.Stopped, MediaState.Paused
                PlayButton.IsEnabled = True
                StopButton.IsEnabled = False
        End Select
    End Sub

    ''' <summary>
    ''' Creates a MediaHistoryItem for the song we are playing and 
    ''' adds it to the history area of the Music + Videos Hub.
    ''' </summary>
    Private Sub AddToHistory()
        If _playingSong IsNot Nothing Then
            Dim historyItem As New MediaHistoryItem()
            historyItem.Title = _playingSong.Name
            historyItem.Source = ""

            ' TODO: Use a more unique image here that better identifies 
            ' the history item as having come from this app.
            historyItem.ImageStream = _playingSong.Album.GetThumbnail()

            If historyItem.ImageStream Is Nothing Then
                ' No album art found, use a generic place holder image.
                Dim sri As StreamResourceInfo = Application.GetResourceStream(New Uri("AlbumThumbnailPlaceholder.png", UriKind.Relative))
                historyItem.ImageStream = sri.Stream
            End If

            ' If we get activated by the MediaHistoryItem we're creating here, 
            ' our NavigationContext will have a key-value pair ("playSong", "<Song Name>")
            ' where <Song Name> is the Name property of the _playingSong object.
            historyItem.PlayerContext(_playSongKey) = _playingSong.Name

            ' Add our item to the MediaHistory area of the Music + Videos Hub.
            Dim mediaHistory As MediaHistory = mediaHistory.Instance
            mediaHistory.WriteRecentPlay(historyItem)
        End If
    End Sub
End Class
