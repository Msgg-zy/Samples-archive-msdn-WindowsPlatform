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
Imports sdkQuickCardVB.AppConnectExample.ViewModel

Partial Public Class QuickCardTargetPage
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()

        ' Create the ViewModel object.
        Me.DataContext = New QuickCardTargetPageViewModel()

        ' Create event handler for the page Loaded event.
        AddHandler Loaded, AddressOf QuickCardTargetPage_Loaded

    End Sub

    ' A property for the ViewModel.
    Private ReadOnly Property ViewModel() As QuickCardTargetPageViewModel
        Get
            Return CType(DataContext, QuickCardTargetPageViewModel)
        End Get
    End Property

    Private Sub QuickCardTargetPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Load the quick card parameters from the App Connect deep link URI.
        ViewModel.LoadUriParameters(Me.NavigationContext.QueryString)
    End Sub
End Class
