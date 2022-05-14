
namespace SimpleValidation
{
    partial class FluentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SocialSecurityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorMessagesButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValidButton = new System.Windows.Forms.Button();
            this.BirthDateTimePicker = new SimpleValidation.Controls.NullableDateTimePicker();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.White;
            this.SubmitButton.Image = global::SimpleValidation.Properties.Resources.checkmark;
            this.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubmitButton.Location = new System.Drawing.Point(15, 213);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(117, 23);
            this.SubmitButton.TabIndex = 18;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(15, 81);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "First";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(56, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Toggle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "SSN";
            // 
            // SocialSecurityTextBox
            // 
            this.SocialSecurityTextBox.Location = new System.Drawing.Point(15, 34);
            this.SocialSecurityTextBox.Name = "SocialSecurityTextBox";
            this.SocialSecurityTextBox.Size = new System.Drawing.Size(100, 20);
            this.SocialSecurityTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Birth";
            // 
            // ErrorMessagesButton
            // 
            this.ErrorMessagesButton.BackColor = System.Drawing.Color.White;
            this.ErrorMessagesButton.Image = global::SimpleValidation.Properties.Resources.blueInformation_16;
            this.ErrorMessagesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrorMessagesButton.Location = new System.Drawing.Point(138, 213);
            this.ErrorMessagesButton.Name = "ErrorMessagesButton";
            this.ErrorMessagesButton.Size = new System.Drawing.Size(117, 23);
            this.ErrorMessagesButton.TabIndex = 19;
            this.ErrorMessagesButton.Text = "Messages";
            this.ErrorMessagesButton.UseVisualStyleBackColor = false;
            this.ErrorMessagesButton.Click += new System.EventHandler(this.ErrorMessagesButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // ValidButton
            // 
            this.ValidButton.Location = new System.Drawing.Point(180, 13);
            this.ValidButton.Name = "ValidButton";
            this.ValidButton.Size = new System.Drawing.Size(75, 23);
            this.ValidButton.TabIndex = 22;
            this.ValidButton.Text = "Valid";
            this.ValidButton.UseVisualStyleBackColor = true;
            this.ValidButton.Click += new System.EventHandler(this.ValidButton_Click);
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.DateTime = new System.DateTime(2022, 5, 14, 10, 5, 47, 711);
            this.BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateTimePicker.Location = new System.Drawing.Point(15, 178);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.BirthDateTimePicker.TabIndex = 21;
            this.BirthDateTimePicker.Value = new System.DateTime(2022, 5, 14, 10, 5, 47, 711);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(15, 130);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 23;
            // 
            // FluentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 248);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.ValidButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SocialSecurityTextBox);
            this.Controls.Add(this.BirthDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ErrorMessagesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FluentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluent";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SocialSecurityTextBox;
        private Controls.NullableDateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ErrorMessagesButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ValidButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
    }
}