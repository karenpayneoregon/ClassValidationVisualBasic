Imports System.ComponentModel.DataAnnotations

Namespace Rules
    Public Class CustomerWeekendValidation
        Public Shared Function WeekendValidate(senderDate As Date) As ValidationResult
            Return If(senderDate.DayOfWeek = DayOfWeek.Saturday OrElse senderDate.DayOfWeek = DayOfWeek.Sunday,
                      New ValidationResult("The weekend days are not valid"), ValidationResult.Success)
        End Function
    End Class
End Namespace