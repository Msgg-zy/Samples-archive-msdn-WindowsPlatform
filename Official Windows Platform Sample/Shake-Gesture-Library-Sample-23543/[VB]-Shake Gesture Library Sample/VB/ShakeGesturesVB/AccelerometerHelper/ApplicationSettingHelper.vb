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


Namespace Microsoft.Phone.Applications.Common
    Public NotInheritable Class ApplicationSettingHelper
        '
        ' Attempt to get a value from the application settings
        ' if not successful (no present, wrong type), returns provided default value
        '
        'Expected type of the setting
        'Name of the key
        'Default value to be returned if fails</param>

        Private Sub New()
        End Sub
        Public Shared Function TryGetValueWithDefault(Of TValue)(ByVal key As String, ByVal defaultValue As TValue) As TValue
            Dim retval As TValue = defaultValue
            If IsolatedStorageSettings.ApplicationSettings.Contains(key) Then
                Dim value As Object = IsolatedStorageSettings.ApplicationSettings(key)
                If TypeOf value Is TValue Then
                    retval = CType(value, TValue)
                End If
            End If
            Return retval
        End Function


        ''' <summary>
        ''' Add key/value or Update existing key with new value to the application settings
        ''' </summary>
        ''' <param name="key">Name of the key</param>
        ''' <param name="value">New or updated value</param>
        ''' <returns></returns>
        Public Shared Function AddOrUpdateValue(ByVal key As String, ByVal value As Object) As Boolean
            Dim valueChanged As Boolean = False
            If IsolatedStorageSettings.ApplicationSettings.Contains(key) Then
                If IsolatedStorageSettings.ApplicationSettings(key) IsNot value Then
                    IsolatedStorageSettings.ApplicationSettings(key) = value
                    valueChanged = True
                End If
            Else
                IsolatedStorageSettings.ApplicationSettings.Add(key, value)
                valueChanged = True
            End If
            Return valueChanged
        End Function


        ''' <summary>
        ''' Explicit Save. Not needed as Save will automatically be called at appInstance exit
        ''' </summary>
        Public Shared Sub Save()
            IsolatedStorageSettings.ApplicationSettings.Save()
        End Sub
    End Class
End Namespace
