Imports BasicClassValidation.Classes
Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.Validators

Namespace MockData
    Public Class MovieExample
        ''' <summary>
        ''' Demonstrates invalid range where a valid range is between in this case 10 and 100 dollars
        ''' </summary>
        ''' <returns></returns>
        Public Function CreateBadMovie() As String
            Dim result As String = ""

            Dim movie As New Movie With {.Title = "Black Tide", .Genre = "Adventure", .Price = 1.45D, .Rating = "Good"}
            Dim validationResult As EntityValidationResult = ValidationHelper.ValidateEntity(movie)

            If validationResult.HasError Then
                result = validationResult.ErrorMessageList()
            End If

            Return result

        End Function
    End Class
End Namespace