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
    ' Constructor
    Public Sub New()
        InitializeComponent()

        ' Set the data context of the listbox control to the sample data.
        DataContext = App.MainViewModel
        AddHandler Loaded, AddressOf MainPage_Loaded
    End Sub

    ' Load data from the MainViewModel.
    Private Sub MainPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Text that describes how the sample app works.
        Dim body As String = String.Concat("Welcome to the search extensibility sample application named TreyResearch. ", vbCr, vbCr, "To use this application, tap the Search button on your phone and search for a baby, nusery, or toy product. Then tap a product under the products list in the web pivot page. ", vbCr, vbCr, "In the product card that appears, swipe to the apps pivot page and launch the TreyResearch application.")

        ' If the app data has not been loaded yet, load it.
        If Not App.MainViewModel.IsDataLoaded Then
            ' Load data here
            App.MainViewModel.LoadData()

            ' Bind the description text to the TextBlock.
            App.MainViewModel.Body = body
        End If
    End Sub

    ' PhoneApplicationPage_Loaded implementation.
    Private Sub PhoneApplicationPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
    End Sub
End Class
