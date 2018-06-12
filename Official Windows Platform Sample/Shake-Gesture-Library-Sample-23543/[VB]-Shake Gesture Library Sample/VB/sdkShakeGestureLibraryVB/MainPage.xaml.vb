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
Imports ShakeGestures
Imports System.IO

Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        AddHandler ShakeGesturesHelper.Instance.ShakeGesture, AddressOf Instance_ShakeGesture
        ShakeGesturesHelper.Instance.MinimumRequiredMovesForShake = 4
        ShakeGesturesHelper.Instance.Active = True

        InitializeComponent()
    End Sub

    ' Set the data context of the TextBlock to the answer.
    Private Sub Instance_ShakeGesture(ByVal sender As Object, ByVal e As ShakeGestureEventArgs)
        ' Use BeginInvoke to write to the UI thread.
        textBlock1.Dispatcher.BeginInvoke(Sub() textBlock1.DataContext = GetAnswer())
    End Sub

    ' Generate a random number and retrieve this item from the anser
    ' list.
    Private Function GetAnswer() As String
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(Answers.Count)
        Return Answers(randomNumber)
    End Function

    ' List of answers.
    Private answersValue As List(Of String)
    Public ReadOnly Property Answers() As List(Of String)
        Get
            If answersValue Is Nothing Then
                LoadAnswers()
            End If

            Return answersValue
        End Get
    End Property

    ' Load the answers from the text file.
    Private Sub LoadAnswers()
        answersValue = New List(Of String)()

        Using reader As New StreamReader(Application.GetResourceStream(New Uri("answers.txt", UriKind.Relative)).Stream)
            Dim line As String
            line = reader.ReadLine()
            Do While line IsNot Nothing
                answersValue.Add(line)
                line = reader.ReadLine()
            Loop
        End Using
    End Sub
End Class
