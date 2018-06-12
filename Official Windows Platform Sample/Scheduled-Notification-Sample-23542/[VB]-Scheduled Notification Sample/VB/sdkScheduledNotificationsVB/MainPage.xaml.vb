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

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    Private notifications As IEnumerable(Of ScheduledNotification)

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ResetItemsList()
        ' Use GetActions to retrieve all of the scheduled actions
        ' stored for this application. The type <Reminder> is specified
        ' to retrieve only Reminder objects.
        ' reminders = ScheduledActionService.GetActions(Of Reminder)()
        notifications = ScheduledActionService.GetActions(Of ScheduledNotification)()


        ' If there are 1 or more notifications, hide the "no notifications"
        ' TextBlock. IF there are zero reminders, show the TextBlock.
        ' If reminders.Count(Of Reminder)() > 0 Then
        If notifications.Count() > 0 Then
            EmptyTextBlock.Visibility = Visibility.Collapsed
        Else
            EmptyTextBlock.Visibility = Visibility.Visible
        End If

        ' Update the ReminderListBox with the list of reminders.
        ' A full MVVM implementation can automate this step.
        NotificationListBox.ItemsSource = notifications
    End Sub

    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        MyBase.OnNavigatedTo(e)

        ' Reset the ReminderListBox items when the page is navigated to.
        ResetItemsList()
    End Sub

    Private Sub deleteButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' The scheduled action name is stored in the Tag property
        ' of the delete button for each reminder.
        Dim name As String = CStr((CType(sender, Button)).Tag)

        ' Call Remove to unregister the scheduled action with the service.
        ScheduledActionService.Remove(name)

        ' Reset the ReminderListBox items
        ResetItemsList()
    End Sub

    Private Sub ApplicationBarAddButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Navigate to the AddReminder page when the add button is clicked.
        NavigationService.Navigate(New Uri("/AddNotification.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
