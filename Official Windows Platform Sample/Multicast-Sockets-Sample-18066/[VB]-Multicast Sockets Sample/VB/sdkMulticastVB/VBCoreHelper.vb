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
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Diagnostics
Imports System.Collections
Imports System.Runtime.Serialization
Imports System.Reflection
Imports System.Threading
Imports System.Security
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Text


'This Contains Functions Missing from the VBCore Embedded into the assembly using the VBruntime* switch
' Adding these helper classes with specific implementations should re-enable some testcases.

Public Module VBCoreHelperFunctionality
    'ControlChars
    Public Class ControlChars
        Public Const CrLf As String = ChrW(13) & ChrW(10)
        Public Const Cr As Char = ChrW(13)
        Public Const FormFeed As Char = ChrW(12)
        Public Const Lf As Char = ChrW(10)
        Public Const NewLine As String = ChrW(13) & ChrW(10)
        Public Const NullChar As Char = ChrW(0)
        Public Const Quote As Char = """"c
        Public Const Tab As Char = ChrW(9)
        Public Const VerticalTab As Char = ChrW(11)
    End Class
End Module


