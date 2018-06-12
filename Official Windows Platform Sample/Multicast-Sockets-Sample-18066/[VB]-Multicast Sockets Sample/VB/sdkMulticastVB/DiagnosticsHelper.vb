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
Public Class DiagnosticsHelper
    Public Shared Function SafeShow(ByVal messageBoxText As String, ByVal caption As String, ByVal button As MessageBoxButton) As MessageBoxResult
        Dim result As MessageBoxResult = MessageBoxResult.None

        ' Am I already on the UI thread?
        If System.Windows.Deployment.Current.Dispatcher.CheckAccess() Then
            result = MessageBox.Show(messageBoxText, caption, button)
        Else
            System.Windows.Deployment.Current.Dispatcher.BeginInvoke(Sub() result = MessageBox.Show(messageBoxText, caption, button))
        End If

        Return result
    End Function

    Public Shared Function SafeShow(ByVal messageBoxText As String) As MessageBoxResult
        Return SafeShow(messageBoxText, String.Empty, MessageBoxButton.OK)
    End Function
End Class
