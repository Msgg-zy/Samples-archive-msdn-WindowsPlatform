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
Namespace Microsoft.Phone.Applications.Common
    Public Class Simple3DVector
        ''' <summary>
        ''' X-axis coordinate
        ''' </summary>

        Public Property X() As Double

        ''' <summary>
        ''' Y-axis coordinate
        ''' </summary>

        Public Property Y() As Double


        ''' <summary>
        ''' Z-axis coordinate
        ''' </summary>

        Public Property Z() As Double

        ''' <summary>
        ''' Default constructor
        ''' Creates a null vector
        ''' </summary>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' Cector constructor from 3 double values
        ''' </summary>
        ''' <param name="x">X</param>
        ''' <param name="y">Y</param>
        ''' <param name="z">Z</param>
        Public Sub New(ByVal x As Double, ByVal y As Double, ByVal z As Double)
            Me.X = x
            Me.Y = y
            Me.Z = z
        End Sub

        ''' <summary>
        ''' Cloning constructor
        ''' </summary>
        ''' <param name="v">Vector to clone</param>
        Public Sub New(ByVal v As Simple3DVector)
            If v IsNot Nothing Then
                X = v.X
                Y = v.Y
                Z = v.Z
            End If
        End Sub

        ''' <summary>
        ''' Override the ToString method to display vector in suitable format:
        ''' </summary>
        Public Overrides Function ToString() As String
            Return (String.Format("({0:0.000},{1:0.000},{2:0.000})", X, Y, Z))
        End Function

        ''' <summary>
        ''' Overload (==) operator for 2 vectors
        ''' </summary>
        Public Shared Operator =(ByVal v1 As Simple3DVector, ByVal v2 As Simple3DVector) As Boolean
            If Object.ReferenceEquals(v1, v2) Then
                Return True
            End If

            If (CObj(v1) Is Nothing) OrElse (CObj(v2) Is Nothing) Then
                Return False
            End If

            Return (v1.X = v2.X) AndAlso (v1.Y = v2.Y) AndAlso (v1.Z = v2.Z)
        End Operator

        ''' <summary>
        ''' Overload (!=) operator for 2 vectors
        ''' </summary>
        Public Shared Operator <>(ByVal v1 As Simple3DVector, ByVal v2 As Simple3DVector) As Boolean
            Return Not (v1 = v2)
        End Operator

        ''' <summary>
        ''' Override the Object.Equals(object o) method:
        ''' </summary>
        Public Overloads Overrides Function Equals(ByVal o As Object) As Boolean
            If TypeOf o Is Simple3DVector Then
                Return CBool(Me = CType(o, Simple3DVector))
            Else
                Return False
            End If
        End Function

        ''' <summary>
        ''' Override the Object.Equals(object o) method:
        ''' </summary>
        Public Overrides Function GetHashCode() As Integer
            Return X.GetHashCode() Xor Y.GetHashCode() Xor Z.GetHashCode()
        End Function

        ''' <summary>
        ''' Overload (+) operator for 2 vectors
        ''' </summary>
        Public Shared Operator +(ByVal v1 As Simple3DVector, ByVal v2 As Simple3DVector) As Simple3DVector
            Return New Simple3DVector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z)
        End Operator

        ''' <summary>
        ''' Overload (-) operator for 2 vectors
        ''' </summary>
        Public Shared Operator -(ByVal v1 As Simple3DVector, ByVal v2 As Simple3DVector) As Simple3DVector
            Return New Simple3DVector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z)
        End Operator

        ''' <summary>
        ''' Overload (*) operator for 2 vectors
        ''' </summary>
        Public Shared Operator *(ByVal v1 As Simple3DVector, ByVal v2 As Simple3DVector) As Simple3DVector
            Return New Simple3DVector(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z)
        End Operator

        ''' <summary>
        ''' Overload (*) operator for a vector and double (scaling)
        ''' </summary>
        Public Shared Operator *(ByVal v As Simple3DVector, ByVal d As Double) As Simple3DVector
            Return New Simple3DVector(d * v.X, d * v.Y, d * v.Z)
        End Operator

        ''' <summary>
        ''' Overload (/) operator for a vector and double (scaling)
        ''' </summary>
        Public Shared Operator /(ByVal v As Simple3DVector, ByVal d As Double) As Simple3DVector
            Return New Simple3DVector(v.X / d, v.Y / d, v.Z / d)
        End Operator

        Private _magnitude? As Double = Nothing

        ''' <summary>
        ''' Get Magnitude of vector
        ''' </summary>
        Public ReadOnly Property Magnitude() As Double
            Get
                If _magnitude Is Nothing Then
                    _magnitude = Math.Sqrt(X * X + Y * Y + Z * Z)
                End If
                Return _magnitude.Value
            End Get
        End Property
    End Class
End Namespace
