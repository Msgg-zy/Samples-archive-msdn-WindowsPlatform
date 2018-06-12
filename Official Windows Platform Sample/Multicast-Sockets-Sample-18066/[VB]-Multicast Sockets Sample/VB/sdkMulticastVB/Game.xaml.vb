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
Partial Public Class Game
    Inherits PhoneApplicationPage
    ' Both players in a game choose a rock, paper or scissors.
    ' Store the choices in these variables
    Private _myChoice As String = String.Empty
    Private _opponentsChoice As String = String.Empty

    ' The player names
    Private _player As String = Nothing
    Private _opponent As String = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        MyBase.OnNavigatedTo(e)

        ' Initialize the game
        NavigationContext.QueryString.TryGetValue("player", _player)
        NavigationContext.QueryString.TryGetValue("opponent", _opponent)

        If App.GamePlay.CurrentOpponent Is Nothing Then
            NavigationService.Navigate(New Uri("/Players.xaml?player=" & _player, UriKind.RelativeOrAbsolute))
        End If

        MyScoreName.Text = _player
        MyScoreValue.Text = "0"
        OpponentScoreName.Text = _opponent
        OpponentScoreValue.Text = "0"
        OpponentPiecesTextBlock.Text = _opponent
        MyPiecesTextBlock.Text = _player

        ' No choices have been made yet
        _myChoice = String.Empty
        _opponentsChoice = String.Empty

        ' Register for event notifications.
        RegisterEvents()
    End Sub

    Protected Overrides Sub OnNavigatingFrom(ByVal e As System.Windows.Navigation.NavigatingCancelEventArgs)
        MyBase.OnNavigatingFrom(e)

        ' Notify opponent (if one exists) that I have left the game
        If e.NavigationMode = System.Windows.Navigation.NavigationMode.Back Then
            App.GamePlay.LeaveGame()
        Else
            App.GamePlay.Leave(False)
        End If

        UnregisterEvents()
    End Sub

    Private Sub RegisterEvents()
        AddHandler App.GamePlay.OpponentPlayed, AddressOf GamePlay_OpponentPlayed
        AddHandler App.GamePlay.NewGameRequested, AddressOf GamePlay_NewGameRequested
        AddHandler App.GamePlay.LeftGame, AddressOf GamePlay_LeftGame
    End Sub

    Private Sub UnregisterEvents()
        If App.GamePlay IsNot Nothing Then
            RemoveHandler App.GamePlay.OpponentPlayed, AddressOf GamePlay_OpponentPlayed
            RemoveHandler App.GamePlay.NewGameRequested, AddressOf GamePlay_NewGameRequested
            RemoveHandler App.GamePlay.LeftGame, AddressOf GamePlay_LeftGame
        End If
    End Sub

    Private Sub GamePlay_LeftGame(ByVal sender As Object, ByVal e As PlayerEventArgs)
        ' If the opponent leaves the game, back out of the game screen, since we will want
        ' to choose another opponent.
        DiagnosticsHelper.SafeShow(String.Format("Player '{0}' has left the game", e.playerInfo.PlayerName))

        ' Opponent has left, so clear the opponent name
        _opponent = Nothing
        If NavigationService.CanGoBack Then
            NavigationService.GoBack()
        End If

    End Sub

    Private Sub GamePlay_NewGameRequested(ByVal sender As Object, ByVal e As PlayerEventArgs)
        ' Either player can tap "Play Again" which sends a message to setup a new game
        ' We encapsualte the setting up of a new game here.
        SetupNewGame()
    End Sub

    Private Sub GamePlay_OpponentPlayed(ByVal sender As Object, ByVal e As OpponentPlayedEventArgs)
        ' We received notification that the opponent has chosen a gamepiece (rock, paper, scissors)
        ' The event argument contains the piece the opponent chose.
        _opponentsChoice = e.gamepiece

        ' If I have already chosen, then we are ready to see who won
        If Not String.IsNullOrWhiteSpace(_myChoice) Then
            ' Color the opponent's gamepiece
            SelectGamePiece(OpponentGamePieces, _opponentsChoice)
            DetermineWinner()
        End If
    End Sub

    ''' <summary>
    ''' Change the visual representation (style) of the gamepiece that was chosen
    ''' </summary>
    ''' <param name="stackPanel">The gamepieces are organized into two StackPanels. This parameter contains the 
    ''' StackPanel, or gamepiece set, to change. It can be our set, or the opponent's.</param>
    ''' <param name="tag">Each gamepiece has the tag property set uniquely to identify each.</param>
    Private Sub SelectGamePiece(ByVal stackPanel As StackPanel, ByVal tag As String)
        For Each border In stackPanel.Children.OfType(Of Border)()
            If border.Child.GetValue(TagProperty).ToString() = tag Then
                border.BorderBrush = CType(Resources("PhoneAccentBrush"), Brush)
                border.Background = CType(Resources("PhoneAccentBrush"), Brush)
            Else
                border.BorderBrush = New SolidColorBrush(Colors.Transparent)
                border.Background = New SolidColorBrush(Colors.Transparent)
            End If
        Next border
    End Sub

    ''' <summary>
    ''' Clear the visual representation of all gamepieces in a set
    ''' </summary>
    ''' <param name="stackPanel">he gamepieces are organized into two StackPanels. This parameter contains the 
    ''' StackPanel, or gamepiece set, to change. It can be our set, or the opponent's.</param>
    Private Sub ClearGamePieces(ByVal stackPanel As StackPanel)
        For Each border In stackPanel.Children.OfType(Of Border)()
            border.BorderBrush = New SolidColorBrush(Colors.Transparent)
            border.Background = New SolidColorBrush(Colors.Transparent)
        Next border
    End Sub


    Private Sub GamePiece_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Don't allow me to change my mind. Once a gamepiece is selected (clicked) we are locked in for this round.
        MyGamePieces.IsHitTestVisible = False
        Dim button As Button = TryCast(sender, Button)

        ' The tag on the button identifies the piece (that is, rock, paper or scissors)
        _myChoice = button.Tag.ToString()
        SelectGamePiece(MyGamePieces, _myChoice)

        ' Tell the opponent I am ready to play, and send my selection
        App.GamePlay.Play(_myChoice)

        ' The opponet may have played already. If that is the case, the _opponentsChoice field
        ' will contain their choice.
        If Not String.IsNullOrWhiteSpace(_opponentsChoice) Then
            ' Color the opponent's gamepiece
            SelectGamePiece(OpponentGamePieces, _opponentsChoice)

            ' Sicne we have both played, find out who won.
            DetermineWinner()
        End If

    End Sub

    Private Sub DetermineWinner()
        ' Both players must have played
        If _myChoice <> String.Empty AndAlso _opponentsChoice <> String.Empty Then
            ' Draw if we chose the same gamepiece
            If _myChoice = _opponentsChoice Then
                ' Draw
                ResultTextBlock.Text = "Draw!"
            Else

                Select Case _myChoice
                    Case "PAPER"
                        ' Paper beats Rock
                        If _opponentsChoice = "ROCK" Then
                            ' You win
                            ResultTextBlock.Text = "You Win!"
                            MyScoreValue.Text = (Int32.Parse(MyScoreValue.Text) + 1).ToString()
                        Else
                            ' Opponent Wins
                            ResultTextBlock.Text = "Opponent Wins!"
                            OpponentScoreValue.Text = (Int32.Parse(OpponentScoreValue.Text) + 1).ToString()
                        End If
                    Case "ROCK"
                        ' Rock beats scissors
                        If _opponentsChoice = "SCISSORS" Then
                            ' You win
                            ResultTextBlock.Text = "You Win!"
                            MyScoreValue.Text = (Int32.Parse(MyScoreValue.Text) + 1).ToString()
                        Else
                            ' Opponent Wins
                            ResultTextBlock.Text = "Opponent Wins!"
                            OpponentScoreValue.Text = (Int32.Parse(OpponentScoreValue.Text) + 1).ToString()
                        End If
                    Case "SCISSORS"
                        ' Scissors beats paper
                        If _opponentsChoice = "PAPER" Then
                            ' You win
                            ResultTextBlock.Text = "You Win!"
                            MyScoreValue.Text = (Int32.Parse(MyScoreValue.Text) + 1).ToString()
                        Else
                            ' Opponent Wins
                            ResultTextBlock.Text = "Opponent Wins!"
                            OpponentScoreValue.Text = (Int32.Parse(OpponentScoreValue.Text) + 1).ToString()
                        End If
                    Case Else
                        ' ??
                End Select
            End If

            _myChoice = String.Empty
            _opponentsChoice = _myChoice
            PlayAgainButton.Visibility = System.Windows.Visibility.Visible

        End If
    End Sub

    Private Sub PlayAgainButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        SetupNewGame()
        App.GamePlay.NewGame()

    End Sub

    Private Sub SetupNewGame()
        PlayAgainButton.Visibility = System.Windows.Visibility.Collapsed
        ClearGamePieces(MyGamePieces)
        ClearGamePieces(OpponentGamePieces)
        ResultTextBlock.Text = String.Empty
        MyGamePieces.IsHitTestVisible = True
    End Sub

    Private Sub PhoneApplicationPage_Unloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        UnregisterEvents()
    End Sub

End Class
