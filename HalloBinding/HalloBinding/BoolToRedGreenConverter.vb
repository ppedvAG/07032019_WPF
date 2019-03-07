Imports System.Globalization

Public Class BoolToRedGreenConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert

        If CType(value, Boolean) Then
            Return New SolidColorBrush(Colors.Green)
        Else
            Return New SolidColorBrush(Colors.Red)
        End If

    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
