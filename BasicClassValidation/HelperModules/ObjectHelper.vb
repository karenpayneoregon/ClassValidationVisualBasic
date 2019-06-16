Namespace HelperModules
    Public Module ObjectHelper
        Public Function IsList(sender As Object) As Boolean
            If sender Is Nothing Then
                Return False
            End If
            Return TypeOf sender Is IList AndAlso
                   sender.GetType().IsGenericType AndAlso
                   sender.GetType().GetGenericTypeDefinition().IsAssignableFrom(GetType(List(Of )))
        End Function
    End Module
End Namespace