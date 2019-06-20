Imports System.ComponentModel.DataAnnotations

Namespace Rules
    ''' <summary>
    ''' Checks for if a date falls on a weekend.
    ''' </summary>
    <Obsolete("This method is class, use WeekendDateNotPermittedAttribute instead.")>
    Public Class CustomerWeekendValidation
        Public Shared Function WeekendValidate(senderDate As Date) As ValidationResult
            Return If(senderDate.DayOfWeek = DayOfWeek.Saturday OrElse senderDate.DayOfWeek = DayOfWeek.Sunday,
                      New ValidationResult("The weekend days are not valid"),
                      ValidationResult.Success)
        End Function
    End Class
    ''' <summary>
    ''' Disallow date to be a weekend date
    ''' </summary>
    Public Class WeekendDateNotPermittedAttribute
        Inherits ValidationAttribute

        Public Overrides Function IsValid(ByVal senderDate As Object) As Boolean
            Dim d As DateTime = Convert.ToDateTime(senderDate)
            If d.DayOfWeek = DayOfWeek.Saturday OrElse d.DayOfWeek = DayOfWeek.Sunday Then
                Return False
            Else
                Return True
            End If
        End Function
    End Class

End Namespace