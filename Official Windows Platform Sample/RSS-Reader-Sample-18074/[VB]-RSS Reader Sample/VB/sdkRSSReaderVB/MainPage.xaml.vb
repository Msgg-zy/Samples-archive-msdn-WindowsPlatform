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
Imports System.ServiceModel.Syndication
Imports Microsoft.Phone.Tasks
Imports System.IO

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Click handler which runs when the 'Load Feed' or 'Refresh Feed' button is clicked. 
    Private Sub loadFeedButton_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
        ' WebClient is used instead of HttpWebRequest in this code sample because 
        ' the implementation is simpler and easier to use, and we do not need to use 
        ' advanced functionality that HttpWebRequest provides, such as the ability to send headers.
        Dim webClient As New WebClient()

        ' Subscribe to the DownloadStringCompleted event prior to downloading the RSS feed.
        AddHandler webClient.DownloadStringCompleted, AddressOf webClient_DownloadStringCompleted

        ' Download the RSS feed. DownloadStringAsync was used instead of OpenStreamAsync because we do not need 
        ' to leave a stream open, and we will not need to worry about closing the channel. 
        webClient.DownloadStringAsync(New System.Uri("http://windowsteamblog.com/windows_phone/b/windowsphone/rss.aspx"))
    End Sub

    ' Event handler which runs after the feed is fully downloaded.
    Private Sub webClient_DownloadStringCompleted(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        If e.Error IsNot Nothing Then
            ' Showing the exact error message is useful for debugging. In a finalized application, 
            ' output a friendly and applicable string to the user instead. 
            Deployment.Current.Dispatcher.BeginInvoke(Sub() MessageBox.Show(e.Error.Message))
        Else
            ' Save the feed into the State property in case the application is tombstoned. 
            Me.State("feed") = e.Result

            UpdateFeedList(e.Result)
        End If
    End Sub

    ' This method determines whether the user has navigated to the application after the application was tombstoned.
    Protected Overrides Sub OnNavigatedTo(ByVal e As System.Windows.Navigation.NavigationEventArgs)
        ' First, check whether the feed is already saved in the page state.
        If Me.State.ContainsKey("feed") Then
            ' Get the feed again only if the application was tombstoned, which means the ListBox will be empty.
            ' This is because the OnNavigatedTo method is also called when navigating between pages in your application.
            ' You would want to rebind only if your application was tombstoned and page state has been lost. 
            If feedListBox.Items.Count = 0 Then
                UpdateFeedList(TryCast(State("feed"), String))
            End If
        End If
    End Sub

    ' This method sets up the feed and binds it to our ListBox. 
    Private Sub UpdateFeedList(ByVal feedXML As String)
        ' Load the feed into a SyndicationFeed instance
        Dim stringReader As New StringReader(feedXML)
        Dim xmlReader As XmlReader = xmlReader.Create(stringReader)
        Dim feed As SyndicationFeed = SyndicationFeed.Load(xmlReader)

        ' In Windows Phone OS 7.1, WebClient events are raised on the same type of thread they were called upon. 
        ' For example, if WebClient was run on a background thread, the event would be raised on the background thread. 
        ' While WebClient can raise an event on the UI thread if called from the UI thread, a best practice is to always 
        ' use the Dispatcher to update the UI. This keeps the UI thread free from heavy processing.
        ' Bind the list of SyndicationItems to our ListBox
        Deployment.Current.Dispatcher.BeginInvoke(Sub()
                                                      feedListBox.ItemsSource = feed.Items
                                                      loadFeedButton.Content = "Refresh Feed"
                                                  End Sub)

    End Sub

    ' The SelectionChanged handler for the feed items 
    Private Sub feedListBox_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
        Dim listBox As ListBox = TryCast(sender, ListBox)

        If listBox IsNot Nothing AndAlso listBox.SelectedItem IsNot Nothing Then
            ' Get the SyndicationItem that was tapped.
            Dim sItem As SyndicationItem = CType(listBox.SelectedItem, SyndicationItem)

            ' Set up the page navigation only if a link actually exists in the feed item.
            If sItem.Links.Count > 0 Then
                ' Get the associated URI of the feed item.
                Dim uri As Uri = sItem.Links.FirstOrDefault().Uri

                ' Create a new WebBrowserTask Launcher to navigate to the feed item. 
                ' An alternative solution would be to use a WebBrowser control, but WebBrowserTask is simpler to use. 
                Dim webBrowserTask As New WebBrowserTask()
                webBrowserTask.Uri = uri
                webBrowserTask.Show()
            End If
        End If
    End Sub
End Class
