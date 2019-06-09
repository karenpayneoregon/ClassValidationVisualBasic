Imports BasicClassValidation.Classes
Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.Validators

Namespace Forms
    Public Class SocialSecurityForm
        Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click

            Dim taxpayer As New Taxpayer With
                    {
                        .FirstName = FirstNameTextBox.Text,
                        .LastName = LastNameTextBox.Text,
                        .SSN = SsnTextBox.Text
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