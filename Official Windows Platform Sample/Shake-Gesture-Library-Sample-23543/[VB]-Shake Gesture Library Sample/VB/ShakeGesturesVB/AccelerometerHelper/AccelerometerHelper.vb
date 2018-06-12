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
Imports System
Imports System.Diagnostics
Imports Microsoft.Devices.Sensors


Namespace Microsoft.Phone.Applications.Common
    ''' <summary>
    ''' Arguments provided by the Accelerometer Helper data event
    ''' </summary>
    Public Class AccelerometerHelperReadingEventArgs
        Inherits EventArgs
        ''' <summary>
        ''' Raw, unfiltered accelerometer data (acceleration vector in all 3 dimensions) coming directly from sensor.
        ''' This is required for updating rapidly reacting UI.
        ''' </summary>
        Public Property RawAcceleration() As Simple3DVector

        ''' <summary>
        ''' Filtered accelerometer data using a combination of a low-pass and threshold triggered high-pass on each axis to 
        ''' elimate the majority of the sensor low amplitude noise while trending very quickly to large offsets (not perfectly
        ''' smooth signal in that case), providing a very low latency. This is ideal for quickly reacting UI updates.
        ''' </summary>
        Public Property OptimalyFilteredAcceleration() As Simple3DVector

        ''' <summary>
        ''' Filtered accelerometer data using a 1 Hz first-order low-pass on each axis to elimate the main sensor noise
        ''' while providing a medium latency. This can be used for moderatly reacting UI updates requiring a very smooth signal.
        ''' </summary>
        Public Property LowPassFilteredAcceleration() As Simple3DVector

        ''' <summary>
        ''' Filtered and temporally averaged accelerometer data using an arithmetic mean of the last 25 "optimaly filtered" 
        ''' samples (see above), so over 500ms at 50Hz on each axis, to virtually eliminate most sensor noise. 
        ''' This provides a very stable reading but it has also a very high latency and cannot be used for rapidly reacting UI.
        ''' </summary>
        Public Property AverageAcceleration() As Simple3DVector
    End Class

    ''' <summary>
    ''' Accelerometer Helper Class, providing filtering and local calibration of accelerometer sensor data 
    ''' </summary>
    Public NotInheritable Class AccelerometerHelper
        Implements IDisposable
#Region "Private fields"

        ' Singleton instance for helper - prefered solution to static class to avoid static constructor (10x slower)
        'INSTANT VB TODO TASK: There is no VB equivalent to 'volatile':
        'ORIGINAL LINE: private static volatile AccelerometerHelper _singletonInstance;
        Private Shared _singletonInstance As AccelerometerHelper

        Private Shared _syncRoot As New Object()

        ''' <summary>
        ''' Accelerometer sensor
        ''' </summary>
        Private _sensor As Accelerometer

        ''' <summary>
        ''' This is the inclination angle on any axis beyond which the device cannot be calibrated on that particular axis
        ''' </summary>
        Private Const MaximumCalibrationTiltAngle As Double = 20.0 * Math.PI / 180.0 ' 20 deg inclination from non-calibrated axis max

        ''' <summary>
        ''' Corresponding lateral acceleration offset at 1g of Maximum Calibration Tilt Angle
        ''' </summary>
        Private Shared _maximumCalibrationOffset As Double = Math.Sin(MaximumCalibrationTiltAngle)

        ''' <summary>
        ''' This is the maximum inclination angle variation on any axis between the average acceleration and the filtered 
        ''' acceleration beyond which the device cannot be calibrated on that particular axis.
        ''' The calibration cannot be done until this condition is met on the last contiguous samples from the accelerometer
        ''' </summary>
        Private Const MaximumStabilityTiltDeltaAngle As Double = 0.5 * Math.PI / 180.0 ' 0.5 deg inclination delta at max

        ''' <summary>
        ''' Corresponding lateral acceleration offset at 1g of Maximum Stability Tilt Delta Angle
        ''' </summary>
        Private Shared _maximumStabilityDeltaOffset As Double = Math.Sin(MaximumStabilityTiltDeltaAngle)

        ''' <summary>
        ''' Number of samples for which the accelemeter is "stable" (filtered acceleration is within Maximum Stability Tilt 
        ''' Delta Angle of average acceleration)
        ''' </summary>
        Private _deviceStableCount As Integer = 0

        ''' <summary>
        ''' Number of prior samples to keep for averaging.       
        ''' The higher this number, the larger the latency will be: 
        ''' At 50Hz sampling rate: Latency = 20ms * SamplesCount
        ''' </summary>
        Private Const SamplesCount As Integer = 25 ' averaging and checking stability on 500ms

        ''' <summary>
        '''  This is the smoothing factor used for the 1st order discrete Low-Pass filter
        '''  The cut-off frequency fc = fs * K/(2*PI*(1-K))
        ''' </summary>
        Private Const LowPassFilterCoef As Double = 0.1 ' With a 50Hz sampling rate, this is gives a 1Hz cut-off

        ''' <summary>
        ''' Maximum amplitude of noise from sample to sample. 
        ''' This is used to remove the noise selectively while allowing fast trending for larger amplitudes
        ''' </summary>
        Private Const NoiseMaxAmplitude As Double = 0.05 ' up to 0.05g deviation from filtered value is considered noise

        ''' <summary>
        ''' Indicates that the helper has not been initialized yet.
        ''' This is used for filter past data initialization
        ''' </summary>
        Private _initialized As Boolean = False

        ''' <summary>
        ''' Circular buffer of filtered samples
        ''' </summary>
        Private _sampleBuffer(SamplesCount - 1) As Simple3DVector

        ''' <summary>
        ''' n-1 of low pass filter output
        ''' </summary>
        Private _previousLowPassOutput As Simple3DVector

        ''' <summary>
        ''' n-1 of optimal filter output
        ''' </summary>
        Private _previousOptimalFilterOutput As Simple3DVector

        ''' <summary>
        ''' Sum of all the filtered samples in the circular buffer file
        ''' </summary>
        Private _sampleSum As New Simple3DVector(0.0 * SamplesCount, 0.0 * SamplesCount, -1.0 * SamplesCount) ' assume start flat: -1g in z axis

        ''' <summary>
        ''' Index in circular buffer of samples
        ''' </summary>
        Private _sampleIndex As Integer

        ''' <summary>
        ''' Average acceleration
        ''' This is a simple arithmetic average over the entire _sampleFile (SamplesCount elements) which contains filtered readings
        ''' This is used for the calibration, to get a more steady reading of the acceleration
        ''' </summary>
        Private _averageAcceleration As Simple3DVector

        Private Const AccelerometerCalibrationKeyName As String = "AccelerometerCalibration"

        ''' <summary>
        ''' Accelerometer is active and reading value when true
        ''' </summary>
        Private _active As Boolean = False

#End Region


#Region "Public events"

        ''' <summary>
        ''' New raw and processed accelerometer data available event.
        ''' Fires every 20ms.
        ''' </summary>
        Public Event ReadingChanged As EventHandler(Of AccelerometerHelperReadingEventArgs)

#End Region


#Region "Constructor and finalizer"

        ''' <summary>
        ''' Private constructor,
        ''' Use Instance property to get singleton instance
        ''' </summary>
        Private Sub New()
            ' Determine if accelerometer is present

            _sensor = New Accelerometer()
            If _sensor Is Nothing Then
                NoAccelerometer = True
            Else
                NoAccelerometer = (_sensor.State = SensorState.NotSupported)
            End If
            _sensor = Nothing

            'Set up buckets for calculating rolling average of the accelerations
            _sampleIndex = 0
            ZeroAccelerationCalibrationOffset = AccelerometerCalibrationPersisted
        End Sub

#End Region


#Region "Public properties"

        ''' <summary>
        ''' Singleton instance of the Accelerometer Helper class
        ''' </summary>
        Public Shared ReadOnly Property Instance() As AccelerometerHelper
            Get
                If _singletonInstance Is Nothing Then
                    SyncLock _syncRoot
                        If _singletonInstance Is Nothing Then
                            _singletonInstance = New AccelerometerHelper()
                        End If
                    End SyncLock
                End If
                Return _singletonInstance
            End Get
        End Property

        ''' <summary>
        ''' True when the device is "stable" (no movement for about 0.5 sec)
        ''' </summary>
        Public ReadOnly Property DeviceStable() As Boolean
            Get
                Return (_deviceStableCount >= SamplesCount)
            End Get
        End Property

        ''' <summary>
        ''' Property to get and set Calibration Setting Key
        ''' </summary>
        Private Shared Property AccelerometerCalibrationPersisted() As Simple3DVector
            Get
                Dim x As Double = ApplicationSettingHelper.TryGetValueWithDefault(Of Double)(AccelerometerCalibrationKeyName & "X", 0)
                Dim y As Double = ApplicationSettingHelper.TryGetValueWithDefault(Of Double)(AccelerometerCalibrationKeyName & "Y", 0)
                Return New Simple3DVector(x, y, 0)
            End Get

            Set(ByVal value As Simple3DVector)
                Dim updated As Boolean = ApplicationSettingHelper.AddOrUpdateValue(AccelerometerCalibrationKeyName & "X", value.X)
                updated = updated Or ApplicationSettingHelper.AddOrUpdateValue(AccelerometerCalibrationKeyName & "Y", value.Y)
                If updated Then
                    ApplicationSettingHelper.Save()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Persistant data (calibration of accelerometer)
        ''' </summary>

        Public Property ZeroAccelerationCalibrationOffset() As Simple3DVector

        ''' <summary>
        ''' Accelerometer is not present on device 
        ''' </summary>

        Public Property NoAccelerometer() As Boolean


        ''' <summary>
        ''' Accelerometer is active and reading value when true
        ''' </summary>
        Public Property Active() As Boolean
            Get
                Return _active
            End Get
            Set(ByVal value As Boolean)
                If Not NoAccelerometer Then
                    If value Then
                        If Not _active Then
                            StartAccelerometer()
                        End If
                    Else
                        If _active Then
                            StopAccelerometer()
                        End If
                    End If
                End If
            End Set
        End Property

#End Region


#Region "Public methods"

        ''' <summary>
        ''' Release sensor resource if not already done
        ''' </summary>
        Public Sub Dispose() Implements IDisposable.Dispose
            If _sensor IsNot Nothing Then
                _sensor.Dispose()
            End If
        End Sub

        ''' <summary>
        ''' Indicate that the calibration of the sensor would work along a particular set of axis
        ''' because the device is "stable enough" or not inclined beyond reasonable
        ''' </summary>
        ''' <param name="xAxis">check stability on X axis if true</param>
        ''' <param name="yAxis">check stability on X axis if true</param>
        ''' <returns>true if all of the axis checked were "stable enough" or not too inclined</returns>
        Public Function CanCalibrate(ByVal xAxis As Boolean, ByVal yAxis As Boolean) As Boolean
            Dim retval As Boolean = False
            SyncLock _sampleBuffer
                If DeviceStable Then
                    Dim accelerationMagnitude As Double = 0
                    If xAxis Then
                        accelerationMagnitude += _averageAcceleration.X * _averageAcceleration.X
                    End If
                    If yAxis Then
                        accelerationMagnitude += _averageAcceleration.Y * _averageAcceleration.Y
                    End If
                    accelerationMagnitude = Math.Sqrt(accelerationMagnitude)
                    If accelerationMagnitude <= _maximumCalibrationOffset Then
                        retval = True
                    End If
                End If
            End SyncLock
            Return retval
        End Function

        ''' <summary>
        ''' Calibrates the accelerometer on X and / or Y axis and save data to isolated storage.
        ''' </summary>
        ''' <param name="xAxis">calibrates X axis if true</param>
        ''' <param name="yAxis">calibrates Y axis if true</param>
        ''' <returns>true if succeeds</returns>
        Public Function Calibrate(ByVal xAxis As Boolean, ByVal yAxis As Boolean) As Boolean
            Dim retval As Boolean = False
            SyncLock _sampleBuffer
                If CanCalibrate(xAxis, yAxis) Then
                    ZeroAccelerationCalibrationOffset = New Simple3DVector(If(xAxis, -_averageAcceleration.X, ZeroAccelerationCalibrationOffset.X), If(yAxis, -_averageAcceleration.Y, ZeroAccelerationCalibrationOffset.Y), 0)
                    ' Persist data
                    AccelerometerCalibrationPersisted = ZeroAccelerationCalibrationOffset
                    retval = True
                End If
            End SyncLock
            Return retval
        End Function

#End Region


#Region "Private methods"



        ''' <summary>
        ''' Initialize Accelerometer sensor and start sampling
        ''' </summary>
        Private Sub StartAccelerometer()
            Try
                _sensor = New Accelerometer()
                If _sensor IsNot Nothing Then
                    AddHandler _sensor.CurrentValueChanged, AddressOf sensor_CurrentValueChanged
                    _sensor.Start()
                    _active = True
                    NoAccelerometer = False
                Else
                    _active = False
                    NoAccelerometer = True
                End If
            Catch e As Exception
                _active = False
                NoAccelerometer = True
                Debug.WriteLine("Exception creating Accelerometer: " & e.Message)
            End Try
        End Sub

        ''' <summary>
        ''' Stop smpling and release accelerometer sensor
        ''' </summary>
        Private Sub StopAccelerometer()
            Try
                If _sensor IsNot Nothing Then
                    RemoveHandler _sensor.CurrentValueChanged, AddressOf sensor_CurrentValueChanged
                    _sensor.Stop()
                    _sensor = Nothing
                    _active = False
                    _initialized = False
                End If
            Catch e As Exception
                _active = False
                NoAccelerometer = True
                Debug.WriteLine("Exception deleting Accelerometer: " & e.Message)
            End Try
        End Sub

        ''' <summary>
        ''' 1st order discrete low-pass filter used to remove noise from raw accelerometer.
        ''' </summary>
        ''' <param name="newInputValue">New input value (latest sample)</param>
        ''' <param name="priorOutputValue">The previous output value (filtered, one sampling period ago)</param>
        ''' <returns>The new output value</returns>
        Private Shared Function LowPassFilter(ByVal newInputValue As Double, ByVal priorOutputValue As Double) As Double
            Dim newOutputValue As Double = priorOutputValue + LowPassFilterCoef * (newInputValue - priorOutputValue)
            Return newOutputValue
        End Function

        ''' <summary>
        ''' discrete low-magnitude fast low-pass filter used to remove noise from raw accelerometer while allowing fast trending on high amplitude changes
        ''' </summary>
        ''' <param name="newInputValue">New input value (latest sample)</param>
        ''' <param name="priorOutputValue">The previous (n-1) output value (filtered, one sampling period ago)</param>
        ''' <returns>The new output value</returns>
        Private Shared Function FastLowAmplitudeNoiseFilter(ByVal newInputValue As Double, ByVal priorOutputValue As Double) As Double
            Dim newOutputValue As Double = newInputValue
            If Math.Abs(newInputValue - priorOutputValue) <= NoiseMaxAmplitude Then
                newOutputValue = priorOutputValue + LowPassFilterCoef * (newInputValue - priorOutputValue)
            End If
            Return newOutputValue
        End Function

        ''' <summary>
        ''' Called on accelerometer sensor sample available.
        ''' Main accelerometer data filtering routine
        ''' </summary>
        ''' <param name="sender">Sender of the event.</param>
        ''' <param name="e">AccelerometerReadingAsyncEventArgs</param>
        Private Sub sensor_CurrentValueChanged(ByVal sender As Object, ByVal e As SensorReadingEventArgs(Of AccelerometerReading))
            Dim lowPassFilteredAcceleration As Simple3DVector
            Dim optimalFilteredAcceleration As Simple3DVector
            Dim averagedAcceleration As Simple3DVector
            Dim rawAcceleration As New Simple3DVector(e.SensorReading.Acceleration.X, e.SensorReading.Acceleration.Y, e.SensorReading.Acceleration.Z)

            SyncLock _sampleBuffer
                If Not _initialized Then
                    _sampleSum = rawAcceleration * SamplesCount
                    _averageAcceleration = rawAcceleration

                    ' Initialize file with 1st value
                    For i = 0 To SamplesCount - 1
                        _sampleBuffer(i) = _averageAcceleration
                    Next i

                    _previousLowPassOutput = _averageAcceleration
                    _previousOptimalFilterOutput = _averageAcceleration

                    _initialized = True
                End If

                ' low-pass filter
                lowPassFilteredAcceleration = New Simple3DVector(LowPassFilter(rawAcceleration.X, _previousLowPassOutput.X), LowPassFilter(rawAcceleration.Y, _previousLowPassOutput.Y), LowPassFilter(rawAcceleration.Z, _previousLowPassOutput.Z))
                _previousLowPassOutput = lowPassFilteredAcceleration

                ' optimal filter
                optimalFilteredAcceleration = New Simple3DVector(FastLowAmplitudeNoiseFilter(rawAcceleration.X, _previousOptimalFilterOutput.X), FastLowAmplitudeNoiseFilter(rawAcceleration.Y, _previousOptimalFilterOutput.Y), FastLowAmplitudeNoiseFilter(rawAcceleration.Z, _previousOptimalFilterOutput.Z))
                _previousOptimalFilterOutput = optimalFilteredAcceleration

                ' Increment circular buffer insertion index
                _sampleIndex += 1
                If _sampleIndex >= SamplesCount Then ' if at max SampleCount then wrap samples back to the beginning position in the list
                    _sampleIndex = 0
                End If

                ' Add new and remove old at _sampleIndex
                Dim newVect As Simple3DVector = optimalFilteredAcceleration
                _sampleSum += newVect
                _sampleSum -= _sampleBuffer(_sampleIndex)
                _sampleBuffer(_sampleIndex) = newVect

                averagedAcceleration = _sampleSum / SamplesCount
                _averageAcceleration = averagedAcceleration

                ' Stablity check
                ' If current low-pass filtered sample is deviating for more than 1/100 g from average (max of 0.5 deg inclination noise if device steady)
                ' then reset the stability counter.
                ' The calibration will be prevented until the counter is reaching the sample count size (calibration enabled only if entire 
                ' sampling buffer is "stable"
                Dim deltaAcceleration As Simple3DVector = averagedAcceleration - optimalFilteredAcceleration
                If (Math.Abs(deltaAcceleration.X) > _maximumStabilityDeltaOffset) OrElse (Math.Abs(deltaAcceleration.Y) > _maximumStabilityDeltaOffset) OrElse (Math.Abs(deltaAcceleration.Z) > _maximumStabilityDeltaOffset) Then
                    _deviceStableCount = 0
                Else
                    If _deviceStableCount < SamplesCount Then
                        _deviceStableCount += 1
                    End If
                End If

                ' Add calibrations
                rawAcceleration += ZeroAccelerationCalibrationOffset
                lowPassFilteredAcceleration += ZeroAccelerationCalibrationOffset
                optimalFilteredAcceleration += ZeroAccelerationCalibrationOffset
                averagedAcceleration += ZeroAccelerationCalibrationOffset
            End SyncLock

            If ReadingChangedEvent IsNot Nothing Then
                Dim readingEventArgs As New AccelerometerHelperReadingEventArgs()

                readingEventArgs.RawAcceleration = rawAcceleration
                readingEventArgs.LowPassFilteredAcceleration = lowPassFilteredAcceleration
                readingEventArgs.OptimalyFilteredAcceleration = optimalFilteredAcceleration
                readingEventArgs.AverageAcceleration = averagedAcceleration

                RaiseEvent ReadingChanged(Me, readingEventArgs)
            End If

        End Sub

#End Region

   
    End Class
End Namespace
