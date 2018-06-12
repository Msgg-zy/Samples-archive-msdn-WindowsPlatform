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
Imports System.Text


Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ''' <summary>
    ''' MainPage constructor
    ''' </summary>
    Public Sub New()
        ' Holds the push channel that is created or found.
        Dim pushChannel As HttpNotificationChannel

        ' The name of our push channel.
        Dim channelName As String = "ToastSampleChannel"

        InitializeComponent()

        ' Try to find the push channel.
        pushChannel = HttpNotificationChannel.Find(channelName)

        ' If the channel was not found, then create a new connection to the push service.
        If pushChannel Is Nothing Then
            pushChannel = New HttpNotificationChannel(channelName)

            ' Register for all the events before attempting to open the channel.
            AddHandler pushChannel.ChannelUriUpdated, AddressOf PushChannel_ChannelUriUpdated
            AddHandler pushChannel.ErrorOccurred, AddressOf PushChannel_ErrorOccurred

            ' Register for this notification only if you need to receive the notifications while your application is running.
            AddHandler pushChannel.ShellToastNotificationReceived, AddressOf PushChannel_ShellToastNotificationReceived

            pushChannel.Open()

            ' Bind this new channel for toast events.
            pushChannel.BindToShellToast()

        Else
            ' The channel was already open, so just register for all the events.
            AddHandler pushChannel.ChannelUriUpdated, AddressOf PushChannel_ChannelUriUpdated
            AddHandler pushChannel.ErrorOccurred, AddressOf PushChannel_ErrorOccurred

            ' Register for this notification only if you need to receive the notifications while your application is running.
            AddHandler pushChannel.ShellToastNotificationReceived, AddressOf PushChannel_ShellToastNotificationReceived

            ' Display the URI for testing purposes. Normally, the URI would be passed back to your web service at this point.
            System.Diagnostics.Debug.WriteLine(pushChannel.ChannelUri.ToString())
            MessageBox.Show(String.Format("Channel Uri is {0}", pushChannel.ChannelUri.ToString()))

        End If
    End Sub

    ''' <summary>
    ''' Event handler for when the push channel Uri is updated.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PushChannel_ChannelUriUpdated(ByVal sender As Object, ByVal e As NotificationChannelUriEventArgs)

        ' Display the new URI for testing purposes.   Normally, the URI would be passed back to your web service at this point.
        Dispatcher.BeginInvoke(Sub()
                                   System.Diagnostics.Debug.WriteLine(e.ChannelUri.ToString())
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
    ''' Event handler for when a toast notification arrives while your application is running.  
    ''' The toast will not display if your application is running so you must add this
    ''' event handler if you want to do something with the toast notification.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PushChannel_ShellToastNotificationReceived(ByVal sender As Object, ByVal e As NotificationEventArgs)
        Dim message As New StringBuilder()
        Dim relativeUri As String = String.Empty

        message.AppendFormat("Received Toast {0}:" & vbLf, Date.Now.ToShortTimeString())

        ' Parse out the information that was part of the message.
        For Each key In e.Collection.Keys
            message.AppendFormat("{0}: {1}" & vbLf, key, e.Collection(key))

            If String.Compare(key, "wp:Param", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.CompareOptions.IgnoreCase) = 0 Then
                relativeUri = e.Collection(key)
            End If
        Next key

        ' Display a dialog of all the fields in the toast.
        Dispatcher.BeginInvoke(Function() MessageBox.Show(message.ToString()))

    End Sub

    ''' <summary>
    ''' Navigate to page 2 button clicked event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonNavigate_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Me.NavigationService.Navigate(New Uri("/Page2.xaml?NavigatedFrom=Main Page", UriKind.Relative))
    End Sub

End Class
