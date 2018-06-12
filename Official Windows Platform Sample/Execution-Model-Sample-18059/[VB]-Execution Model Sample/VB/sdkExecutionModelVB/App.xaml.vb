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
Imports System.Threading
Imports System.IO
Imports System.IO.IsolatedStorage

    Partial Public Class App
        Inherits Application
#Region "ApplicationDataObject"

        ' Declare a private variable to store application state.
        Private _applicationDataObject As String

        ' Declare an event for when the application data changes.
        Public Event ApplicationDataObjectChanged As EventHandler

        ' Declare a public property to access the application data variable.
        Public Property ApplicationDataObject() As String
            Get
                Return _applicationDataObject
            End Get
            Set(ByVal value As String)
                If value <> _applicationDataObject Then
                    _applicationDataObject = value
                    OnApplicationDataObjectChanged(EventArgs.Empty)
                End If
            End Set
        End Property

        ' Create a method to raise the ApplicationDataObjectChanged event.
        Protected Sub OnApplicationDataObjectChanged(ByVal e As EventArgs)
        Dim handler As EventHandler = ApplicationDataObjectChangedEvent
            If handler IsNot Nothing Then
                handler(Me, e)
            End If
        End Sub

        ' Declare a public property to store the status of the application data.
        Public Property ApplicationDataStatus() As String

#End Region


        ''' <summary>
        ''' Provides easy access to the root frame of the Phone Application.
        ''' </summary>
    ''' <remarks>The root frame of the Phone Application.</remarks>
    Private _RootFrame As PhoneApplicationFrame
    Public Property RootFrame() As PhoneApplicationFrame
        Get
            Return _RootFrame
        End Get
        Private Set(ByVal value As PhoneApplicationFrame)
            _RootFrame = value
        End Set
    End Property

        ''' <summary>
        ''' Constructor for the Application object.
        ''' </summary>
        Public Sub New()
            ' Global handler for uncaught exceptions. 
            AddHandler UnhandledException, AddressOf Application_UnhandledException

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
                'Application.Current.Host.Settings.EnableCacheVisualization = true;

                ' Disable the application idle detection by setting the UserIdleDetectionMode property of the
                ' application's PhoneApplicationService object to Disabled.
                ' Caution:- Use this under debug mode only. Application that disables user idle detection will continue to run
                ' and consume battery power when the user is not using the phone.
                PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled
            End If

        End Sub

#Region "ExecutionModelEvents"

        ' Code to execute when the application is launching (eg, from Start)
        ' This code will not execute when the application is reactivated
        Private Sub Application_Launching(ByVal sender As Object, ByVal e As LaunchingEventArgs)
        End Sub

        ' Code to execute when the application is activated (brought to foreground)
        ' This code will not execute when the application is first launched
        Private Sub Application_Activated(ByVal sender As Object, ByVal e As ActivatedEventArgs)
            If e.IsApplicationInstancePreserved Then
                ApplicationDataStatus = "application instance preserved."
                Return
            End If

            ' Check to see if the key for the application state data is in the State dictionary.
            If PhoneApplicationService.Current.State.ContainsKey("ApplicationDataObject") Then
                ' If it exists, assign the data to the application member variable.
                ApplicationDataStatus = "data from preserved state."
                ApplicationDataObject = TryCast(PhoneApplicationService.Current.State("ApplicationDataObject"), String)
            End If
        End Sub

        ' Code to execute when the application is deactivated (sent to background)
        ' This code will not execute when the application is closing
        Private Sub Application_Deactivated(ByVal sender As Object, ByVal e As DeactivatedEventArgs)
            ' If there is data in the application member variable...
            If Not String.IsNullOrEmpty(ApplicationDataObject) Then
                ' Store it in the State dictionary.
                PhoneApplicationService.Current.State("ApplicationDataObject") = ApplicationDataObject

                ' Also store it in Isolated Storage, in case the application is never reactivated.
                SaveDataToIsolatedStorage("myDataFile.txt", ApplicationDataObject)
            End If
        End Sub

        ' Code to execute when the application is closing (eg, user hit Back)
        ' This code will not execute when the application is deactivated
        Private Sub Application_Closing(ByVal sender As Object, ByVal e As ClosingEventArgs)
            ' The application will not be tombstoned, so only save to Isolated Storage
            If Not String.IsNullOrEmpty(ApplicationDataObject) Then
                SaveDataToIsolatedStorage("myDataFile.txt", ApplicationDataObject)
            End If
        End Sub

#End Region

#Region "GetAndSaveDataMethods"

        Public Sub GetDataAsync()
            ' Call the GetData method on a new thread.
            Dim t As New Thread(New ThreadStart(AddressOf GetData))
            t.Start()
        End Sub

        Private Sub GetData()
            ' Check the time elapsed since data was last saved to Isolated Storage
            Dim TimeSinceLastSave As TimeSpan = TimeSpan.FromSeconds(0)
            If IsolatedStorageSettings.ApplicationSettings.Contains("DataLastSavedTime") Then
                Dim dataLastSaveTime As Date = CDate(IsolatedStorageSettings.ApplicationSettings("DataLastSavedTime"))
                TimeSinceLastSave = Date.Now.Subtract(dataLastSaveTime)
            End If

            ' Check to see if data exists in Isolated Storage and see if the data is fresh.
            ' This example uses 30 seconds as the valid time window to make it easy to test. 
            ' Real apps will use a larger window.
            Dim isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
            If isoStore.FileExists("myDataFile.txt") AndAlso TimeSinceLastSave.TotalSeconds < 30 Then
                ' This method loads the data from Isolated Storage, if it is available.
                Dim sr As New StreamReader(isoStore.OpenFile("myDataFile.txt", FileMode.Open))
                Dim data As String = sr.ReadToEnd()
                sr.Close()

                ApplicationDataStatus = "data from isolated storage"
                ApplicationDataObject = data
            Else
                ' Otherwise it gets the data from the Web. 
                Dim request As HttpWebRequest = CType(WebRequest.Create(New Uri("http://windowsteamblog.com/windows_phone/b/windowsphone/rss.aspx")), HttpWebRequest)
                request.BeginGetResponse(AddressOf HandleWebResponse, request)
            End If
        End Sub

        Private Sub HandleWebResponse(ByVal result As IAsyncResult)
            ' Put this in a try block in case the Web request was unsuccessful.
            Try
                ' Get the request from the IAsyncResult
                Dim request As HttpWebRequest = CType(result.AsyncState, HttpWebRequest)

                ' Read the response stream from the response.
                Dim sr As New StreamReader(request.EndGetResponse(result).GetResponseStream())
                Dim data As String = sr.ReadToEnd()
                data = data.Substring(0, 255)

                ' Use the Dispatcher to call SetData on the UI thread, passing the retrieved data.
            'Dispatcher.BeginInvoke(Sub() SetData(data, "web"))
                ApplicationDataStatus = "data from web."
                ApplicationDataObject = data
            Catch
                ' If the data request fails, alert the user
                ApplicationDataStatus = "Unable to get data from Web."
                ApplicationDataObject = Nothing
            End Try
        End Sub

        Private Sub SaveDataToIsolatedStorage(ByVal isoFileName As String, ByVal value As String)
            Dim isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
            Dim sw As New StreamWriter(isoStore.OpenFile(isoFileName, FileMode.OpenOrCreate))
            sw.Write(value)
            sw.Close()
            IsolatedStorageSettings.ApplicationSettings("DataLastSaveTime") = Date.Now
        End Sub

#End Region

        ' Code to execute if a navigation fails
        Private Sub RootFrame_NavigationFailed(ByVal sender As Object, ByVal e As NavigationFailedEventArgs)
            If System.Diagnostics.Debugger.IsAttached Then
                ' A navigation has failed; break into the debugger
                System.Diagnostics.Debugger.Break()
            End If
        End Sub

        ' Code to execute on Unhandled Exceptions
        Private Sub Application_UnhandledException(ByVal sender As Object, ByVal e As ApplicationUnhandledExceptionEventArgs)
            If System.Diagnostics.Debugger.IsAttached Then
                ' An unhandled exception has occurred; break into the debugger
                System.Diagnostics.Debugger.Break()
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
