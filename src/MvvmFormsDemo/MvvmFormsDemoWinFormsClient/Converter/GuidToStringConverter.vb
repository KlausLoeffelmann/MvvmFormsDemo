Imports System.Globalization
Imports System.Windows.Data

Public Class GuidToStringConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Return value?.ToString
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        If value Is Nothing Then
            Return Guid.Empty
        Else
            Return Guid.Parse(value.ToString)
        End If
    End Function
End Class
