Imports BasicClassValidation.Rules

Namespace Classes

    Public Class Fruit
        <NotABanana(ErrorMessage:="Bananas are not allowed.")>
        Public Property FavoriteFruit() As String
    End Class
End Namespace