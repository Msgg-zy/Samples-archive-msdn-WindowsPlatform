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
Partial Public Class SettingsWithConfirmation
    Inherits PhoneApplicationPage

    Private settings As New AppSettings()

    Public Sub New()
        InitializeComponent()

        ' Add an Application Bar that has a 'done' confirmation button and 
        ' a 'cancel' button
        ApplicationBar = New ApplicationBar()
        ApplicationBar.IsMenuEnabled = True
        ApplicationBar.IsVisible = True
        ApplicationBar.Opacity = 1.0

        Dim doneButton As New ApplicationBarIconButton(New Uri("/Images/appbar.check.rest.png", UriKind.Relative))
        doneButton.Text = "done"
        AddHandler doneButton.Click, AddressOf doneButton_Click

        Dim cancelButton As New ApplicationBarIconButton(New Uri("/Images/appbar.cancel.rest.png", UriKind.Relative))
        cancelButton.Text = "cancel"
        AddHandler cancelButton.Click, AddressOf cancelButton_Click

        ApplicationBar.Buttons.Add(doneButton)
        ApplicationBar.Buttons.Add(cancelButton)
    End Sub

    ''' <summary>
    ''' Done button clicked event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub doneButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        settings.UsernameSetting = textBoxUsername.Text
        settings.PasswordSetting = passwordBoxPassword.Password
        NavigationService.GoBack()
    End Sub

    ''' <summary>
    ''' Cancel button clicked event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        NavigationService.GoBack()
    End Sub
End Class
