Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class LoginForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UserNameTextBox = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.PasswordTextBox = New System.Windows.Forms.TextBox()
            Me.PasswordConfirmTextBox = New System.Windows.Forms.TextBox()
            Me.LogInButton = New System.Windows.Forms.Button()
            Me.EntryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(51, 34)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "User name"
            '
            'UserNameTextBox
            '
            Me.UserNameTextBox.Location = New System.Drawing.Point(115, 34)
            Me.UserNameTextBox.Name = "UserNameTextBox"
            Me.UserNameTextBox.Size = New System.Drawing.Size(200, 20)
            Me.UserNameTextBox.TabIndex = 1
            Me.UserNameTextBox.Text = "karenpayneFromOregon"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(56, 71)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(53, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Password"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(19, 107)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(90, 13)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Confirm password"
            '
            'PasswordTextBox
            '
            Me.PasswordTextBox.Location = New System.Drawing.Point(115, 71)
            Me.PasswordTextBox.Name = "PasswordTextBox"
            Me.PasswordTextBox.Size = New System.Drawing.Size(200, 20)
            Me.PasswordTextBox.TabIndex = 4
            Me.PasswordTextBox.Text = "pass"
            '
            'PasswordConfirmTextBox
            '
            Me.PasswordConfirmTextBox.Location = New System.Drawing.Point(115, 107)
            Me.PasswordConfirmTextBox.Name = "PasswordConfirmTextBox"
            Me.PasswordConfirmTextBox.Size = New System.Drawing.Size(200, 20)
            Me.PasswordConfirmTextBox.TabIndex = 5
            Me.PasswordConfirmTextBox.Text = "pass"
            '
            'LogInButton
            '
            Me.LogInButton.Location = New System.Drawing.Point(115, 184)
            Me.LogInButton.Name = "LogInButton"
            Me.LogInButton.Size = New System.Drawing.Size(185, 23)
            Me.LogInButton.TabIndex = 6
            Me.LogInButton.Text = "Log in"
            Me.LogInButton.UseVisualStyleBackColor = True
            '
            'EntryDateDateTimePicker
            '
            Me.EntryDateDateTimePicker.Location = New System.Drawing.Point(115, 142)
            Me.EntryDateDateTimePicker.Name = "EntryDateDateTimePicker"
            Me.EntryDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
            Me.EntryDateDateTimePicker.TabIndex = 7
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(51, 148)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 13)
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "Entry date"
            '
            'LoginForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(366, 229)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.EntryDateDateTimePicker)
            Me.Controls.Add(Me.LogInButton)
            Me.Controls.Add(Me.PasswordConfirmTextBox)
            Me.Controls.Add(Me.PasswordTextBox)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.UserNameTextBox)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "LoginForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Login validation example"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents UserNameTextBox As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents PasswordTextBox As TextBox
        Friend WithEvents PasswordConfirmTextBox As TextBox
        Friend WithEvents LogInButton As Button
        Friend WithEvents EntryDateDateTimePicker As DateTimePicker
        Friend WithEvents Label4 As Label
    End Class
End Namespace