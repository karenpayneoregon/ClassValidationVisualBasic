Imports BasicClassValidation.Classes
Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.Validators

Namespace MockData
    Public Class StudentExample
        ''' <summary>
        ''' Demonstrates validating against an instance of student where
        ''' email addresses are not the same.
        ''' </summary>
        ''' <returns></returns>
        Public Function CreateBadStudent() As String
            Dim result As String = ""
            Dim student As New StudentModel With
                    {
                    .FirstName = "Karen",
                    .LastName = "Payne",
                    .Email = "kp1@gmail.com",
                    .ConfirmEmail = "kp@gmail.com",
                    .Age = 20
                    }

            Dim validationResult As EntityValidationResult = ValidationHelper.ValidateEntity(student)

            If validationResult.HasError Then
                result = validationResult.ErrorMessageList()
            End If

            Return result

        End Function
        ''' <summary>
        ''' Used to show validation works against a student with proper data assigned to it's properties
        ''' </summary>
        ''' <returns></returns>
        Public Function CreateValidStudent() As String
            Dim result As String = ""
            Dim student As New StudentModel With
                    {
                    .FirstName = "Karen",
                    .LastName = "Payne",
                    .Email = "kp@gmail.com",
                    .ConfirmEmail = "kp@gmail.com",
                    .Age = 20
                    }

            Dim validationResult As EntityValidationResult = ValidationHelper.ValidateEntity(student)

            If validationResult.HasError Then
                result = validationResult.ErrorMessageList()
            End If

            Return result

        End Function
    End Class
End Namespace