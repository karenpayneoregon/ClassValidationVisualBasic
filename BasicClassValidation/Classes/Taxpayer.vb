Imports System.ComponentModel.DataAnnotations

Namespace Classes
    Public Class Taxpayer
        <RegularExpression("^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage:="Invalid Social Security Number")>
        <Required(ErrorMessage:="Contact {0} is required"), DataType(DataType.Text)>
        Public Property SSN() As String
        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        Public Property FirstName() As String
        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        Public Property LastName() As String
    End Class
End Namespace