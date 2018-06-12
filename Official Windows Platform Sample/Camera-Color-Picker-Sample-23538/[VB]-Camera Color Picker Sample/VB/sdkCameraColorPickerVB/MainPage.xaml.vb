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
Imports System.Threading
Imports System.ComponentModel
Imports System.Windows.Media.Imaging
Imports System.IO
Imports Microsoft.Xna.Framework.Media

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    Implements INotifyPropertyChanged
    Private cam As PhotoCamera
    Private bgThread As Thread
    Private bgPleaseExit As Boolean = False
    Private wbCbCrColorPlane As New WriteableBitmap(256, 256)
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ' Internal YCbCr values used by the public properities.
    Private Property Y() As Byte
    Private Property Cb() As Integer
    Private Property Cr() As Integer

    ' For binding from the color plane label.
    Public ReadOnly Property CbText() As String
        Get
            Return String.Format("Cb = {0}", Cb)
        End Get
    End Property

    ' For binding from the color plane label.
    Public ReadOnly Property CrText() As String
        Get
            Return String.Format("Cr = {0}", Cr)
        End Get
    End Property

    ' For binding the location of the Cb/Cr lines and Y arrow.
    Public ReadOnly Property CrOffset() As Double
        Get
            Return 255 - (Cr + 127)
        End Get
    End Property
    Public ReadOnly Property CbOffset() As Double
        Get
            Return Cb + 127
        End Get
    End Property
    Public ReadOnly Property YOffset() As Double
        Get
            Return 255 - Y
        End Get
    End Property

    ' For binding from the ARGB text block.
    Public ReadOnly Property ArgbText() As String
        Get
            Return "#" & YCbCrToArgb(Y, Cb, Cr).ToString("X")
        End Get
    End Property

    ' For binding from the rectangle that displays the crosshairs color.
    Public ReadOnly Property ArgbBrush() As Brush
        Get
            Dim argb As Integer = YCbCrToArgb(Y, Cb, Cr)
            Dim r As Integer = (argb >> 16) And &HFF
            Dim g As Integer = (argb >> 8) And &HFF
            Dim b As Integer = argb And &HFF

            Return New SolidColorBrush(Color.FromArgb(255, CByte(r), CByte(g), CByte(b)))
        End Get
    End Property

    ' Constructor
    Public Sub New()
        InitializeComponent()

        ' Draw CbCr color plane bitmap.
        DrawCbCrColorPlaneBitmap()

        ' Bind the UI to the this page.
        Me.DataContext = Me
    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        ' Check to see if the camera is available on the device.
        If (PhotoCamera.IsCameraTypeSupported(CameraType.Primary) = True) OrElse (PhotoCamera.IsCameraTypeSupported(CameraType.FrontFacing) = True) Then
            cam = New PhotoCamera()
            AddHandler cam.Initialized, AddressOf cam_Initialized
            viewfinderBrush.SetSource(cam)
        Else
            MessageBox.Show("This sample requires a camera.")
            CameraCrosshairs.Visibility = System.Windows.Visibility.Collapsed
        End If
    End Sub

    Protected Overrides Sub OnNavigatingFrom(ByVal e As System.Windows.Navigation.NavigatingCancelEventArgs)
        If cam IsNot Nothing Then
            ' Notify the background worker to stop processing.
            bgPleaseExit = True
            bgThread.Join()

            ' Dispose of the camera object to free memory.
            cam.Dispose()
        End If
    End Sub

    Private Sub cam_Initialized(ByVal sender As Object, ByVal e As CameraOperationCompletedEventArgs)
        If cam IsNot Nothing Then
            ' Set the orientation of the viewfinder.
            Dispatcher.BeginInvoke(Sub() viewfinderBrushTransformation.Angle = cam.Orientation)

            ' Start the background worker thread that processes the camera preview buffer frames.
            bgPleaseExit = False
            bgThread = New Thread(AddressOf colorConversionBackgroundWorker)
            bgThread.Start()
        End If
    End Sub

    Private Sub colorConversionBackgroundWorker()
        ' Grouping the property change notifications in a batch.
        Dim changeCache As New List(Of PropertyChangedEventArgs)()
        changeCache.Add(New PropertyChangedEventArgs("CbText"))
        changeCache.Add(New PropertyChangedEventArgs("CrText"))
        changeCache.Add(New PropertyChangedEventArgs("CrOffset"))
        changeCache.Add(New PropertyChangedEventArgs("CbOffset"))
        changeCache.Add(New PropertyChangedEventArgs("YOffset"))
        changeCache.Add(New PropertyChangedEventArgs("ArgbText"))
        changeCache.Add(New PropertyChangedEventArgs("ArgbBrush"))

        ' Obtain the YCbCr layout settings used by the camera buffer.
        Dim bufferLayout = cam.YCbCrPixelLayout

        ' Allocate the appropriately sized preview buffer.
        Dim currentPreviewBuffer(bufferLayout.RequiredBufferSize - 1) As Byte

        ' Continue processing until asked to stop in OnNavigatingFrom.
        Do While Not bgPleaseExit
            ' Get the current preview buffer from the camera.
            cam.GetPreviewBufferYCbCr(currentPreviewBuffer)

            ' The output parameters used in the following method.
            Dim y As Byte
            Dim cr As Integer
            Dim cb As Integer

            ' Extract details about the pixel where the camera crosshairs meet.
            ' This location is estimated to be X=320, Y=240. Adjust as desired.
            GetYCbCrFromPixel(bufferLayout, currentPreviewBuffer, 320, 240, y, cr, cb)

            ' Set page-level properties to the new YCbCr values.
            Me.Y = y
            Me.Cb = cb
            Me.Cr = cr

            ' not threadsafe, but unlikely to be a problem in this case
            ' Consolidating change notifications
            Dispatcher.BeginInvoke(Sub()
                                       If PropertyChangedEvent IsNot Nothing Then
                                           For Each change In changeCache
                                               RaiseEvent PropertyChanged(Me, change)
                                           Next change
                                       End If
                                   End Sub)
        Loop
    End Sub

    Private Sub GetYCbCrFromPixel(ByVal layout As YCbCrPixelLayout, ByVal currentPreviewBuffer() As Byte, ByVal xFramePos As Integer, ByVal yFramePos As Integer, _
                                  <System.Runtime.InteropServices.Out()> ByRef y As Byte, _
                                  <System.Runtime.InteropServices.Out()> ByRef cr As Integer, _
                                  <System.Runtime.InteropServices.Out()> ByRef cb As Integer)
        ' Find the bytes corresponding to the pixel location in the frame.
        Dim yBufferIndex As Integer = layout.YOffset + yFramePos * layout.YPitch + xFramePos * layout.YXPitch
        Dim crBufferIndex As Integer = layout.CrOffset + (yFramePos \ 2) * layout.CrPitch + (xFramePos \ 2) * layout.CrXPitch
        Dim cbBufferIndex As Integer = layout.CbOffset + (yFramePos \ 2) * layout.CbPitch + (xFramePos \ 2) * layout.CbXPitch

        ' The luminance value is always positive.
        y = currentPreviewBuffer(yBufferIndex)

        ' The preview buffer contains an unsigned value between 255 and 0.
        ' The buffer value is cast from a byte to an integer.
        cr = currentPreviewBuffer(crBufferIndex)

        ' Convert to a signed value between 127 and -128.
        cr -= 128

        ' The preview buffer contains an unsigned value between 255 and 0.
        ' The buffer value is cast from a byte to an integer.
        cb = currentPreviewBuffer(cbBufferIndex)

        ' Convert to a signed value between 127 and -128.
        cb -= 128
    End Sub

    Private Function YCbCrToArgb(ByVal y As Byte, ByVal cb As Integer, ByVal cr As Integer) As UInteger
        ' Individual RGB components.
        Dim r, g, b As Integer

        ' Used for building a 32-bit ARGB pixel.

        Dim argbPixel As UInteger

        ' Assumes Cb & Cr have been converted to signed values (ranging from 127 to -128).

        ' Integer-only division.
        r = y + cr + (cr >> 2) + (cr >> 3) + (cr >> 5)
        g = y - ((cb >> 2) + (cb >> 4) + (cb >> 5)) - ((cr >> 1) + (cr >> 3) + (cr >> 4) + (cr >> 5))
        b = y + cb + (cb >> 1) + (cb >> 2) + (cb >> 6)

        ' Clamp values to 8-bit RGB range between 0 and 255.
        r = If(r <= 255, r, 255)
        r = If(r >= 0, r, 0)
        g = If(g <= 255, g, 255)
        g = If(g >= 0, g, 0)
        b = If(b <= 255, b, 255)
        b = If(b >= 0, b, 0)

        ' Pack individual components into a single pixel.
        argbPixel = &HFF000000L ' Alpha
        argbPixel = argbPixel Or CUInt(b)
        argbPixel = argbPixel Or CUInt(g << 8)
        argbPixel = argbPixel Or CUInt(r << 16)

        ' Return the ARGB pixel.
        Return CInt(Fix(argbPixel))
    End Function

    ' Creates the CbCr color plane image used to display Cb and Cr values.
    ' Uses a fixed Y value of 0.5.
    Private Sub DrawCbCrColorPlaneBitmap()
        ' Generate CbCr color plane, with Y == 0.5
        Dim wb() As Integer = wbCbCrColorPlane.Pixels

        For x = 0 To 254
            For y As Integer = 0 To 254
                Dim cb = x - 128
                Dim cr = (255 - y) - 128

                wb(y * 256 + x) = YCbCrToArgb(128, cb, cr)
            Next y
        Next x

        ' Re-draw bitmap with new values.
        wbCbCrColorPlane.Invalidate()

        ' Set bitmap to image control source.
        imgCbCrColorPlane.Source = wbCbCrColorPlane
    End Sub
End Class
