' 
'    Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
'    Use of this sample source code is subject to the terms of the Microsoft license 
'    agreement under which you licensed this sample source code and is provided AS-IS.
'    If you did not accept the terms of the license agreement, you are not authorized 
'    to use this sample source code.  For the terms of the license, please see the 
'    license agreement between you and Microsoft.
'  
'    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
'  
'
#Const DEBUG_AGENT = True
Imports Microsoft.Phone.Scheduler
Imports Microsoft.Phone.Info
Imports Microsoft.Phone.Shell

Public Class ScheduledAgent
    Inherits ScheduledTaskAgent
    Private Shared _classInitialized As Boolean

    ''' <remarks>
    ''' ScheduledAgent constructor, initializes the UnhandledException handler
    ''' </remarks>
    Public Sub New()
        If Not _classInitialized Then
            _classInitialized = True
            ' Subscribe to the managed exception handler
            Deployment.Current.Dispatcher.BeginInvoke(Sub() AddHandler Application.Current.UnhandledException, AddressOf ScheduledAgent_UnhandledException)
        End If
    End Sub

    ''' Code to execute on Unhandled Exceptions
    Private Sub ScheduledAgent_UnhandledException(ByVal sender As Object, ByVal e As ApplicationUnhandledExceptionEventArgs)
        If System.Diagnostics.Debugger.IsAttached Then
            ' An unhandled exception has occurred; break into the debugger
            System.Diagnostics.Debugger.Break()
        End If
    End Sub

    ''' <summary>
    ''' Agent that runs a scheduled task
    ''' </summary>
    ''' <param name="task">
    ''' The invoked task
    ''' </param>
    ''' <remarks>
    ''' This method is called when a periodic or resource intensive task is invoked
    ''' </remarks>
    Protected Overrides Sub OnInvoke(ByVal task As ScheduledTask)
        'TODO: Add code to perform your task in background
        Dim toastTitle As String = ""

        ' If your application uses both PeriodicTask and ResourceIntensiveTask
        ' you can branch your application code here. Otherwise, you don't need to.
        If TypeOf task Is PeriodicTask Then
            ' Execute periodic task actions here.
            toastTitle = "Periodic "
        Else
            ' Execute resource-intensive task actions here.
            toastTitle = "Resource-intensive "
        End If

        Dim toastMessage As String = String.Concat("Mem usage: ", DeviceStatus.ApplicationPeakMemoryUsage, "/", DeviceStatus.ApplicationMemoryUsageLimit)

        ' Launch a toast to show that the agent is running.
        ' The toast will not be shown if the foreground application is running.
        Dim toast As New ShellToast()
        toast.Title = toastTitle
        toast.Content = toastMessage
        toast.Show()


        ' If debugging is enabled, launch the agent again in one minute.
#If DEBUG_AGENT Then
        ScheduledActionService.LaunchForTest(task.Name, TimeSpan.FromSeconds(60))
#End If

        ' Call NotifyComplete to let the system know the agent is done working.
        NotifyComplete()
    End Sub
End Class