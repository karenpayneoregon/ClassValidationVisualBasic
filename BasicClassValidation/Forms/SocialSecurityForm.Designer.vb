Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SocialSecurityForm
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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.SsnTextBox = New System.Windows.Forms.TextBox()
            Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
            Me.LastNameTextBox = New System.Windows.Forms.TextBox()
            Me.LogInButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(75, 28)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(29, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "SSN"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(49, 56)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(55, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "First name"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(48, 82)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(56, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Last name"
            '
            'SsnTextBox
            '
            Me.SsnTextBox.Location = New System.Drawing.Point(110, 25)
            Me.SsnTextBox.Name = "SsnTextBox"
            Me.SsnTextBox.Size = New System.Drawing.Size(100, 20)
            Me.SsnTextBox.TabIndex = 3
            Me.SsnTextBox.Text = "12345678"
            '
            'FirstNameTextBox
            '
            Me.FirstNameTextBox.Location = New System.Drawing.Point(110, 56)
            Me.FirstNameTextBox.Name = "FirstNameTextBox"
            Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
            Me.FirstNameTextBox.TabIndex = 4
            Me.FirstNameTextBox.Text = "Jim"
            '
            'LastNameTextBox
            '
            Me.LastNameTextBox.Location = New System.Drawing.Point(110, 82)
            Me.LastNameTextBox.Name = "LastNameTextBox"
            Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
            Me.LastNameTextBox.TabIndex = 5
            Me.LastNameTextBox.Text = "Smith"
            '
            'LogInButton
            '
            Me.LogInButton.Location = New System.Drawing.Point(52, 120)
            Me.LogInButton.Name = "LogInButton"
            Me.LogInButton.Size = New System.Drawing.Size(185, 23)
            Me.LogInButton.TabIndex = 7
            Me.LogInButton.Text = "Log in"
            Me.LogInButton.UseVisualStyleBackColor = True
            '
            'SocialSecurityForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(288, 164)
            Me.Controls.Add(Me.LogInButton)
            Me.Controls.Add(Me.LastNameTextBox)
            Me.Controls.Add(Me.FirstNameTextBox)
            Me.Controls.Add(Me.SsnTextBox)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "SocialSecurityForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Social Security validation"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents SsnTextBox As TextBox
        Friend WithEvents FirstNameTextBox As TextBox
        Friend WithEvents LastNameTextBox As TextBox
        Friend WithEvents LogInButton As Button
    End Class
End Namespace