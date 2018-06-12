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
Imports System
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports System.Globalization
Imports System.Threading

    Partial Public Class MainPage
        Inherits PhoneApplicationPage
        ' Constructor
        Public Sub New()
            InitializeComponent()

            SupportedOrientations = SupportedPageOrientation.Portrait Or SupportedPageOrientation.Landscape
        End Sub

        Private Sub LocList_SelectedIndexChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            ' Set the current culture according to the selected locale and display information such as
            ' date, time, currency, etc in the appropriate format.

            Dim nl As String
            Dim cul As String

            nl = locList.SelectedIndex.ToString()

            Select Case nl
                Case "0"
                    cul = "zh-CN"
                Case "1"
                    cul = "zh-TW"
                Case "2"
                    cul = "cs-CZ"
                Case "3"
                    cul = "da-DK"
                Case "4"
                    cul = "nl-NL"
                Case "5"
                    cul = "en-GB"
                Case "6"
                    cul = "en-US"
                Case "7"
                    cul = "fi-FI"
                Case "8"
                    cul = "fr-FR"
                Case "9"
                    cul = "de-DE"
                Case "10"
                    cul = "el-GR"
                Case "11"
                    cul = "hu-HU"
                Case "12"
                    cul = "it-IT"
                Case "13"
                    cul = "ja-JP"
                Case "14"
                    cul = "ko-KR"
                Case "15"
                    cul = "nb-NO"
                Case "16"
                    cul = "pl-PL"
                Case "17"
                    cul = "pt-BR"
                Case "18"
                    cul = "pt-PT"
                Case "19"
                    cul = "ru-RU"
                Case "20"
                    cul = "es-ES"
                Case "21"
                    cul = "sv-SE"
                Case Else
                    cul = "en-US"
            End Select


            ' set this thread's current culture to the culture associated with the selected locale
            Dim newCulture As New CultureInfo(cul)
            Thread.CurrentThread.CurrentCulture = newCulture

            Dim cc, cuic As CultureInfo
            cc = Thread.CurrentThread.CurrentCulture
            cuic = Thread.CurrentThread.CurrentUICulture

            ' display the culture name in the language of the selected locale
            regionalFrmt.Text = cc.NativeName

            ' display the culture name in the localized language
            displayLang.Text = cuic.DisplayName

            ' display the date formats (long and short form) for the  current culuture  
            Dim curDate As Date = Date.Now
            longDate.Text = cc.DateTimeFormat.LongDatePattern.ToString() & " " & curDate.ToString("D")
            shortDate.Text = cc.DateTimeFormat.ShortDatePattern.ToString() & "   " & curDate.ToString("d")

            ' display the time format (long form) for the current culture
            longTime.Text = cc.DateTimeFormat.LongTimePattern & "   " & curDate.ToString("T")

            ' display the currency format and currency symbol for the current culture
            Dim money As Int64 = 123456789
            currencyFrmt.Text = money.ToString("C")
        End Sub

    End Class
