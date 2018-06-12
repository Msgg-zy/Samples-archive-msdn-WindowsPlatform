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
Imports Microsoft.Phone.Applications.Common
Imports System.Collections.Generic
Imports System.Threading

Namespace ShakeGestures
    Public Class ShakeGesturesHelper
#Region "Gesture parameters"

        ''' <summary>
        ''' Any vector that has a magnitude (after reducing gravitation) bigger than this parameter will be considered as a shake vector
        ''' </summary>
        Private Const ShakeMagnitudeWithoutGravitationThreshold_Default As Double = 0.2
        Public Property ShakeMagnitudeWithoutGravitationThreshold() As Double

        ''' <summary>
        ''' This parameter determines how many consecutive still vectors are required to stop a shake signal
        ''' </summary>
        Private Const StillCounterThreshold_Default As Integer = 20
        Public Property StillCounterThreshold() As Integer

        ''' <summary>
        ''' This parameter determines the maximum allowed magnitude (after reducing gravitation) for a still vector to be considered to the average
        ''' The last still vector is averaged out of still vectors that are under this bound
        ''' </summary>
        Private Const StillMagnitudeWithoutGravitationThreshold_Default As Double = 0.02
        Public Property StillMagnitudeWithoutGravitationThreshold() As Double

        ''' <summary>
        ''' The maximum amount of still vectors needed to create a still vector average
        ''' instead of averaging the entire still signal, we just look at the top recent still vectors
        ''' </summary>
        Private Const MaximumStillVectorsNeededForAverage_Default As Integer = 20
        Public Property MaximumStillVectorsNeededForAverage() As Integer

        ''' <summary>
        ''' The minimum amount of still vectors needed to create a still vector average.
        ''' Without enough vectors the average will not be stable and thus ignored
        ''' </summary>
        Private Const MinimumStillVectorsNeededForAverage_Default As Integer = 5
        Public Property MinimumStillVectorsNeededForAverage() As Integer

        ''' <summary>
        ''' Determines the amount of shake vectors needed that has been classified the same to recognize a shake
        ''' </summary>
        Private Const MinimumShakeVectorsNeededForShake_Default As Integer = 10
        Public Property MinimumShakeVectorsNeededForShake() As Integer

        ''' <summary>
        ''' Shake vectors with magnitude less than this parameter will not be considered for gesture classification
        ''' </summary>
        Private Const WeakMagnitudeWithoutGravitationThreshold_Default As Double = 0.2
        Public Property WeakMagnitudeWithoutGravitationThreshold() As Double

        ''' <summary>
        ''' Determines the number of moves required to get a shake signal
        ''' </summary>
        Private Const MinimumRequiredMovesForShake_Default As Integer = 3
        Public Property MinimumRequiredMovesForShake() As Integer

#End Region

#Region "Private fields"

        ' Singleton instance for helper


        Private Shared _singletonInstance As ShakeGesturesHelper

        ' private lock object for protecting the singleton instance
        Private Shared _syncRoot As New Object()

        ' last still vector - average of the last still signal
        ' used to eliminate the gravitation effect 
        ' initial value has no meaning, it's just a dummy vector to avoid dealing with null values
        Private _lastStillVector As New Simple3DVector(0, -1, 0)

        ' flag that indicates whether we are currently in a middle of a shake signal
        Private _isInShakeState As Boolean = False

        ' counts the number of still vectors - while in shake signal
        Private _stillCounter As Integer = 0

        ' holds shake signal vectors
        Private _shakeSignal As New List(Of Simple3DVector)()

        ' holds shake signal histogram
        Private _shakeHistogram(2) As Integer

        ' hold still signal vectors, newest vectors are first
        Private _stillSignal As New LinkedList(Of Simple3DVector)()

#End Region

#Region "Public events"

        ''' <summary>
        ''' Fires when a new shake gesture has been identified
        ''' </summary>
        Public Event ShakeGesture As EventHandler(Of ShakeGestureEventArgs)

#End Region

#Region "Constructor"

        ''' <summary>
        ''' Private constructor
        ''' Use Instance property to get singleton instance
        ''' </summary>
        Private Sub New()
            ' set default values for parameters
            ShakeMagnitudeWithoutGravitationThreshold = ShakeMagnitudeWithoutGravitationThreshold_Default
            StillCounterThreshold = StillCounterThreshold_Default
            StillMagnitudeWithoutGravitationThreshold = StillMagnitudeWithoutGravitationThreshold_Default
            MinimumStillVectorsNeededForAverage = MinimumStillVectorsNeededForAverage_Default
            MaximumStillVectorsNeededForAverage = MaximumStillVectorsNeededForAverage_Default
            MinimumShakeVectorsNeededForShake = MinimumShakeVectorsNeededForShake_Default
            WeakMagnitudeWithoutGravitationThreshold = WeakMagnitudeWithoutGravitationThreshold_Default
            MinimumRequiredMovesForShake = MinimumRequiredMovesForShake_Default

            ' register for acceleromter input
            AddHandler AccelerometerHelper.Instance.ReadingChanged, AddressOf OnAccelerometerHelperReadingChanged
        End Sub

#End Region

#Region "Public properties"

        ''' <summary>
        ''' Singleton instance of the Shake Gestures Helper class
        ''' </summary>
        Public Shared ReadOnly Property Instance() As ShakeGesturesHelper
            Get
                If _singletonInstance Is Nothing Then
                    SyncLock _syncRoot
                        If _singletonInstance Is Nothing Then
                            _singletonInstance = New ShakeGesturesHelper()
                        End If
                    End SyncLock
                End If
                Return _singletonInstance
            End Get
        End Property

        ''' <summary>
        ''' Accelerometer is active and reading value when true
        ''' </summary>
        Public Property Active() As Boolean
            Get
                Return AccelerometerHelper.Instance.Active
            End Get
            Set(ByVal value As Boolean)
                AccelerometerHelper.Instance.Active = value
            End Set
        End Property

        Public Sub Simulate(ByVal shakeType As ShakeType)
            Dim activePreviousState As Boolean = Active

            ThreadPool.QueueUserWorkItem(Sub(o)
                                             Active = False
                                             Simulation.CallTo = AddressOf OnAccelerometerHelperReadingChanged
                                             Thread.Sleep(TimeSpan.FromSeconds(1))
                                             Select Case shakeType
                                                 Case ShakeType.X
                                                     Simulation.SimulateShakeX()
                                                 Case ShakeType.Y
                                                     Simulation.SimulateShakeY()
                                                 Case ShakeType.Z
                                                     Simulation.SimulateShakeZ()
                                             End Select
                                             Simulation.CallTo = Nothing
                                             Active = activePreviousState
                                         End Sub)

        End Sub

#End Region

#Region "Private methods"

        ''' <summary>
        ''' Called when the accelerometer provides a new value
        ''' </summary>
        Private Sub OnAccelerometerHelperReadingChanged(ByVal sender As Object, ByVal e As AccelerometerHelperReadingEventArgs)
            ' work with optimal vector (without noise)
            Dim currentVector As Simple3DVector = e.OptimalyFilteredAcceleration

            ' check if this vector is considered a shake vector
            Dim isShakeMagnitude As Boolean = (Math.Abs(_lastStillVector.Magnitude - currentVector.Magnitude) > ShakeMagnitudeWithoutGravitationThreshold)

            ' following is a state machine for detection of shake signal start and end

            ' if still --> shake
            If ((Not _isInShakeState)) AndAlso (isShakeMagnitude) Then
                ' set shake state flag
                _isInShakeState = True

                ' clear old shake signal
                ClearShakeSignal()

                ' process still signal
                ProcessStillSignal()

                ' add vector to shake signal
                AddVectorToShakeSignal(currentVector)
                ' if still --> still
            ElseIf ((Not _isInShakeState)) AndAlso ((Not isShakeMagnitude)) Then
                ' add vector to still signal
                AddVectorToStillSignal(currentVector)
                ' if shake --> shake
            ElseIf (_isInShakeState) AndAlso (isShakeMagnitude) Then
                ' add vector to shake signal
                AddVectorToShakeSignal(currentVector)

                ' reset still counter
                _stillCounter = 0

                ' try to process shake signal
                If ProcessShakeSignal() Then
                    ' shake signal generated, clear used data
                    ClearShakeSignal()
                End If
                ' if shake --> still
            ElseIf (_isInShakeState) AndAlso ((Not isShakeMagnitude)) Then
                ' add vector to shake signal
                AddVectorToShakeSignal(currentVector)

                ' count still vectors
                _stillCounter += 1

                ' if too much still samples
                If _stillCounter > StillCounterThreshold Then
                    ' clear old still signal
                    _stillSignal.Clear()

                    ' add still vectors from shake signal to still signal
                    For i = 0 To StillCounterThreshold - 1
                        ' calculate current index element
                        Dim currentSampleIndex As Integer = _shakeSignal.Count - StillCounterThreshold + i

                        ' add vector to still signal
                        AddVectorToStillSignal(currentVector)
                    Next i

                    ' remove last samples from shake signal
                    _shakeSignal.RemoveRange(_shakeSignal.Count - StillCounterThreshold, StillCounterThreshold)

                    ' reset shake state flag
                    _isInShakeState = False
                    _stillCounter = 0

                    ' try to process shake signal
                    If ProcessShakeSignal() Then
                        ClearShakeSignal()
                    End If
                End If
            End If
        End Sub

        Private Sub AddVectorToStillSignal(ByVal currentVector As Simple3DVector)
            ' add current vector to still signal, newest vectors are first
            _stillSignal.AddFirst(currentVector)

            ' if still signal is getting too big, remove old items
            If _stillSignal.Count > 2 * MaximumStillVectorsNeededForAverage Then
                _stillSignal.RemoveLast()
            End If
        End Sub

        ''' <summary>
        ''' Add a vector the shake signal and does some preprocessing
        ''' </summary>
        Private Sub AddVectorToShakeSignal(ByVal currentVector As Simple3DVector)
            ' remove still vector from current vector
            Dim currentVectorWithoutGravitation As Simple3DVector = currentVector - _lastStillVector

            ' add current vector to shake signal
            _shakeSignal.Add(currentVectorWithoutGravitation)

            ' skip weak vectors
            If currentVectorWithoutGravitation.Magnitude < WeakMagnitudeWithoutGravitationThreshold Then
                Return
            End If

            ' classify vector 
            Dim vectorShakeType As ShakeType = ClassifyVectorShakeType(currentVectorWithoutGravitation)

            ' count vector to histogram
            _shakeHistogram(CInt(Fix(vectorShakeType))) += 1
        End Sub

        ''' <summary>
        ''' Clear shake signal and related data
        ''' </summary>
        Private Sub ClearShakeSignal()
            ' clear shake signal
            _shakeSignal.Clear()

            ' create empty histogram
            Array.Clear(_shakeHistogram, 0, _shakeHistogram.Length)
        End Sub

        ''' <summary>
        ''' Process still signal: calculate average still vector
        ''' </summary>
        Private Sub ProcessStillSignal()
            Dim sumVector As New Simple3DVector(0, 0, 0)
            Dim count As Integer = 0

            ' going over vectors in still signal
            ' still signal was saved backwards, i.e. newest vectors are first
            For Each currentStillVector In _stillSignal
                ' make sure current vector is very still
                Dim isStillMagnitude As Boolean = (Math.Abs(_lastStillVector.Magnitude - currentStillVector.Magnitude) < StillMagnitudeWithoutGravitationThreshold)

                If isStillMagnitude Then
                    ' sum x,y,z values
                    sumVector += currentStillVector
                    count += 1

                    ' 20 samples are sufficent
                    If count >= MaximumStillVectorsNeededForAverage Then
                        Exit For
                    End If
                End If
            Next currentStillVector

            ' need at least a few vectors to get a good average
            If count >= MinimumStillVectorsNeededForAverage Then
                ' calculate average of still vectors
                _lastStillVector = sumVector / count
            End If
        End Sub

        ''' <summary>
        ''' Classify vector shake type
        ''' </summary>
        Private Function ClassifyVectorShakeType(ByVal v As Simple3DVector) As ShakeType
            Dim absX As Double = Math.Abs(v.X)
            Dim absY As Double = Math.Abs(v.Y)
            Dim absZ As Double = Math.Abs(v.Z)

            ' check if X is the most significant component
            If (absX >= absY) And (absX >= absZ) Then
                Return ShakeType.X
            End If

            ' check if Y is the most significant component
            If (absY >= absX) And (absY >= absZ) Then
                Return ShakeType.Y
            End If

            ' Z is the most significant component
            Return ShakeType.Z
        End Function

        ''' <summary>
        ''' Classify shake signal according to shake histogram
        ''' </summary>
        Private Function ProcessShakeSignal() As Boolean
            Dim xCount As Integer = _shakeHistogram(0)
            Dim yCount As Integer = _shakeHistogram(1)
            Dim zCount As Integer = _shakeHistogram(2)

            Dim _shakeType? As ShakeType = Nothing

            ' if X part is strongest and above a minimum
            If (xCount >= yCount) And (xCount >= zCount) And (xCount >= MinimumShakeVectorsNeededForShake) Then
                _shakeType = ShakeType.X
                ' if Y part is strongest and above a minimum
            ElseIf (yCount >= xCount) And (yCount >= zCount) And (yCount >= MinimumShakeVectorsNeededForShake) Then
                _shakeType = ShakeType.Y
                ' if Z part is strongest and above a minimum
            ElseIf (zCount >= xCount) And (zCount >= yCount) And (zCount >= MinimumShakeVectorsNeededForShake) Then
                _shakeType = ShakeType.Z
            End If

            If _shakeType IsNot Nothing Then
                Dim countSignsChanges As Integer = CountSignChanges(_shakeType.Value)

                ' check that we have enough shakes 
                If countSignsChanges < MinimumRequiredMovesForShake Then
                    _shakeType = Nothing
                End If
            End If

            ' if a strong shake was detected
            If _shakeType IsNot Nothing Then
                ' raise shake gesture event
                Dim localShakeGesture As EventHandler(Of ShakeGestureEventArgs) = ShakeGestureEvent
                If localShakeGesture IsNot Nothing Then
                    localShakeGesture(Me, New ShakeGestureEventArgs(_shakeType.Value))
                End If
                Return True
            End If

            Return False
        End Function

        ''' <summary>
        ''' Count how many shakes the shake signal contains
        ''' </summary>
        Private Function CountSignChanges(ByVal shakeType As ShakeType) As Integer
            Dim countSignsChanges As Integer = 0
            Dim currentSign As Integer = 0
            Dim prevSign? As Integer = Nothing

            For i = 0 To _shakeSignal.Count - 1
                ' get sign of current vector
                Select Case shakeType
                    Case shakeType.X
                        currentSign = Math.Sign(_shakeSignal(i).X)

                    Case shakeType.Y
                        currentSign = Math.Sign(_shakeSignal(i).Y)

                    Case shakeType.Z
                        currentSign = Math.Sign(_shakeSignal(i).Z)
                End Select

                ' skip sign-less vectors
                If currentSign = 0 Then
                    Continue For
                End If

                ' handle sign for first vector
                If prevSign Is Nothing Then
                    prevSign = currentSign
                End If

                ' check if sign changed
                If Not prevSign.Equals(currentSign) Then
                    countSignsChanges += 1
                End If

                ' save previous sign
                prevSign = currentSign
            Next i

            Return countSignsChanges
        End Function

#End Region
    End Class
End Namespace
