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
Imports System.Text
Imports System.Windows.Data
Imports System.Windows.Media.Imaging
Imports System.Collections.ObjectModel

' ViewModel for the main page that is launched from Start.
Public Class MainViewModel
    Implements INotifyPropertyChanged
    ' Text to describe how to use the app.
    Private _body As String

    ' Identifies if data has been loaded.
    Public Property IsDataLoaded As Boolean

    ' Property for text that describes how to use the app.
    Public Property Body() As String
        Get
            Return _body
        End Get
        Set(ByVal value As String)
            If value <> _body Then
                _body = value
                NotifyPropertyChanged("Body")
            End If
        End Set
    End Property

    ' Placeholder for code that actually loads data.
    Public Sub LoadData()
        ' load data here.
        Body = "Loaded."
        Me.IsDataLoaded = True
    End Sub

    ' Event handler for property changes.
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub NotifyPropertyChanged(ByVal propertyName As String)
        Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
        If Nothing IsNot handler Then
            handler(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class

