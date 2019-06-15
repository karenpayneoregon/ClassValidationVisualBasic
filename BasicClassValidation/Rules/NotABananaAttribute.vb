Imports System.ComponentModel.DataAnnotations

Namespace Rules

    <AttributeUsage(AttributeTargets.Property, AllowMultiple:=False, Inherited:=False)>
    Public Class NotABananaAttribute
        Inherits ValidationAttribute

        Public Overrides Function IsValid(value As Object) As Boolean

            Dim inputValue = TryCast(value, String)
            Dim isValidResult = True

            If Not String.IsNullOrEmpty(inputValue) Then
                isValidResult = inputValue.ToUpperInvariant() <> "BANANA"
            End If

            Return isValidResult

        End Function
    End Class
End Namespace