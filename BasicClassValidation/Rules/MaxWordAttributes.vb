Imports System.ComponentModel.DataAnnotations

Namespace Rules

    Public Class MaxWordAttributes
        Inherits ValidationAttribute

        Private ReadOnly mMaxWords As Integer

        Public Sub New(maxWords As Integer)
            MyBase.New("{0} has to many words.")
            mMaxWords = maxWords
        End Sub
        Protected Overrides Function IsValid(
            value As Object, validationContext As ValidationContext) As ValidationResult

            If value Is Nothing Then
                Return ValidationResult.Success
            End If

            Dim textValue = value.ToString()

            If textValue.Split(" "c).Length <= mMaxWords Then
                Return ValidationResult.Success
            End If

            Dim errorMessage = FormatErrorMessage(validationContext.DisplayName)
            Return New ValidationResult(errorMessage)

        End Function
    End Class
End Namespace