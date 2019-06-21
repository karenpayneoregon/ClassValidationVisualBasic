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
        ''' <summary>
        ''' Set date time picker to a Saturday so it breaks the weekend rule set on EntryDate property.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            EntryDateDateTimePicker.Value = Now.AddDays(-(Now.DayOfWeek + 1))
        End Sub
    End Class
End Namespace