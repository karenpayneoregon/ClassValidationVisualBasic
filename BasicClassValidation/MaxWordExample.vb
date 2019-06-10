Imports BasicClassValidation.Rules

Public Class MaxWordExample
    <MaxWordAttributes(5, ErrorMessage:="Too many words in{0}")>
    Public Property Street() As String
End Class
