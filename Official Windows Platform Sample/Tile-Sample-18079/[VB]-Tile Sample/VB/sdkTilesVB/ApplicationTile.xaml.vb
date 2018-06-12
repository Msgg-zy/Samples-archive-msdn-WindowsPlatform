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
Partial Public Class ApplicationTile
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' Set all the properties of the Application Tile.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buttonSetApplicationTile_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim newCount As Integer = 0

        ' Application Tile is always the first Tile, even if it is not pinned to Start.
        Dim TileToFind As ShellTile = ShellTile.ActiveTiles.First()

        ' Application should always be found
        If TileToFind IsNot Nothing Then
            ' if Count was not entered, then assume a value of 0
            If textBoxCount.Text = "" Then
                ' A value of '0' means do not display the Count.
                newCount = 0
                ' otherwise get the numerical value for Count
            Else
                newCount = Integer.Parse(textBoxCount.Text)
            End If

            ' set the properties to update for the Application Tile
            ' Empty strings for the text values and URIs will result in the property being cleared.
            Dim NewTileData As StandardTileData = New StandardTileData With {.Title = textBoxTitle.Text, .BackgroundImage = New Uri(textBoxBackgroundImage.Text, UriKind.Relative), .Count = newCount, .BackTitle = textBoxBackTitle.Text, .BackBackgroundImage = New Uri(textBoxBackBackgroundImage.Text, UriKind.Relative), .BackContent = textBoxBackContent.Text}

            ' Update the Application Tile
            TileToFind.Update(NewTileData)
        End If


    End Sub

End Class
