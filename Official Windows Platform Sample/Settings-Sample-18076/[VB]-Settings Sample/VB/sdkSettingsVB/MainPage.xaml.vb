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
Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Constructor
    Public Sub New()
        InitializeComponent()

        SupportedOrientations = SupportedPageOrientation.Portrait

        ' Add an Application Bar with a 'setting menu item.
        ApplicationBar = New ApplicationBar()
        ApplicationBar.IsMenuEnabled = True
        ApplicationBar.IsVisible = True
        ApplicationBar.Opacity = 1.0

        Dim settingsItem As New ApplicationBarMenuItem("settings")
        AddHandler settingsItem.Click, AddressOf settings_Click

        ApplicationBar.MenuItems.Add(settingsItem)
    End Sub

    ''' <summary>
    ''' Settings button clicked event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub settings_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.NavigationService.Navigate(New Uri("/SettingsWithoutConfirmation.xaml", UriKind.Relative))
    End Sub

End Class
