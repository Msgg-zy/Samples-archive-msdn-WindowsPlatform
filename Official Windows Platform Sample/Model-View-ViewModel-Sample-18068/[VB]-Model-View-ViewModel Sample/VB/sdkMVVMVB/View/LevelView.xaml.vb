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
Imports System.Globalization

Namespace View
    Partial Public Class LevelView
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class BoolOpposite
        Implements System.Windows.Data.IValueConverter
        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
            Dim b As Boolean = CBool(value)
            Return Not b
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
            Dim s As String = TryCast(value, String)
            Dim b As Boolean

            If Boolean.TryParse(s, b) Then
                Return Not b
            End If
            Return False
        End Function
    End Class
End Namespace

