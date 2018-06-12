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
Partial Public Class Players
    Inherits PhoneApplicationPage
    ''' <summary>
    ''' The current player.
    ''' </summary>
    Private _player As String = String.Empty

    Public Sub New()
        InitializeComponent()

        ' The players listbox control is bound to the players list.
        Me.DataContext = App.Players

    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        MyBase.OnNavigatedTo(e)

        If NavigationContext.QueryString.TryGetValue("player", _player) Then
            App.GamePlay.Join(_player)
        End If

        PlayersListBox.SelectedItem = Nothing
    End Sub

    Private Sub ChallengButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If PlayersListBox.SelectedItem Is Nothing Then
            DiagnosticsHelper.SafeShow("Please select an opponent from the list")
        Else
            Dim opponentName As String = (CType(PlayersListBox.SelectedItem, PlayerInfo)).PlayerName
            App.GamePlay.Challenge(opponentName)

        End If
    End Sub

    Private Sub PlayersListBox_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
        ' Note that I cannot select myself in this list.
        If e.AddedItems.Count > 0 AndAlso (CType(e.AddedItems(0), PlayerInfo)).PlayerName = _player Then
            PlayersListBox.SelectedItem = Nothing
        End If
    End Sub
End Class
