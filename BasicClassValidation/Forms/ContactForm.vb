
Imports BasicClassValidation.Classes
Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.Validators

Namespace Forms
    ''' <summary>
    ''' In this example a ErrorProvider displays a red indicator with
    ''' the error text from the attribute on a property of Contact that
    ''' is invalid.
    ''' 
    ''' Each TextBox has it's tag property set to the property of the
    ''' Contact class e.g. FirstNameTextBox tag is FirstName. There are
    ''' other alternatives to this, for example search for TextBox controls
    ''' excluding TextBox.
    ''' </summary>
    Public Class ContactForm
        Private ReadOnly _bsContacts As New BindingSource()
        Private _dataGridViewSizeDone As Boolean
        Private Sub ValidateSingleContactButton_Click(sender As Object, e As EventArgs) Handles ValidateSingleContactButton.Click
            '
            ' clear errors from error provider
            '
            Descendants(Of TextBox)().ToList().ForEach(Sub(ctr) ErrorProvider1.SetError(ctr, ""))

            Dim contact = New Contact() With {
                        .FirstName = FirstNameTextBox.Text,
                        .LastName = LastNameTextBox.Text,
                        .PersonalEmail = PersonalEmailTextBox.Text,
                        .BusinessEmail = BusinessEmailTextBox.Text,
                        .Phone = PhoneTextBox.Text
                    }

            Dim validationResult = ValidationHelper.ValidateEntity(contact)

            If validationResult.HasError Then

                Dim errorItemList As List(Of ErrorContainer) = validationResult.ErrorItemList()

                Dim controlsToValidate = Descendants(Of TextBox)().
                        Where(Function(c) c.Tag IsNot Nothing).
                        Select(Function(ctr) New With {.Control = ctr, .Tag = CStr(ctr.Tag)})

                '
                ' Iterate errors, set error text via the ErrorProvider component
                '
                For Each ec As ErrorContainer In errorItemList
                    Dim current = controlsToValidate.FirstOrDefault(Function(item) item.Tag = ec.PropertyName)
                    If current IsNot Nothing Then
                        ErrorProvider1.SetError(panel1.Controls.Find($"{ec.PropertyName}TextBox", False)(0), ec.ErrorMessage)
                    End If
                Next
            Else
                _bsContacts.Add(contact)
                If _dataGridViewSizeDone Then
                    Return
                End If

                dataGridView1.ExpandColumns()
                _dataGridViewSizeDone = True
            End If
        End Sub

        Private Sub ContactForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            dataGridView1.DataSource = _bsContacts
        End Sub
    End Class
End Namespace