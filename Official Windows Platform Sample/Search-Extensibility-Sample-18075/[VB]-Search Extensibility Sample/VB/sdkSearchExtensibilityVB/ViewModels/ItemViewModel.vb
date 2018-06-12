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
Imports System.Windows.Ink


' ViewModel for the items page that is launched by Search Extras deep link URIs.
Public Class ItemViewModel
    Implements INotifyPropertyChanged

    ' Parameters in the Search Extras deep link URI.
    Private _launchingParams As String

    ' Path to icon that designates if product is recalled.
    Private _iconSource As ImageSource

    ' Text that describe if product is recalled.
    Private _caption As String

    ' Property for Search Extras deep link URI parameters.
    Public Property LaunchingParams() As String
        Get
            Return _launchingParams
        End Get
        Set(ByVal value As String)
            If value <> _launchingParams Then
                _launchingParams = value
                NotifyPropertyChanged("LaunchingParams")
            End If
        End Set
    End Property

    ' Property for path to icon that designates if product is recalled.
    Public Property IconSource() As ImageSource
        Get
            Return _iconSource
        End Get
        Set(ByVal value As ImageSource)
            If value IsNot _iconSource Then
                _iconSource = value
                NotifyPropertyChanged("IconSource")
            End If
        End Set
    End Property

    ' Property of text that describes if product is recalled or not
    Public Property Caption() As String
        Get
            Return _caption
        End Get
        Set(ByVal value As String)
            If value <> _caption Then
                _caption = value
                NotifyPropertyChanged("Caption")
            End If
        End Set
    End Property

    ' Event handler for property changes
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub NotifyPropertyChanged(ByVal propertyName As String)
        Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
        If Nothing IsNot handler Then
            handler(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class
