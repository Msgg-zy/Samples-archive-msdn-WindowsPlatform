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
Imports System.Runtime.Serialization
Imports System.ComponentModel

      <DataContract>
Public Class ViewModel
    Implements INotifyPropertyChanged


    Private _textBox1Text As String
    Private _checkBox1IsChecked As Boolean
    Private _radioButton1IsChecked As Boolean
    Private _radioButton2IsChecked As Boolean
    Private _slider1Value As Double


    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged


    Private Sub NotifyPropertyChanged(ByVal propertyName As String)
        If Nothing IsNot PropertyChangedEvent Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub


    <DataMember()>
    Public Property TextBox1Text() As String
        Get
            Return _textBox1Text
        End Get
        Set(ByVal value As String)
            _textBox1Text = value
            NotifyPropertyChanged("TextBox1Text")
        End Set
    End Property

    <DataMember()>
    Public Property CheckBox1IsChecked() As Boolean
        Get
            Return _checkBox1IsChecked
        End Get
        Set(ByVal value As Boolean)
            _checkBox1IsChecked = value
            NotifyPropertyChanged("CheckBox1IsChecked")
        End Set
    End Property

    <DataMember()>
    Public Property Slider1Value() As Double
        Get
            Return _slider1Value
        End Get
        Set(ByVal value As Double)
            _slider1Value = value
            NotifyPropertyChanged("Slider1Value")
        End Set
    End Property

    <DataMember()>
    Public Property RadioButton1IsChecked() As Boolean
        Get
            Return _radioButton1IsChecked
        End Get
        Set(ByVal value As Boolean)
            _radioButton1IsChecked = value
            NotifyPropertyChanged("RadioButton1IsChecked")
        End Set
    End Property

    <DataMember()>
    Public Property RadioButton2IsChecked() As Boolean
        Get
            Return _radioButton2IsChecked
        End Get
        Set(ByVal value As Boolean)
            _radioButton2IsChecked = value
            NotifyPropertyChanged("RadioButton2IsChecked")
        End Set
    End Property

End Class
