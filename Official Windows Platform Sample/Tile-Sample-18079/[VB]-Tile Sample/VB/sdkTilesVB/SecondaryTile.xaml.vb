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
Partial Public Class SecondaryTile
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()
    End Sub


    ''' <summary>
    ''' Event handler for when this page is navigated to.  Looks to see
    ''' if the tile exists and set the check box appropriately.
    ''' Also fills in the default value for the Title, based on the
    ''' value passed in in the QueryString - either FromMain or FromTile.
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        MyBase.OnNavigatedTo(e)

        ' See if the tile is pinned, and if so, make sure the checkbox for it is checked.
        ' (User may have deleted it manually.)
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(x) x.NavigationUri.ToString().Contains("DefaultTitle=FromTile"))

        checkBoxDisplaySecondaryTile.IsChecked = (TileToFind IsNot Nothing)

        ' To demonstrate the use of the Navigation URI and query parameters, we set the default value
        ' of the Title textbox based on where we navigated from.  If we navigated to this page
        ' from the MainPage, the DefaultTitle parameter will be "FromMain".  If we navigated here
        ' when the secondary Tile was tapped, the parameter will be "FromTile".
        textBoxTitle.Text = Me.NavigationContext.QueryString("DefaultTitle")

    End Sub

    ''' <summary>
    ''' Event handler for when the checkbox is checked. Create a secondary tile if it doesn't
    ''' already exist.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub checkBoxDisplaySecondaryTile_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Look to see if the tile already exists and if so, don't try to create again.
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(x) x.NavigationUri.ToString().Contains("DefaultTitle=FromTile"))

        ' Create the tile if we didn't find it already exists.
        If TileToFind Is Nothing Then
            ' Create the tile object and set some initial properties for the tile.
            ' The Count value of 12 will show the number 12 on the front of the Tile. Valid values are 1-99.
            ' A Count value of 0 will indicate that the Count should not be displayed.
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackgroundImage = New Uri("Red.jpg", UriKind.Relative), .Title = "Secondary Tile", .Count = 12, .BackTitle = "Back of Tile", .BackContent = "Welcome to the back of the Tile", .BackBackgroundImage = New Uri("Blue.jpg", UriKind.Relative)}

            ' Create the tile and pin it to Start. This will cause a navigation to Start and a deactivation of our application.
            ShellTile.Create(New Uri("/SecondaryTile.xaml?DefaultTitle=FromTile", UriKind.Relative), NewTileData)
        End If

    End Sub

    ''' <summary>
    ''' Event handler for when the checkbox is unchecked.  Delete the secondary tile
    ''' if it exists.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub checkBoxDisplaySecondaryTile_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Find the tile we want to delete.
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(x) x.NavigationUri.ToString().Contains("DefaultTitle=FromTile"))

        ' If tile was found, then delete it.
        If TileToFind IsNot Nothing Then
            TileToFind.Delete()
        End If

    End Sub

    ''' <summary>
    ''' Handle the Title button clicked event by setting the front of Tile title.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonSetTitle_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Find the tile we want to update.
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(x) x.NavigationUri.ToString().Contains("DefaultTitle=FromTile"))

        ' If tile was found, then update the Title
        If TileToFind IsNot Nothing Then
            Dim NewTileData As StandardTileData = New StandardTileData With {.Title = textBoxTitle.Text}

            TileToFind.Update(NewTileData)
        End If

    End Sub

    ''' <summary>
    ''' Handle the Background Image button clicked event by setting the front of Tile background image.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonSetBackgroundImage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Find the tile we want to update.
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(x) x.NavigationUri.ToString().Contains("DefaultTitle=FromTile"))

        ' If tile was found, then update the background image.
        If TileToFind IsNot Nothing Then
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackgroundImage = New Uri(textBoxBackgroundImage.Text, UriKind.Relative)}

            TileToFind.Update(NewTileData)
        End If

    End Sub

    ''' <summary>
    ''' Handle the Count button clicked event by setting the front of Tile count value.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonSetCount_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim newCount As Integer = 0

        ' Find the tile we want to update.
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(x) x.NavigationUri.ToString().Contains("DefaultTitle=FromTile"))

        ' If tile was found, then update the count.
        If TileToFind IsNot Nothing Then
            ' if Count was not entered, then assume a value of 0
            If textBoxCount.Text = "" Then
                newCount = 0
                ' otherwise get the numerical value for Count
            Else
                newCount = Integer.Parse(textBoxCount.Text)
            End If

            Dim NewTileData As StandardTileData = New StandardTileData With {.Count = newCount}

            TileToFind.Update(NewTileData)
        End If

    End Sub

    ''' <summary>
    ''' Handle the Back Title button clicked event by setting the back of Tile title.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonSetBackTitle_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Find the tile we want to update.
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(x) x.NavigationUri.ToString().Contains("DefaultTitle=FromTile"))

        ' If tile was found, then update the title on the back of the tile
        If TileToFind IsNot Nothing Then
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackTitle = textBoxBackTitle.Text}

            TileToFind.Update(NewTileData)
        End If

    End Sub

    ''' <summary>
    ''' Handle the Back Background Image button clicked event by setting the back of Tile background image.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonSetBackBackgroundImage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Find the tile we want to update.
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(x) x.NavigationUri.ToString().Contains("DefaultTitle=FromTile"))

        ' If tile was found, then update the background image on the back of the tile.
        If TileToFind IsNot Nothing Then
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackBackgroundImage = New Uri(textBoxBackBackgroundImage.Text, UriKind.Relative)}

            TileToFind.Update(NewTileData)
        End If

    End Sub

    ''' <summary>
    ''' Handle the Back Content button clicked event by setting the back of Tile content.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonSetBackContent_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Find the tile we want to update.
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.FirstOrDefault(Function(x) x.NavigationUri.ToString().Contains("DefaultTitle=FromTile"))

        ' If tile was found, then update the content on the back of the tile.
        If TileToFind IsNot Nothing Then
            Dim NewTileData As StandardTileData = New StandardTileData With {.BackContent = textBoxBackContent.Text}

            TileToFind.Update(NewTileData)
        End If

    End Sub


End Class
