Imports System.ComponentModel.DataAnnotations

Namespace Rules
    ''' <summary>
    ''' Handles check for null date
    ''' </summary>
    Public Class BirthDateValidation
        Public Shared Function BirthDateValidate(senderDate As Date?) As ValidationResult

            Return If(senderDate.Value = Date.MinValue,
                      New ValidationResult("BirthDate required"),
                      ValidationResult.Success)
        End Function
    End Class
End Namespace