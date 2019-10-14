Module UtilityBelt
    ''' <summary>
    ''' Gets a brush from web like rgb color string (#ffffff). Optionally pass a double for Opacity as the second arg.
    ''' </summary>
    ''' <param name="strRGB"></param>
    ''' <param name="dblOpacity"></param>
    ''' <returns>SolidColorBrush</returns>
    Public Function BrushFromRGB(strRGB As String, Optional dblOpacity As Double = 1.0) As SolidColorBrush
        If dblOpacity = 1.0 Then
            Return New BrushConverter().ConvertFrom(strRGB)
        Else
            Dim mBrush = New BrushConverter().ConvertFrom(strRGB)
            mBrush.Opacity = dblOpacity
            Return mBrush
        End If
    End Function
End Module
