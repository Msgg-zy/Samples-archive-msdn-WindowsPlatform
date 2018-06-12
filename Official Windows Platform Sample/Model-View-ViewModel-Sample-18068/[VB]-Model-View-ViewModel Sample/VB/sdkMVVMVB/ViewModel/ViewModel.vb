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
Imports System.Collections.ObjectModel
Imports System.IO.IsolatedStorage
Imports sdkMVVMVB.Model

Namespace ViewModelNS
    Public Class ViewModel
        Public Property Accomplishments() As ObservableCollection(Of Accomplishment)


        Public Sub GetAccomplishments()
            If IsolatedStorageSettings.ApplicationSettings.Count > 0 Then
                GetSavedAccomplishments()
            Else
                GetDefaultAccomplishments()
            End If
        End Sub


        Public Sub GetDefaultAccomplishments()
            Dim a As New ObservableCollection(Of Accomplishment)()

            ' Items to collect
            a.Add(New Accomplishment() With {.Name = "Potions", .Type = "Item"})
            a.Add(New Accomplishment() With {.Name = "Coins", .Type = "Item"})
            a.Add(New Accomplishment() With {.Name = "Hearts", .Type = "Item"})
            a.Add(New Accomplishment() With {.Name = "Swords", .Type = "Item"})
            a.Add(New Accomplishment() With {.Name = "Shields", .Type = "Item"})

            ' Levels to complete
            a.Add(New Accomplishment() With {.Name = "Level 1", .Type = "Level"})
            a.Add(New Accomplishment() With {.Name = "Level 2", .Type = "Level"})
            a.Add(New Accomplishment() With {.Name = "Level 3", .Type = "Level"})

            Accomplishments = a
            'MessageBox.Show("Got accomplishments from default")
        End Sub


        Public Sub GetSavedAccomplishments()
            Dim a As New ObservableCollection(Of Accomplishment)()

            For Each o In IsolatedStorageSettings.ApplicationSettings.Values
                a.Add(CType(o, Accomplishment))
            Next o

            Accomplishments = a
            'MessageBox.Show("Got accomplishments from storage")
        End Sub

        Public Sub SaveAccomplishments()
            Dim settings As IsolatedStorageSettings = IsolatedStorageSettings.ApplicationSettings

            For Each a In Accomplishments
                If settings.Contains(a.Name) Then
                    settings(a.Name) = a
                Else
                    settings.Add(a.Name, a.GetCopy())
                End If
            Next a

            settings.Save()
            MessageBox.Show("Finished saving accomplishments")
        End Sub
    End Class
End Namespace
