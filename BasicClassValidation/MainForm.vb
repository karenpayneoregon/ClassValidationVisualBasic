Imports BasicClassValidation.Classes
Imports BasicClassValidation.Forms
Imports BasicClassValidation.LanguageExtensions
Imports BasicClassValidation.MockData
Imports BasicClassValidation.Validators

Public Class MainForm
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim f As New LoginForm
        Try
            If f.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Proceed with accessing the program")
            Else
                MessageBox.Show("Handle incorrect login")
            End If
        Finally
            f.Dispose()
        End Try

    End Sub

    Private Sub SocialSecurityLoginButton_Click(sender As Object, e As EventArgs) Handles SocialSecurityLoginButton.Click
        Dim f As New SocialSecurityForm
        Try
            If f.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Proceed with accessing the program")
            Else
                MessageBox.Show("Handle incorrect login")
            End If
        Finally
            f.Dispose()
        End Try

    End Sub
    Private Sub ValidateSingleDateButton_Click(sender As Object, e As EventArgs) Handles ValidateSingleDateButton.Click
        Dim f As New SimpleDateValidationForm
        Try
            If f.ShowDialog() = DialogResult.OK Then
                MessageBox.Show($"Date is valid {f.SelectedDate.ToString("MM/dd/yyyy")}")
            Else
                MessageBox.Show("Invalid date")
            End If
        Finally
            f.Dispose()
        End Try

    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
    Private Sub InvalidDecimalRangeButton_Click(sender As Object, e As EventArgs) Handles InvalidDecimalRangeButton.Click
        Dim movie As New MovieExample

        Dim movieResults = movie.CreateBadMovie()

        If String.IsNullOrWhiteSpace(movieResults) Then
            MessageBox.Show("Range is valid")
        Else
            MessageBox.Show($"Errors{Environment.NewLine}{movieResults}")
        End If

    End Sub
    Private Sub ValidateStudentModelButton_Click(sender As Object, e As EventArgs) Handles ValidateStudentModelButton.Click
        Dim ops As New StudentExample

        Dim studentResults = ops.CreateValidStudent()

        If String.IsNullOrWhiteSpace(studentResults) Then
            MessageBox.Show("Valid student")
        Else
            MessageBox.Show($"Errors{Environment.NewLine}{studentResults}")
        End If

        studentResults = ops.CreateBadStudent()
        If String.IsNullOrWhiteSpace(studentResults) Then
            MessageBox.Show("Valid student")
        Else
            MessageBox.Show($"Errors{Environment.NewLine}{studentResults}")
        End If

    End Sub

    Private Sub ValidateIsInListAndEnmButton_Click(sender As Object, e As EventArgs) Handles ValidateIsInListAndEnmButton.Click
        Dim f As New ListAndEnmForm
        If f.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("Book entered")
        Else
            MessageBox.Show("Book not entered")
        End If
    End Sub
End Class
'