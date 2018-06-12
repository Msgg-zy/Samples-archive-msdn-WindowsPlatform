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
Namespace Microsoft.Phone.Controls.Unsupported


    ''' <summary>
    ''' The platform does not currently support relative sized translation values. 
    ''' This primitive control walks through visual state animation storyboards
    ''' and looks for identifying values to use as percentages.
    ''' </summary>
    Public Class RelativeAnimatingContentControl
        Inherits ContentControl
        ''' <summary>
        ''' A simple Epsilon-style value used for trying to determine if a double
        ''' has an identifying value. 
        ''' </summary>
        Private Const SimpleDoubleComparisonEpsilon As Double = 0.000009

        ''' <summary>
        ''' The last known width of the control.
        ''' </summary>
        Private _knownWidth As Double

        ''' <summary>
        ''' The last known height of the control.
        ''' </summary>
        Private _knownHeight As Double

        ''' <summary>
        ''' A set of custom animation adapters used to update the animation
        ''' storyboards when the size of the control changes.
        ''' </summary>
        Private _specialAnimations As List(Of AnimationValueAdapter)

        ''' <summary>
        ''' Initializes a new instance of the RelativeAnimatingContentControl
        ''' type.
        ''' </summary>
        Public Sub New()
            AddHandler SizeChanged, AddressOf OnSizeChanged
        End Sub

        ''' <summary>
        ''' Handles the size changed event.
        ''' </summary>
        ''' <param name="sender">The source object.</param>
        ''' <param name="e">The event arguments.</param>
        Private Sub OnSizeChanged(ByVal sender As Object, ByVal e As SizeChangedEventArgs)
            If e IsNot Nothing AndAlso e.NewSize.Height > 0 AndAlso e.NewSize.Width > 0 Then
                _knownWidth = e.NewSize.Width
                _knownHeight = e.NewSize.Height

                Clip = New RectangleGeometry With {.Rect = New Rect(0, 0, _knownWidth, _knownHeight)}

                UpdateAnyAnimationValues()
            End If
        End Sub

        ''' <summary>
        ''' Walks through the known storyboards in the control's template that
        ''' may contain identifying values, storing them for future
        ''' use and updates.
        ''' </summary>
        Private Sub UpdateAnyAnimationValues()
            If _knownHeight > 0 AndAlso _knownWidth > 0 Then
                ' Initially, before any special animations have been found,
                ' the visual state groups of the control must be explored. 
                ' By definition they must be at the implementation root of the
                ' control.
                If _specialAnimations Is Nothing Then
                    _specialAnimations = New List(Of AnimationValueAdapter)()

                    For Each group As VisualStateGroup In VisualStateManager.GetVisualStateGroups(Me)
                        If group Is Nothing Then
                            Continue For
                        End If
                        For Each state As VisualState In group.States
                            If state IsNot Nothing Then
                                Dim sb As Storyboard = state.Storyboard
                                If sb IsNot Nothing Then
                                    ' Examine all children of the storyboards,
                                    ' looking for either type of double
                                    ' animation.
                                    For Each timeline As Timeline In sb.Children
                                        Dim da As DoubleAnimation = TryCast(timeline, DoubleAnimation)
                                        Dim dakeys = TryCast(timeline, DoubleAnimationUsingKeyFrames)
                                        If da IsNot Nothing Then
                                            ProcessDoubleAnimation(da)
                                        ElseIf dakeys IsNot Nothing Then
                                            ProcessDoubleAnimationWithKeys(dakeys)
                                        End If
                                    Next timeline
                                End If
                            End If
                        Next state
                    Next group
                End If

                ' Update special animation values relative to the current size.
                UpdateKnownAnimations()
            End If
        End Sub

        ''' <summary>
        ''' Walks through all special animations, updating based on the current
        ''' size of the control.
        ''' </summary>
        Private Sub UpdateKnownAnimations()
            For Each adapter In _specialAnimations
                adapter.UpdateWithNewDimension(_knownWidth, _knownHeight)
            Next adapter
        End Sub

        ''' <summary>
        ''' Processes a double animation with keyframes, looking for known 
        ''' special values to store with an adapter.
        ''' </summary>
        ''' <param name="da">The double animation using key frames instance.</param>
        Private Sub ProcessDoubleAnimationWithKeys(ByVal da As DoubleAnimationUsingKeyFrames)
            ' Look through all keyframes in the instance.
            For Each frame In da.KeyFrames
                Dim d = DoubleAnimationFrameAdapter.GetDimensionFromIdentifyingValue(frame.Value)
                If d.HasValue Then
                    _specialAnimations.Add(New DoubleAnimationFrameAdapter(d.Value, frame))
                End If
            Next frame
        End Sub

        ''' <summary>
        ''' Processes a double animation looking for special values.
        ''' </summary>
        ''' <param name="da">The double animation instance.</param>
        Private Sub ProcessDoubleAnimation(ByVal da As DoubleAnimation)
            ' Look for a special value in the To property.
            If da.To.HasValue Then
                Dim d = DoubleAnimationToAdapter.GetDimensionFromIdentifyingValue(da.To.Value)
                If d.HasValue Then
                    _specialAnimations.Add(New DoubleAnimationToAdapter(d.Value, da))
                End If
            End If

            ' Look for a special value in the From property.
            If da.From.HasValue Then
                Dim d = DoubleAnimationFromAdapter.GetDimensionFromIdentifyingValue(da.To.Value)
                If d.HasValue Then
                    _specialAnimations.Add(New DoubleAnimationFromAdapter(d.Value, da))
                End If
            End If
        End Sub

#Region "Private animation updating system"
        ''' <summary>
        ''' A selection of dimensions of interest for updating an animation.
        ''' </summary>
        Private Enum DoubleAnimationDimension
            ''' <summary>
            ''' The width (horizontal) dimension.
            ''' </summary>
            Width

            ''' <summary>
            ''' The height (vertical) dimension.
            ''' </summary>
            Height
        End Enum

        ''' <summary>
        ''' A simple class designed to store information about a specific 
        ''' animation instance and its properties. Able to update the values at
        ''' runtime.
        ''' </summary>
        Private MustInherit Class AnimationValueAdapter
            ''' <summary>
            ''' Gets or sets the original double value.
            ''' </summary>
            Protected Property OriginalValue() As Double

            ''' <summary>
            ''' Initializes a new instance of the AnimationValueAdapter type.
            ''' </summary>
            ''' <param name="dimension">The dimension of interest for updates.</param>
            Public Sub New(ByVal dimension As DoubleAnimationDimension)
                Me.Dimension = dimension
            End Sub

            ''' <summary>
            ''' Gets the dimension of interest for the control.
            ''' </summary>
            Private _Dimension As DoubleAnimationDimension
            Public Property Dimension() As DoubleAnimationDimension
                Get
                    Return _Dimension
                End Get
                Private Set(ByVal value As DoubleAnimationDimension)
                    _Dimension = value
                End Set
            End Property

            ''' <summary>
            ''' Updates the original instance based on new dimension information
            ''' from the control. Takes both and allows the subclass to make the
            ''' decision on which ratio, values, and dimension to use.
            ''' </summary>
            ''' <param name="width">The width of the control.</param>
            ''' <param name="height">The height of the control.</param>
            Public MustOverride Sub UpdateWithNewDimension(ByVal width As Double, ByVal height As Double)
        End Class

        Private MustInherit Class GeneralAnimationValueAdapter(Of T)
            Inherits AnimationValueAdapter
            ''' <summary>
            ''' Stores the animation instance.
            ''' </summary>
            Protected Property Instance() As T

            ''' <summary>
            ''' Gets the value of the underlying property of interest.
            ''' </summary>
            ''' <returns>Returns the value of the property.</returns>
            Protected MustOverride Function GetValue() As Double

            ''' <summary>
            ''' Sets the value for the underlying property of interest.
            ''' </summary>
            ''' <param name="newValue">The new value for the property.</param>
            Protected MustOverride Sub SetValue(ByVal newValue As Double)

            ''' <summary>
            ''' Gets the initial value (minus the identifying value portion) that the
            ''' designer stored within the visual state animation property.
            ''' </summary>
            Private _InitialValue As Double
            Protected Property InitialValue() As Double
                Get
                    Return _InitialValue
                End Get
                Private Set(ByVal value As Double)
                    _InitialValue = value
                End Set
            End Property

            ''' <summary>
            ''' The ratio based on the original identifying value, used for computing
            ''' the updated animation property of interest when the size of the
            ''' control changes.
            ''' </summary>
            Private _ratio As Double

            ''' <summary>
            ''' Initializes a new instance of the GeneralAnimationValueAdapter
            ''' type.
            ''' </summary>
            ''' <param name="d">The dimension of interest.</param>
            ''' <param name="instance">The animation type instance.</param>
            Public Sub New(ByVal d As DoubleAnimationDimension, ByVal instance As T)
                MyBase.New(d)
                Me.Instance = instance

                InitialValue = StripIdentifyingValueOff(GetValue())
                _ratio = InitialValue / 100
            End Sub

            ''' <summary>
            ''' Approximately removes the identifying value from a value.
            ''' </summary>
            ''' <param name="number">The initial number.</param>
            ''' <returns>Returns a double with an adjustment for the identifying
            ''' value portion of the number.</returns>
            Public Function StripIdentifyingValueOff(ByVal number As Double) As Double
                Return If(Dimension = DoubleAnimationDimension.Width, number - 0.1, number - 0.2)
            End Function

            ''' <summary>
            ''' Retrieves the dimension, if any, from the number. If the number
            ''' does not have an identifying value, null is returned.
            ''' </summary>
            ''' <param name="number">The double value.</param>
            ''' <returns>Returns a double animation dimension if the number was
            ''' contained an identifying value; otherwise, returns null.</returns>
            Public Shared Function GetDimensionFromIdentifyingValue(ByVal number As Double) As DoubleAnimationDimension?
                Dim floor As Double = Math.Floor(number)
                Dim remainder As Double = number - floor

                If remainder >= 0.1 - SimpleDoubleComparisonEpsilon AndAlso remainder <= 0.1 + SimpleDoubleComparisonEpsilon Then
                    Return DoubleAnimationDimension.Width
                End If
                If remainder >= 0.2 - SimpleDoubleComparisonEpsilon AndAlso remainder <= 0.2 + SimpleDoubleComparisonEpsilon Then
                    Return DoubleAnimationDimension.Height
                End If
                Return Nothing
            End Function

            ''' <summary>
            ''' Updates the animation instance based on the dimensions of the
            ''' control.
            ''' </summary>
            ''' <param name="width">The width of the control.</param>
            ''' <param name="height">The height of the control.</param>
            Public Overrides Sub UpdateWithNewDimension(ByVal width As Double, ByVal height As Double)
                Dim size As Double = If(Dimension = DoubleAnimationDimension.Width, width, height)
                UpdateValue(size)
            End Sub

            ''' <summary>
            ''' Updates the value of the property.
            ''' </summary>
            ''' <param name="sizeToUse">The size of interest to use with a ratio
            ''' computation.</param>
            Private Sub UpdateValue(ByVal sizeToUse As Double)
                SetValue(sizeToUse * _ratio)
            End Sub
        End Class

        ''' <summary>
        ''' Adapter for DoubleAnimation's To property.
        ''' </summary>
        Private Class DoubleAnimationToAdapter
            Inherits GeneralAnimationValueAdapter(Of DoubleAnimation)
            ''' <summary>
            ''' Gets the value of the underlying property of interest.
            ''' </summary>
            ''' <returns>Returns the value of the property.</returns>
            Protected Overrides Function GetValue() As Double
                Return CDbl(Instance.To)
            End Function

            ''' <summary>
            ''' Sets the value for the underlying property of interest.
            ''' </summary>
            ''' <param name="newValue">The new value for the property.</param>
            Protected Overrides Sub SetValue(ByVal newValue As Double)
                Instance.To = newValue
            End Sub

            ''' <summary>
            ''' Initializes a new instance of the DoubleAnimationToAdapter type.
            ''' </summary>
            ''' <param name="dimension">The dimension of interest.</param>
            ''' <param name="instance">The instance of the animation type.</param>
            Public Sub New(ByVal dimension As DoubleAnimationDimension, ByVal instance As DoubleAnimation)
                MyBase.New(dimension, instance)
            End Sub
        End Class

        ''' <summary>
        ''' Adapter for DoubleAnimation's From property.
        ''' </summary>
        Private Class DoubleAnimationFromAdapter
            Inherits GeneralAnimationValueAdapter(Of DoubleAnimation)
            ''' <summary>
            ''' Gets the value of the underlying property of interest.
            ''' </summary>
            ''' <returns>Returns the value of the property.</returns>
            Protected Overrides Function GetValue() As Double
                Return CDbl(Instance.From)
            End Function

            ''' <summary>
            ''' Sets the value for the underlying property of interest.
            ''' </summary>
            ''' <param name="newValue">The new value for the property.</param>
            Protected Overrides Sub SetValue(ByVal newValue As Double)
                Instance.From = newValue
            End Sub

            ''' <summary>
            ''' Initializes a new instance of the DoubleAnimationFromAdapter 
            ''' type.
            ''' </summary>
            ''' <param name="dimension">The dimension of interest.</param>
            ''' <param name="instance">The instance of the animation type.</param>
            Public Sub New(ByVal dimension As DoubleAnimationDimension, ByVal instance As DoubleAnimation)
                MyBase.New(dimension, instance)
            End Sub
        End Class

        ''' <summary>
        ''' Adapter for double key frames.
        ''' </summary>
        Private Class DoubleAnimationFrameAdapter
            Inherits GeneralAnimationValueAdapter(Of DoubleKeyFrame)
            ''' <summary>
            ''' Gets the value of the underlying property of interest.
            ''' </summary>
            ''' <returns>Returns the value of the property.</returns>
            Protected Overrides Function GetValue() As Double
                Return Instance.Value
            End Function

            ''' <summary>
            ''' Sets the value for the underlying property of interest.
            ''' </summary>
            ''' <param name="newValue">The new value for the property.</param>
            Protected Overrides Sub SetValue(ByVal newValue As Double)
                Instance.Value = newValue
            End Sub

            ''' <summary>
            ''' Initializes a new instance of the DoubleAnimationFrameAdapter
            ''' type.
            ''' </summary>
            ''' <param name="dimension">The dimension of interest.</param>
            ''' <param name="frame">The instance of the animation type.</param>
            Public Sub New(ByVal dimension As DoubleAnimationDimension, ByVal frame As DoubleKeyFrame)
                MyBase.New(dimension, frame)
            End Sub
        End Class
#End Region
    End Class
End Namespace
