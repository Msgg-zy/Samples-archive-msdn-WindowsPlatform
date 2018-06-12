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
    Private _viewModel As ViewModel
    Private _isNewPageInstance As Boolean = False

    ' Constructor
    Public Sub New()
        InitializeComponent()

        _isNewPageInstance = True

        ' Set the event handler for when the application data object changes
        AddHandler TryCast(Application.Current, sdkExecutionModelVB.App).ApplicationDataObjectChanged, AddressOf MainPage_ApplicationDataObjectChanged

    End Sub


    Protected Overrides Sub OnNavigatedFrom(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        ' If this is a back navigation, the page will be discarded, so there
        ' is no need to save state.
        If e.NavigationMode <> System.Windows.Navigation.NavigationMode.Back Then
            ' Save the ViewModel variable in the page's State dictionary.
            State("ViewModel") = _viewModel
        End If
    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        ' If _isNewPageInstance is true, the page constuctor has been called, so
        ' state may need to be restored
        If _isNewPageInstance Then


            '				#Region "RestorePageState"

            If _viewModel Is Nothing Then
                If State.Count > 0 Then
                    _viewModel = CType(State("ViewModel"), ViewModel)
                Else
                    _viewModel = New ViewModel()
                End If
            End If
            DataContext = _viewModel

            '				#End Region


            '				#Region "RestoreApplicationState"

            ' if the application member variable is not empty,
            ' set the page's data object from the application member variable.
            If (TryCast(Application.Current, sdkExecutionModelVB.App)).ApplicationDataObject IsNot Nothing Then
                UpdateApplicationDataUI()
            Else

                ' Otherwise, call the method that loads data.
                statusTextBlock.Text = "getting data..."
                TryCast(Application.Current, sdkExecutionModelVB.App).GetDataAsync()
            End If

            '				#End Region
        End If

        ' Set _isNewPageInstance to false. If the user navigates back to this page
        ' and it has remained in memory, this value will continue to be false.
        _isNewPageInstance = False
    End Sub

    ' The event handler called when the ApplicationDataObject changes.
    Private Sub MainPage_ApplicationDataObjectChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' Call UpdateApplicationData on the UI thread.
        Dispatcher.BeginInvoke(Sub() UpdateApplicationDataUI())
    End Sub

    Private Sub UpdateApplicationDataUI()
        ' Set the ApplicationData and ApplicationDataStatus members of the ViewModel
        ' class to update the UI.
        dataTextBlock.Text = (TryCast(Application.Current, sdkExecutionModelVB.App)).ApplicationDataObject
        statusTextBlock.Text = (TryCast(Application.Current, sdkExecutionModelVB.App)).ApplicationDataStatus
    End Sub
End Class
