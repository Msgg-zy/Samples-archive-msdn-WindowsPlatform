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
Imports System.Windows.Media.Imaging
Imports Microsoft.Phone
Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Windows.Controls.Primitives
Imports Microsoft.Xna.Framework.Media

Partial Public Class Crop
    Inherits PhoneApplicationPage

    'Variables for the application bar buttons
    Private btnCrop As ApplicationBarIconButton
    Private btnAccept As ApplicationBarIconButton
    Private btnReject As ApplicationBarIconButton
    Private btnHelp As ApplicationBarIconButton


    'Variable for the help popup
    Private help As New Popup()

    'Variables for the crop feature
    Private p1, p2 As Point
    Private cropping As Boolean = False


    Public Sub New()
        InitializeComponent()

        textStatus.Text = "Select the cropping region with your finger." & " Once completed, tap the crop button to crop the image."


        'Sets the source to the Image control on the crop page to the WriteableBitmap object created previously.
        DisplayedImageElement.Source = App.CapturedImage


        'Create event handlers for cropping selection on the picture.
        AddHandler DisplayedImageElement.MouseLeftButtonDown, AddressOf CropImage_MouseLeftButtonDown
        AddHandler DisplayedImageElement.MouseLeftButtonUp, AddressOf CropImage_MouseLeftButtonUp
        AddHandler DisplayedImageElement.MouseMove, AddressOf CropImage_MouseMove


        'Used for rendering the cropping rectangle on the image.
        AddHandler CompositionTarget.Rendering, AddressOf CompositionTarget_Rendering





        'Creating an application bar and then setting visibility and menu properties.
        ApplicationBar = New ApplicationBar()
        ApplicationBar.IsVisible = True
        ApplicationBar.IsMenuEnabled = True

        'This code creates the application bar icon buttons.
        btnCrop = New ApplicationBarIconButton(New Uri("/Icons/appbar.edit.rest.png", UriKind.Relative))
        btnAccept = New ApplicationBarIconButton(New Uri("/Icons/appbar.check.rest.png", UriKind.Relative))
        btnReject = New ApplicationBarIconButton(New Uri("/Icons/appbar.cancel.rest.png", UriKind.Relative))
        btnHelp = New ApplicationBarIconButton(New Uri("/Icons/appbar.questionmark.rest.png", UriKind.Relative))

        'Labels for the application bar buttons.
        btnCrop.Text = "Crop"
        btnAccept.Text = "Accept"
        btnReject.Text = "Reject"
        btnHelp.Text = "Help"

        'This code adds buttons to application bar.
        ApplicationBar.Buttons.Add(btnCrop)
        ApplicationBar.Buttons.Add(btnAccept)
        ApplicationBar.Buttons.Add(btnReject)
        ApplicationBar.Buttons.Add(btnHelp)



        'This code will create event handlers for buttons.
        AddHandler btnCrop.Click, AddressOf btnCrop_Click
        AddHandler btnAccept.Click, AddressOf btnAccept_Click
        AddHandler btnReject.Click, AddressOf btnReject_Click
        AddHandler btnHelp.Click, AddressOf btnHelp_Click

        'Disable buttons so user cannot click until appropriate time.
        btnCrop.IsEnabled = False
        btnAccept.IsEnabled = False
        btnReject.IsEnabled = False

        'Begin storyboard for rectangle color effect.
        Rectangle.Begin()
    End Sub


    Private Sub btnHelp_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a popup/message box for help and add content to the popup


        'Stack panel with a black background
        Dim panelHelp As New StackPanel()
        panelHelp.Background = New SolidColorBrush(Colors.Black)
        panelHelp.Width = 400
        panelHelp.Height = 550

        'Create a white border
        Dim border As New Border()
        border.BorderBrush = New SolidColorBrush(Colors.White)
        border.BorderThickness = New Thickness(7.0)

        'Create a close button to exit popup
        Dim close As New Button()
        close.Content = "Close"
        close.Margin = New Thickness(5.0)
        AddHandler close.Click, AddressOf close_Click


        'Create helper text
        Dim textblockHelp As New TextBlock()
        textblockHelp.FontSize = 24
        textblockHelp.Foreground = New SolidColorBrush(Colors.White)
        textblockHelp.TextWrapping = TextWrapping.Wrap
        textblockHelp.Text = "Use your finger on the image to define a cropping region." & " Once the region is selected, as seen with a rectangle, tap the crop button to crop the image." & " You may choose to save this image in the media library by tapping the check button on the application bar, or reject the cropping and return to the original image with the cancel button (X)."
        textblockHelp.Margin = New Thickness(5.0)

        'Add controls to stack panel
        panelHelp.Children.Add(textblockHelp)
        panelHelp.Children.Add(close)
        border.Child = panelHelp

        ' Set the Child property of Popup to the border 
        ' that contains a stackpanel, textblock and button.
        help.Child = border

        ' Set where the popup will show up on the screen.   
        help.VerticalOffset = 150
        help.HorizontalOffset = 40

        ' Open the popup.
        help.IsOpen = True

    End Sub


    ''' <summary>
    ''' Click event handler for the close button on the help popup.
    ''' This will create a popup/message box for help and add content to the popup.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub close_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        help.IsOpen = False
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CompositionTarget_Rendering(ByVal sender As Object, ByVal e As EventArgs)
        If cropping Then

            Rect.SetValue(Canvas.LeftProperty, If(p1.X < p2.X, p1.X, p2.X))
            Rect.SetValue(Canvas.TopProperty, If(p1.Y < p2.Y, p1.Y, p2.Y))
            Rect.Width = CInt(Fix(Math.Abs(p2.X - p1.X)))
            Rect.Height = CInt(Fix(Math.Abs(p2.Y - p1.Y)))
        End If
    End Sub


    ''' <summary>
    ''' Click event handler for mouse move.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CropImage_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        p2 = e.GetPosition(DisplayedImageElement)
    End Sub

    ''' <summary>
    ''' Click event handler for mouse left button up
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CropImage_MouseLeftButtonUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        p2 = e.GetPosition(DisplayedImageElement)
        cropping = False


    End Sub

    ''' <summary>
    ''' Click event handler for mouse left button down
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub CropImage_MouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        btnCrop.IsEnabled = True
        p1 = e.GetPosition(DisplayedImageElement)
        p2 = p1
        Rect.Visibility = Visibility.Visible
        cropping = True
    End Sub

    ''' <summary>
    ''' Click event handler for the reject button on the application bar.
    ''' This will allow you to reject the cropped image and set back to the original image.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnReject_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Sets the cropped image back to the original image. For users that want to revert changes.
        DisplayedImageElement.Source = App.CapturedImage

        'Buttons are disabled and user cannot proceed to use the below until they crop an image again.
        btnCrop.IsEnabled = False
        btnAccept.IsEnabled = False
        btnReject.IsEnabled = False

        'Instructional Text
        textStatus.Text = "Select the cropping region with your finger." & " Once completed, tap the crop button to crop the image."

    End Sub

    ''' <summary>
    ''' Click event handler for the accept button on the application bar.
    ''' Saves cropped image to isolated storage, then into
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnAccept_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Make progress bar visible for the event handler as there may be posible latency.
        progressBar2.Visibility = Visibility.Visible

        'Create filename for JPEG in isolated storage
        Dim tempJPEG As String = "TempJPEG.jpg"

        'Create virtual store and file stream. Check for duplicate tempJPEG files.
        Dim myStore = IsolatedStorageFile.GetUserStoreForApplication()
        If myStore.FileExists(tempJPEG) Then
            myStore.DeleteFile(tempJPEG)
        End If
        Dim myFileStream As IsolatedStorageFileStream = myStore.CreateFile(tempJPEG)



        'Encode the WriteableBitmap into JPEG stream and place into isolated storage.
        Extensions.SaveJpeg(App.CroppedImage, myFileStream, App.CroppedImage.PixelWidth, App.CroppedImage.PixelHeight, 0, 85)
        myFileStream.Close()

        'Create a new file stream.
        myFileStream = myStore.OpenFile(tempJPEG, FileMode.Open, FileAccess.Read)

        'Add the JPEG file to the photos library on the device.
        Dim library As New MediaLibrary()
        Dim pic As Picture = library.SavePicture("SavedPicture.jpg", myFileStream)
        myFileStream.Close()

        progressBar2.Visibility = Visibility.Collapsed

        textStatus.Text = "Picture saved to photos library on the device."






    End Sub



    ''' <summary>
    ''' Click event handler for the crop button on the application bar.
    ''' This code creates the new cropped writeable bitmap object.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCrop_Click(ByVal sender As Object, ByVal e As EventArgs)


        ' Get the size of the source image captured by the camera
        Dim originalImageWidth As Double = App.CapturedImage.PixelWidth
        Dim originalImageHeight As Double = App.CapturedImage.PixelHeight


        ' Get the size of the image when it is displayed on the phone
        Dim displayedWidth As Double = DisplayedImageElement.ActualWidth
        Dim displayedHeight As Double = DisplayedImageElement.ActualHeight

        ' Calculate the ratio of the original image to the displayed image
        Dim widthRatio As Double = originalImageWidth / displayedWidth
        Dim heightRatio As Double = originalImageHeight / displayedHeight

        ' Create a new WriteableBitmap. The size of the bitmap is the size of the cropping rectangle
        ' drawn by the user, multiplied by the image size ratio.
        App.CroppedImage = New WriteableBitmap(CInt(Fix(widthRatio * Math.Abs(p2.X - p1.X))), CInt(Fix(heightRatio * Math.Abs(p2.Y - p1.Y))))


        ' Calculate the offset of the cropped image. This is the distance, in pixels, to the top left corner
        ' of the cropping rectangle, multiplied by the image size ratio.
        Dim xoffset As Integer = CInt(Fix((If(p1.X < p2.X, p1.X, p2.X)) * widthRatio))
        Dim yoffset As Integer = CInt(Fix((If(p1.Y < p2.Y, p1.Y, p2.X)) * heightRatio))

        ' Copy the pixels from the targeted region of the source image into the target image, 
        ' using the calculated offset
        For i = 0 To App.CroppedImage.Pixels.Length - 1
            Dim x As Integer = CInt(Fix((i Mod App.CroppedImage.PixelWidth) + xoffset))
            Dim y As Integer = CInt(Fix((i / App.CroppedImage.PixelWidth) + yoffset))
            App.CroppedImage.Pixels(i) = App.CapturedImage.Pixels(y * App.CapturedImage.PixelWidth + x)
        Next i

        ' Set the source of the image control to the new cropped bitmap
        DisplayedImageElement.Source = App.CroppedImage
        Rect.Visibility = Visibility.Collapsed


        'Enable  accept and reject buttons to save or discard current cropped image.
        'Disable crop button until a new cropping region is selected.
        btnAccept.IsEnabled = True
        btnReject.IsEnabled = True
        btnCrop.IsEnabled = False

        'Instructional text
        textStatus.Text = "Continue to crop image, accept, or reject."
    End Sub

End Class

