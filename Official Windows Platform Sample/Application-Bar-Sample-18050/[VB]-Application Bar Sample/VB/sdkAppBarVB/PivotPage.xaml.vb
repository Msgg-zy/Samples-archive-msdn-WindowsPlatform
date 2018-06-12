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
Partial Public Class PivotPage
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()

        'Set the initial values for the Application Bar properties by checking the radio buttons.
        ForeNormal.IsChecked = True
        BackNormal.IsChecked = True
        One.IsChecked = True
        DefaultSize.IsChecked = True
        Visible.IsChecked = True
        Enabled.IsChecked = True
    End Sub

    Private Sub ForeColorChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim [option] As String = (CType(sender, RadioButton)).Name
        Select Case [option]
            Case "ForeNormal"
                ApplicationBar.ForegroundColor = CType(Resources("PhoneForegroundColor"), Color)

            Case "ForeAccent"
                ApplicationBar.ForegroundColor = CType(Resources("PhoneAccentColor"), Color)
        End Select
    End Sub

    Private Sub BackColorChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim [option] As String = (CType(sender, RadioButton)).Name
        Select Case [option]
            Case "BackNormal"
                ApplicationBar.BackgroundColor = New Color() With {.A = 0, .R = 0, .G = 0, .B = 0}

            Case "BackAccent"
                ApplicationBar.BackgroundColor = CType(Resources("PhoneAccentColor"), Color)
        End Select
    End Sub

    Private Sub OpacityChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim [option] As String = (CType(sender, RadioButton)).Name
        Select Case [option]
            Case "One"
                ApplicationBar.Opacity = 1.0

            Case "Half"
                ApplicationBar.Opacity = 0.5

            Case "Zero"
                ApplicationBar.Opacity = 0.0
        End Select
    End Sub

    Private Sub ModeChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim [option] As String = (CType(sender, RadioButton)).Name
        Select Case [option]
            Case "DefaultSize"
                ApplicationBar.Mode = ApplicationBarMode.Default

            Case "Mini"
                ApplicationBar.Mode = ApplicationBarMode.Minimized
        End Select
    End Sub

    Private Sub VisibilityChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim [option] As String = (CType(sender, RadioButton)).Name
        Select Case [option]
            Case "Visible"
                ApplicationBar.IsVisible = True

            Case "Hidden"
                ApplicationBar.IsVisible = False
        End Select
    End Sub

    Private Sub MenuEnabledChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim [option] As String = (CType(sender, RadioButton)).Name
        Select Case [option]
            Case "Enabled"
                ApplicationBar.IsMenuEnabled = True

            Case "Disabled"
                ApplicationBar.IsMenuEnabled = False
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Button 1 works!  Do something useful in your application.")
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Button 2 works!  Do something useful in your application.")
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Button 3 works!  Do something useful in your application.")
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Button 4 works!  Do something useful in your application.")
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("The default Application Bar size is " & ApplicationBar.DefaultSize & " pixels.")
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("The mini Application Bar size is " & ApplicationBar.MiniSize & " pixels.")
    End Sub
    'page class
End Class
