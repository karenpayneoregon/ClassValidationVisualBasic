Imports System.ComponentModel.DataAnnotations
Imports BasicClassValidation.HelperModules
Namespace Rules
    Public Class ListHasElements
        Inherits ValidationAttribute

        Public Overrides Function IsValid(sender As Object) As Boolean

            If sender Is Nothing Then
                Return False
            End If

            If IsList(sender) Then
                Dim result = CType(sender, IEnumerable).Cast(Of Object)().ToList()
                Return result.Any()
            Else
                Return False
            End If

        End Function
    End Class
End Namespace