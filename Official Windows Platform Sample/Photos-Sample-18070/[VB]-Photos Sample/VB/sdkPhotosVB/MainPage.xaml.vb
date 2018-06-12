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
Imports Microsoft.Phone.Tasks
Imports Microsoft.Phone
Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Windows.Controls.Primitives

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    'This is a variable for the help popup.
    Private help As New Popup()

    'The application bar buttons that are used.
    Private btnCamera As ApplicationBarIconButton
    Private btnCrop As ApplicationBarIconButton
    Private btnHelp As ApplicationBarIconButton

    'The camera chooser used to capture a picture.
    Private ctask As CameraCaptureTask

    ' Constructor
    Public Sub New()
        InitializeComponent()

        SupportedOrientations = SupportedPageOrientation.Portrait Or SupportedPageOrientation.Landscape

        'Creates an application bar and then sets visibility and menu properties.
        ApplicationBar = New ApplicationBar()
        ApplicationBar.IsVisible = True

        'This code creates the application bar icon buttons.
        btnCamera = New ApplicationBarIconButton(New Uri("/Icons/appbar.feature.camera.rest.png", UriKind.Relative))
        btnCrop = New ApplicationBarIconButton(New Uri("/Icons/appbar.edit.rest.png", UriKind.Relative))
        btnHelp = New ApplicationBarIconButton(New Uri("/Icons/appbar.questionmark.rest.png", UriKind.Relative))

        'Labels for the application bar buttons.
        btnCamera.Text = "Camera"
        btnCrop.Text = "Crop"
        btnHelp.Text = "Help"

        'This code will create event handlers for buttons.
        AddHandler btnCamera.Click, AddressOf btnCamera_Click
        AddHandler btnCrop.Click, AddressOf btnCrop_Click
        AddHandler btnHelp.Click, AddressOf btnHelp_Click

        'This code adds buttons to application bar.
        ApplicationBar.Buttons.Add(btnCamera)
        ApplicationBar.Buttons.Add(btnCrop)
        ApplicationBar.Buttons.Add(btnHelp)

        'Disable crop button until photo is taken.
        btnCrop.IsEnabled = False

        textStatus.Text = "Tap the camera button to take a picture."

        'Create new instance of CameraCaptureClass
        ctask = New CameraCaptureTask()

        'Create new event handler for capturing a photo
        AddHandler ctask.Completed, AddressOf ctask_Completed
    End Sub


    ''' <summary>
    ''' Click event handler for the help button.
    '''This will create a popup/message box for help and add content to the popup.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnHelp_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Stack panel with a black background.
        Dim panelHelp As New StackPanel()
        panelHelp.Background = New SolidColorBrush(Colors.Black)
        panelHelp.Width = 300
        panelHelp.Height = 400

        'Create a white border.
        Dim border As New Border()
        border.BorderBrush = New SolidColorBrush(Colors.White)
        border.BorderThickness = New Thickness(7.0)

        'Create a close button to exit popup.
        Dim close As New Button()
        close.Content = "Close"
        close.Margin = New Thickness(5.0)
        AddHandler close.Click, AddressOf close_Click

        'Create helper text
        Dim textblockHelp As New TextBlock()
        textblockHelp.FontSize = 24
        textblockHelp.Foreground = New SolidColorBrush(Colors.White)
        textblockHelp.TextWrapping = TextWrapping.Wrap
        textblockHelp.Text = "Tap the camera button image on the application bar to take a photo." & " Once the photo is taken and returned to this page, tap the crop button on the application bar to crop the image."
        textblockHelp.Margin = New Thickness(5.0)

        'Add controls to stack panel
        panelHelp.Children.Add(textblockHelp)
        panelHelp.Children.Add(close)
        border.Child = panelHelp

        ' Set the Child property of Popup to the border 
        ' that contains a stackpanel, textblock and button.
        help.Child = border

        ' Set where the popup will show up on the screen.   
        help.VerticalOffset = 200
        help.HorizontalOffset = 85

        ' Open the popup.
        help.IsOpen = True
    End Sub

    ''' <summary>
    ''' Click event handler for the close button on the help popup.
    ''' Closes the poupup.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub close_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        help.IsOpen = False
    End Sub

    ''' <summary>
    ''' Click event handler for the crop button on the application bar.
    ''' This will redirect the user to the cropping page.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCrop_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Error text for if user does not take a photo before choosing the crop button.
        If App.CapturedImage Is Nothing Then
            textStatus.Text = "You must take a picture first."

        Else
            'If photo has been taken, crop button navigates to Crop.xaml page.
            NavigationService.Navigate(New Uri("/Crop.xaml", UriKind.Relative))
        End If
    End Sub

    ''' <summary>
    ''' Click event handler for the camera button.
    ''' Opens the camera on the phone.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCamera_Click(ByVal sender As Object, ByVal e As EventArgs)
        textStatus.Text = ""

        'Show the camera.
        ctask.Show()

        'Set progress bar to visible to show time between user snapshot and decoding
        'of image into a writeable bitmap object.
        progressBar1.Visibility = Visibility.Visible
    End Sub


    ''' <summary>
    ''' Event handler for retrieving the JPEG photo stream.
    ''' Also to for decoding JPEG stream into a writeable bitmap and displaying.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ctask_Completed(ByVal sender As Object, ByVal e As PhotoResult)

        If e.TaskResult = TaskResult.OK AndAlso e.ChosenPhoto IsNot Nothing Then

            'Take JPEG stream and decode into a WriteableBitmap object
            App.CapturedImage = PictureDecoder.DecodeJpeg(e.ChosenPhoto)

            'Collapse visibility on the progress bar once writeable bitmap is visible.
            progressBar1.Visibility = Visibility.Collapsed


            'Populate image control with WriteableBitmap object.
            MainImage.Source = App.CapturedImage

            'Once writeable bitmap has been rendered, the crop button
            'is enabled.
            btnCrop.IsEnabled = True

            textStatus.Text = "Tap the crop button to proceed"
        Else
            textStatus.Text = "You decided not to take a picture."
        End If
    End Sub
End Class
