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
Imports System.Windows.Threading
Imports System.Diagnostics

''' <summary>
''' This class handles all game communication. Communication for the game is made up of
''' a number of commands that we have defined in the GameCommand.vb class. These commands 
''' are the grammar, or set of actions, that we can transmist and receive and interpret.
''' </summary>
Public Class GamePlay
    Implements IDisposable
    ''' <summary>
    ''' All communication takes place using a UdpAnySourceMulticastChannel. 
    ''' A UdpAnySourceMulticastChannel is a wrapper we create around the UdpAnySourceMulticastClient.
    ''' </summary>
    ''' <value>The channel.</value>
    Private Property Channel() As UdpAnySourceMulticastChannel

    ''' <summary>
    ''' The IP address of the multicast group. 
    ''' </summary>
    ''' <remarks>
    ''' A multicast group is defined by a multicast group address, which is an IP address 
    ''' that must be in the range from 224.0.0.0 to 239.255.255.255. Multicast addresses in 
    ''' the range from 224.0.0.0 to 224.0.0.255 inclusive are “well-known” reserved multicast 
    ''' addresses. For example, 224.0.0.0 is the Base address, 224.0.0.1 is the multicast group 
    ''' address that represents all systems on the same physical network, and 224.0.0.2 represents 
    ''' all routers on the same physical network.The Internet Assigned Numbers Authority (IANA) is 
    ''' responsible for this list of reserved addresses. For more information on the reserved 
    ''' address assignments, please see the IANA website.
    ''' http://go.microsoft.com/fwlink/?LinkId=221630
    ''' </remarks>
    Private Const GROUP_ADDRESS As String = "224.0.1.11"

    ''' <summary>
    ''' This defines the port number through which all communication with the multicast group will take place. 
    ''' </summary>
    ''' <remarks>
    ''' The value in this example is arbitrary and you are free to choose your own.
    ''' </remarks>
    Private Const GROUP_PORT As Integer = 54329

    ''' <summary>
    ''' The name of this player.
    ''' </summary>
    Private _playerName As String

    Public Sub New()
        Me.Channel = New UdpAnySourceMulticastChannel(GROUP_ADDRESS, GROUP_PORT)

        ' Register for events on the multicast channel.
        RegisterEvents()

        ' Send a message to the multicast group regularly. This is done because
        ' we use UDP unicast messages during the game, sending messages directly to 
        ' our opponent. This uses the BeginSendTo method on UpdAnySourceMulticastClient
        ' and according to the documentation:
        ' "The transmission is only allowed if the address specified in the remoteEndPoint
        ' parameter has already sent a multicast packet to this receiver"
        ' So, if everyone sends a message to the multicast group, we are guaranteed that this 
        ' player (receiver) has been sent a multicast packet by the opponent. 
        StartKeepAlive()
    End Sub

#Region "Properties"
    ''' <summary>
    ''' The player, against whom, I am currently playing.
    ''' </summary>
    Private _currentOpponent As PlayerInfo
    Public ReadOnly Property CurrentOpponent() As PlayerInfo
        Get
            Return _currentOpponent
        End Get
    End Property

    ''' <summary>
    ''' Whether we are joined to the multicast group
    ''' </summary>
    Public Property IsJoined As Boolean
#End Region

#Region "Game Actions"
    ''' <summary>
    ''' Join the multicast group.
    ''' </summary>
    ''' <param name="playerName">The player name I want to join as.</param>
    ''' <remarks>The player name is not needed for multicast communication. it is 
    ''' used in this example to identify each member of the multicast group with 
    ''' a friendly name. </remarks>
    Public Sub Join(ByVal playerName As String)
        If IsJoined Then
            Return
        End If

        ' Store my player name
        _playerName = playerName

        'Open the connection
        Me.Channel.Open()
    End Sub

    ''' <summary>
    ''' Send a message to the given opponent to challenge him to a game.
    ''' </summary>
    ''' <param name="opponentName">The identifier for the opponent to challenge.</param>
    Public Sub Challenge(ByVal opponentName As String)
        ' Look for this opponent in the list of oppoennts in the group
        Dim opponent As PlayerInfo = App.Players.Where(Function(player) player.PlayerName = opponentName).SingleOrDefault()
        If opponent IsNot Nothing Then
            Me.Channel.SendTo(opponent.PlayerEndPoint, GameCommands.ChallengeFormat, _playerName)
        Else
            DiagnosticsHelper.SafeShow("Opponent is null!")
        End If
    End Sub

    ''' <summary>
    ''' Inform the given opponent that we accept his challenge to play.
    ''' </summary>
    ''' <param name="opponent">The opponent</param>
    Public Sub AcceptChallenge(ByVal opponent As PlayerInfo)
        If opponent IsNot Nothing Then
            _currentOpponent = opponent
            Me.Channel.SendTo(_currentOpponent.PlayerEndPoint, GameCommands.AcceptChallengeFormat, _playerName)
        End If
    End Sub

    ''' <summary>
    ''' Reject the challenge from the given opponent.
    ''' </summary>
    ''' <param name="opponent">The opponent</param>
    Public Sub RejectChallenge(ByVal opponent As PlayerInfo)
        If opponent IsNot Nothing Then
            Me.Channel.SendTo(opponent.PlayerEndPoint, GameCommands.RejectChallengeFormat, _playerName)
        End If
    End Sub

    ''' <summary>
    ''' Leave the multicast group. We will not show up in the list of opponents on any
    ''' other client devices.
    ''' </summary>
    Public Sub Leave(ByVal disconnect As Boolean)
        If Me.Channel IsNot Nothing Then
            ' Tell everyone we have left
            Me.Channel.Send(GameCommands.LeaveFormat, _playerName)

            ' Only close the underlying communications channel to the multicast group
            ' if disconnect == true.
            If disconnect Then
                Me.Channel.Close()
            End If

        End If

        ' Clear the opponent
        _currentOpponent = Nothing
        Me.IsJoined = False
    End Sub

    ''' <summary>
    ''' Leave the current game
    ''' </summary>
    Public Sub LeaveGame()
        If Me.Channel IsNot Nothing AndAlso _currentOpponent IsNot Nothing Then
            ' Tell the opponent
            Me.Channel.SendTo(_currentOpponent.PlayerEndPoint, GameCommands.LeaveGameFormat, _playerName)
            _currentOpponent = Nothing
        End If
    End Sub

    ''' <summary>
    ''' Tell the opponent what our choice is for this current game
    ''' </summary>
    ''' <param name="gamepiece">A Rock, Paper or Scissors</param>
    Public Sub Play(ByVal gamepiece As String)
        If Me.Channel IsNot Nothing Then
            ' Tell the opponent
            Me.Channel.SendTo(_currentOpponent.PlayerEndPoint, GameCommands.PlayFormat, _playerName, gamepiece)
        End If
    End Sub

    ''' <summary>
    ''' Tell the opponent we want to start a new game
    ''' </summary>
    Public Sub NewGame()
        If Me.Channel IsNot Nothing AndAlso _currentOpponent IsNot Nothing Then
            ' Tell the opponent
            Me.Channel.SendTo(_currentOpponent.PlayerEndPoint, GameCommands.NewGameFormat, _playerName)
        End If
    End Sub
#End Region

#Region "Multicast Communication"
    ''' <summary>
    ''' Register for events on the multicast channel.
    ''' </summary>
    Private Sub RegisterEvents()
        ' Register for events from the multicast channel
        AddHandler Channel.Joined, AddressOf Channel_Joined
        AddHandler Channel.BeforeClose, AddressOf Channel_BeforeClose
        AddHandler Channel.PacketReceived, AddressOf Channel_PacketReceived
    End Sub

    ''' <summary>
    ''' Unregister for events on the multicast channel
    ''' </summary>
    Private Sub UnregisterEvents()
        If Me.Channel IsNot Nothing Then
            ' Register for events from the multicast channel
            RemoveHandler Channel.Joined, AddressOf Channel_Joined
            RemoveHandler Channel.BeforeClose, AddressOf Channel_BeforeClose
            RemoveHandler Channel.PacketReceived, AddressOf Channel_PacketReceived
        End If
    End Sub
    ''' <summary>
    ''' Handles the BeforeClose event of the Channel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Channel_BeforeClose(ByVal sender As Object, ByVal e As EventArgs)
        Me.Channel.Send(String.Format(GameCommands.Leave, _playerName))
    End Sub

    ''' <summary>
    ''' Handles the Joined event of the Channel.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Channel_Joined(ByVal sender As Object, ByVal e As EventArgs)
        Me.IsJoined = True
        Me.Channel.Send(GameCommands.JoinFormat, _playerName)
    End Sub

    ''' <summary>
    ''' Handles the PacketReceived event of the Channel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The see cref="SilverlightPlayground.UDPMulticast.UdpPacketReceivedEventArgs" instance containing the event data.</param>
    Private Sub Channel_PacketReceived(ByVal sender As Object, ByVal e As UdpPacketReceivedEventArgs)
        Dim message As String = e.Message.Trim(ControlChars.NullChar)
        Dim messageParts() As String = message.Split(GameCommands.CommandDelimeter.ToCharArray())

        If messageParts.Length = 2 Then
            Select Case messageParts(0)
                Case GameCommands.Join
                    OnPlayerJoined(New PlayerInfo(messageParts(1), e.Source))
                Case GameCommands.AcceptChallenge
                    OnChallengeAccepted(New PlayerInfo(messageParts(1), e.Source))
                Case GameCommands.Challenge
                    OnChallengeReceived(New PlayerInfo(messageParts(1), e.Source))
                Case GameCommands.NewGame
                    OnNewGame(New PlayerInfo(messageParts(1), e.Source))
                Case GameCommands.Leave
                    OnPlayerLeft(New PlayerInfo(messageParts(1), e.Source))
                Case GameCommands.LeaveGame
                    OnLeaveGame(New PlayerInfo(messageParts(1), e.Source))
                Case GameCommands.RejectChallenge
                    OnChallengeRejected(New PlayerInfo(messageParts(1), e.Source))
                Case GameCommands.Ready
                    Debug.WriteLine("Ready received")
                Case Else
            End Select


        ElseIf messageParts.Length = 3 AndAlso messageParts(0) = GameCommands.Play Then
            Dim args As New OpponentPlayedEventArgs()
            args.gamepiece = messageParts(2)
            args.playerInfo = New PlayerInfo(messageParts(1), e.Source)
            RaiseEvent OpponentPlayed(Me, args)
        Else
            ' Ignore messages that don't have the expected number of parts.
        End If
    End Sub
#End Region

#Region "Command Handlers - methods to handle each command that we receive"
    ''' <summary>
    ''' Handle a player joining the multicast group.
    ''' </summary>
    ''' <param name="playerInfo">The player.</param>
    Private Sub OnPlayerJoined(ByVal playerInfo As PlayerInfo)
        Dim add As Boolean = True
        Dim numberAdded As Integer = 0

        For Each pi In App.Players
            If pi.PlayerName = playerInfo.PlayerName Then

                pi.PlayerEndPoint = playerInfo.PlayerEndPoint

                add = False
                Exit For
            End If
        Next pi

        If add Then
            numberAdded += 1
            App.Players.Add(playerInfo)
        End If

        ' If any new players have been added, send out our join message again
        ' to make sure we are added to their player list.
        If numberAdded > 0 Then
            Me.Channel.Send(GameCommands.JoinFormat, _playerName)
        End If

#If DEBUG Then
        Debug.WriteLine(" =========   PLAYERS =============")
        For Each pi In App.Players
            Debug.WriteLine(String.Format("{1} [{0}]", pi.PlayerName, pi.PlayerEndPoint))
        Next pi
#End If
    End Sub

    ''' <summary>
    ''' Handle a player leaving the multicast group.
    ''' </summary>
    ''' <param name="playerInfo">The player.</param>
    Private Sub OnPlayerLeft(ByVal playerInfo As PlayerInfo)
        If playerInfo.PlayerName <> _playerName Then
            For Each pi In App.Players
                If pi.PlayerName = playerInfo.PlayerName Then
                    App.Players.Remove(pi)
                    Exit For
                End If
            Next pi
        End If

        OnLeaveGame(playerInfo)
    End Sub

    ''' <summary>
    ''' Handle a challenge from a player.
    ''' </summary>
    ''' <param name="playerInfo">The player.</param>
    Private Sub OnChallengeReceived(ByVal playerInfo As PlayerInfo)
        If playerInfo.PlayerName = _playerName Then
            Return
        End If

        If _currentOpponent IsNot Nothing Then
            ' Automatically reject incoming challenge if I am already in a game
            RejectChallenge(playerInfo)
        Else
            Dim result As MessageBoxResult = DiagnosticsHelper.SafeShow(String.Format("'{0}' is challenging you." & Environment.NewLine & "Ok to accept, Cancel to reject", playerInfo.PlayerName), "Incoming Challenge", MessageBoxButton.OKCancel)
            If result = MessageBoxResult.OK Then
                AcceptChallenge(playerInfo)
                Dim uriString As String = String.Format("/Game.xaml?player={0}&opponent={1}", _playerName, playerInfo.PlayerName)
                TryCast(Application.Current, App).RootFrame.Navigate(New Uri(uriString, UriKind.RelativeOrAbsolute))
            Else
                RejectChallenge(playerInfo)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handle a player accepting our challenge.
    ''' </summary>
    ''' <param name="playerInfo">The player.</param>
    Private Sub OnChallengeAccepted(ByVal playerInfo As PlayerInfo)
        _currentOpponent = playerInfo
        DiagnosticsHelper.SafeShow(String.Format("Player '{0}' Accepted Your Challenge", playerInfo.PlayerName))
        Dim uriString As String = String.Format("/Game.xaml?player={0}&opponent={1}", _playerName, playerInfo.PlayerName)
        TryCast(Application.Current, App).RootFrame.Navigate(New Uri(uriString, UriKind.RelativeOrAbsolute))
    End Sub

    ''' <summary>
    ''' Handle a player rejecting our challenge.
    ''' </summary>
    ''' <param name="playerInfo">The player.</param>
    Private Sub OnChallengeRejected(ByVal playerInfo As PlayerInfo)
        _currentOpponent = Nothing
        DiagnosticsHelper.SafeShow(String.Format("Player '{0}' Rejected Your Challenge", playerInfo.PlayerName))
    End Sub

    ''' <summary>
    ''' Handle an opponent requesting a new game.
    ''' </summary>
    ''' <param name="playerInfo">The player.</param>
    Private Sub OnNewGame(ByVal playerInfo As PlayerInfo)
        ' Is the current opponent requesting a new game?
        If _currentOpponent IsNot Nothing AndAlso playerInfo.PlayerName = _currentOpponent.PlayerName Then
            Dim args As New PlayerEventArgs()
            args.playerInfo = playerInfo
            RaiseEvent NewGameRequested(Me, args)
        End If
    End Sub

    ''' <summary>
    ''' Handle a player leaving a game.
    ''' </summary>
    ''' <param name="playerInfo">The player.</param>
    Private Sub OnLeaveGame(ByVal playerInfo As PlayerInfo)
        ' Kill game if I am playing against this opponent
        If _currentOpponent IsNot Nothing AndAlso playerInfo.PlayerName = _currentOpponent.PlayerName Then
            Dim args As New PlayerEventArgs()
            args.playerInfo = playerInfo
            RaiseEvent LeftGame(Me, args)
        End If
    End Sub

    Public Event OpponentPlayed As OpponentPlayedEventHandler
    Public Event NewGameRequested As NewGameRequestedHandler
    Public Event LeftGame As LeftGameHandler
#End Region

#Region "Keep-Alive"
    Private _dt As DispatcherTimer
    Private Sub StartKeepAlive()
        If _dt Is Nothing Then
            _dt = New DispatcherTimer()
            _dt.Interval = New TimeSpan(0, 0, 1)
            AddHandler _dt.Tick, Sub(s As Object, args As EventArgs)
                                     If Me.Channel IsNot Nothing AndAlso IsJoined Then
                                         Me.Channel.Send(GameCommands.ReadyFormat, _playerName)
                                     End If
                                 End Sub
        End If
        _dt.Start()

    End Sub


    Private Sub StopkeepAlive()
        If _dt IsNot Nothing Then
            _dt.Stop()
        End If
    End Sub
#End Region

#Region "IDisposable Implementation"
    Public Sub Dispose() Implements IDisposable.Dispose
        UnregisterEvents()
        StopkeepAlive()
    End Sub
#End Region

End Class

' A delegate type for hooking up change notifications.
Public Delegate Sub OpponentPlayedEventHandler(ByVal sender As Object, ByVal e As OpponentPlayedEventArgs)
Public Delegate Sub NewGameRequestedHandler(ByVal sender As Object, ByVal e As PlayerEventArgs)
Public Delegate Sub LeftGameHandler(ByVal sender As Object, ByVal e As PlayerEventArgs)

Public Class PlayerEventArgs
    Inherits EventArgs
    Public Property playerInfo() As PlayerInfo
End Class

''' <summary>
''' When we receive a message that the opponent has played, we pass
''' on the playerInfo and the gamepiece they played.
''' </summary>
Public Class OpponentPlayedEventArgs
    Inherits EventArgs
    Public Property playerInfo() As PlayerInfo
    Public Property gamepiece() As String
End Class
