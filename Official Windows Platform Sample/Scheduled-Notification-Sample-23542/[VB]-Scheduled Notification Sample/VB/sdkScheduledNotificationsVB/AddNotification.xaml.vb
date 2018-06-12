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
Imports Microsoft.Phone.Scheduler

Partial Public Class AddNotification
    Inherits PhoneApplicationPage
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ApplicationBarSaveButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Generate a unique name for the new notification. You can choose a
        ' name that is meaningful for your app, or just use a GUID.
        Dim name As String = Guid.NewGuid().ToString()



        ' Get the begin time for the notification by combining the DatePicker
        ' value and the TimePicker value.
        Dim [date] As Date = CDate(beginDatePicker.Value)
        Dim time As Date = CDate(beginTimePicker.Value)
        Dim beginTime As Date = [date] + time.TimeOfDay

        ' Make sure that the begin time has not already passed.
        If beginTime < Date.Now Then
            MessageBox.Show("the begin date must be in the future.")
            Return
        End If

        ' Get the expiration time for the notification
        [date] = CDate(expirationDatePicker.Value)
        time = CDate(expirationTimePicker.Value)
        Dim expirationTime As Date = [date] + time.TimeOfDay

        ' Make sure that the expiration time is after the begin time.
        If expirationTime < beginTime Then
            MessageBox.Show("expiration time must be after the begin time.")
            Return
        End If

        ' Determine which recurrence radio button is checked.
        Dim recurrence As RecurrenceInterval = RecurrenceInterval.None
        If dailyRadioButton.IsChecked = True Then
            recurrence = RecurrenceInterval.Daily
        ElseIf weeklyRadioButton.IsChecked = True Then
            recurrence = RecurrenceInterval.Weekly
        ElseIf monthlyRadioButton.IsChecked = True Then
            recurrence = RecurrenceInterval.Monthly
        ElseIf endOfMonthRadioButton.IsChecked = True Then
            recurrence = RecurrenceInterval.EndOfMonth
        ElseIf yearlyRadioButton.IsChecked = True Then
            recurrence = RecurrenceInterval.Yearly
        End If


        ' Create a Uri for the page that will be launched if the user
        ' taps on the reminder. Use query string parameters to pass 
        ' content to the page that is launched.
        Dim param1Value As String = param1TextBox.Text
        Dim param2Value As String = param2TextBox.Text
        Dim queryString As String = ""
        If param1Value <> "" AndAlso param2Value <> "" Then
            queryString = String.Concat("?param1=", param1Value, "&param2=", param2Value)
        ElseIf param1Value <> "" OrElse param2Value <> "" Then
            queryString = If(param1Value IsNot Nothing, "?param1=" & param1Value, "?param2=" & param2Value)
        End If

        Dim navigationUri As New Uri("/ShowParams.xaml" & queryString, UriKind.Relative)

        If CBool(reminderRadioButton.IsChecked) Then
            Dim reminder As New Reminder(name)
            reminder.Title = titleTextBox.Text
            reminder.Content = contentTextBox.Text
            reminder.BeginTime = beginTime
            reminder.ExpirationTime = expirationTime
            reminder.RecurrenceType = recurrence
            reminder.NavigationUri = navigationUri

            ' Register the reminder with the system.
            ScheduledActionService.Add(reminder)
        Else
            Dim alarm As New Alarm(name)
            alarm.Content = contentTextBox.Text
            alarm.Sound = New Uri("/Ringtones/Ring01.wma", UriKind.Relative)
            alarm.BeginTime = beginTime
            alarm.ExpirationTime = expirationTime
            alarm.RecurrenceType = recurrence

            ScheduledActionService.Add(alarm)
        End If

        ' Navigate back to the main reminder list page.
        NavigationService.GoBack()

    End Sub

    Private Sub reminderRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        titleTextBox.IsEnabled = True
    End Sub

    Private Sub alarmRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        titleTextBox.Text = ""
        titleTextBox.IsEnabled = False
    End Sub
End Class
