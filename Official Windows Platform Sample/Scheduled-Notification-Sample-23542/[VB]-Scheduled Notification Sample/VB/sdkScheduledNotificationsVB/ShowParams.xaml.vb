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
Imports Microsoft.Phone.Controls

Partial Public Class ShowParams
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Implement the OnNavigatedTo method and use NavigationContext.QueryString
    ' to get the parameter values passed by the reminder.
    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        MyBase.OnNavigatedTo(e)

        Dim param1Value As String = ""
        Dim param2Value As String = ""

        NavigationContext.QueryString.TryGetValue("param1", param1Value)
        NavigationContext.QueryString.TryGetValue("param2", param2Value)

        param1TextBlock.Text = param1Value
        param2TextBlock.Text = param2Value
    End Sub

End Class
