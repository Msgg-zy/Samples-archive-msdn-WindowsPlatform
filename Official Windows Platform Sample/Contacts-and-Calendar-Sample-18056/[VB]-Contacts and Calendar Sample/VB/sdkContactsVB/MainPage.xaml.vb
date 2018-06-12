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
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.UserData

    Partial Public Class MainPage
        Inherits PhoneApplicationPage
        Private contactFilterKind As FilterKind = FilterKind.None

        ' Constructor
        Public Sub New()
            InitializeComponent()

        nameRadiobutton.IsChecked = True

            ContactAccounts.DataContext = (New Contacts()).Accounts
            CalendarAccounts.DataContext = (New Appointments()).Accounts
        End Sub


        Private Sub SearchContacts_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            'Add code to validate the contactFilterString.Text input.

            ContactResultsLabel.Text = "results are loading..."
            ContactResultsData.DataContext = Nothing

            Dim cons As New Contacts()

            AddHandler cons.SearchCompleted, AddressOf Contacts_SearchCompleted

            cons.SearchAsync(contactFilterString.Text, contactFilterKind, "Contacts Test #1")
        End Sub


        Private Sub Contacts_SearchCompleted(ByVal sender As Object, ByVal e As ContactsSearchEventArgs)
        'MessageBox.Show(e.State.ToString())

            Try
                'Bind the results to the list box that displays them in the UI
                ContactResultsData.DataContext = e.Results
            Catch e1 As System.Exception
                'That's okay, no results
            End Try

            If ContactResultsData.Items.Count > 0 Then
                ContactResultsLabel.Text = "results (tap name for details...)"
            Else
                ContactResultsLabel.Text = "no results"
            End If
        End Sub


        Private Sub ContactResultsData_Tap(ByVal sender As Object, ByVal e As GestureEventArgs)
            App.con = (TryCast((TryCast(sender, ListBox)).SelectedValue, Contact))

            NavigationService.Navigate(New Uri("/ContactDetails.xaml", UriKind.Relative))
        End Sub


        Private Sub FilterChange(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim [option] As String = (CType(sender, RadioButton)).Name

            Dim scope As New InputScope()
            Dim scopeName As New InputScopeName()

            Select Case [option]
                Case "name"
                    contactFilterKind = FilterKind.DisplayName
                    scopeName.NameValue = InputScopeNameValue.Text

                Case "phone"
                    contactFilterKind = FilterKind.PhoneNumber
                    scopeName.NameValue = InputScopeNameValue.TelephoneNumber

                Case "email"
                    contactFilterKind = FilterKind.EmailAddress
                    scopeName.NameValue = InputScopeNameValue.EmailSmtpAddress

                Case Else
                    contactFilterKind = FilterKind.None
            End Select

            scope.Names.Add(scopeName)
            contactFilterString.InputScope = scope
            contactFilterString.Focus()
        End Sub


        Private Sub SearchAppointments_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AppointmentResultsLabel.Text = "results are loading..."
            AppointmentResultsData.DataContext = Nothing
            Dim appts As New Appointments()

            AddHandler appts.SearchCompleted, AddressOf Appointments_SearchCompleted

            Dim start As Date = Date.Now
            Dim [end] As Date = start.AddDays(7)

            appts.SearchAsync(start, [end], 20, "Appointments Test #1")
        End Sub


        Private Sub Appointments_SearchCompleted(ByVal sender As Object, ByVal e As AppointmentsSearchEventArgs)
            StartDate.Text = e.StartTimeInclusive.ToShortDateString()
            EndDate.Text = e.EndTimeInclusive.ToShortDateString()

            Try
                'Bind the results to the list box that displays them in the UI
                AppointmentResultsData.DataContext = e.Results
            Catch e1 As System.Exception
                'That's okay, no results
            End Try

            If AppointmentResultsData.Items.Count > 0 Then
                AppointmentResultsLabel.Text = "results (tap for details...)"
            Else
                AppointmentResultsLabel.Text = "no results"
            End If
        End Sub


        Private Sub AppointmentResultsData_Tap(ByVal sender As Object, ByVal e As GestureEventArgs)
            App.appt = (TryCast((TryCast(sender, ListBox)).SelectedValue, Appointment))

            NavigationService.Navigate(New Uri("/AppointmentDetails.xaml", UriKind.Relative))
        End Sub

    End Class 'End page class


    Public Class ContactPictureConverter
        Implements System.Windows.Data.IValueConverter
        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
            Dim c As Contact = TryCast(value, Contact)
            If c Is Nothing Then
                Return Nothing
            End If

            Dim imageStream As System.IO.Stream = c.GetPicture()
            If Nothing IsNot imageStream Then
                Return Microsoft.Phone.PictureDecoder.DecodeJpeg(imageStream)
            End If
            Return Nothing
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class 'End converter class


