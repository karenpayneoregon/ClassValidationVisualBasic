Imports BasicClassValidation.Classes
Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.Validators

Namespace Forms

    Public Class LoginForm
        Private Sub LogInButton_Click(sender As Object, e As EventArgs) _
            Handles LogInButton.Click

            Dim login As New CustomerLogin With
                    {
                        .Name = UserNameTextBox.Text,
                        .Password = PasswordTextBox.Text,
                        .PasswordConfirmation = PasswordConfirmTextBox.Text,
                        .EntryDate = EntryDateDateTimePicker.Value
                    }

            Dim validationResult As EntityValidationResult = ValidationHelper.ValidateEntity(login)

            If validationResult.HasError Then
                MessageBox.Show(validationResult.ErrorMessageList())
            Else
                DialogResult = DialogResult.OK
            End If

        End Sub
    End Class
End Namespace