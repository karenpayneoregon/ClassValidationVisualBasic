Imports BasicClassValidation.Classes
Imports BasicClassValidation.Enumerations
Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.Validators

Namespace Forms

    Public Class ListAndEnmForm
        Private Sub ListAndEnmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CategoryComboBox.Items.AddRange([Enum].GetNames(GetType(BookCategory)))
            CategoryComboBox.SelectedIndex = 0
        End Sub

        Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click

            Dim category = DirectCast([Enum].Parse(GetType(BookCategory), CategoryComboBox.Text), BookCategory)

            Dim book = New Book() With
                    {
                    .Title = BookTitleTextBox.Text,
                    .ISBN = IsbnTextBox.Text,
                    .Category = If(category = BookCategory.Select, Nothing, category),
                    .NotesList = TextBox1.Lines.ToList()
                    }

            Dim validationResult = ValidationHelper.ValidateEntity(book)

            If validationResult.HasError Then
                MessageBox.Show(validationResult.ErrorMessageList())
            Else
                DialogResult = DialogResult.OK
            End If

        End Sub
    End Class
End Namespace