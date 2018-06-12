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
Imports Microsoft.Phone.BackgroundAudio

' Use a sine wave generator as 
' a Media Stream Source (MSS)
Imports StreamingAudioMediaSource

''' <summary>
''' A background agent that performs per-track streaming for playback
''' </summary>
Public Class AudioTrackStreamer
    Inherits AudioStreamingAgent
    ''' <summary>
    ''' Called when a new track requires audio decoding
    ''' (typically because it is about to start playing)
    ''' </summary>
    ''' <param name="track">
    ''' The track that needs audio streaming
    ''' </param>
    ''' <param name="streamer">
    ''' The AudioStreamer object to which a MediaStreamSource should be
    ''' attached to commence playback
    ''' </param>
    ''' <remarks>
    ''' To invoke this method for a track set the Source parameter of the AudioTrack to null
    ''' before setting  into the Track property of the BackgroundAudioPlayer instance
    ''' property set to true;
    ''' otherwise it is assumed that the system will perform all streaming
    ''' and decoding
    ''' </remarks>
    Protected Overrides Sub OnBeginStreaming(ByVal track As AudioTrack, ByVal streamer As AudioStreamer)
        ' Set the source of streamer to a media stream source
        Dim freq As Double = Convert.ToDouble(track.Tag)

        ' Use sine wave audio generator to simulate a streaming audio feed
        Dim mss As New SineMediaStreamSource(freq, 1.0, TimeSpan.FromSeconds(5))

        ' Event handler for when a track is complete or the user switches tracks
        AddHandler mss.StreamComplete, AddressOf mss_StreamComplete

        ' Set the source
        streamer.SetSource(mss)
    End Sub


    ''' <summary>
    ''' Called when a track ends or the user switches tracks.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mss_StreamComplete(ByVal sender As Object, ByVal e As EventArgs)
        NotifyComplete()
    End Sub


    ''' <summary>
    ''' Called when the agent request is getting cancelled
    ''' The call to base.OnCancel() is necessary to release the background streaming resources
    ''' </summary>
    Protected Overrides Sub OnCancel()
        MyBase.OnCancel()
    End Sub
End Class
