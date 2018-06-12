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
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.BackgroundTransfer
Imports System.IO.IsolatedStorage


Partial Public Class AddBackgroundTransfer
    Inherits PhoneApplicationPage
    Private ReadOnly urls As New List(Of String)() From {"http://create.msdn.com/assets/cms/images/samples/windowsphonetestfile1.png", "http://create.msdn.com/assets/cms/images/samples/windowsphonetestfile2.png", "http://create.msdn.com/assets/cms/images/samples/windowsphonetestfile3A.png", "http://create.msdn.com/assets/cms/images/samples/windowsphonetestfile4.png", "http://create.msdn.com/assets/cms/images/samples/windowsphonetestfile5.png"}

    Public Sub New()
        InitializeComponent()

        ' Bind the list of urls to the ListBox
        URLListBox.ItemsSource = urls

        ' Make sure that the required "transfers" directory exists
        ' in isolated storage.
        Using isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
            If Not isoStore.DirectoryExists("/shared/transfers") Then
                isoStore.CreateDirectory("/shared/transfers")
            End If
        End Using
    End Sub

    Private Sub addButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Check to see if the maximum number of requests per app has been exceeded.
        If BackgroundTransferService.Requests.Count() >= 5 Then
            ' Note: Instead of showing a message to the user, you could store the
            ' requested file URI in isolated storage and add it to the queue later.
            MessageBox.Show("The maximum number of background file transfer requests for this application has been exceeded. ")
            Return
        End If

        ' Get the URI of the file to be transferred from the Tag property
        ' of the button that was clicked.
        Dim transferFileName As String = TryCast((CType(sender, Button)).Tag, String)
        Dim transferUri As New Uri(Uri.EscapeUriString(transferFileName), UriKind.RelativeOrAbsolute)

        ' Create the new transfer request, passing in the URI of the file to 
        ' be transferred.
        Dim transferRequest As New BackgroundTransferRequest(transferUri)

        ' Set the transfer method. GET and POST are supported.
        transferRequest.Method = "GET"

        ' Get the file name from the end of the transfer Uri and create a local Uri 
        ' in the "transfers" directory in isolated storage.
        Dim downloadFile As String = transferFileName.Substring(transferFileName.LastIndexOf("/") + 1)
        Dim downloadUri As New Uri("shared/transfers/" & downloadFile, UriKind.RelativeOrAbsolute)
        transferRequest.DownloadLocation = downloadUri

        ' Pass custom data with the Tag property. This value cannot be more than 4000 characters.
        ' In this example, the friendly name for the file is passed. 
        transferRequest.Tag = downloadFile



        ' If the WiFi-only checkbox is not checked, then set the TransferPreferences
        ' to allow transfers over a cellular connection.
        If wifiOnlyCheckbox.IsChecked = False Then
            transferRequest.TransferPreferences = TransferPreferences.AllowCellular
        End If
        If externalPowerOnlyCheckbox.IsChecked = False Then
            transferRequest.TransferPreferences = TransferPreferences.AllowBattery
        End If
        If wifiOnlyCheckbox.IsChecked = False AndAlso externalPowerOnlyCheckbox.IsChecked = False Then
            transferRequest.TransferPreferences = TransferPreferences.AllowCellularAndBattery
        End If


        ' Add the transfer request using the BackgroundTransferService. Do this in 
        ' a try block in case an exception is thrown.
        Try
            BackgroundTransferService.Add(transferRequest)
        Catch ex As InvalidOperationException
            ' TBD - update when exceptions are finalized
            MessageBox.Show("Unable to add background transfer request. " & ex.Message)
        Catch e1 As Exception
            MessageBox.Show("Unable to add background transfer request.")
        End Try

    End Sub
End Class
