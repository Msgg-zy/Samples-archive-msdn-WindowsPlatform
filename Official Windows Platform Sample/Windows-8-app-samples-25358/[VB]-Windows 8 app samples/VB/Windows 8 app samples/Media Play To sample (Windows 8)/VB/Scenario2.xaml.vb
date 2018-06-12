﻿'*********************************************************
'
' Copyright (c) Microsoft. All rights reserved.
' THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
' IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
' PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************

Imports Windows.UI.Xaml.Navigation
Imports Windows.UI.Xaml.Media.Imaging
Imports Windows.UI.Core
Imports Windows.Media.PlayTo
Imports Windows.Storage
Imports Windows.Storage.Pickers
Imports Windows.Storage.Streams

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Partial Public NotInheritable Class Scenario2
    Inherits SDKTemplate.Common.LayoutAwarePage
    ' A pointer back to the main page.  This is needed if you want to call methods in MainPage such
    ' as NotifyUser()
    Private rootPage As MainPage = MainPage.Current
    Private playToManager As PlayToManager = Nothing
    Private _dispatcher As CoreDispatcher = Nothing
    Private playlistTimer As DispatcherTimer = Nothing

    Public Sub New()
        Me.InitializeComponent()
    End Sub

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        _dispatcher = Window.Current.CoreWindow.Dispatcher

        playlistTimer = New DispatcherTimer
        playlistTimer.Interval = New TimeSpan(0, 0, 10)
        AddHandler playlistTimer.Tick, AddressOf playlistTimer_Tick

        playToManager = playToManager.GetForCurrentView()
        AddHandler playToManager.SourceRequested, AddressOf playToManager_SourceRequested
        playListPlayNext()
    End Sub

    Private Sub playlistTimer_Tick(sender As Object, e As Object)
        If Playlist IsNot Nothing Then
            playListPlayNext()
        End If
    End Sub

    Private Sub playToManager_SourceRequested(sender As PlayToManager, args As PlayToSourceRequestedEventArgs)
        Dim deferral = args.SourceRequest.GetDeferral()
        Dim handler = dispatcher.RunAsync(CoreDispatcherPriority.Normal, Sub()
                                                                             args.SourceRequest.SetSource(ImageSource.PlayToSource)
                                                                             deferral.Complete()
                                                                         End Sub)

		End Sub

    Protected Overrides Sub OnNavigatedFrom(e As NavigationEventArgs)
        RemoveHandler playToManager.SourceRequested, AddressOf playToManager_SourceRequested
    End Sub

    Private Sub playSlideshow_Click(sender As Object, e As RoutedEventArgs)
        If Playlist IsNot Nothing Then
            rootPage.NotifyUser("Playlist playing", NotifyType.StatusMessage)
            playlistTimer.Start()
        End If
    End Sub

    Private Sub pauseSlideshow_Click(sender As Object, e As RoutedEventArgs)
        If Playlist IsNot Nothing Then
            rootPage.NotifyUser("Playlist paused", NotifyType.StatusMessage)
            playlistTimer.Stop()
        End If
    End Sub

    Private Sub previousItem_Click(sender As Object, e As RoutedEventArgs)
        If Playlist IsNot Nothing Then
            Playlist.SelectedIndex = If((Playlist.SelectedIndex - 1 >= 0), Playlist.SelectedIndex - 1, Playlist.Items.Count - 1)
            rootPage.NotifyUser("Previous item selected in the list", NotifyType.StatusMessage)
        End If
    End Sub

    Private Sub nextItem_Click(sender As Object, e As RoutedEventArgs)
        If Playlist IsNot Nothing Then
            playListPlayNext()
            rootPage.NotifyUser("Next item selected in the list", NotifyType.StatusMessage)
        End If
    End Sub

    Private Sub playListPlayNext()
        If Playlist IsNot Nothing Then
            Playlist.SelectedIndex = If((Playlist.SelectedIndex + 1 < Playlist.Items.Count), Playlist.SelectedIndex + 1, 0)
        End If
    End Sub

    Private Sub Playlist_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        If Playlist IsNot Nothing Then
            ImageSource.Source = New BitmapImage(New Uri("ms-appx:///Assets/" & DirectCast(Playlist.SelectedItem, ListBoxItem).Content.ToString))
            rootPage.NotifyUser(DirectCast(Playlist.SelectedItem, ListBoxItem).Content.ToString & " selected from the list", NotifyType.StatusMessage)
        End If
    End Sub

End Class
