﻿'*********************************************************
'
' Copyright (c) Microsoft. All rights reserved.
' THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
' IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
' PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************

Imports SDKTemplate

Imports System
Imports Windows.Graphics.Display
Imports Windows.UI.Text
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Media
Imports Windows.UI.Xaml.Navigation

Partial Public NotInheritable Class Scenario2
    Inherits SDKTemplate.Common.LayoutAwarePage
    Private Shared defaultFontFamily As New FontFamily("Segoe UI")
    Private Shared overrideFontFamily As New FontFamily("Segoe Script")

    Public Sub New()
        InitializeComponent()
        AddHandler DisplayProperties.LogicalDpiChanged, AddressOf DisplayProperties_LogicalDpiChanged
        DefaultLayoutText.FontSize = PxFromPt(20)
        ' xaml fontsize is in pixels.
        DefaultLayoutText.FontFamily = defaultFontFamily
    End Sub

    ' Helpers to convert between points and pixels.
    Private Function PtFromPx(pixel As Double) As Double
        Return pixel * 72 / 96
    End Function

    Private Function PxFromPt(pt As Double) As Double
        Return pt * 96 / 72
    End Function

    Private Sub SetOverrideRectSize(sizeInPhysicalPx As Double, scaleFactor As Double)
        ' Set the size of OverrideLayoutRect based on the desired size in physical pixels and the scale factor.
        ' The code here is to demonstrate how to override default scaling behavior to keep the physical pixel size of a control.
        Dim sizeInRelativePx As Double = sizeInPhysicalPx / scaleFactor
        OverrideLayoutRect.Width = sizeInRelativePx
        OverrideLayoutRect.Height = sizeInRelativePx
    End Sub

    Private Sub SetOverrideTextFont(size As Double, fontFamily As FontFamily)
        OverrideLayoutText.FontSize = PxFromPt(size)
        ' xaml fontsize is in pixels.
        OverrideLayoutText.FontFamily = fontFamily
    End Sub

    Private Sub OutputSettings(scaleFactor As Double, rectangle As FrameworkElement, relativePxText As TextBlock, physicalPxText As TextBlock, fontTextBlock As TextBlock)
        ' Get the size of the rectangle in relative pixels and calulate the size in physical pixels.
        Dim sizeInRelativePx As Double = rectangle.Width
        Dim sizeInPhysicalPx As Double = sizeInRelativePx * scaleFactor

        relativePxText.Text = sizeInRelativePx.ToString("F1") & " relative px"
        physicalPxText.Text = sizeInPhysicalPx.ToString("F0") & " physical px"

        Dim fontSize As Double = PtFromPx(fontTextBlock.FontSize)
        fontTextBlock.Text = fontSize.ToString("F0") & "pt " & fontTextBlock.FontFamily.Source
    End Sub

    Private Sub ResetOutput()
        ResolutionTextBlock.Text = Window.Current.Bounds.Width.ToString("F1") & "x" & Window.Current.Bounds.Height.ToString("F1")

        Dim scaleFactor As Double
        Dim fontSize As Double
        Dim fontFamily As FontFamily

        Select Case DisplayProperties.ResolutionScale
            Case ResolutionScale.Invalid, ResolutionScale.Scale100Percent
                scaleFactor = 1.0
                fontSize = 20
                fontFamily = defaultFontFamily
                Exit Select

            Case ResolutionScale.Scale140Percent
                scaleFactor = 1.4
                fontSize = 11
                fontFamily = overrideFontFamily
                Exit Select

            Case ResolutionScale.Scale180Percent
                scaleFactor = 1.8
                fontSize = 9
                fontFamily = overrideFontFamily
                Exit Select
            Case Else
                scaleFactor = 1.0
                fontSize = 20
                fontFamily = defaultFontFamily
                Exit Select
        End Select

        ' Set the override rectangle size and override text font.
        Const rectSizeInPhysicalPx As Double = 100
        SetOverrideRectSize(rectSizeInPhysicalPx, scaleFactor)
        SetOverrideTextFont(fontSize, fontFamily)

        ' Output settings for controls with default scaling behavior.
        OutputSettings(scaleFactor, DefaultLayoutRect, DefaultRelativePx, DefaultPhysicalPx, DefaultLayoutText)
        ' Output settings for override controls.
        OutputSettings(scaleFactor, OverrideLayoutRect, OverrideRelativePx, OverridePhysicalPx, OverrideLayoutText)
    End Sub

    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        ResetOutput()
    End Sub

    Private Sub DisplayProperties_LogicalDpiChanged(sender As Object)
        ResetOutput()
    End Sub
End Class
