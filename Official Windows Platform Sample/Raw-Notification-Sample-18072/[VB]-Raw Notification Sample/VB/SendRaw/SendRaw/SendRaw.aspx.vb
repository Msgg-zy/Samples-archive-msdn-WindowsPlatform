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
Imports System.Net
Imports System.IO

Partial Public Class SendRaw
    Inherits System.Web.UI.Page
    ''' <summary>
    ''' Event handler for the Send Raw Notification button.  Forms the post message and
    ''' sends it to the Microsoft Push Notification Server.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub ButtonSendRaw_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            ' Get the Uri that the Microsoft Push Notification Service returns to the Push Client when creating a notification channel.
            ' Normally, a web service would listen for Uri's coming from the web client and maintain a list of Uri's to send
            ' notifications out to.
            Dim subscriptionUri As String = TextBoxUri.Text.ToString()


            Dim sendNotificationRequest As HttpWebRequest = CType(WebRequest.Create(subscriptionUri), HttpWebRequest)

            ' We will create a HTTPWebRequest that posts the raw notification to the Microsoft Push Notification Service.
            ' HTTP POST is the only allowed method to send the notification.
            sendNotificationRequest.Method = "POST"

            ' Create the raw message.
            Dim rawMessage As String = String.Concat("<?xml version=""1.0"" encoding=""utf-8""?>", "<root>", "<Value1>", TextBoxValue1.Text.ToString(), "<Value1>", "<Value2>", TextBoxValue2.Text.ToString(), "<Value2>", "</root>")

            ' Sets the notification payload to send.
            Dim notificationMessage() As Byte = Encoding.Default.GetBytes(rawMessage)

            ' Sets the web request content length.
            sendNotificationRequest.ContentLength = notificationMessage.Length
            sendNotificationRequest.ContentType = "text/xml"
            sendNotificationRequest.Headers.Add("X-NotificationClass", "3")


            Using requestStream As Stream = sendNotificationRequest.GetRequestStream()
                requestStream.Write(notificationMessage, 0, notificationMessage.Length)
            End Using

            ' Send the notification and get the response.
            Dim response As HttpWebResponse = CType(sendNotificationRequest.GetResponse(), HttpWebResponse)
            Dim notificationStatus As String = response.Headers("X-NotificationStatus")
            Dim notificationChannelStatus As String = response.Headers("X-SubscriptionStatus")
            Dim deviceConnectionStatus As String = response.Headers("X-DeviceConnectionStatus")

            ' Display the response from the Microsoft Push Notification Service.  
            ' Normally, error handling code would be here.  In the real world, because data connections are not always available,
            ' notifications may need to be throttled back if the device cannot be reached.
            Dim textBoxResponseBuilder As New StringBuilder(notificationStatus)
            textBoxResponseBuilder.Append(" | ")
            textBoxResponseBuilder.Append(deviceConnectionStatus)
            textBoxResponseBuilder.Append(" | ")
            textBoxResponseBuilder.Append(notificationChannelStatus)
            TextBoxResponse.Text = textBoxResponseBuilder.ToString()
        Catch ex As Exception
            TextBoxResponse.Text = "Exception caught sending update: " & ex.ToString()
        End Try

    End Sub
End Class
