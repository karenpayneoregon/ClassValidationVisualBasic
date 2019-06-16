Imports System.ComponentModel.DataAnnotations
Imports BasicClassValidation.Enumerations
Imports BasicClassValidation.Rules

Namespace Classes
    Public Class Book
        <Required(ErrorMessage:="{0} is required")>
        Public Property Title() As String

        <Required(ErrorMessage:="{0} is required")>
        Public Property ISBN() As String

        <RequiredEnum(ErrorMessage:="{0} is required.")>
        Public Property Category() As BookCategory

        <ListHasElements(ErrorMessage:="{0} must contain at lease one note")>
        Public Property NotesList() As List(Of String)

    End Class
End Namespace