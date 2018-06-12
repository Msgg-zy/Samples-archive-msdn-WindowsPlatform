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
Imports System.ComponentModel

Namespace Model
    Public Class Accomplishment
        Implements INotifyPropertyChanged
        ' The name of the accomplishment.
        Public Property Name() As String

        ' The type of the accomplishment, Item or Level.
        Public Property Type() As String

        ' The number of each item that has been collected.
        Private _count As Integer
        Public Property Count() As Integer
            Get
                Return _count
            End Get
            Set(ByVal value As Integer)
                _count = value
                RaisePropertyChanged("Count")
            End Set
        End Property

        ' Whether a level has been completed or not
        Private _completed As Boolean
        Public Property Completed() As Boolean
            Get
                Return _completed
            End Get
            Set(ByVal value As Boolean)
                _completed = value
                RaisePropertyChanged("Completed")
            End Set
        End Property


        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub RaisePropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub


        ' Create a copy of an accomplishment to save.
        ' If your object is databound, this copy is not databound.
        Public Function GetCopy() As Accomplishment
            Dim copy As Accomplishment = CType(Me.MemberwiseClone(), Accomplishment)
            Return copy
        End Function
    End Class
End Namespace
