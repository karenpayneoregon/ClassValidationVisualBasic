Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
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
        ''' <summary>
        ''' Simple demonstration showing how to interrogate the formatting of a property
        ''' in this case Price. Note this is to be considered fragile since the property name
        ''' is in a string meaning if the property name changes the code below will throw a
        ''' runtime exception.
        ''' 
        ''' What makes this work
        ''' DisplayFormat(DataFormatString:="{0:c}")
        ''' which declared on price property 
        ''' </summary>
        Public Sub ShowPriceFormat()

            Dim movie As New Movie With {.Title = "Black Tide", .Genre = "Adventure", .Price = 1.45D}

            Dim prop As PropertyInfo = GetType(Movie).GetProperty("Price")

            Dim attribute = CType(prop.GetCustomAttributes(GetType(DisplayFormatAttribute), True).
                    FirstOrDefault(), DisplayFormatAttribute)

            If attribute IsNot Nothing Then
                Console.WriteLine(attribute.DataFormatString, movie.Price)
            End If

        End Sub
    End Class
End Namespace