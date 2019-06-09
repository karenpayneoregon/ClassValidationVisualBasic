Imports System.ComponentModel.DataAnnotations
''' <summary>
''' Use to provide validation on a date "MyDate" in <see cref="SomeModel"/>
''' </summary>
Public Class MyDateAttribute
    Inherits ValidationAttribute
    ''' <summary>
    ''' Validate date is greater than today. Of course this can change to
    ''' match your date rule.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Public Overrides Function IsValid(value As Object) As Boolean
        Dim d As Date = Convert.ToDateTime(value)
        Return d >= Date.Now
    End Function
End Class