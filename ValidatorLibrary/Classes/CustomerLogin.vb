﻿Imports System.ComponentModel.DataAnnotations

Namespace Classes
    Public Class CustomerLogin

        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        <MaxLength(12, ErrorMessage:="The {0} can not have more than {1} characters")>
        Public Property Name() As String

        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        <StringLength(12, MinimumLength:=6)>
        Public Property Password() As String

        <Compare("Password", ErrorMessage:="Passwords do not match, please try again")>
        <StringLength(12, MinimumLength:=6)>
        Public Property PasswordConfirmation() As String

    End Class
End Namespace