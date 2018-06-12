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
Imports System.Windows.Data
Imports System.Text.RegularExpressions
Imports System.Globalization


Public Class RssTextTrimmer
    Implements IValueConverter
    ' Clean up text fields from each SyndicationItem. 
    Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
        If value Is Nothing Then
            Return Nothing
        End If

        Dim maxLength As Integer = 200
        Dim strLength As Integer = 0
        Dim fixedString As String = ""

        ' Remove HTML tags and newline characters from the text, and decodes HTML encoded characters. 
        ' This is a basic method. Additional code would be needed to more thoroughly  
        ' remove certain elements, such as embedded Javascript. 

        ' Remove HTML tags. 
        fixedString = Regex.Replace(value.ToString(), "<[^>]+>", String.Empty)

        ' Remove newline characters
        fixedString = fixedString.Replace(vbCr, "").Replace(vbLf, "")

        ' Remove encoded HTML characters
        fixedString = HttpUtility.HtmlDecode(fixedString)

        strLength = fixedString.ToString().Length

        ' Some feed management tools include an image tag in the Description field of an RSS feed, 
        ' so even if the Description field (and thus, the Summary property) is not populated, it could still contain HTML. 
        ' Due to this, after we strip tags from the string, we should return null if there is nothing left in the resulting string. 
        If strLength = 0 Then
            Return Nothing

            ' Truncate the text if it is too long. 
        ElseIf strLength >= maxLength Then
            fixedString = fixedString.Substring(0, maxLength)

            ' Unless we take the next step, the string truncation could occur in the middle of a word.
            ' Using LastIndexOf we can find the last space character in the string and truncate there. 
            fixedString = fixedString.Substring(0, fixedString.LastIndexOf(" "))
        End If

        fixedString &= "..."

        Return fixedString
    End Function

    ' This code sample does not use TwoWay binding and thus, we do not need to flesh out ConvertBack.  
    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
