﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ValidatePersonButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContactTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.daysComboBox = New System.Windows.Forms.ComboBox()
        Me.yearsComboBox = New System.Windows.Forms.ComboBox()
        Me.birthDateMonthComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ValidatePersonButton
        '
        Me.ValidatePersonButton.Location = New System.Drawing.Point(93, 195)
        Me.ValidatePersonButton.Name = "ValidatePersonButton"
        Me.ValidatePersonButton.Size = New System.Drawing.Size(163, 23)
        Me.ValidatePersonButton.TabIndex = 0
        Me.ValidatePersonButton.Text = "Validate Person"
        Me.ValidatePersonButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First name"
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(111, 35)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.firstNameTextBox.TabIndex = 2
        Me.firstNameTextBox.Text = "Karen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last name"
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(111, 73)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.lastNameTextBox.TabIndex = 4
        Me.lastNameTextBox.Text = "Payne"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Birth date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ContactTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.daysComboBox)
        Me.GroupBox1.Controls.Add(Me.yearsComboBox)
        Me.GroupBox1.Controls.Add(Me.birthDateMonthComboBox)
        Me.GroupBox1.Controls.Add(Me.ValidatePersonButton)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.firstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 237)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Person"
        '
        'ContactTypeComboBox
        '
        Me.ContactTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ContactTypeComboBox.FormattingEnabled = True
        Me.ContactTypeComboBox.Location = New System.Drawing.Point(111, 150)
        Me.ContactTypeComboBox.Name = "ContactTypeComboBox"
        Me.ContactTypeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ContactTypeComboBox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contact type"
        '
        'daysComboBox
        '
        Me.daysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.daysComboBox.FormattingEnabled = True
        Me.daysComboBox.Location = New System.Drawing.Point(170, 112)
        Me.daysComboBox.Name = "daysComboBox"
        Me.daysComboBox.Size = New System.Drawing.Size(50, 21)
        Me.daysComboBox.TabIndex = 11
        '
        'yearsComboBox
        '
        Me.yearsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearsComboBox.FormattingEnabled = True
        Me.yearsComboBox.Location = New System.Drawing.Point(232, 112)
        Me.yearsComboBox.Name = "yearsComboBox"
        Me.yearsComboBox.Size = New System.Drawing.Size(79, 21)
        Me.yearsComboBox.TabIndex = 10
        '
        'birthDateMonthComboBox
        '
        Me.birthDateMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.birthDateMonthComboBox.FormattingEnabled = True
        Me.birthDateMonthComboBox.Location = New System.Drawing.Point(111, 112)
        Me.birthDateMonthComboBox.Name = "birthDateMonthComboBox"
        Me.birthDateMonthComboBox.Size = New System.Drawing.Size(50, 21)
        Me.birthDateMonthComboBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(244, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 299)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ValidatePersonButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents birthDateMonthComboBox As ComboBox
    Friend WithEvents yearsComboBox As ComboBox
    Friend WithEvents daysComboBox As ComboBox
    Friend WithEvents ContactTypeComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
