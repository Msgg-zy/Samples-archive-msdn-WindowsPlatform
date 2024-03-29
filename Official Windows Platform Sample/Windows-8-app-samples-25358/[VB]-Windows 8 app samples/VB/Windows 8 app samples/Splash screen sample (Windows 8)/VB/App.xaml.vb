﻿' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
' THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
' 
' Copyright (c) Microsoft Corporation. All rights reserved

Imports Windows.ApplicationModel
Imports Windows.ApplicationModel.Activation
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Navigation
Imports SDKTemplate
Imports SplashScreenSample

Namespace Global.SDKTemplate

    ''' <summary>
    ''' Provides application-specific behavior to supplement the default Application class.
    ''' </summary>
    Partial NotInheritable Class App
        Inherits Application
        ''' <summary>
        ''' Initializes the singleton application object.  This is the first line of authored code
        ''' executed, and as such is the logical equivalent of main() or WinMain().
        ''' </summary>
        Public Sub New()
            Me.InitializeComponent()
            AddHandler Me.Suspending, AddressOf OnSuspending
        End Sub

        Private Async Sub OnSuspending(sender As Object, args As SuspendingEventArgs)
            Dim deferral As SuspendingDeferral = args.SuspendingOperation.GetDeferral()
            Await SuspensionManager.SaveAsync()
            deferral.Complete()
        End Sub


        ''' <summary>
        ''' Invoked when the application is launched normally by the end user.  Other entry points
        ''' will be used when the application is launched to open a specific file, to display
        ''' search results, and so forth.
        ''' </summary>
        ''' <param name="args">Details about the launch request and process.</param>
        Protected Overrides Sub OnLaunched(args As LaunchActivatedEventArgs)
            If args.PreviousExecutionState <> ApplicationExecutionState.Running Then
                Dim loadState As Boolean = (args.PreviousExecutionState = ApplicationExecutionState.Terminated)
                Dim extendedSplash As ExtendedSplash = New ExtendedSplash(args.SplashScreen, loadState)
                Window.Current.Content = extendedSplash
            End If

            Window.Current.Activate()
        End Sub
    End Class

End Namespace

