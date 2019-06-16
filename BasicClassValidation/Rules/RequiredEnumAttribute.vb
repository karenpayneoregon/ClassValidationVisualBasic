Imports System.ComponentModel.DataAnnotations

Namespace Rules
    ''' <summary>
    ''' Validates a property of type Enum is assigned.
    ''' For this to work number the elements from 1 to x,
    ''' do not assign 0 to an element.
    ''' </summary>
    Public Class RequiredEnumAttribute
        Inherits RequiredAttribute

        Public Overrides Function IsValid(ByVal value As Object) As Boolean
            If value Is Nothing Then
                Return False
            End If

            Dim type = value.GetType()
            Return type.IsEnum AndAlso System.Enum.IsDefined(type, value)

        End Function
    End Class
End Namespace