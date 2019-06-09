Imports BasicClassValidation.Classes
Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.Validators

Namespace Forms
    Public Class SocialSecurityForm
        Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
            '
            ' Note that many people like to use SSN format 111-11-1111 so we remove dashes.
            ' Alternately a mask may be used on the TextBox.
            '
            Dim taxpayer As New Taxpayer With
                    {
                        .FirstName = FirstNameTextBox.Text,
                        .LastName = LastNameTextBox.Text,
                        .SSN = SsnTextBox.Text.Replace("-", "")
                    }

            Dim validationResult As EntityValidationResult = ValidationHelper.ValidateEntity(taxpayer)

            If validationResult.HasError Then
                MessageBox.Show(validationResult.ErrorMessageList())
            Else
                DialogResult = DialogResult.OK
            End If

        End Sub
    End Class
End Namespace