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
Imports System.IO

''' <summary>
''' A Media Stream Source implemented to play WAVE files
''' </summary>
Public Class SineMediaStreamSource
    Inherits MediaStreamSource
    Private _audioDesc As MediaStreamDescription
    Private _currentPosition As Long
    Private _startPosition As Long
    Private _currentTimeStamp As Long
    Private _frequency As Double
    Private _amplitude As Double
    Private _duration As Long
    Private _waveFormat As WAVEFORMATEX
    Private Const convertToSeconds As Double = 10000000.0

    Private _emptySampleDict As New Dictionary(Of MediaSampleAttributeKeys, String)()

    Public Event StreamComplete As EventHandler

    Public Sub New(ByVal frequency As Double, ByVal amplitude As Double, ByVal duration As TimeSpan)
        _frequency = frequency
        _amplitude = amplitude
        _duration = CLng(Fix(duration.TotalSeconds * convertToSeconds))
    End Sub

    Public Sub New(ByVal amplitude As Double, ByVal duration As TimeSpan)
        Dim twoRoot12 As Double = Math.Pow(2, (1.0 / 12.0))
        Dim noteChooser As New Random()
        Dim note As Integer = noteChooser.Next(13)
        Dim frequency As Double = 440.0 * Math.Pow(twoRoot12, note)

        _frequency = frequency
        _amplitude = amplitude
        _duration = CLng(Fix(duration.TotalSeconds * convertToSeconds))
    End Sub

    Protected Overrides Sub OpenMediaAsync()
        ' Create a parser
        Dim streamAttributes As New Dictionary(Of MediaStreamAttributeKeys, String)()
        Dim sourceAttributes As New Dictionary(Of MediaSourceAttributesKeys, String)()
        Dim availableStreams As New List(Of MediaStreamDescription)()

        ' Stream Description 
        _waveFormat = New WAVEFORMATEX()
        _waveFormat.BitsPerSample = 8
        _waveFormat.Channels = 1
        _waveFormat.FormatTag = 1 ' Format.PCM
        _waveFormat.SamplesPerSec = 22050
        _waveFormat.Size = 0
        _waveFormat.BlockAlign = CShort(Fix(_waveFormat.Channels * _waveFormat.BitsPerSample / 8))
        _waveFormat.AvgBytesPerSec = _waveFormat.SamplesPerSec * _waveFormat.Channels * _waveFormat.BitsPerSample / 8

        streamAttributes(MediaStreamAttributeKeys.CodecPrivateData) = _waveFormat.ToHexString() ' wfx
        Dim msd As New MediaStreamDescription(MediaStreamType.Audio, streamAttributes)

        _audioDesc = msd
        availableStreams.Add(_audioDesc)

        sourceAttributes(MediaSourceAttributesKeys.Duration) = _duration.ToString()
        ReportOpenMediaCompleted(sourceAttributes, availableStreams)
    End Sub

    Protected Sub CallStreamComplete()
        ' This may throw a null reference exception - that indicates that the agent did not correctly
        ' subscribe to StreamComplete so it could call NotifyComplete
        If Nothing IsNot StreamCompleteEvent Then
            RaiseEvent StreamComplete(Me, New EventArgs())
        End If
    End Sub

    Protected Overrides Sub CloseMedia()
        ' Close the stream
        _currentPosition = 0
        _startPosition = _currentPosition
        _audioDesc = Nothing
        CallStreamComplete()
    End Sub

    Protected Overrides Sub GetDiagnosticAsync(ByVal diagnosticKind As MediaStreamSourceDiagnosticKind)
        Throw New NotImplementedException()
    End Sub

    Private Function AlignUp(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim tmp As Integer = a + b - 1
        Return tmp - (tmp Mod b)
    End Function

    Private Sub FillBuffer(ByVal buffer() As Byte, ByVal startTime As Long, ByVal endTime As Long)
        Dim startSecond As Double = startTime / convertToSeconds
        Dim sampleLength As Long = _waveFormat.AudioDurationFromBufferSize(CUInt(_waveFormat.BlockAlign))
        Dim sampleTime As Double = sampleLength / convertToSeconds
        Dim currentSecond As Double = startSecond
        Dim endSecond As Double = endTime / convertToSeconds
        For i As Integer = 0 To buffer.Length - 1 Step _waveFormat.BlockAlign
            Dim sample As Double
            Dim timeFromEnd As Double = endSecond - currentSecond
            If (1.5 > timeFromEnd AndAlso timeFromEnd > 1.25) OrElse (1.0 > timeFromEnd AndAlso timeFromEnd > 0.75) OrElse (0.5 > timeFromEnd AndAlso timeFromEnd > 0.25) Then
                sample = 0
            Else
                sample = (_amplitude * Math.Sin(2 * Math.PI * _frequency * currentSecond))
            End If
            Dim sampleValue As Short = CShort(Fix(sample * 128 + 128))
            buffer(i) = CByte(sampleValue)
            If _waveFormat.Channels = 2 Then
                buffer(i + 1) = CByte(sampleValue)
            End If

            currentSecond += sampleTime
        Next i
    End Sub

    Protected Overrides Sub GetSampleAsync(ByVal mediaStreamType As MediaStreamType)
        ' Start with one second of data, rounded up to the nearest block.
        Dim cbBuffer As UInteger = CUInt(AlignUp(_waveFormat.AvgBytesPerSec / 100, _waveFormat.BlockAlign))

        If _currentTimeStamp < _duration Then
            Dim buffer(cbBuffer - 1) As Byte
            FillBuffer(buffer, _currentTimeStamp, _duration)
            ' Send out the next sample
            Using stream = New MemoryStream(buffer)
                Dim msSamp As New MediaStreamSample(_audioDesc, stream, 0, cbBuffer, _currentTimeStamp, _emptySampleDict)

                ' Move our timestamp and position forward
                _currentTimeStamp += _waveFormat.AudioDurationFromBufferSize(cbBuffer)

                ReportGetSampleCompleted(msSamp)
            End Using
        Else ' Report EOS
            ReportGetSampleCompleted(New MediaStreamSample(_audioDesc, Nothing, 0, 0, 0, _emptySampleDict))
        End If
    End Sub

    Protected Overrides Sub SeekAsync(ByVal seekToTime As Long)
        _currentPosition = _waveFormat.BufferSizeFromAudioDuration(seekToTime)
        _currentTimeStamp = seekToTime
        ReportSeekCompleted(seekToTime)
    End Sub

    Protected Overrides Sub SwitchMediaStreamAsync(ByVal mediaStreamDescription As MediaStreamDescription)
        Throw New NotImplementedException()
    End Sub
End Class
