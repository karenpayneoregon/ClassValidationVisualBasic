Imports BasicClassValidation.Classes
Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.Validators

Namespace Forms

    Public Class LoginForm
        Private Sub LogInButton_Click(sender As Object, e As EventArgs) _
            Handles LogInButton.Click

            'Dim controlsToValidate = Descendants(Of Control)().Where(Function(c) c.Tag IsNot Nothing).Select(Function(ctr) New With {.Control = ctr, .Tag = CStr(ctr.Tag)})

            'Descendants(Of TextBox)().ToList().ForEach(Sub(tb) ErrorProvider1.SetError(tb, ""))
            'ErrorProvider1.SetError(EntryDateDateTimePicker, "")

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

                'For Each ec As ErrorContainer In validationResult.ErrorItemList()
                '    Console.WriteLine(ec.PropertyName)
                '    Dim currentItem = controlsToValidate.FirstOrDefault(Function(ctr) ctr.Tag = ec.PropertyName)
                '    Console.WriteLine(currentItem)
                'Next

            Else
                DialogResult = DialogResult.OK
            End If

        End Sub
    End Class
End Namespace