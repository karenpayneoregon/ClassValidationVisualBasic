Imports System.ComponentModel.DataAnnotations

Namespace Classes

    Public Class Movie
        Public Property Id As Integer

        <StringLength(60, MinimumLength:=3)>
        Public Property Title As String

        <DataType(DataType.Date)>
        Public Property ReleaseDate As DateTime

        <RegularExpression("^[A-Z]+[a-zA-Z''-'\s]*$")>
        <Required>
        <StringLength(30)>
        Public Property Genre As String

        <DataType(DataType.Currency)>
        <DisplayFormat(DataFormatString:="{0:c}")>
        <Required(ErrorMessage:="Price is Required"),
            Range(10, 100,
                  ErrorMessage:="{0} must be between {1} and {2} dollars.")>
        Public Property Price As Decimal

        <RegularExpression("^[A-Z]+[a-zA-Z''-'\s]*$")>
        <StringLength(4)>
        Public Property Rating As String
    End Class
End Namespace