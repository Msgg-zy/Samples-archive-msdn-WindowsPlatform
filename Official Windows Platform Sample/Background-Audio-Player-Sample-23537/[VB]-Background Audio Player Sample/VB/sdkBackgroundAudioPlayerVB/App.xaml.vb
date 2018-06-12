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
Imports System.IO.IsolatedStorage
Imports System.Windows.Resources
Imports Microsoft.Phone.BackgroundAudio

Partial Public Class App
    Inherits Application

    ''' <summary>
    ''' Provides easy access to the root frame of the Phone Application.
    ''' </summary>
    ''' <returns>The root frame of the Phone Application.</returns>
    Public Property RootFrame As PhoneApplicationFrame

    ''' <summary>
    ''' Constructor for the Application object.
    ''' </summary>
    Public Sub New()
        ' Copy media to isolated storage
        CopyToIsolatedStorage()

        ' Standard Silverlight initialization
        InitializeComponent()

        ' Phone-specific initialization
        InitializePhoneApplication()

        ' Show graphics profiling information while debugging.
        If System.Diagnostics.Debugger.IsAttached Then
            ' Close the background audio player in case it 
            ' was running from a previous debugging session.
            BackgroundAudioPlayer.Instance.Close()

            ' Display the current frame rate counters.
            'Application.Current.Host.Settings.EnableFrameRateCounter = True

            ' Show the areas of the app that are being redrawn in each frame.
            'Application.Current.Host.Settings.EnableRedrawRegions = True

            ' Enable non-production analysis visualization mode, 
            ' which shows areas of a page that are handed off to GPU with a colored overlay.
            'Application.Current.Host.Settings.EnableCacheVisualization = True


            ' Disable the application idle detection by setting the UserIdleDetectionMode property of the
            ' application's PhoneApplicationService object to Disabled.
            ' Caution:- Use this under debug mode only. Application that disables user idle detection will continue to run
            ' and consume battery power when the user is not using the phone.
            PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled
        End If

    End Sub

    ' Code to execute when the application is launching (eg, from Start)
    ' This code will not execute when the application is reactivated
    Private Sub Application_Launching(ByVal sender As Object, ByVal e As LaunchingEventArgs)
    End Sub

    ' Code to execute when the application is activated (brought to foreground)
    ' This code will not execute when the application is first launched
    Private Sub Application_Activated(ByVal sender As Object, ByVal e As ActivatedEventArgs)
    End Sub

    ' Code to execute when the application is deactivated (sent to background)
    ' This code will not execute when the application is closing
    Private Sub Application_Deactivated(ByVal sender As Object, ByVal e As DeactivatedEventArgs)
    End Sub

    ' Code to execute when the application is closing (eg, user hit Back)
    ' This code will not execute when the application is deactivated
    Private Sub Application_Closing(ByVal sender As Object, ByVal e As ClosingEventArgs)
    End Sub

    ' Code to execute if a navigation fails
    Private Sub RootFrame_NavigationFailed(ByVal sender As Object, ByVal e As NavigationFailedEventArgs)
        If Diagnostics.Debugger.IsAttached Then
            ' A navigation has failed; break into the debugger
            Diagnostics.Debugger.Break()
        End If
    End Sub

    Public Sub Application_UnhandledException(ByVal sender As Object, ByVal e As ApplicationUnhandledExceptionEventArgs) Handles Me.UnhandledException

        ' Show graphics profiling information while debugging.
        If Diagnostics.Debugger.IsAttached Then
            Diagnostics.Debugger.Break()
        Else
            e.Handled = True
            MessageBox.Show(e.ExceptionObject.Message & Environment.NewLine & e.ExceptionObject.StackTrace,
                            "Error", MessageBoxButton.OK)
        End If
    End Sub

#Region "Phone application initialization"
    ' Avoid double-initialization
    Private phoneApplicationInitialized As Boolean = False

    ' Do not add any additional code to this method
    Private Sub InitializePhoneApplication()
        If phoneApplicationInitialized Then
            Return
        End If

        ' Create the frame but don't set it as RootVisual yet; this allows the splash
        ' screen to remain active until the application is ready to render.
        RootFrame = New PhoneApplicationFrame()
        AddHandler RootFrame.Navigated, AddressOf CompleteInitializePhoneApplication

        ' Handle navigation failures
        AddHandler RootFrame.NavigationFailed, AddressOf RootFrame_NavigationFailed

        ' Ensure we don't initialize again
        phoneApplicationInitialized = True
    End Sub

    ' Do not add any additional code to this method
    Private Sub CompleteInitializePhoneApplication(ByVal sender As Object, ByVal e As NavigationEventArgs)
        ' Set the root visual to allow the application to render
        If RootVisual IsNot RootFrame Then
            RootVisual = RootFrame
        End If

        ' Remove this handler since it is no longer needed
        RemoveHandler RootFrame.Navigated, AddressOf CompleteInitializePhoneApplication
    End Sub
#End Region

    ''' <summary>
    ''' Copies the files from the application data to isolated storage.
    ''' </summary>
    Private Sub CopyToIsolatedStorage()
        Using storage As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
            ' Copy audio files to isolated storage
            Dim files() As String = {"Ring01.wma", "Ring02.wma", "Ring03.wma"}

            For Each _fileName In files
                If Not storage.FileExists(_fileName) Then
                    Dim _filePath As String = "Audio/" & _fileName
                    Dim resource As StreamResourceInfo = Application.GetResourceStream(New Uri(_filePath, UriKind.Relative))

                    Using file As IsolatedStorageFileStream = storage.CreateFile(_fileName)
                        Dim chunkSize As Integer = 4096
                        Dim bytes(chunkSize - 1) As Byte
                        Dim byteCount As Integer

                        byteCount = resource.Stream.Read(bytes, 0, chunkSize)
                        Do While byteCount > 0
                            file.Write(bytes, 0, byteCount)
                            byteCount = resource.Stream.Read(bytes, 0, chunkSize)
                        Loop
                    End Using
                End If
            Next _fileName

            ' Copy Tile icons for each track to isolated storage
            Dim icons() As String = {"Ring01.jpg", "Ring02.jpg", "Ring03.jpg", "Episode29.jpg"}

            For Each _fileName In icons
                If Not storage.FileExists("Shared/Media/" & _fileName) Then
                    Dim _filePath As String = "Images/" & _fileName
                    Dim iconResource As StreamResourceInfo = Application.GetResourceStream(New Uri(_filePath, UriKind.Relative))

                    ' The Tile images MUST be located in the Shared/Media directory in order 
                    ' to get picked up by the Now Playing Tile in the Music + Videos Hub
                    Using file As IsolatedStorageFileStream = storage.CreateFile("Shared/Media/" & _fileName)
                        Dim chunkSize As Integer = 4096
                        Dim bytes(chunkSize - 1) As Byte
                        Dim byteCount As Integer

                        byteCount = iconResource.Stream.Read(bytes, 0, chunkSize)
                        Do While byteCount > 0
                            file.Write(bytes, 0, byteCount)
                            byteCount = iconResource.Stream.Read(bytes, 0, chunkSize)
                        Loop
                    End Using
                End If
            Next _fileName

        End Using
    End Sub

End Class
