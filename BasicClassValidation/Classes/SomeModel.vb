''' <summary>
''' Demonstrates validating a date, in this case the date is greater than today.
''' This is done via a customer data attribute class <see cref="MyDateAttribute"/>
''' </summary>
Public Class SomeModel
    <MyDate(ErrorMessage:="Invalid date")>
    Public Property DateOfBirth() As Date
End Class