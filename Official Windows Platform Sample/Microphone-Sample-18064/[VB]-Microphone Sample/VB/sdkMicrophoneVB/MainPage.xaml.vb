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
Imports System
Imports System.IO
Imports System.Threading
Imports System.Windows.Media.Imaging
Imports System.Windows.Threading
Imports Microsoft.Phone.Controls
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Audio

    Partial Public Class MainPage
        Inherits PhoneApplicationPage
        Private microphone As Microphone = Microphone.Default ' Object representing the physical microphone on the device
        Private buffer() As Byte ' Dynamic buffer to retrieve audio data from the microphone
        Private stream As New MemoryStream() ' Stores the audio data for later playback
        Private soundInstance As SoundEffectInstance ' Used to play back audio
        Private soundIsPlaying As Boolean = False ' Flag to monitor the state of sound playback

        ' Status images
        Private blankImage As BitmapImage
        Private microphoneImage As BitmapImage
        Private speakerImage As BitmapImage

        ''' <summary>
        ''' Constructor 
        ''' </summary>
        Public Sub New()
            InitializeComponent()

            ' Timer to simulate the XNA Framework game loop (Microphone is 
            ' from the XNA Framework). We also use this timer to monitor the 
            ' state of audio playback so we can update the UI appropriately.
            Dim dt As New DispatcherTimer()
            dt.Interval = TimeSpan.FromMilliseconds(33)
            AddHandler dt.Tick, AddressOf dt_Tick
            dt.Start()

            ' Event handler for getting audio data when the buffer is full
            AddHandler microphone.BufferReady, AddressOf microphone_BufferReady

            blankImage = New BitmapImage(New Uri("Images/blank.png", UriKind.RelativeOrAbsolute))
            microphoneImage = New BitmapImage(New Uri("Images/microphone.png", UriKind.RelativeOrAbsolute))
            speakerImage = New BitmapImage(New Uri("Images/speaker.png", UriKind.RelativeOrAbsolute))
        End Sub

        ''' <summary>
        ''' Updates the XNA FrameworkDispatcher and checks to see if a sound is playing.
        ''' If sound has stopped playing, it updates the UI.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub dt_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Try
                FrameworkDispatcher.Update()
            Catch
            End Try

            If True = soundIsPlaying Then
                If soundInstance.State <> SoundState.Playing Then
                    ' Audio has finished playing
                    soundIsPlaying = False

                    ' Update the UI to reflect that the 
                    ' sound has stopped playing
                    SetButtonStates(True, True, False)
                    UserHelp.Text = "press play" & vbLf & "or record"
                    StatusImage.Source = blankImage
                End If
            End If
        End Sub

        ''' <summary>
        ''' The Microphone.BufferReady event handler.
        ''' Gets the audio data from the microphone and stores it in a buffer,
        ''' then writes that buffer to a stream for later playback.
        ''' Any action in this event handler should be quick!
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub microphone_BufferReady(ByVal sender As Object, ByVal e As EventArgs)
            ' Retrieve audio data
            microphone.GetData(buffer)

            ' Store the audio data in a stream
            stream.Write(buffer, 0, buffer.Length)
        End Sub

        ''' <summary>
        ''' Handles the Click event for the record button.
        ''' Sets up the microphone and data buffers to collect audio data,
        ''' then starts the microphone. Also, updates the UI.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub recordButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Get audio data in 1/2 second chunks
            microphone.BufferDuration = TimeSpan.FromMilliseconds(500)

            ' Allocate memory to hold the audio data
            buffer = New Byte(microphone.GetSampleSizeInBytes(microphone.BufferDuration) - 1) {}

            ' Set the stream back to zero in case there is already something in it
            stream.SetLength(0)

            ' Start recording
            microphone.Start()

            SetButtonStates(False, False, True)
            UserHelp.Text = "record"
            StatusImage.Source = microphoneImage
        End Sub

        ''' <summary>
        ''' Handles the Click event for the stop button.
        ''' Stops the microphone from collecting audio and updates the UI.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub stopButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If microphone.State = MicrophoneState.Started Then
                ' In RECORD mode, user clicked the 
                ' stop button to end recording
                microphone.Stop()
            ElseIf soundInstance.State = SoundState.Playing Then
                ' In PLAY mode, user clicked the 
                ' stop button to end playing back
                soundInstance.Stop()
            End If

            SetButtonStates(True, True, False)
            UserHelp.Text = "ready"
            StatusImage.Source = blankImage
        End Sub

        ''' <summary>
        ''' Handles the Click event for the play button.
        ''' Plays the audio collected from the microphone and updates the UI.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub playButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If stream.Length > 0 Then
                ' Update the UI to reflect that
                ' sound is playing
                SetButtonStates(False, False, True)
                UserHelp.Text = "play"
                StatusImage.Source = speakerImage

                ' Play the audio in a new thread so the UI can update.
                Dim soundThread As New Thread(New ThreadStart(AddressOf playSound))
                soundThread.Start()
            End If
        End Sub

        ''' <summary>
        ''' Plays the audio using SoundEffectInstance 
        ''' so we can monitor the playback status.
        ''' </summary>
        Private Sub playSound()
            ' Play audio using SoundEffectInstance so we can monitor it's State 
            ' and update the UI in the dt_Tick handler when it is done playing.
            Dim sound As New SoundEffect(stream.ToArray(), microphone.SampleRate, AudioChannels.Mono)
            soundInstance = sound.CreateInstance()
            soundIsPlaying = True
            soundInstance.Play()
        End Sub

        ''' <summary>
        ''' Helper method to change the IsEnabled property for the ApplicationBarIconButtons.
        ''' </summary>
        ''' <param name="recordEnabled">New state for the record button.</param>
        ''' <param name="playEnabled">New state for the play button.</param>
        ''' <param name="stopEnabled">New state for the stop button.</param>
        Private Sub SetButtonStates(ByVal recordEnabled As Boolean, ByVal playEnabled As Boolean, ByVal stopEnabled As Boolean)
            TryCast(ApplicationBar.Buttons(0), ApplicationBarIconButton).IsEnabled = recordEnabled
            TryCast(ApplicationBar.Buttons(1), ApplicationBarIconButton).IsEnabled = playEnabled
            TryCast(ApplicationBar.Buttons(2), ApplicationBarIconButton).IsEnabled = stopEnabled
        End Sub
    End Class
