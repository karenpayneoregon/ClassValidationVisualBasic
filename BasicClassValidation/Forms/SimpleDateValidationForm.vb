Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.Validators

Public Class SimpleDateValidationForm
    Private mSelectedDate As Date
    Public ReadOnly Property SelectedDate() As Date
        Get
            Return mSelectedDate
        End Get
    End Property
    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click

        Dim result As New SomeModel With {.DateOfBirth = MonthCalendar1.SelectionRange.Start}
        Dim validationResult As EntityValidationResult = ValidationHelper.ValidateEntity(result)

        If validationResult.HasError Then
            MessageBox.Show(validationResult.ErrorMessageList())
        Else
            mSelectedDate = result.DateOfBirth
            DialogResult = DialogResult.OK
        End If

    End Sub
End Class