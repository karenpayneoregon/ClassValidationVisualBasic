Imports System.ComponentModel.DataAnnotations

Namespace Rules
    ''' <summary>
    ''' Provides custom rule for phone number rather than using [Phone]
    ''' </summary>
    Public Class CheckPhoneValidationAttribute
        Inherits ValidationAttribute

        Public Overrides Function IsValid(value As Object) As Boolean
            If value Is Nothing Then
                Return False
            End If

            Dim convertedValue As String = value.ToString()

            Return (Not String.IsNullOrWhiteSpace(convertedValue)) AndAlso
                   IsDigitsOnly(convertedValue) AndAlso convertedValue.Length <= 10

        End Function
        Private Function IsDigitsOnly(str As String) As Boolean

            For Each c In str
                If c < "0"c OrElse c > "9"c Then
                    Return False
                End If
            Next

            Return True

        End Function
    End Class
End Namespace