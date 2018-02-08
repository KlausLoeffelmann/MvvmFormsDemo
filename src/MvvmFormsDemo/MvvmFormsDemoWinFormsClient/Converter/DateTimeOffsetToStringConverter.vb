Imports System.Globalization
Imports System.Windows.Data

Public Class NullableDateTimeOffsetToStringConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        If value Is Nothing Then
            Return Nothing
        Else
            Return DirectCast(value, DateTimeOffset).ToString("yyyy-mm-dd")
        End If
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        If value Is Nothing Then
            Return Nothing
        Else
            Return DateTimeOffset.Parse(value.ToString)
        End If
    End Function
End Class
