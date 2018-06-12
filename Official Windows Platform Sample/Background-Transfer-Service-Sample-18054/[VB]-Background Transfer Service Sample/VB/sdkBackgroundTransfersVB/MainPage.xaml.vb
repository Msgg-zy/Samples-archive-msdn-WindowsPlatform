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
Imports System.IO.IsolatedStorage
Imports Microsoft.Phone.BackgroundTransfer


Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' List of BackgroundTransferRequest objects that will be bound
    ' to the ListBox in MainPage.xaml
    Private transferRequests As IEnumerable(Of BackgroundTransferRequest)

    ' Booleans for tracking if any transfers are waiting for user
    ' action. 
    Private WaitingForExternalPower As Boolean
    Private WaitingForExternalPowerDueToBatterySaverMode As Boolean
    Private WaitingForNonVoiceBlockingNetwork As Boolean
    Private WaitingForWiFi As Boolean


    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        ' Reset all of the user action booleans on page load.
        WaitingForExternalPower = False
        WaitingForExternalPowerDueToBatterySaverMode = False
        WaitingForNonVoiceBlockingNetwork = False
        WaitingForWiFi = False

        ' When the page loads, refresh the list of file transfers.
        InitialTansferStatusCheck()
        UpdateUI()
    End Sub

    Private Sub InitialTansferStatusCheck()
        UpdateRequestsList()

        For Each transfer In transferRequests
            AddHandler transfer.TransferStatusChanged, AddressOf transfer_TransferStatusChanged
            AddHandler transfer.TransferProgressChanged, AddressOf transfer_TransferProgressChanged
            ProcessTransfer(transfer)
        Next transfer

        If WaitingForExternalPower Then
            MessageBox.Show("You have one or more file transfers waiting for external power. Connect your device to external power to continue transferring.")
        End If
        If WaitingForExternalPowerDueToBatterySaverMode Then
            MessageBox.Show("You have one or more file transfers waiting for external power. Connect your device to external power or disable Battery Saver Mode to continue transferring.")
        End If
        If WaitingForNonVoiceBlockingNetwork Then
            MessageBox.Show("You have one or more file transfers waiting for a network that supports simultaneous voice and data.")
        End If
        If WaitingForWiFi Then
            MessageBox.Show("You have one or more file transfers waiting for a WiFi connection. Connect your device to a WiFi network to continue transferring.")
        End If

    End Sub

    Private Sub transfer_TransferStatusChanged(ByVal sender As Object, ByVal e As BackgroundTransferEventArgs)
        ProcessTransfer(e.Request)
        UpdateUI()
    End Sub

    Private Sub ProcessTransfer(ByVal transfer As BackgroundTransferRequest)
        Select Case transfer.TransferStatus
            Case TransferStatus.Completed

                ' If the status code of a completed transfer is 200 or 206, the
                ' transfer was successful
                If transfer.StatusCode = 200 OrElse transfer.StatusCode = 206 Then
                    ' Remove the transfer request in order to make room in the 
                    ' queue for more transfers. Transfers are not automatically
                    ' removed by the system.
                    RemoveTransferRequest(transfer.RequestId)

                    ' In this example, the downloaded file is moved into the root
                    ' Isolated Storage directory
                    Using isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
                        Dim filename As String = transfer.Tag
                        If isoStore.FileExists(filename) Then
                            isoStore.DeleteFile(filename)
                        End If
                        isoStore.MoveFile(transfer.DownloadLocation.OriginalString, filename)
                    End Using

                Else
                    ' This is where you can handle whatever error is indicated by the
                    ' StatusCode and then remove the transfer from the queue. 
                    RemoveTransferRequest(transfer.RequestId)

                    If transfer.TransferError IsNot Nothing Then
                        ' Handle TransferError, if there is one.
                    End If
                End If

            Case TransferStatus.WaitingForExternalPower
                WaitingForExternalPower = True

            Case TransferStatus.WaitingForExternalPowerDueToBatterySaverMode
                WaitingForExternalPowerDueToBatterySaverMode = True

            Case TransferStatus.WaitingForNonVoiceBlockingNetwork
                WaitingForNonVoiceBlockingNetwork = True

            Case TransferStatus.WaitingForWiFi
                WaitingForWiFi = True
        End Select
    End Sub

    Private Sub transfer_TransferProgressChanged(ByVal sender As Object, ByVal e As BackgroundTransferEventArgs)
        UpdateUI()
    End Sub

    Private Sub UpdateRequestsList()
        ' The Requests property returns new references, so make sure that
        ' you dispose of the old references to avoid memory leaks.
        If transferRequests IsNot Nothing Then
            For Each request In transferRequests
                request.Dispose()
            Next request
        End If
        transferRequests = BackgroundTransferService.Requests
    End Sub

    Private Sub UpdateUI()
        ' Update the list of transfer requests
        UpdateRequestsList()

        ' Update the TransferListBox with the list of transfer requests.
        TransferListBox.ItemsSource = transferRequests

        ' If there are 1 or more transfers, hide the "no transfers"
        ' TextBlock. IF there are zero transfers, show the TextBlock.
        If TransferListBox.Items.Count > 0 Then
            EmptyTextBlock.Visibility = Visibility.Collapsed
        Else
            EmptyTextBlock.Visibility = Visibility.Visible
        End If

    End Sub



    Private Sub RemoveTransferRequest(ByVal transferID As String)
        ' Use Find to retrieve the transfer request with the specified ID.
        Dim transferToRemove As BackgroundTransferRequest = BackgroundTransferService.Find(transferID)

        ' try to remove the transfer from the background transfer service.
        Try
            BackgroundTransferService.Remove(transferToRemove)
        Catch e1 As Exception

        End Try
    End Sub

    Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' The ID for each transfer request is bound to the
        ' Tag property of each Remove button.
        Dim transferID As String = TryCast((CType(sender, Button)).Tag, String)

        ' Delete the transfer request
        RemoveTransferRequest(transferID)

        ' Refresh the list of file transfers
        UpdateUI()
    End Sub

    Private Sub CancelAllButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Loop through the list of transfer requests
        For Each transfer In BackgroundTransferService.Requests
            RemoveTransferRequest(transfer.RequestId)
        Next transfer

        ' Refresh the list of file transfer requests.
        UpdateUI()
    End Sub

    Private Sub AddBackgroundTransferButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Navigate to the AddBackgroundTransfer page when the Add button
        ' is tapped.
        NavigationService.Navigate(New Uri("/AddBackgroundTransfer.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
