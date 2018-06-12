'
'   Copyright (c) 2012 - 2013 Microsoft Corporation.  All rights reserved.
'   Use of this sample source code is subject to the terms of the Microsoft license 
'   agreement under which you licensed this sample source code and is provided AS-IS.
'   If you did not accept the terms of the license agreement, you are not authorized 
'   to use this sample source code.  For the terms of the license, please see the 
'   license agreement between you and Microsoft.
'  
'   To see all Code Samples for Windows Phone, visit http://code.msdn.microsoft.com/wpapps
'  
'
Imports System.IO.IsolatedStorage
Imports System.Diagnostics

Public Class AppSettings

    ' Our isolated storage settings
    Private settings As IsolatedStorageSettings

    ' The isolated storage key names of our settings
    Private Const CheckBoxSettingKeyName As String = "CheckBoxSetting"
    Private Const ListBoxSettingKeyName As String = "ListBoxSetting"
    Private Const RadioButton1SettingKeyName As String = "RadioButton1Setting"
    Private Const RadioButton2SettingKeyName As String = "RadioButton2Setting"
    Private Const RadioButton3SettingKeyName As String = "RadioButton3Setting"
    Private Const UsernameSettingKeyName As String = "UsernameSetting"
    Private Const PasswordSettingKeyName As String = "PasswordSetting"

    ' The default value of our settings
    Private Const CheckBoxSettingDefault As Boolean = True
    Private Const ListBoxSettingDefault As Integer = 0
    Private Const RadioButton1SettingDefault As Boolean = True
    Private Const RadioButton2SettingDefault As Boolean = False
    Private Const RadioButton3SettingDefault As Boolean = False
    Private Const UsernameSettingDefault As String = ""
    Private Const PasswordSettingDefault As String = ""

    ''' <summary>
    ''' Constructor that gets the application settings.
    ''' </summary>
    Public Sub New()
        Try
            ' Get the settings for this application.
            settings = IsolatedStorageSettings.ApplicationSettings

        Catch e As Exception
            Debug.WriteLine("Exception while using IsolatedStorageSettings: " & e.ToString())
        End Try
    End Sub

    ''' <summary>
    ''' Update a setting value for our application. If the setting does not
    ''' exist, then add the setting.
    ''' </summary>
    ''' <param name="Key"></param>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Public Function AddOrUpdateValue(ByVal Key As String, ByVal value As Object) As Boolean
        Dim valueChanged As Boolean = False

        ' If the key exists
        If settings.Contains(Key) Then
            ' If the value has changed
            If settings(Key) IsNot value Then
                ' Store the new value
                settings(Key) = value
                valueChanged = True
            End If
            ' Otherwise create the key.
        Else
            settings.Add(Key, value)
            valueChanged = True
        End If

        Return valueChanged
    End Function


    ''' <summary>
    ''' Get the current value of the setting, or if it is not found, set the 
    ''' setting to the default setting.
    ''' </summary>
    ''' <typeparam name="valueType"></typeparam>
    ''' <param name="Key"></param>
    ''' <param name="defaultValue"></param>
    ''' <returns></returns>
    Public Function GetValueOrDefault(Of valueType)(ByVal Key As String, ByVal defaultValue As valueType) As valueType
        Dim value As valueType

        ' If the key exists, retrieve the value.
        If settings.Contains(Key) Then
            value = CType(settings(Key), valueType)
            ' Otherwise, use the default value.
        Else
            value = defaultValue
        End If

        Return value
    End Function


    ''' <summary>
    ''' Save the settings.
    ''' </summary>
    Public Sub Save()
        settings.Save()
    End Sub


    ''' <summary>
    ''' Property to get and set a CheckBox Setting Key.
    ''' </summary>
    Public Property CheckBoxSetting() As Boolean
        Get
            Return GetValueOrDefault(Of Boolean)(CheckBoxSettingKeyName, CheckBoxSettingDefault)
        End Get
        Set(ByVal value As Boolean)
            If (AddOrUpdateValue(CheckBoxSettingKeyName, value)) Then
                Save()
            End If
        End Set
    End Property


    ''' <summary>
    ''' Property to get and set a ListBox Setting Key.
    ''' </summary>
    Public Property ListBoxSetting() As Integer
        Get
            Return GetValueOrDefault(Of Integer)(ListBoxSettingKeyName, ListBoxSettingDefault)
        End Get
        Set(ByVal value As Integer)
            If (AddOrUpdateValue(ListBoxSettingKeyName, value)) Then
                Save()
            End If
        End Set
    End Property


    ''' <summary>
    ''' Property to get and set a RadioButton Setting Key.
    ''' </summary>
    Public Property RadioButton1Setting() As Boolean
        Get
            Return GetValueOrDefault(Of Boolean)(RadioButton1SettingKeyName, RadioButton1SettingDefault)
        End Get
        Set(ByVal value As Boolean)
            If (AddOrUpdateValue(RadioButton1SettingKeyName, value)) Then
                Save()
            End If
        End Set
    End Property


    ''' <summary>
    ''' Property to get and set a RadioButton Setting Key.
    ''' </summary>
    Public Property RadioButton2Setting() As Boolean
        Get
            Return GetValueOrDefault(Of Boolean)(RadioButton2SettingKeyName, RadioButton2SettingDefault)
        End Get
        Set(ByVal value As Boolean)
            If (AddOrUpdateValue(RadioButton2SettingKeyName, value)) Then
                Save()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Property to get and set a RadioButton Setting Key.
    ''' </summary>
    Public Property RadioButton3Setting() As Boolean
        Get
            Return GetValueOrDefault(Of Boolean)(RadioButton3SettingKeyName, RadioButton3SettingDefault)
        End Get
        Set(ByVal value As Boolean)
            If (AddOrUpdateValue(RadioButton3SettingKeyName, value)) Then
                Save()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Property to get and set a Username Setting Key.
    ''' </summary>
    Public Property UsernameSetting() As String
        Get
            Return GetValueOrDefault(Of String)(UsernameSettingKeyName, UsernameSettingDefault)
        End Get
        Set(ByVal value As String)
            If (AddOrUpdateValue(UsernameSettingKeyName, value)) Then
                Save()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Property to get and set a Password Setting Key.
    ''' </summary>
    Public Property PasswordSetting() As String
        Get
            Return GetValueOrDefault(Of String)(PasswordSettingKeyName, PasswordSettingDefault)
        End Get
        Set(ByVal value As String)
            If (AddOrUpdateValue(PasswordSettingKeyName, value)) Then
                Save()
            End If
        End Set
    End Property


End Class
