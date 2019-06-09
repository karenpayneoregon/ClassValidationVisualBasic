Imports BasicClassValidation.Forms

Public Class MainForm
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
End Class