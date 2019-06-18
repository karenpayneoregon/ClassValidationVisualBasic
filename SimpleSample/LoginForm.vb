Imports ValidatorLibrary.Classes
Imports ValidatorLibrary.LanguageExtensions
Imports ValidatorLibrary.Validators

''' <summary>
''' Very simple demo for using validation
''' </summary>
Public Class LoginForm
    Private retryCount As Integer = 0
    Private Sub LogInButton_Click(sender As Object, e As EventArgs) _
        Handles LogInButton.Click

        Dim login As New CustomerLogin With
                {
                    .Name = UserNameTextBox.Text,
                    .Password = PasswordTextBox.Text,
                    .PasswordConfirmation = PasswordConfirmTextBox.Text
                }

        Dim validationResult As EntityValidationResult = ValidationHelper.ValidateEntity(login)

        If validationResult.HasError Then
            If retryCount >= 3 Then
                MessageBox.Show("Guards toss them out!")
                Close()
            End If
            MessageBox.Show(validationResult.ErrorMessageList())
            retryCount += 1
        Else
            Dim f As New MainForm(login.Name)
            f.Show()
            Hide()
        End If

    End Sub
End Class