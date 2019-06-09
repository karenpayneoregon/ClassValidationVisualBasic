Imports System.ComponentModel.DataAnnotations

Namespace Classes
    Public Class StudentModel
        Public Property Id() As Integer

        <Required(ErrorMessage:="{0} is Required"),
            StringLength(50, MinimumLength:=3)>
        Public Property FirstName() As String

        <Required(ErrorMessage:="{0} is Required"),
            StringLength(50, MinimumLength:=3)>
        Public Property LastName() As String

        <Required(ErrorMessage:="Email ID is Required"),
            DataType(DataType.EmailAddress),
            MaxLength(50),
            RegularExpression("[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}",
                              ErrorMessage:="Incorrect Email Format")>
        Public Property Email() As String

        <Required(ErrorMessage:="Confirm Email is Required"),
            DataType(DataType.EmailAddress),
            Compare("Email", ErrorMessage:="both email addresses must match.")>
        Public Property ConfirmEmail() As String

        <Required(ErrorMessage:="Age is Required"),
            Range(1, 60, ErrorMessage:="{0} must be between {1}-{2} in years.")>
        Public Property Age() As Integer
    End Class
End Namespace