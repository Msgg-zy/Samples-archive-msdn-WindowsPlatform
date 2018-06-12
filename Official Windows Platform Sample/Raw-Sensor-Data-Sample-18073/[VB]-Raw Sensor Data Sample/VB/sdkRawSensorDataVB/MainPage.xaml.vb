' 
'    Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
'    Use of this sample source code is subject to the terms of the Microsoft license 
'    agreement under which you licensed this sample source code and is provided AS-IS.
'    If you did not accept the terms of the license agreement, you are not authorized 
'    to use this sample source code.  For the terms of the license, please see the 
'    license agreement between you and Microsoft.
'  
'    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
'  
'

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CompassButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        NavigationService.Navigate(New Uri("/CompassPage.xaml", UriKind.Relative))
    End Sub

    Private Sub AccelerometerButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        NavigationService.Navigate(New Uri("/AccelerometerPage.xaml", UriKind.Relative))
    End Sub

    Private Sub GyroscopeButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        NavigationService.Navigate(New Uri("/GyroscopePage.xaml", UriKind.Relative))
    End Sub
End Class
