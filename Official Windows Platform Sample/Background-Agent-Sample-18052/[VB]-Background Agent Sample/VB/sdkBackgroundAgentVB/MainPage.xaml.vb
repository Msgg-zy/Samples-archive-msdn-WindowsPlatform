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



Partial Public Class MainPage
    Inherits PhoneApplicationPage

    Private periodicTask As PeriodicTask
    Private resourceIntensiveTask As ResourceIntensiveTask

    Private periodicTaskName As String = "PeriodicAgent"
    Private resourceIntensiveTaskName As String = "ResourceIntensiveAgent"
    Public agentsAreEnabled As Boolean = True

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub StartPeriodicAgent()
        ' Variable for tracking enabled status of background agents for this app.
        agentsAreEnabled = True

        ' Obtain a reference to the period task, if one exists
        periodicTask = TryCast(ScheduledActionService.Find(periodicTaskName), PeriodicTask)

        ' If the task already exists and background agents are enabled for the
        ' application, you must remove the task and then add it again to update 
        ' the schedule
        If periodicTask IsNot Nothing Then
            RemoveAgent(periodicTaskName)
        End If

        periodicTask = New PeriodicTask(periodicTaskName)

        ' The description is required for periodic agents. This is the string that the user
        ' will see in the background services Settings page on the device.
        periodicTask.Description = "This demonstrates a periodic task."

        ' Place the call to Add in a try block in case the user has disabled agents
        Try
            ScheduledActionService.Add(periodicTask)

            PeriodicStackPanel.DataContext = periodicTask

            ' If debugging is enabled, use LaunchForTest to launch the agent in one minute.
#If (DEBUG_AGENT) Then
				ScheduledActionService.LaunchForTest(periodicTaskName, TimeSpan.FromSeconds(60))
#End If
        Catch exception As InvalidOperationException
            If exception.Message.Contains("BNS Error: The action is disabled") Then
                MessageBox.Show("Background agents for this application have been disabled by the user.")
                agentsAreEnabled = False
            End If

            If exception.Message.Contains("BNS Error: The maximum number of ScheduledActions of this type have already been added.") Then
                ' No user action required. The system prompts the user when the hard limit of periodic tasks has been reached.
            End If

            PeriodicCheckBox.IsChecked = False

        Catch exception As SchedulerServiceException
            ' No user action required.
            PeriodicCheckBox.IsChecked = False
        End Try
    End Sub

    Private Sub StartResourceIntensiveAgent()
        ' Variable for tracking enabled status of background agents for this app.
        agentsAreEnabled = True

        resourceIntensiveTask = TryCast(ScheduledActionService.Find(resourceIntensiveTaskName), ResourceIntensiveTask)

        ' If the task already exists and background agents are enabled for the
        ' application, you must remove the task and then add it again to update 
        ' the schedule
        If resourceIntensiveTask IsNot Nothing Then
            RemoveAgent(resourceIntensiveTaskName)
        End If

        resourceIntensiveTask = New ResourceIntensiveTask(resourceIntensiveTaskName)

        ' The description is required for periodic agents. This is the string that the user
        ' will see in the background services Settings page on the device.
        resourceIntensiveTask.Description = "This demonstrates a resource-intensive task."

        ' Place the call to Add in a try block in case the user has disabled agents
        Try
            ScheduledActionService.Add(resourceIntensiveTask)

            ResourceIntensiveStackPanel.DataContext = resourceIntensiveTask

            ' If debugging is enabled, use LaunchForTest to launch the agent in one minute.
#If (DEBUG_AGENT) Then
				ScheduledActionService.LaunchForTest(resourceIntensiveTaskName, TimeSpan.FromSeconds(60))
#End If
        Catch exception As InvalidOperationException
            If exception.Message.Contains("BNS Error: The action is disabled") Then
                MessageBox.Show("Background agents for this application have been disabled by the user.")
                agentsAreEnabled = False
            End If
            ResourceIntensiveCheckBox.IsChecked = False

        Catch exception As SchedulerServiceException
            ' No user action required.
            ResourceIntensiveCheckBox.IsChecked = False
        End Try
    End Sub

    Private Sub RemoveAgent(ByVal name As String)
        Try
            ScheduledActionService.Remove(name)
        Catch e1 As Exception
        End Try
    End Sub

    Private ignoreCheckBoxEvents As Boolean = False

    Private Sub PeriodicCheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If ignoreCheckBoxEvents Then
            Return
        End If
        StartPeriodicAgent()
    End Sub
    Private Sub PeriodicCheckBox_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If ignoreCheckBoxEvents Then
            Return
        End If
        RemoveAgent(periodicTaskName)
    End Sub
    Private Sub ResourceIntensiveCheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If ignoreCheckBoxEvents Then
            Return
        End If
        StartResourceIntensiveAgent()
    End Sub
    Private Sub ResourceIntensiveCheckBox_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If ignoreCheckBoxEvents Then
            Return
        End If
        RemoveAgent(resourceIntensiveTaskName)
    End Sub


    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        ignoreCheckBoxEvents = True

        periodicTask = TryCast(ScheduledActionService.Find(periodicTaskName), PeriodicTask)

        If periodicTask IsNot Nothing Then
            PeriodicStackPanel.DataContext = periodicTask
        End If

        resourceIntensiveTask = TryCast(ScheduledActionService.Find(resourceIntensiveTaskName), ResourceIntensiveTask)
        If resourceIntensiveTask IsNot Nothing Then
            ResourceIntensiveStackPanel.DataContext = resourceIntensiveTask
        End If

        ignoreCheckBoxEvents = False

    End Sub

End Class
