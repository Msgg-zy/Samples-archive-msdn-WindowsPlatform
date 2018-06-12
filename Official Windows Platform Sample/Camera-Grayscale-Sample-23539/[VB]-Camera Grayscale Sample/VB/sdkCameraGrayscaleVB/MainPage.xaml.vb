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
Imports Microsoft.Devices
Imports System.Windows.Media.Imaging
Imports System.Threading



Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Variables
    Private cam As New PhotoCamera()
    Private Shared pauseFramesEvent As New ManualResetEvent(True)
    Private wb As WriteableBitmap
    Private ARGBFramesThread As Thread

    Private _pumpARGBFrames As Boolean


    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    'Code for camera initialization event, and setting the source for the viewfinder
    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)

        ' Check to see if the camera is available on the device.
        If (PhotoCamera.IsCameraTypeSupported(CameraType.Primary) = True) _
            OrElse (PhotoCamera.IsCameraTypeSupported(CameraType.FrontFacing) = True) Then
            ' Initialize the default camera.
            cam = New Microsoft.Devices.PhotoCamera()

            'Event is fired when the PhotoCamera object has been initialized
            AddHandler cam.Initialized, AddressOf cam_Initialized

            'Set the VideoBrush source to the camera
            viewfinderBrush.SetSource(cam)
        Else
            ' The camera is not supported on the device.
            ' Write message.
            Me.Dispatcher.BeginInvoke(Sub() txtDebug.Text = "A Camera is not available on this device.")

            ' Disable UI.
            GrayscaleOnButton.IsEnabled = False
            GrayscaleOffButton.IsEnabled = False
        End If
    End Sub

    Protected Overrides Sub OnNavigatingFrom(ByVal e As System.Windows.Navigation.NavigatingCancelEventArgs)
        If cam IsNot Nothing Then
            ' Dispose of the camera to minimize power consumption and to expedite shutdown.
            cam.Dispose()

            ' Release memory, ensure garbage collection.
            RemoveHandler cam.Initialized, AddressOf cam_Initialized
        End If
    End Sub

    'Update UI if initialization succeeds
    Private Sub cam_Initialized(ByVal sender As Object, ByVal e As Microsoft.Devices.CameraOperationCompletedEventArgs)
        If e.Succeeded Then
            Me.Dispatcher.BeginInvoke(Sub() txtDebug.Text = "Camera initialized")

        End If
    End Sub

    ' ARGB frame pump
    Private Sub PumpARGBFrames()
        ' Create capture buffer.
        Dim ARGBPx(CInt(Fix(cam.PreviewResolution.Width)) * CInt(Fix(cam.PreviewResolution.Height)) - 1) As Integer

        Try
            Dim phCam As PhotoCamera = CType(cam, PhotoCamera)

            Do While _pumpARGBFrames
                pauseFramesEvent.WaitOne()

                ' Copies the current viewfinder frame into a buffer for further manipulation.
                phCam.GetPreviewBufferArgb32(ARGBPx)

                ' Conversion to grayscale.
                For i = 0 To ARGBPx.Length - 1
                    ARGBPx(i) = ColorToGray(ARGBPx(i))
                Next i

                pauseFramesEvent.Reset()
                ' Copy to WriteableBitmap.
                Deployment.Current.Dispatcher.BeginInvoke(Sub()
                                                              ARGBPx.CopyTo(wb.Pixels, 0)
                                                              wb.Invalidate()
                                                              pauseFramesEvent.Set()
                                                          End Sub)
            Loop

        Catch e As Exception
            ' Display error message.
            Me.Dispatcher.BeginInvoke(Sub() txtDebug.Text = e.Message)
        End Try
    End Sub

    Friend Function ColorToGray(ByVal color As Integer) As Integer
        Dim gray As Integer = 0

        Dim a As Integer = color >> 24
        Dim r As Integer = (color And &HFF0000) >> 16
        Dim g As Integer = (color And &HFF00) >> 8
        Dim b As Integer = (color And &HFF)

        If (r = g) AndAlso (g = b) Then
            gray = color
        Else
            ' Calculate for the illumination.
            ' I =(int)(0.109375*R + 0.59375*G + 0.296875*B + 0.5)
            Dim i = (7 * r + 38 * g + 19 * b + 32) >> 6

            gray = ((a And &HFF) << 24) Or ((i And &HFF) << 16) Or ((i And &HFF) << 8) Or (i And &HFF)
        End If
        Return gray
    End Function

    ' Start ARGB to grayscale pump.
    Private Sub GrayOn_Clicked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        MainImage.Visibility = Visibility.Visible
        _pumpARGBFrames = True
        ARGBFramesThread = New System.Threading.Thread(AddressOf PumpARGBFrames)

        wb = New WriteableBitmap(CInt(Fix(cam.PreviewResolution.Width)), CInt(Fix(cam.PreviewResolution.Height)))
        Me.MainImage.Source = wb

        ' Start pump.
        ARGBFramesThread.Start()
        Me.Dispatcher.BeginInvoke(Sub() txtDebug.Text = "ARGB to Grayscale")
    End Sub

    ' Stop ARGB to grayscale pump.
    Private Sub GrayOff_Clicked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        MainImage.Visibility = Visibility.Collapsed
        _pumpARGBFrames = False

        Me.Dispatcher.BeginInvoke(Sub() txtDebug.Text = "")
    End Sub
End Class
