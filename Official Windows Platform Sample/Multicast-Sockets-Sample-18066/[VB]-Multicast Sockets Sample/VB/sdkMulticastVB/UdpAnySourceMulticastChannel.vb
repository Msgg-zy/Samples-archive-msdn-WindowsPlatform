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
Imports System.Net.Sockets
Imports System.Text
Imports System.Diagnostics

''' <summary>
''' This contains the UDP multicast sockets code for joining the group, sending and receiving data.
''' </summary>
Public Class UdpAnySourceMulticastChannel
    Implements IDisposable
    ''' <summary>
    ''' Occurs when a packet is received.
    ''' </summary>
    Public Event PacketReceived As EventHandler(Of UdpPacketReceivedEventArgs)

    ''' <summary>
    ''' Occurs when the request to join a multicast group has completed.
    ''' </summary>
    Public Event Joined As EventHandler

    ''' <summary>
    ''' Occurs before closing or shutting down this instance.
    ''' </summary>
    Public Event BeforeClose As EventHandler

    ''' <summary>
    ''' Gets or sets a value indicating whether this instance is disposed.
    ''' </summary>
    ''' <value>
    ''' 	<c>true</c> if this instance is disposed; otherwise, <c>false</c>.
    ''' </value>
    Public Property IsDisposed As Boolean

    ''' <summary>
    ''' Gets or sets a value indicating whether this instance is joined.
    ''' </summary>
    ''' <value><c>true</c> if this instance is joined; otherwise, <c>false</c>.</value>
    Public Property IsJoined As Boolean

    ''' <summary>
    ''' Gets or sets the size of the max message.
    ''' </summary>
    ''' <value>The size of the max message.</value>
    Private Property ReceiveBuffer() As Byte()

    ''' <summary>
    ''' Gets or sets the client.
    ''' </summary>
    ''' <value>The client.</value>
    Private Property Client() As UdpAnySourceMulticastClient

    ''' <summary>
    ''' Initializes a new instance of the <see cref="UdpAnySourceMulticastChannel"/> class.
    ''' </summary>
    ''' <param name="address">The address.</param>
    ''' <param name="port">The port.</param>
    Public Sub New(ByVal address As String, ByVal port As Integer)
        Me.New(IPAddress.Parse(address), port, 1024)
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the <see cref="UdpAnySourceMulticastChannel"/> class.
    ''' </summary>
    ''' <param name="address">The address.</param>
    ''' <param name="port">The port.</param>
    ''' <param name="maxMessageSize">Size of the max message.</param>
    Public Sub New(ByVal address As IPAddress, ByVal port As Integer, ByVal maxMessageSize As Integer)
        Me.ReceiveBuffer = New Byte(maxMessageSize - 1) {}
        Me.Client = New UdpAnySourceMulticastClient(address, port)

    End Sub

    ''' <summary>
    ''' Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        If Not IsDisposed Then
            Me.IsDisposed = True

            If Me.Client IsNot Nothing Then
                Me.Client.Dispose()
            End If
        End If
    End Sub

    ' Make sure we don't attempt overlapping join requests.
    Private _joinPending As Boolean = False

    ''' <summary>
    ''' Opens this instance.
    ''' </summary>
    Public Sub Open()
        Try
            If (Not Me.IsJoined) AndAlso (Not _joinPending) Then
                _joinPending = True
                Me.Client.BeginJoinGroup(New AsyncCallback(AddressOf OpenCallback), Nothing)
            End If
        Catch socketEx As SocketException
            ' See if we can do something when a SocketException occurs.
            HandleSocketException(socketEx)
        End Try
    End Sub

    Private Sub OpenCallback(ByVal result As IAsyncResult)
        Try
            Me.Client.EndJoinGroup(result)

            Me.IsJoined = True
            _joinPending = False

            ' We don't want to receive the messages we send.
            Me.Client.MulticastLoopback = False
            Deployment.Current.Dispatcher.BeginInvoke(Sub()
                                                          Me.OnJoined()
                                                          Me.Receive()
                                                      End Sub)
        Catch socketEx As SocketException
            ' See if we can do something when a SocketException occurs.
            HandleSocketException(socketEx)
        End Try

    End Sub

    ''' <summary>
    ''' Closes this instance.
    ''' </summary>
    Public Sub Close()
        Me.OnBeforeClose()
        Me.IsJoined = False
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' Sends the specified format. This is a multicast message that is sent to all members of the multicast group.
    ''' </summary>
    ''' <param name="format">The format.</param>
    ''' <param name="args">The args.</param>
    Public Sub Send(ByVal format As String, ByVal ParamArray args() As Object)
        Try
            If Me.IsJoined Then
                Dim data() As Byte = Encoding.UTF8.GetBytes(String.Format(format, args))
                Me.Client.BeginSendToGroup(data, 0, data.Length, New AsyncCallback(AddressOf SendToGroupCallback), Nothing)
            End If
        Catch socketEx As SocketException

            ' See if we can do something when a SocketException occurs.
            HandleSocketException(socketEx)
        Catch e1 As InvalidOperationException
            Debug.WriteLine("BeginSendToGroup IOE")
        End Try
    End Sub

    Private Sub SendToGroupCallback(ByVal result As IAsyncResult)
        Try
            If Not IsDisposed Then
                Me.Client.EndSendToGroup(result)
            End If
        Catch socketEx As SocketException
            ' See if we can do something when a SocketException occurs.
            HandleSocketException(socketEx)
        End Try
    End Sub

    ''' <summary>
    ''' Sends the specified format. This is a unicast message, sent to the member of the multicast group at the given endPoint.
    ''' </summary>
    ''' /// <param name="endPoint">The destination.</param>
    ''' <param name="format">The format.</param>
    ''' <param name="args">The args.</param>
    Public Sub SendTo(ByVal endPoint As IPEndPoint, ByVal format As String, ByVal ParamArray args() As Object)
        Try
            If Me.IsJoined Then
                Dim msg As String = String.Format(format, args)
                Dim data() As Byte = Encoding.UTF8.GetBytes(msg)
                Me.Client.BeginSendTo(data, 0, data.Length, endPoint, New AsyncCallback(AddressOf SendToCallback), Nothing)
            Else
                DiagnosticsHelper.SafeShow("Not joined!")
            End If
        Catch socketEx As SocketException
            ' See if we can do something when a SocketException occurs.
            HandleSocketException(socketEx)
        End Try
    End Sub

    Private Sub SendToCallback(ByVal result As IAsyncResult)
        Try
            If Not IsDisposed Then
                Me.Client.EndSendTo(result)
            End If
        Catch socketEx As SocketException
            ' See if we can do something when a SocketException occurs.
            HandleSocketException(socketEx)
        End Try
    End Sub

    ''' <summary>
    ''' Receives this instance.
    ''' </summary>
    Private Sub Receive()
        If Me.IsJoined Then
            Array.Clear(Me.ReceiveBuffer, 0, Me.ReceiveBuffer.Length)
            Me.Client.BeginReceiveFromGroup(Me.ReceiveBuffer, 0, Me.ReceiveBuffer.Length, New AsyncCallback(AddressOf ReceiveFromGroupCallback), Nothing)
        End If
    End Sub

    Private Sub ReceiveFromGroupCallback(ByVal result As IAsyncResult)
        Try
            If Not IsDisposed Then
                ' We can retrieve the endPoint of the member of the multicast group that sent this message.
                ' We will send this on to the game and it will be stored at part of this member's PlayerInfo. 
                ' It can then be used to send unicast messages, targeted to that one recipient. These messsages
                ' will be sent using the SendTo method above.
                Dim source As IPEndPoint = Nothing
                Me.Client.EndReceiveFromGroup(result, source)
                Deployment.Current.Dispatcher.BeginInvoke(Sub()
                                                              Me.OnReceive(source, Me.ReceiveBuffer)
                                                              Me.Receive()
                                                          End Sub)
            End If
        Catch socketEx As SocketException
            ' See if we can do something when a SocketException occurs.
            HandleSocketException(socketEx)
        Catch e1 As InvalidOperationException
            Debug.WriteLine("ReceiveFromGroupCallback IOE")
        End Try
    End Sub

    ''' <summary>
    ''' Called when [receive].
    ''' </summary>
    ''' <param name="source">The source.</param>
    ''' <param name="data">The data.</param>
    Private Sub OnReceive(ByVal source As IPEndPoint, ByVal data() As Byte)
        Dim handler As EventHandler(Of UdpPacketReceivedEventArgs) = Me.PacketReceivedEvent

        If handler IsNot Nothing Then
            handler(Me, New UdpPacketReceivedEventArgs(data, source))
        End If
    End Sub

    ''' <summary>
    ''' Called when [after open].
    ''' </summary>
    Private Sub OnJoined()
        Dim handler As EventHandler = Me.JoinedEvent

        If handler IsNot Nothing Then
            handler(Me, EventArgs.Empty)
        End If
    End Sub

    ''' <summary>
    ''' Called when [before close].
    ''' </summary>
    Private Sub OnBeforeClose()
        Dim handler As EventHandler = Me.BeforeCloseEvent

        If handler IsNot Nothing Then
            handler(Me, EventArgs.Empty)
        End If
    End Sub


    ''' <summary>
    ''' If a Socketexception occurs, it is possible to handle these exceptions gracefully.
    ''' </summary>
    ''' <remarks>
    ''' This method contains examples of what you can do when a SocketException occurs. 
    ''' However, it is not exhaustive and you should handle these exceptions according
    ''' to your applications specific behavior.
    ''' </remarks>
    ''' <param name="socketEx"></param>
    Private Sub HandleSocketException(ByVal socketEx As SocketException)
        If socketEx.SocketErrorCode = SocketError.NetworkDown Then
            DiagnosticsHelper.SafeShow("A SocketExeption has occurred. Please make sure your device is on a Wi-Fi network and the Wi-Fi network is operational")
        ElseIf socketEx.SocketErrorCode = SocketError.ConnectionReset Then
            ' Try to re-join the multi-cast group. 
            ' No retry count has been implemented here. This is left as an exercise.
            Me.IsJoined = False
            Me.Open()
        ElseIf socketEx.SocketErrorCode = SocketError.AccessDenied Then
            DiagnosticsHelper.SafeShow("An error occurred. Try Again.")
        Else
            ' Just display the message.
            DiagnosticsHelper.SafeShow(socketEx.Message)
        End If

    End Sub
End Class
