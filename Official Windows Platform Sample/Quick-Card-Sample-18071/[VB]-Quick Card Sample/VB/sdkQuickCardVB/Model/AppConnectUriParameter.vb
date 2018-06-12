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

Namespace AppConnectExample.Model
	' Represents a parameter from a quick card in an App Connect deep link URI
	Public Class AppConnectUriParameter
		Implements INotifyPropertyChanged
		' The parameter name
		Private _paramName As String
		Public Property ParamName() As String
			Get
				Return _paramName
			End Get
			Set(ByVal value As String)
				If _paramName <> value Then
					_paramName = value
					NotifyPropertyChanged("ParamName")
				End If
			End Set
		End Property

		' The parameter value
		Private _paramValue As String
		Public Property ParamValue() As String
			Get
				Return _paramValue
			End Get
			Set(ByVal value As String)
				If _paramValue <> value Then
					_paramValue = value
					NotifyPropertyChanged("ParamValue")
				End If
			End Set
		End Property

		' Class constructor
		Public Sub New(ByVal pName As String, ByVal pValue As String)
			_paramName = pName.Trim()

			If _paramName = "Category" Then
				' Place multiple categories on new lines.
				_paramValue = pValue.Replace(",", "," & vbLf)
			Else
				_paramValue = pValue
			End If
		End Sub

		#Region "INotifyPropertyChanged Members"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		' Used to notify that a property changed
		Private Sub NotifyPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

		#End Region
	End Class
End Namespace
