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
Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub JoinButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If String.IsNullOrWhiteSpace(UsernameTextBox.Text) Then
            ' Display a message. Diagnostics.SafeShow is a wrapper that makes sure
            ' we call the messagebox on the UI thread.
            DiagnosticsHelper.SafeShow("Please enter a username to join the game")
        Else
            ' Make sure the name we chose shows up in the players list.
            App.Players.Add(New PlayerInfo(UsernameTextBox.Text))

            ' Go to the players list.
            NavigationService.Navigate(New Uri("/Players.xaml?player=" & UsernameTextBox.Text, UriKind.RelativeOrAbsolute))
        End If
    End Sub

    Private Sub LeaveButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If App.GamePlay IsNot Nothing Then
            App.GamePlay.Leave(False)
        End If
    End Sub
End Class
