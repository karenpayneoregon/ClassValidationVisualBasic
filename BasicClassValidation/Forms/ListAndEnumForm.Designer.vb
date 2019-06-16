Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ListAndEnmForm
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
            Me.BookTitleTextBox = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.IsbnTextBox = New System.Windows.Forms.TextBox()
            Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.ValidateButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(45, 30)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(27, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Title"
            '
            'BookTitleTextBox
            '
            Me.BookTitleTextBox.Location = New System.Drawing.Point(115, 27)
            Me.BookTitleTextBox.Name = "BookTitleTextBox"
            Me.BookTitleTextBox.Size = New System.Drawing.Size(341, 20)
            Me.BookTitleTextBox.TabIndex = 1
            Me.BookTitleTextBox.Text = "One Giant Leap: The Impossible Mission That Flew Us to the Moon"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(45, 70)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(32, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "ISBN"
            '
            'IsbnTextBox
            '
            Me.IsbnTextBox.Location = New System.Drawing.Point(115, 67)
            Me.IsbnTextBox.Name = "IsbnTextBox"
            Me.IsbnTextBox.Size = New System.Drawing.Size(141, 20)
            Me.IsbnTextBox.TabIndex = 3
            Me.IsbnTextBox.Text = "1501106295"
            '
            'CategoryComboBox
            '
            Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CategoryComboBox.FormattingEnabled = True
            Me.CategoryComboBox.Location = New System.Drawing.Point(115, 106)
            Me.CategoryComboBox.Name = "CategoryComboBox"
            Me.CategoryComboBox.Size = New System.Drawing.Size(141, 21)
            Me.CategoryComboBox.TabIndex = 4
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(28, 114)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(49, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Category"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(28, 140)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(35, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Notes"
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(115, 137)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(141, 38)
            Me.TextBox1.TabIndex = 7
            Me.TextBox1.Text = "One" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Two" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Three"
            '
            'ValidateButton
            '
            Me.ValidateButton.Location = New System.Drawing.Point(115, 191)
            Me.ValidateButton.Name = "ValidateButton"
            Me.ValidateButton.Size = New System.Drawing.Size(149, 23)
            Me.ValidateButton.TabIndex = 8
            Me.ValidateButton.Text = "Validate"
            Me.ValidateButton.UseVisualStyleBackColor = True
            '
            'ListAndEnmForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(503, 236)
            Me.Controls.Add(Me.ValidateButton)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.CategoryComboBox)
            Me.Controls.Add(Me.IsbnTextBox)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.BookTitleTextBox)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "ListAndEnmForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Is in List And Enm"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents BookTitleTextBox As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents IsbnTextBox As TextBox
        Friend WithEvents CategoryComboBox As ComboBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents ValidateButton As Button
    End Class
End Namespace