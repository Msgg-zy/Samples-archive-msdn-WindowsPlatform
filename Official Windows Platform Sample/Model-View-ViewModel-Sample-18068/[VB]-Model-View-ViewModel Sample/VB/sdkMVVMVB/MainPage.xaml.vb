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
Imports sdkMVVMVB.ViewModelNS

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    Private vm As ViewModel

    ' Constructor
    Public Sub New()
        InitializeComponent()
        vm = New ViewModel()
    End Sub


    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        MyBase.OnNavigatedTo(e)

        If (Not StateUtilities.IsLaunching) AndAlso Me.State.ContainsKey("Accomplishments") Then
            ' Old instance of the application
            ' The user started the application from the Back button.

            vm = CType(Me.State("Accomplishments"), ViewModel)
            'MessageBox.Show("Got data from state")
        Else
            ' New instance of the application
            ' The user started the application from the application list,
            ' or there is no saved state available.

            vm.GetAccomplishments()
            'MessageBox.Show("Did not get data from state")
        End If


        ' There are two different views, but only one view model.
        ' So, use LINQ queries to populate the views.

        ' Set the data context for the Item view.
        ItemViewOnPage.DataContext = From Accomplishment In vm.Accomplishments
                                     Where Accomplishment.Type = "Item"
                                     Select Accomplishment

        ' Set the data context for the Level view.
        LevelViewOnPage.DataContext = From Accomplishment In vm.Accomplishments
                                      Where Accomplishment.Type = "Level"
                                      Select Accomplishment

        ' If there is only one view, you could use the following code
        ' to populate the view.
        'AccomplishmentViewOnPage.DataContext = vm.Accomplishments
    End Sub


    Protected Overrides Sub OnNavigatedFrom(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        MyBase.OnNavigatedFrom(e)

        If Me.State.ContainsKey("Accomplishments") Then
            Me.State("Accomplishments") = vm
        Else
            Me.State.Add("Accomplishments", vm)
        End If

        StateUtilities.IsLaunching = False
    End Sub


    Private Sub AppBarSave_Click(ByVal sender As Object, ByVal e As EventArgs)
        vm.SaveAccomplishments()
    End Sub
End Class
