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
Partial Public Class App
    Inherits Application
    ' UI controls on the RootFrame template.
    Dim historyListBox As ListBox ' ListBox for listing the navigation history
    Dim popLastButton As Button ' Button to pop the newest entry from the back stack
    Dim popToSelectedButton As Button ' Button to pop all entries in the back stack up to the selected entry
    Dim currentPageTextBlock As TextBlock ' TextBlock to display the current page the user is on
    ''' <summary>
    ''' Provides easy access to the root frame of the Phone Application.
    ''' </summary>
    ''' <returns>The root frame of the Phone Application.</returns>
    Public Property RootFrame As PhoneApplicationFrame

    ''' <summary>
    ''' Constructor for the Application object.
    ''' </summary>
    Public Sub New()
        ' Standard Silverlight initialization
        InitializeComponent()

        ' Phone-specific initialization
        InitializePhoneApplication()

        ' Show graphics profiling information while debugging.
        If System.Diagnostics.Debugger.IsAttached Then
            ' Display the current frame rate counters.
            Application.Current.Host.Settings.EnableFrameRateCounter = True

            ' Show the areas of the app that are being redrawn in each frame.
            'Application.Current.Host.Settings.EnableRedrawRegions = True

            ' Enable non-production analysis visualization mode, 
            ' which shows areas of a page that are handed off to GPU with a colored overlay.
            'Application.Current.Host.Settings.EnableCacheVisualization = True


            ' Disable the application idle detection by setting the UserIdleDetectionMode property of the
            ' application's PhoneApplicationService object to Disabled.
            ' Caution:- Use this under debug mode only. Application that disables user idle detection will continue to run
            ' and consume battery power when the user is not using the phone.
            PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled
        End If
        ' Set the template for the RootFrame to the new template we created in the Application.Resources in App.xaml
        RootFrame.Template = TryCast(Resources("NewFrameTemplate"), ControlTemplate)
        RootFrame.ApplyTemplate()

        popToSelectedButton = TryCast((TryCast(VisualTreeHelper.GetChild(RootFrame, 0), FrameworkElement)).FindName("btnPopToSelected"), Button)
        AddHandler popToSelectedButton.Click, AddressOf PopToSelectedButton_Click

        popLastButton = TryCast((TryCast(VisualTreeHelper.GetChild(RootFrame, 0), FrameworkElement)).FindName("btnPopLast"), Button)
        AddHandler popLastButton.Click, AddressOf PopLastButton_Click

        currentPageTextBlock = TryCast((TryCast(VisualTreeHelper.GetChild(RootFrame, 0), FrameworkElement)).FindName("CurrentPage"), TextBlock)

        historyListBox = TryCast((TryCast(VisualTreeHelper.GetChild(RootFrame, 0), FrameworkElement)).FindName("HistoryList"), ListBox)
        AddHandler historyListBox.SelectionChanged, AddressOf HistoryList_SelectionChanged

        ' Update the navigation history listbox whenever a navigation happens in the application
        AddHandler RootFrame.Navigated, Sub()
                                            RootFrame.Dispatcher.BeginInvoke(Sub() UpdateHistory())
                                        End Sub
    End Sub

    ''' <summary>
    ''' Use the BackStack property to refresh the navigation history listbox with the latest history.
    ''' </summary>
    Private Sub UpdateHistory()
        historyListBox.Items.Clear()
        Dim i As Integer = 0

        ' The BackStack property is a collection of JournalEntry objects.
        For Each journalEntry In RootFrame.BackStack.Reverse()
            historyListBox.Items.Insert(0, String.Concat(i, ": ", journalEntry.Source))
            i += 1
        Next journalEntry

        currentPageTextBlock.Text = String.Concat("[", RootFrame.Source, "]")

        If popLastButton IsNot Nothing Then
            popLastButton.IsEnabled = (historyListBox.Items.Count() > 0)
        End If
    End Sub

    ''' <summary>
    ''' Remove the last entry from the back stack
    ''' </summary>
    Private Sub PopLastButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' If RemoveBackEntry is called on an empty back stack, an InvalidOperationException is thrown.
        ' Check to make sure the BackStack has entries before calling RemoveBackEntry.
        If RootFrame.BackStack.Count() > 0 Then
            RootFrame.RemoveBackEntry()
        End If

        ' Refresh the history list since the back stack has been modified.
        UpdateHistory()
    End Sub

    ''' <summary>
    ''' Remove all entries from the back stack up to the selected item, but not including it.
    ''' </summary>
    Private Sub PopToSelectedButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' Make sure something has been selected
        If historyListBox IsNot Nothing AndAlso historyListBox.SelectedIndex >= 0 Then
            For i = 0 To historyListBox.SelectedIndex - 1
                RootFrame.RemoveBackEntry()
            Next i

            ' Refresh the history list since the back stack has been modified.
            UpdateHistory()
        End If
    End Sub

    ''' <summary>
    ''' Handle SelectionChanged event for navigation history list.
    ''' </summary>
    Private Sub HistoryList_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
        If historyListBox IsNot Nothing AndAlso popToSelectedButton IsNot Nothing Then
            popToSelectedButton.IsEnabled = If(historyListBox.SelectedItems.Count > 0, True, False)
        End If

    End Sub

    ' Code to execute when the application is launching (eg, from Start)
    ' This code will not execute when the application is reactivated
    Private Sub Application_Launching(ByVal sender As Object, ByVal e As LaunchingEventArgs)
    End Sub

    ' Code to execute when the application is activated (brought to foreground)
    ' This code will not execute when the application is first launched
    Private Sub Application_Activated(ByVal sender As Object, ByVal e As ActivatedEventArgs)
    End Sub

    ' Code to execute when the application is deactivated (sent to background)
    ' This code will not execute when the application is closing
    Private Sub Application_Deactivated(ByVal sender As Object, ByVal e As DeactivatedEventArgs)
    End Sub

    ' Code to execute when the application is closing (eg, user hit Back)
    ' This code will not execute when the application is deactivated
    Private Sub Application_Closing(ByVal sender As Object, ByVal e As ClosingEventArgs)
    End Sub

    ' Code to execute if a navigation fails
    Private Sub RootFrame_NavigationFailed(ByVal sender As Object, ByVal e As NavigationFailedEventArgs)
        If Diagnostics.Debugger.IsAttached Then
            ' A navigation has failed; break into the debugger
            Diagnostics.Debugger.Break()
        End If
    End Sub

    Public Sub Application_UnhandledException(ByVal sender As Object, ByVal e As ApplicationUnhandledExceptionEventArgs) Handles Me.UnhandledException

        ' Show graphics profiling information while debugging.
        If Diagnostics.Debugger.IsAttached Then
            Diagnostics.Debugger.Break()
        Else
            e.Handled = True
            MessageBox.Show(e.ExceptionObject.Message & Environment.NewLine & e.ExceptionObject.StackTrace,
                            "Error", MessageBoxButton.OK)
        End If
    End Sub

#Region "Phone application initialization"
    ' Avoid double-initialization
    Private phoneApplicationInitialized As Boolean = False

    ' Do not add any additional code to this method
    Private Sub InitializePhoneApplication()
        If phoneApplicationInitialized Then
            Return
        End If

        ' Create the frame but don't set it as RootVisual yet; this allows the splash
        ' screen to remain active until the application is ready to render.
        RootFrame = New PhoneApplicationFrame()
        AddHandler RootFrame.Navigated, AddressOf CompleteInitializePhoneApplication

        ' Handle navigation failures
        AddHandler RootFrame.NavigationFailed, AddressOf RootFrame_NavigationFailed

        ' Ensure we don't initialize again
        phoneApplicationInitialized = True
    End Sub

    ' Do not add any additional code to this method
    Private Sub CompleteInitializePhoneApplication(ByVal sender As Object, ByVal e As NavigationEventArgs)
        ' Set the root visual to allow the application to render
        If RootVisual IsNot RootFrame Then
            RootVisual = RootFrame
        End If

        ' Remove this handler since it is no longer needed
        RemoveHandler RootFrame.Navigated, AddressOf CompleteInitializePhoneApplication
    End Sub
#End Region

End Class
