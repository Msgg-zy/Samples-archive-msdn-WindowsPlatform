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
Partial Public Class Keyboard6
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()

        'You can set the Keyboard Input Scope by using either XAML or code.
        'See the XAML file for the XAML version.
        'The code version is below.

        Dim scope As New InputScope()
        Dim name As New InputScopeName()

        name.NameValue = InputScopeNameValue.PostalAddress '<--Here
        scope.Names.Add(name)

        txtK6.InputScope = scope

        'To create keyboard 6, you can use any of the following Input Scopes.
        '--------------------------------------------------------------------
        ' AddressStreet
        ' CurrencyAmountAndSymbol
        ' CurrencyChinese
        ' PostalAddress
        ' PostalCode
        ' Time
    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        MyBase.OnNavigatedTo(e)

        'This code opens up the keyboard when you navigate to the page.
        txtK6.UpdateLayout()
        txtK6.Focus()
    End Sub
End Class
