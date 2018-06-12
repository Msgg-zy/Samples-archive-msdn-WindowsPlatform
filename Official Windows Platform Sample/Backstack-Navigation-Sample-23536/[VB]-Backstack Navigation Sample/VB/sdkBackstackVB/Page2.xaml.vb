'
'   Copyright (c) 2012 - 2013 Microsoft Corporation.  All rights reserved.
'   Use of this sample source code is subject to the terms of the Microsoft license 
'   agreement under which you licensed this sample source code and is provided AS-IS.
'   If you did not accept the terms of the license agreement, you are not authorized 
'   to use this sample source code.  For the terms of the license, please see the 
'   license agreement between you and Microsoft.
'  
'   To see all Code Samples for Windows Phone, visit http://code.msdn.microsoft.com/wpapps
'  
'
Partial Public Class Page2
    Inherits PhoneApplicationPage
    ' The URI string of the next page to navigate to from this page.
    ' String.Empty here means that there is no next page.
    Private nextPage As String

    Public Sub New()
        InitializeComponent()

        ' Set the application title - use the same application title on each page
        ApplicationTitle.Text = "SDK BACKSTACK SAMPLE"

        ' Set unique page title. In this example we will use "page 1", "page 2" etc.
        PageTitle.Text = "page 2"

        ' Set the URI string of the next page, or String.Empty if there is no next page.
        nextPage = "/Page3.xaml"
    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        MyBase.OnNavigatedTo(e)

        ' Show the Next button, if we have defined a next page.
        btnNext.Visibility = If(String.IsNullOrWhiteSpace(nextPage), Visibility.Collapsed, Visibility.Visible)

        If ShellTile.ActiveTiles.FirstOrDefault(Function(o) o.NavigationUri.ToString().Contains(NavigationService.Source.ToString())) Is Nothing Then
            PinToStartCheckBox.IsChecked = False
        Else
            PinToStartCheckBox.IsChecked = True
        End If
    End Sub

    ''' <summary>
    ''' Navigate to the next page.
    ''' </summary>
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Make sure to only attempt navigation if we have defined a next page.
        If Not String.IsNullOrWhiteSpace(nextPage) Then
            Me.NavigationService.Navigate(New Uri(nextPage, UriKind.Relative))
        End If
    End Sub

    ''' <summary>
    ''' Toggle pinning this a tile for this page on the start menu.
    ''' </summary>
    Private Sub PinToStartCheckBox_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Try to find a tile that has this page's URI
        Dim tile As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(o) o.NavigationUri.ToString().Contains(NavigationService.Source.ToString()))

        If tile Is Nothing Then
            ' No tile was found, so add one for this page.
            Dim tileData As StandardTileData = New StandardTileData With {.Title = PageTitle.Text}
            ShellTile.Create(New Uri(NavigationService.Source.ToString(), UriKind.Relative), tileData)
        Else
            ' A tile was found, so remove it.
            tile.Delete()
        End If
    End Sub


End Class
