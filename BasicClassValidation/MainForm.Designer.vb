<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.SocialSecurityLoginButton = New System.Windows.Forms.Button()
        Me.ValidateSingleDateButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InvalidDecimalRangeButton = New System.Windows.Forms.Button()
        Me.ValidateStudentModelButton = New System.Windows.Forms.Button()
        Me.ValidateIsInListAndEnmButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(23, 26)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(231, 23)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.Text = "Generic Log in"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'SocialSecurityLoginButton
        '
        Me.SocialSecurityLoginButton.Location = New System.Drawing.Point(23, 55)
        Me.SocialSecurityLoginButton.Name = "SocialSecurityLoginButton"
        Me.SocialSecurityLoginButton.Size = New System.Drawing.Size(231, 23)
        Me.SocialSecurityLoginButton.TabIndex = 1
        Me.SocialSecurityLoginButton.Text = "Social security Log in"
        Me.SocialSecurityLoginButton.UseVisualStyleBackColor = True
        '
        'ValidateSingleDateButton
        '
        Me.ValidateSingleDateButton.Location = New System.Drawing.Point(23, 84)
        Me.ValidateSingleDateButton.Name = "ValidateSingleDateButton"
        Me.ValidateSingleDateButton.Size = New System.Drawing.Size(231, 23)
        Me.ValidateSingleDateButton.TabIndex = 3
        Me.ValidateSingleDateButton.Text = "Validate single date"
        Me.ValidateSingleDateButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InvalidDecimalRangeButton
        '
        Me.InvalidDecimalRangeButton.Location = New System.Drawing.Point(23, 113)
        Me.InvalidDecimalRangeButton.Name = "InvalidDecimalRangeButton"
        Me.InvalidDecimalRangeButton.Size = New System.Drawing.Size(231, 23)
        Me.InvalidDecimalRangeButton.TabIndex = 5
        Me.InvalidDecimalRangeButton.Text = "Invalid Decimal range"
        Me.InvalidDecimalRangeButton.UseVisualStyleBackColor = True
        '
        'ValidateStudentModelButton
        '
        Me.ValidateStudentModelButton.Location = New System.Drawing.Point(23, 142)
        Me.ValidateStudentModelButton.Name = "ValidateStudentModelButton"
        Me.ValidateStudentModelButton.Size = New System.Drawing.Size(231, 23)
        Me.ValidateStudentModelButton.TabIndex = 6
        Me.ValidateStudentModelButton.Text = "Valid Student model"
        Me.ValidateStudentModelButton.UseVisualStyleBackColor = True
        '
        'ValidateIsInListAndEnmButton
        '
        Me.ValidateIsInListAndEnmButton.Location = New System.Drawing.Point(23, 171)
        Me.ValidateIsInListAndEnmButton.Name = "ValidateIsInListAndEnmButton"
        Me.ValidateIsInListAndEnmButton.Size = New System.Drawing.Size(231, 23)
        Me.ValidateIsInListAndEnmButton.TabIndex = 7
        Me.ValidateIsInListAndEnmButton.Text = "Validate Book"
        Me.ValidateIsInListAndEnmButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 264)
        Me.Controls.Add(Me.ValidateIsInListAndEnmButton)
        Me.Controls.Add(Me.ValidateStudentModelButton)
        Me.Controls.Add(Me.InvalidDecimalRangeButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ValidateSingleDateButton)
        Me.Controls.Add(Me.SocialSecurityLoginButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents SocialSecurityLoginButton As Button
    Friend WithEvents ValidateSingleDateButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents InvalidDecimalRangeButton As Button
    Friend WithEvents ValidateStudentModelButton As Button
    Friend WithEvents ValidateIsInListAndEnmButton As Button
End Class
