Imports System.ComponentModel.DataAnnotations
Imports BasicClassValidation.Rules

Namespace Classes
    Public Class Contact
        <RegularExpression("^.{3,}$", ErrorMessage:="{0} Minimum 3 characters required")>
        <Required(ErrorMessage:="{0} Required")>
        <StringLength(30, MinimumLength:=3, ErrorMessage:="Invalid {0}")>
        Public Property FirstName() As String

        <RegularExpression("^.{3,}$", ErrorMessage:="{0} Minimum 3 characters required")>
        <Required(ErrorMessage:="{0} Required")>
        <StringLength(30, MinimumLength:=3, ErrorMessage:="Invalid {0}")>
        Public Property LastName() As String

        Public ReadOnly Property FullName() As String
            Get
                Return $"{FirstName} {LastName}"
            End Get
        End Property

        <Required(ErrorMessage:="Please Enter Email Address")>
        <RegularExpression("^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage:="Please Enter Correct {0} Email Address")>
        Public Property BusinessEmail() As String

        ''' <summary>
        ''' Personal Email address
        ''' </summary>
        <Required(ErrorMessage:="Please enter your {0} email address")>
        <DataType(DataType.EmailAddress)>
        <MaxLength(70)>
        <RegularExpression("[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage:="Please enter correct {0} email")>
        Public Property PersonalEmail() As String

        ''' <summary>
        ''' Phone number
        ''' </summary>
        ''' <remarks>
        ''' Data annotations for phone can be simple as show below
        ''' [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        ''' But in this case there is a custom rule to keep phone number to 10 characters
        ''' </remarks>
        <Required(ErrorMessage:="Mobile no. is required")>
        <CheckPhoneValidation(ErrorMessage:="{0} must be no longer than 10")>
        Public Property Phone() As String

        Public Overrides Function ToString() As String
            Return $"{FirstName} {LastName} '{BusinessEmail}'"
        End Function
    End Class
End Namespace
