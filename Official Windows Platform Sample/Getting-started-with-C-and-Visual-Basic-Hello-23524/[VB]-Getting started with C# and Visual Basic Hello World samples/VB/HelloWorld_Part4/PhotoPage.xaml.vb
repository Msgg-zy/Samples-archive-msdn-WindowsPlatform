' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class PhotoPage
    Inherits Page

    Private mruToken As String = Nothing

    ''' <summary>
    ''' NavigationHelper is used on each page to aid in navigation and 
    ''' process lifetime management
    ''' </summary>
    Public ReadOnly Property NavigationHelper As Common.NavigationHelper
        Get
            Return Me._navigationHelper
        End Get
    End Property
    Private _navigationHelper As Common.NavigationHelper

    ''' <summary>
    ''' This can be changed to a strongly typed view model.
    ''' </summary>
    Public ReadOnly Property DefaultViewModel As Common.ObservableDictionary
        Get
            Return Me._defaultViewModel
        End Get
    End Property
    Private _defaultViewModel As New Common.ObservableDictionary()

    Public Sub New()

        InitializeComponent()
        Me._navigationHelper = New Common.NavigationHelper(Me)
        AddHandler Me._navigationHelper.LoadState, AddressOf NavigationHelper_LoadState
        AddHandler Me._navigationHelper.SaveState, AddressOf NavigationHelper_SaveState
    End Sub

    ''' <summary>
    ''' Populates the page with content passed during navigation.  Any saved state is also
    ''' provided when recreating a page from a prior session.
    ''' </summary>
    ''' <param name="sender">
    ''' The source of the event; typically <see cref="NavigationHelper"/>
    ''' </param>
    ''' <param name="e">Event data that provides both the navigation parameter passed to
    ''' <see cref="Frame.Navigate"/> when this page was initially requested and
    ''' a dictionary of state preserved by this page during an earlier
    ''' session.  The state will be null the first time a page is visited.</param>
    Private Async Sub NavigationHelper_LoadState(sender As Object, e As Common.LoadStateEventArgs)
        If e.PageState IsNot Nothing AndAlso e.PageState.ContainsKey("mruToken") Then
            Dim value As Object = Nothing
            If e.PageState.TryGetValue("mruToken", value) Then

                If (value IsNot Nothing) Then
                    mruToken = value.ToString()

                    ' Open the file via the token that you stored when adding this file into the MRU list.
                    Dim file =
                        Await Windows.Storage.AccessCache.StorageApplicationPermissions.MostRecentlyUsedList.GetFileAsync(mruToken)

                    If (file IsNot Nothing) Then
                        ' Open a stream for the selected file.
                        Dim fileStream = Await file.OpenAsync(Windows.Storage.FileAccessMode.Read)

                        ' Set the image source to a bitmap.
                        Dim BitmapImage = New Windows.UI.Xaml.Media.Imaging.BitmapImage()

                        BitmapImage.SetSource(fileStream)
                        displayImage.Source = BitmapImage

                        ' Set the data context for the page.
                        Me.DataContext = file
                    End If
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Preserves state associated with this page in case the application is suspended or the
    ''' page is discarded from the navigation cache.  Values must conform to the serialization
    ''' requirements of <see cref="Common.SuspensionManager.SessionState"/>.
    ''' </summary>
    ''' <param name="sender">
    ''' The source of the event; typically <see cref="NavigationHelper"/>
    ''' </param>
    ''' <param name="e">Event data that provides a dictionary of state preserved by this page 
    ''' during an earlier session.  The state will be null the first time a page is visited.</param>
    Private Sub NavigationHelper_SaveState(sender As Object, e As Common.SaveStateEventArgs)
        If Not String.IsNullOrEmpty(mruToken) Then
            e.PageState("mruToken") = mruToken
        End If
    End Sub

#Region "NavigationHelper registration"

    ''' The methods provided in this section are simply used to allow
    ''' NavigationHelper to respond to the page's navigation methods.
    ''' 
    ''' Page specific logic should be placed in event handlers for the  
    ''' <see cref="Common.NavigationHelper.LoadState"/>
    ''' and <see cref="Common.NavigationHelper.SaveState"/>.
    ''' The navigation parameter is available in the LoadState method 
    ''' in addition to page state preserved during an earlier session.

    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        _navigationHelper.OnNavigatedTo(e)
    End Sub

    Protected Overrides Sub OnNavigatedFrom(e As NavigationEventArgs)
        _navigationHelper.OnNavigatedFrom(e)
    End Sub

#End Region

    Private Sub PhotoPage_SizeChanged(sender As Object, e As SizeChangedEventArgs) Handles pageRoot.SizeChanged
        If e.NewSize.Height / e.NewSize.Width >= 1 Then
            VisualStateManager.GoToState(Me, "PortraitLayout", True)
        Else
            VisualStateManager.GoToState(Me, "DefaultLayout", True)
        End If
    End Sub

    Private Async Sub GetPhotoButton_Click(sender As Object, e As RoutedEventArgs)

        Dim openPicker = New Windows.Storage.Pickers.FileOpenPicker()
        openPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary
        openPicker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail

        ' Filter to include a sample subset of file types.
        openPicker.FileTypeFilter.Clear()
        openPicker.FileTypeFilter.Add(".bmp")
        openPicker.FileTypeFilter.Add(".png")
        openPicker.FileTypeFilter.Add(".jpeg")
        openPicker.FileTypeFilter.Add(".jpg")

        ' Open the file picker.
        Dim file = Await openPicker.PickSingleFileAsync()

        ' file is null if user cancels the file picker.
        If file IsNot Nothing Then

            ' Open a stream for the selected file.
            Dim fileStream = Await file.OpenAsync(Windows.Storage.FileAccessMode.Read)

            ' Set the image source to the selected bitmap.
            Dim BitmapImage = New Windows.UI.Xaml.Media.Imaging.BitmapImage()

            BitmapImage.SetSource(fileStream)
            displayImage.Source = BitmapImage
            Me.DataContext = file

            ' Add picked file to MostRecentlyUsedList.
            mruToken = Windows.Storage.AccessCache.StorageApplicationPermissions.MostRecentlyUsedList.Add(file)
        End If
    End Sub
End Class
