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
Imports Microsoft.Phone.Notification
Imports System.Diagnostics


Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ''' <summary>
    ''' MainPage constructor
    ''' </summary>
    Public Sub New()
        ' Holds the push channel that is created or found.
        Dim pushChannel As HttpNotificationChannel

        ' The name of our push channel.
        Dim channelName As String = "RawSampleChannel"

        InitializeComponent()

        ' Try to find the push channel.
        pushChannel = HttpNotificationChannel.Find(channelName)

        ' If the channel was not found, then create a new connection to the push service.
        If pushChannel Is Nothing Then
            pushChannel = New HttpNotificationChannel(channelName)

            ' Register for all the events before attempting to open the channel.
            AddHandler pushChannel.ChannelUriUpdated, AddressOf PushChannel_ChannelUriUpdated
            AddHandler pushChannel.ErrorOccurred, AddressOf PushChannel_ErrorOccurred
            AddHandler pushChannel.HttpNotificationReceived, AddressOf PushChannel_HttpNotificationReceived

            pushChannel.Open()

        Else
            ' The channel was already open, so just register for all the events.
            AddHandler pushChannel.ChannelUriUpdated, AddressOf PushChannel_ChannelUriUpdated
            AddHandler pushChannel.ErrorOccurred, AddressOf PushChannel_ErrorOccurred
            AddHandler pushChannel.HttpNotificationReceived, AddressOf PushChannel_HttpNotificationReceived

            ' Display the URI for testing purposes. Normally, the URI would be passed back to your web service at this point.
            Debug.WriteLine(pushChannel.ChannelUri.ToString())
            MessageBox.Show(String.Format("Channel Uri is {0}", pushChannel.ChannelUri.ToString()))

        End If
    End Sub

    ''' <summary>
    ''' Event handler for when the push channel Uri is updated.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PushChannel_ChannelUriUpdated(ByVal sender As Object, ByVal e As NotificationChannelUriEventArgs)

        ' Display the new URI for testing purposes. Normally, the URI would be passed back to your web service at this point.
        Dispatcher.BeginInvoke(Sub()
                                   Debug.WriteLine(e.ChannelUri.ToString())
                                   MessageBox.Show(String.Format("Channel Uri is {0}", e.ChannelUri.ToString()))
                               End Sub)
    End Sub

    ''' <summary>
    ''' Event handler for when a push notification error occurs.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PushChannel_ErrorOccurred(ByVal sender As Object, ByVal e As NotificationChannelErrorEventArgs)
        ' Error handling logic for your particular application would be here.
        Dispatcher.BeginInvoke(Function() MessageBox.Show(String.Format("A push notification {0} error occurred.  {1} ({2}) {3}", e.ErrorType, e.Message, e.ErrorCode, e.ErrorAdditionalData)))
    End Sub

    ''' <summary>
    ''' Event handler for when a raw notification arrives.  For this sample, the raw 
    ''' data is simply displayed in a MessageBox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PushChannel_HttpNotificationReceived(ByVal sender As Object, ByVal e As HttpNotificationEventArgs)
        Dim message As String

        Using reader As New System.IO.StreamReader(e.Notification.Body)
            message = reader.ReadToEnd()
        End Using


        Dispatcher.BeginInvoke(Function() MessageBox.Show(String.Format("Received Notification {0}:" & vbLf & "{1}", Date.Now.ToShortTimeString(), message)))
    End Sub

End Class
