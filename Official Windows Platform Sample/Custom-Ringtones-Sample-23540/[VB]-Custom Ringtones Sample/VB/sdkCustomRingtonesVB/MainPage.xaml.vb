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
Imports Microsoft.Phone.Tasks
Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Windows.Resources
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Media

    Partial Public Class MainPage
        Inherits PhoneApplicationPage
        ' Declare the SaveRingtoneTask object with page scope.
        Private saveRingtoneChooser As SaveRingtoneTask

        ' Path where ringtone files are stored
        Private filepath As String = "Ringtones/"

        ' Used to simulate the XNA Framework Game loop.
        Private timer As GameTimer

        ' Flag that indicates if we need to resume 
        ' Zune playback after previewing a ringtone.
        Private resumeMediaPlayerAfterDone As Boolean = False


        ' Constructor
        Public Sub New()
            ' Create a GameTimer to pump the XNA Framework.
            timer = New GameTimer()
            timer.UpdateInterval = TimeSpan.FromTicks(333333)
            AddHandler timer.Update, AddressOf timer_Update

            ' Start the timer, which calls FrameworkDispatcher.Update regularly
            timer.Start()

            ' Initialize the SaveRingtoneTask and assign the Completed handler.
            saveRingtoneChooser = New SaveRingtoneTask()
            AddHandler saveRingtoneChooser.Completed, AddressOf saveRingtoneChooser_Completed

            InitializeComponent()
        End Sub


#Region "Event Handlers"

        ''' <summary>
        ''' Pumps the XNA Framework internals.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub timer_Update(ByVal sender As Object, ByVal e As GameTimerEventArgs)
            FrameworkDispatcher.Update()
        End Sub


        ''' <summary>
        ''' Handles the preview button Click event.
        ''' Toggles between Preview and Pause states.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub previewToggleButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' If we're already playing a ringtone, stop playback
            If MediaElementState.Playing = ringtonePlayer.CurrentState Then
                ' Stop playback
                ringtonePlayer.Stop()
                Return
            End If

            Dim ringtonePath As String = GetRingtonePath()

            If Nothing IsNot ringtonePath Then
                ' If Zune is playing music, pause 
                ' it while we play the ringtone.
                ZunePause()

                ringtonePlayer.Source = New Uri(ringtonePath, UriKind.Relative)
                ringtonePlayer.Play()
            End If
        End Sub


        ''' <summary>
        ''' Updates the UI and resumes Zune playback, if necessary.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub media_CurrentStateChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If MediaElementState.Playing = ringtonePlayer.CurrentState Then
                ' The ringtone is playing, display the Stop button.
                TryCast(ApplicationBar.Buttons(0), ApplicationBarIconButton).IconUri = New Uri("Images/stop.png", UriKind.Relative)
                TryCast(ApplicationBar.Buttons(0), ApplicationBarIconButton).Text = "stop"
            Else
                ' The ringtone is not playing, display the Play button.
                TryCast(ApplicationBar.Buttons(0), ApplicationBarIconButton).IconUri = New Uri("Images/play.png", UriKind.Relative)
                TryCast(ApplicationBar.Buttons(0), ApplicationBarIconButton).Text = "preview"

                ' If Zune was playing music before we 
                ' played a ringtone, resume playback.
                ZuneResume()
            End If
        End Sub


        ''' <summary>
        ''' In this example, the SaveRingtoneTask is shown in response to a button click. 
        ''' The ringtone file name and display name are obtained from a ListBox control.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub addButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim ringtonePath As String = GetRingtonePath()

            If Nothing IsNot ringtonePath Then
                ' Download the ringtone to local isolated storage
                DownloadToIsoStore(ringtonePath)

                ' Set up parameters for the SaveRingtoneTask
                ' For more on the "isostore:/" path syntax, see the Silverlight Uri class documentation.
                saveRingtoneChooser.Source = New Uri("isostore:/" & ringtonePath)
                saveRingtoneChooser.DisplayName = CStr((CType(ringtonesListBox.SelectedItem, ListBoxItem)).Content)
                saveRingtoneChooser.IsShareable = True

                ' If we're playing a ringtone, stop playback
                If MediaElementState.Playing = ringtonePlayer.CurrentState Then
                    ' Stop playback
                    ringtonePlayer.Stop()
                End If

                ' Launch the SaveRingtoneTask chooser
                saveRingtoneChooser.Show()
            End If
        End Sub


        ''' <summary>
        ''' The Completed event handler. No data is returned from this Chooser, but 
        ''' the TaskResult field indicates if the task was completed or cancelled.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub saveRingtoneChooser_Completed(ByVal sender As Object, ByVal e As TaskEventArgs)
            If e.TaskResult = TaskResult.OK Then
                statusTextBlock.Text = "Save completed."
            ElseIf e.TaskResult = TaskResult.Cancel Then
                statusTextBlock.Text = "Save cancelled."
            End If

            ' Delete the downloaded ringtone file.
            DeleteFromIsoStore((CType(sender, SaveRingtoneTask)).Source.AbsolutePath)
        End Sub


        ''' <summary>
        ''' Stops playing the previous ringtone when the user changes the selection in the ListBox.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub ringtonesListBox_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            If (Nothing IsNot ringtonePlayer) AndAlso (MediaElementState.Playing = ringtonePlayer.CurrentState) Then
                ringtonePlayer.Stop()
            End If
        End Sub

#End Region ' Event Handlers


#Region "Ringtone File Handling"

        ''' <summary>
        ''' Constructs the path to the media file based on the 
        ''' Name property of the currently selected ListBoxItem.
        ''' </summary>
        ''' <returns></returns>
        Private Function GetRingtonePath() As String
            Dim strMsg As String = String.Empty
            Dim ringtonePath As String = Nothing

            ' A ListBox contains the available ringtones
            Dim selection As ListBoxItem = CType(ringtonesListBox.SelectedItem, ListBoxItem)

            If Nothing IsNot selection Then
                ' The filename is stored in the Name property
                ' of each ListBoxItem, minus the file extension
                Dim filename As String = selection.Name & ".wma"

                ringtonePath = filepath & filename
            Else
                strMsg = "Nothing selected"
            End If

            statusTextBlock.Text = strMsg
            Return ringtonePath
        End Function


        ''' <summary>
        ''' Simulates downloading a ringtone file to application isolated 
        ''' storage by just copying it from application data storage.
        ''' </summary>
        ''' <param name="fileName"></param>
        Private Sub DownloadToIsoStore(ByVal fileName As String)
            Dim isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()

            ' If the file already exists, no need to "download", just return
            If isoStore.FileExists(fileName) Then
                Return
            End If

            Dim sr As StreamResourceInfo = Application.GetResourceStream(New Uri(fileName, UriKind.Relative))

            Using br As New BinaryReader(sr.Stream)
                ' Simulate "downloading" the ringtone file
                Dim data() As Byte = br.ReadBytes(CInt(Fix(sr.Stream.Length)))

                ' Save to local isolated storage
                SaveToIsoStore(fileName, data)
            End Using

        End Sub


        ''' <summary>
        ''' Create a file in the application's isolated storage.
        ''' </summary>
        ''' <param name="fileName"></param>
        ''' <param name="data"></param>
        Private Sub SaveToIsoStore(ByVal fileName As String, ByVal data() As Byte)
            Dim strBaseDir As String = String.Empty
            Dim delimStr As String = "/"
            Dim delimiter() As Char = delimStr.ToCharArray()
            Dim dirsPath() As String = fileName.Split(delimiter)

            ' Get the IsoStore
            Dim isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()

            ' We want to re-create the directory structure but not the file
        For i = 0 To dirsPath.Length - 2
            strBaseDir = System.IO.Path.Combine(strBaseDir, dirsPath(i))

            If Not isoStore.DirectoryExists(strBaseDir) Then
                isoStore.CreateDirectory(strBaseDir)
            End If
        Next i

            ' Clean out existing file.
            DeleteFromIsoStore(fileName)

            ' Write the file 
            Using bw As New BinaryWriter(isoStore.CreateFile(fileName))
                bw.Write(data)
                bw.Close()
            End Using
        End Sub


        ''' <summary>
        ''' Deletes a file from isolated storage.
        ''' </summary>
        ''' <param name="fileName"></param>
        Private Sub DeleteFromIsoStore(ByVal fileName As String)
            ' Get the IsoStore
            Dim isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()

            ' Clean out existing file.
            If isoStore.FileExists(fileName) Then
                isoStore.DeleteFile(fileName)
            End If
        End Sub

#End Region ' Ringtone File Handling


#Region "Zune Pause/Resume"

        Private Sub ZunePause()
            ' Please see the MainPage() constructor above where the GameTimer object is created.
            ' This enables the use of the XNA framework MediaPlayer class by pumping the XNA FrameworkDispatcher.

            ' Pause the Zune player if it is already playing music.
            If Not MediaPlayer.GameHasControl Then
                MediaPlayer.Pause()
                resumeMediaPlayerAfterDone = True
            End If
        End Sub

        Private Sub ZuneResume()
            ' If Zune was playing music, resume playback
            If resumeMediaPlayerAfterDone Then
                MediaPlayer.Resume()
            End If
        End Sub

#End Region ' Zune Pause/Resume
    End Class
