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
Imports System.Windows.Navigation
Imports System.Net

Public Class QuickCardUriMapper
    Inherits UriMapperBase

    ' Navigation destination. 
    Private Shared TargetPageName As String = "ItemPage.xaml"
    Private tempUri As String

    Public Overrides Function MapUri(ByVal uri As Uri) As Uri

        tempUri = uri.ToString()

        ' Parse URI when launched by App Connect from Search
        If tempUri.Contains("/SearchExtras") Then

            ' Decode all characters in the URI.
            tempUri = HttpUtility.UrlDecode(tempUri)

            ' Create a new URI for product cards.
            If tempUri.Contains("Bing_Products") Then

                Return GetProductCardUri(tempUri)

            End If

            ' Create a new URI for place cards.
            If tempUri.Contains("Bing_Places") Then

                Return GetPlaceCardUri(tempUri)

            End If

            ' Create a new URI for movie cards.
            If tempUri.Contains("Bing_Movies") Then

                Return GetMovieCardUri(tempUri)

            End If

        End If

        ' Immediately return the URI when it is not related to App Connect for Search.
        Return uri

    End Function

    ' Return a parsed Product Card URI.
    Private Function GetProductCardUri(ByVal uri As String) As Uri

        ' Extract parameter values from URI.
        Dim ProductNameValue As String = GetURIParameterValue("ProductName=", uri)
        Dim CategoryValue As String = GetURIParameterValue("Category=", uri)

        ' Create new URI.
        Dim NewURI As String = String.Format("/{0}?ProductName={1}&Category={2}", TargetPageName, ProductNameValue, CategoryValue)

        Return New Uri(NewURI, UriKind.Relative)

    End Function


    ' Return a parsed Place Card URI.
    Private Function GetPlaceCardUri(ByVal uri As String) As Uri

        ' Extract parameter values from URI.
        Dim PlaceNameValue As String = GetURIParameterValue("PlaceName=", uri)
        Dim PlaceLatitudeValue As String = GetURIParameterValue("PlaceLatitude=", uri)
        Dim PlaceLongitudeValue As String = GetURIParameterValue("PlaceLongitude=", uri)
        Dim PlaceAddressValue As String = GetURIParameterValue("PlaceAddress=", uri)
        Dim CategoryValue As String = GetURIParameterValue("Category=", uri)

        ' Create new URI.
        Dim NewURI As String = String.Format("/{0}?PlaceName={1}&PlaceLatitude={2}&PlaceLongitude={3}&PlaceAddress={4}&Category={5}", TargetPageName, PlaceNameValue, PlaceLatitudeValue, PlaceLongitudeValue, PlaceAddressValue, CategoryValue)

        Return New Uri(NewURI, UriKind.Relative)

    End Function

    ' Return a parsed Movie Card URI.
    Private Function GetMovieCardUri(ByVal uri As String) As Uri

        ' Extract parameter values from URI.
        Dim MovieNameValue As String = GetURIParameterValue("MovieName=", uri)
        Dim CategoryValue As String = GetURIParameterValue("Category=", uri)

        ' Create new URI.
        Dim NewURI As String = String.Format("/{0}?MovieName={1}&Category={2}", TargetPageName, MovieNameValue, CategoryValue)

        Return New Uri(NewURI, UriKind.Relative)

    End Function


    ' This method extracts the string values that correspond to parameters in an App Connect URI.
    Private Function GetURIParameterValue(ByVal parameteridentifier As String, ByVal uri As String) As String

        Dim tempValue As String = ""

        ' If the parameter exists in the string, extract the corresonding parameter value.
        If uri.Contains(parameteridentifier) Then

            Dim subUri As String

            ' Extract the characters that contain and follow the parameter identifier.
            subUri = uri.Substring(uri.LastIndexOf(parameteridentifier))

            ' Remove the parameter identifier from the substring.
            subUri = subUri.Replace(parameteridentifier, "")

            ' Obtain the position of the next parameter in the substring.
            Dim nextParameterPosition As Integer = FindNextParameter(subUri)


            If nextParameterPosition < Integer.MaxValue Then

                ' Remove the characters that contain and follow the next parameter.
                tempValue = subUri.Substring(0, nextParameterPosition)

            Else

                ' No more parameters follow in the string. 
                tempValue = subUri

            End If

            ' Encode the parameter values to help prevent issues in the URI.
            tempValue = HttpUtility.UrlEncode(tempValue)

        End If

        Return tempValue

    End Function

    ' Returns the string position of the next App Connect URI parameter, if applicable.
    Private Function FindNextParameter(ByVal subUri As String) As Integer

        Dim lowestPosition As Integer = Integer.MaxValue
        Dim tempPosition As Integer

        tempPosition = subUri.IndexOf("&ProductName")
        If (tempPosition > -1) AndAlso (tempPosition < lowestPosition) Then
            lowestPosition = tempPosition
        End If

        tempPosition = subUri.IndexOf("&Category")
        If (tempPosition > -1) AndAlso (tempPosition < lowestPosition) Then
            lowestPosition = tempPosition
        End If

        tempPosition = subUri.IndexOf("&PlaceName")
        If (tempPosition > -1) AndAlso (tempPosition < lowestPosition) Then
            lowestPosition = tempPosition
        End If

        tempPosition = subUri.IndexOf("?PlaceName")
        If (tempPosition > -1) AndAlso (tempPosition < lowestPosition) Then
            lowestPosition = tempPosition
        End If

        tempPosition = subUri.IndexOf("&PlaceLatitude")
        If (tempPosition > -1) AndAlso (tempPosition < lowestPosition) Then
            lowestPosition = tempPosition
        End If

        tempPosition = subUri.IndexOf("&PlaceLongitude")
        If (tempPosition > -1) AndAlso (tempPosition < lowestPosition) Then
            lowestPosition = tempPosition
        End If

        tempPosition = subUri.IndexOf("&PlaceAddress")
        If (tempPosition > -1) AndAlso (tempPosition < lowestPosition) Then
            lowestPosition = tempPosition
        End If

        tempPosition = subUri.IndexOf("&MovieName")
        If (tempPosition > -1) AndAlso (tempPosition < lowestPosition) Then
            lowestPosition = tempPosition
        End If

        Return lowestPosition

    End Function

End Class
