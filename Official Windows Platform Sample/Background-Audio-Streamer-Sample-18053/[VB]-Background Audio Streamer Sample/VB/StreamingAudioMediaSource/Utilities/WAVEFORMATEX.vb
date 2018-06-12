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
Public Class WAVEFORMATEX
#Region "Data"
    Public Property FormatTag() As Short
    Public Property Channels() As Short
    Public Property SamplesPerSec() As Integer
    Public Property AvgBytesPerSec() As Integer
    Public Property BlockAlign() As Short
    Public Property BitsPerSample() As Short
    Public Property Size() As Short
    Public Const SizeOf As UInteger = 18
    Public Property ext() As Byte()
#End Region ' Data

    ''' <summary>
    ''' Convert the data to a hex string
    ''' </summary>
    ''' <returns></returns>
    Public Function ToHexString() As String
        Dim s As String = ""

        s &= ToLittleEndianString(String.Format("{0:X4}", FormatTag))
        s &= ToLittleEndianString(String.Format("{0:X4}", Channels))
        s &= ToLittleEndianString(String.Format("{0:X8}", SamplesPerSec))
        s &= ToLittleEndianString(String.Format("{0:X8}", AvgBytesPerSec))
        s &= ToLittleEndianString(String.Format("{0:X4}", BlockAlign))
        s &= ToLittleEndianString(String.Format("{0:X4}", BitsPerSample))
        s &= ToLittleEndianString(String.Format("{0:X4}", Size))

        Return s
    End Function

    ''' <summary>
    ''' Set the data from a byte array (usually read from a file)
    ''' </summary>
    ''' <param name="byteArray"></param>
    Public Sub SetFromByteArray(ByVal byteArray() As Byte)
        If (byteArray.Length + 2) < SizeOf Then
            Throw New ArgumentException("Byte array is too small")
        End If

        FormatTag = BitConverter.ToInt16(byteArray, 0)
        Channels = BitConverter.ToInt16(byteArray, 2)
        SamplesPerSec = BitConverter.ToInt32(byteArray, 4)
        AvgBytesPerSec = BitConverter.ToInt32(byteArray, 8)
        BlockAlign = BitConverter.ToInt16(byteArray, 12)
        BitsPerSample = BitConverter.ToInt16(byteArray, 14)
        If byteArray.Length >= SizeOf Then
            Size = BitConverter.ToInt16(byteArray, 16)
        Else
            Size = 0
        End If

        If byteArray.Length > WAVEFORMATEX.SizeOf Then
            ext = New Byte(byteArray.Length - WAVEFORMATEX.SizeOf - 1) {}
            Array.Copy(byteArray, CInt(Fix(WAVEFORMATEX.SizeOf)), ext, 0, ext.Length)
        Else
            ext = Nothing
        End If
    End Sub

    ''' <summary>
    ''' Convert a BigEndian string to a LittleEndian string
    ''' </summary>
    ''' <param name="bigEndianString"></param>
    ''' <returns></returns>
    Public Shared Function ToLittleEndianString(ByVal bigEndianString As String) As String
        If bigEndianString Is Nothing Then
            Return ""
        End If

        Dim bigEndianChars() As Char = bigEndianString.ToCharArray()

        ' Guard
        If bigEndianChars.Length Mod 2 <> 0 Then
            Return ""
        End If

        Dim i, ai, bi, ci, di As Integer
        Dim a, b, c, d As Char
        For i = 0 To bigEndianChars.Length \ 2 - 1 Step 2
            ' front byte
            ai = i
            bi = i + 1

            ' back byte
            ci = bigEndianChars.Length - 2 - i
            di = bigEndianChars.Length - 1 - i

            a = bigEndianChars(ai)
            b = bigEndianChars(bi)
            c = bigEndianChars(ci)
            d = bigEndianChars(di)

            bigEndianChars(ci) = a
            bigEndianChars(di) = b
            bigEndianChars(ai) = c
            bigEndianChars(bi) = d
        Next i

        Return New String(bigEndianChars)
    End Function

    ''' <summary>
    ''' Ouput the data into a string.
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Dim rawData(17) As Char
        BitConverter.GetBytes(FormatTag).CopyTo(rawData, 0)
        BitConverter.GetBytes(Channels).CopyTo(rawData, 2)
        BitConverter.GetBytes(SamplesPerSec).CopyTo(rawData, 4)
        BitConverter.GetBytes(AvgBytesPerSec).CopyTo(rawData, 8)
        BitConverter.GetBytes(BlockAlign).CopyTo(rawData, 12)
        BitConverter.GetBytes(BitsPerSample).CopyTo(rawData, 14)
        BitConverter.GetBytes(Size).CopyTo(rawData, 16)
        Return New String(rawData)
    End Function

    ''' <summary>
    ''' Calculate the duration of audio based on the size of the peekAheadBuffer
    ''' </summary>
    ''' <param name="cbAudioDataSize"></param>
    ''' <returns></returns>
    Public Function AudioDurationFromBufferSize(ByVal cbAudioDataSize As UInt32) As Int64
        If AvgBytesPerSec = 0 Then
            Return 0
        End If

        Return CLng(Fix(cbAudioDataSize)) * 10000000 \ AvgBytesPerSec
    End Function

    ''' <summary>
    ''' Calculate the peekAheadBuffer size necessary for a duration of audio
    ''' </summary>
    ''' <param name="duration"></param>
    ''' <returns></returns>
    Public Function BufferSizeFromAudioDuration(ByVal duration As Int64) As Int64
        Dim size As Int64 = duration * AvgBytesPerSec \ 10000000
        Dim remainder As UInt32 = CUInt(size Mod BlockAlign)
        If remainder <> 0 Then
            size += BlockAlign - remainder
        End If

        Return size
    End Function

    ''' <summary>
    ''' Validate that the Wave format is consistent.
    ''' </summary>
    Public Sub ValidateWaveFormat()
        If FormatTag <> FormatPCM Then
            Throw New ArgumentException("Only PCM format is supported")
        End If

        If Channels <> 1 AndAlso Channels <> 2 Then
            Throw New ArgumentException("Only 1 or 2 channels are supported")
        End If

        If BitsPerSample <> 8 AndAlso BitsPerSample <> 16 Then
            Throw New ArgumentException("Only 8 or 16 bit samples are supported")
        End If

        If Size <> 0 Then
            Throw New ArgumentException("Size must be 0")
        End If

        If BlockAlign <> Channels * (BitsPerSample \ 8) Then
            Throw New ArgumentException("Block Alignment is incorrect")
        End If

        If SamplesPerSec > (UInt32.MaxValue / BlockAlign) Then
            Throw New ArgumentException("SamplesPerSec overflows")
        End If

        If AvgBytesPerSec <> SamplesPerSec * BlockAlign Then
            Throw New ArgumentException("AvgBytesPerSec is wrong")
        End If
    End Sub

    Private Const FormatPCM As Int16 = 1
    Private Const FormatIEEE As Int16 = 3
End Class
