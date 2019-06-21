Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ContactForm
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
            Me.components = New System.ComponentModel.Container()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
            Me.ValidateSingleContactButton = New System.Windows.Forms.Button()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.BusinessEmailTextBox = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.LastNameTextBox = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.PersonalEmailTextBox = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.PhoneTextBox = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dataGridView1
            '
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.Size = New System.Drawing.Size(744, 184)
            Me.dataGridView1.TabIndex = 0
            '
            'ValidateSingleContactButton
            '
            Me.ValidateSingleContactButton.Location = New System.Drawing.Point(24, 186)
            Me.ValidateSingleContactButton.Name = "ValidateSingleContactButton"
            Me.ValidateSingleContactButton.Size = New System.Drawing.Size(175, 23)
            Me.ValidateSingleContactButton.TabIndex = 5
            Me.ValidateSingleContactButton.Text = "Validate contact"
            Me.ValidateSingleContactButton.UseVisualStyleBackColor = True
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.BusinessEmailTextBox)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.LastNameTextBox)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.FirstNameTextBox)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.PersonalEmailTextBox)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.PhoneTextBox)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.ValidateSingleContactButton)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 184)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(744, 221)
            Me.panel1.TabIndex = 4
            '
            'BusinessEmailTextBox
            '
            Me.BusinessEmailTextBox.Location = New System.Drawing.Point(103, 94)
            Me.BusinessEmailTextBox.Name = "BusinessEmailTextBox"
            Me.BusinessEmailTextBox.Size = New System.Drawing.Size(199, 20)
            Me.BusinessEmailTextBox.TabIndex = 2
            Me.BusinessEmailTextBox.Tag = "BusinessEmail"
            Me.BusinessEmailTextBox.Text = "maryjonesAbc@mycompany.com"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(21, 97)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(76, 13)
            Me.label5.TabIndex = 9
            Me.label5.Text = "Business email"
            '
            'LastNameTextBox
            '
            Me.LastNameTextBox.Location = New System.Drawing.Point(103, 60)
            Me.LastNameTextBox.Name = "LastNameTextBox"
            Me.LastNameTextBox.Size = New System.Drawing.Size(199, 20)
            Me.LastNameTextBox.TabIndex = 1
            Me.LastNameTextBox.Tag = "LastName"
            Me.LastNameTextBox.Text = "Jones"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(41, 63)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(56, 13)
            Me.label4.TabIndex = 7
            Me.label4.Text = "Last name"
            '
            'FirstNameTextBox
            '
            Me.FirstNameTextBox.Location = New System.Drawing.Point(103, 27)
            Me.FirstNameTextBox.Name = "FirstNameTextBox"
            Me.FirstNameTextBox.Size = New System.Drawing.Size(199, 20)
            Me.FirstNameTextBox.TabIndex = 0
            Me.FirstNameTextBox.Tag = "FirstName"
            Me.FirstNameTextBox.Text = "Mary"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(42, 27)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(55, 13)
            Me.label3.TabIndex = 5
            Me.label3.Text = "First name"
            '
            'PersonalEmailTextBox
            '
            Me.PersonalEmailTextBox.Location = New System.Drawing.Point(103, 120)
            Me.PersonalEmailTextBox.Name = "PersonalEmailTextBox"
            Me.PersonalEmailTextBox.Size = New System.Drawing.Size(152, 20)
            Me.PersonalEmailTextBox.TabIndex = 3
            Me.PersonalEmailTextBox.Tag = "PersonalEmail"
            Me.PersonalEmailTextBox.Text = "mary@gmail.com"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(22, 127)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(75, 13)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Personal email"
            '
            'PhoneTextBox
            '
            Me.PhoneTextBox.Location = New System.Drawing.Point(103, 146)
            Me.PhoneTextBox.Name = "PhoneTextBox"
            Me.PhoneTextBox.Size = New System.Drawing.Size(152, 20)
            Me.PhoneTextBox.TabIndex = 4
            Me.PhoneTextBox.Tag = "Phone"
            Me.PhoneTextBox.Text = "1234567890"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(59, 149)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(38, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Phone"
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.ErrorProvider1.ContainerControl = Me
            '
            'ContactForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(744, 405)
            Me.Controls.Add(Me.dataGridView1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "ContactForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Contact validation using ErrorProvider"
            CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private WithEvents dataGridView1 As DataGridView
        Private WithEvents ValidateSingleContactButton As Button
        Private WithEvents panel1 As Panel
        Private WithEvents BusinessEmailTextBox As TextBox
        Private WithEvents label5 As Label
        Private WithEvents LastNameTextBox As TextBox
        Private WithEvents label4 As Label
        Private WithEvents FirstNameTextBox As TextBox
        Private WithEvents label3 As Label
        Private WithEvents PersonalEmailTextBox As TextBox
        Private WithEvents label2 As Label
        Private WithEvents PhoneTextBox As TextBox
        Private WithEvents label1 As Label
        Friend WithEvents ErrorProvider1 As ErrorProvider
    End Class
End Namespace