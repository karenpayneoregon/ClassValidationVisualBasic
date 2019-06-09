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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SocialSecurityLoginButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents SocialSecurityLoginButton As Button
End Class
