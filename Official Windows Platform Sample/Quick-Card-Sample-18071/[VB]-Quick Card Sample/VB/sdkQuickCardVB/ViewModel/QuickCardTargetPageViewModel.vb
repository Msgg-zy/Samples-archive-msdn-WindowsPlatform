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
Imports System.Collections.ObjectModel

' Reference the data model.
Imports sdkQuickCardVB.AppConnectExample.Model

Namespace AppConnectExample.ViewModel
	Public Class QuickCardTargetPageViewModel
		Implements INotifyPropertyChanged
		' Observeable collection for the App Connect deep link URI parameters.
		Private _AppConnectUriParameters As ObservableCollection(Of AppConnectUriParameter)
		Public Property AppConnectUriParameters() As ObservableCollection(Of AppConnectUriParameter)
			Get
				Return _AppConnectUriParameters
			End Get
			Set(ByVal value As ObservableCollection(Of AppConnectUriParameter))
				If _AppConnectUriParameters IsNot value Then
					_AppConnectUriParameters = value
					NotifyPropertyChanged("AppConnectUriParameters")
				End If
			End Set
		End Property

		' Class constructor.
		Public Sub New()
			' Create observeable collection object.
			AppConnectUriParameters = New ObservableCollection(Of AppConnectUriParameter)()
		End Sub

		' Load parameters from quick page; extract from the NavigationContext.QueryString
		Public Sub LoadUriParameters(ByVal QueryString As IDictionary(Of String, String))
			' Clear parameters in the ViewModel.
			AppConnectUriParameters.Clear()

			' Loop through the quick card parameters in the App Connect deep link URI.
            For Each strKey In QueryString.Keys
                ' Set default value for parameter if no value is present.
                Dim strKeyValue As String = "<no value present in URI>"

                ' Try to extract parameter value from URI.
                QueryString.TryGetValue(strKey, strKeyValue)

                ' Add parameter object to ViewModel collection.
                AppConnectUriParameters.Add(New AppConnectUriParameter(strKey, strKeyValue))
            Next strKey
		End Sub

		#Region "INotifyPropertyChanged Members"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		' Used to notify that a property has changed.
		Private Sub NotifyPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
		#End Region
	End Class
End Namespace
