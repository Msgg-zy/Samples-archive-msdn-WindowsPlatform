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
Imports SDKTemplate
Imports Windows.Devices.Sensors
Imports Windows.Foundation
Imports Windows.UI.Core

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Partial Public NotInheritable Class Scenario2
    Inherits Global.SDKTemplate.Common.LayoutAwarePage

    Private _accelerometer As Accelerometer
    Private _shakeCount As UShort

    ' A pointer back to the main page.  This is needed if you want to call methods in MainPage such
    ' as NotifyUser()
    Private rootPage As Global.SDKTemplate.MainPage = Global.SDKTemplate.MainPage.Current

    Public Sub New()
        Me.InitializeComponent()

        _accelerometer = Accelerometer.GetDefault
        If _accelerometer Is Nothing Then
            rootPage.NotifyUser("No accelerometer found", NotifyType.StatusMessage)
        End If
        _shakeCount = 0
    End Sub

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached. The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        ScenarioEnableButton.IsEnabled = True
        ScenarioDisableButton.IsEnabled = False
    End Sub

    ''' <summary>
    ''' Invoked immediately before the Page is unloaded and is no longer the current source of a parent Frame.
    ''' </summary>
    ''' <param name="e">
    ''' Event data that can be examined by overriding code. The event data is representative
    ''' of the navigation that will unload the current Page unless canceled. The
    ''' navigation can potentially be canceled by setting Cancel.
    ''' </param>
    Protected Overrides Sub OnNavigatingFrom(e As NavigatingCancelEventArgs)
        If ScenarioDisableButton.IsEnabled Then
            RemoveHandler Window.Current.VisibilityChanged, AddressOf VisibilityChanged
            RemoveHandler _accelerometer.Shaken, AddressOf Shaken
        End If

        MyBase.OnNavigatingFrom(e)
    End Sub

    ''' <summary>
    ''' This is the event handler for VisibilityChanged events. You would register for these notifications
    ''' if handling sensor data when the app is not visible could cause unintended actions in the app.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">
    ''' Event data that can be examined for the current visibility state.
    ''' </param>
    Private Sub VisibilityChanged(sender As Object, e As VisibilityChangedEventArgs)
        If ScenarioDisableButton.IsEnabled Then
            If e.Visible
                ' Re-enable sensor input
                AddHandler _accelerometer.Shaken, AddressOf Shaken
            Else
                ' Disable sensor input
                RemoveHandler _accelerometer.Shaken, AddressOf Shaken
            End If
        End If
    End Sub

    ''' <summary>
    ''' This is the event handler for Shaken events.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Shaken(sender As Object, e As AccelerometerShakenEventArgs)
        Await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, Sub()
                                                                     _shakeCount += 1
                                                                     ScenarioOutputText.Text = _shakeCount.ToString
                                                                 End Sub)
    End Sub

    ''' <summary>
    ''' This is the click handler for the 'Enable' button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScenarioEnable(sender As Object, e As RoutedEventArgs)
        If _accelerometer IsNot Nothing Then
            AddHandler Window.Current.VisibilityChanged, AddressOf VisibilityChanged
            AddHandler _accelerometer.Shaken, AddressOf Shaken
            ScenarioEnableButton.IsEnabled = False
            ScenarioDisableButton.IsEnabled = True
        Else
            rootPage.NotifyUser("No accelerometer found", NotifyType.StatusMessage)
        End If
    End Sub

    ''' <summary>
    ''' This is the click handler for the 'Disable' button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScenarioDisable(sender As Object, e As RoutedEventArgs)
        RemoveHandler Window.Current.VisibilityChanged, AddressOf VisibilityChanged
        RemoveHandler _accelerometer.Shaken, AddressOf Shaken
        ScenarioEnableButton.IsEnabled = True
        ScenarioDisableButton.IsEnabled = False
    End Sub
End Class
