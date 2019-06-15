namespace Sample1
{
    partial class Form1
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
            this.ValidateSingleContactButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PersonalEmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BusinessEmailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValidateSingleContactButton
            // 
            this.ValidateSingleContactButton.Location = new System.Drawing.Point(24, 186);
            this.ValidateSingleContactButton.Name = "ValidateSingleContactButton";
            this.ValidateSingleContactButton.Size = new System.Drawing.Size(175, 23);
            this.ValidateSingleContactButton.TabIndex = 9;
            this.ValidateSingleContactButton.Text = "Validate contact";
            this.ValidateSingleContactButton.UseVisualStyleBackColor = true;
            this.ValidateSingleContactButton.Click += new System.EventHandler(this.ValidateSingleContactButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BusinessEmailTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LastNameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FirstNameTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PersonalEmailTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PhoneTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ValidateSingleContactButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 221);
            this.panel1.TabIndex = 2;
            // 
            // PersonalEmailTextBox
            // 
            this.PersonalEmailTextBox.Location = new System.Drawing.Point(103, 120);
            this.PersonalEmailTextBox.Name = "PersonalEmailTextBox";
            this.PersonalEmailTextBox.Size = new System.Drawing.Size(152, 20);
            this.PersonalEmailTextBox.TabIndex = 7;
            this.PersonalEmailTextBox.Text = "mary@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personal email";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(103, 146);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(152, 20);
            this.PhoneTextBox.TabIndex = 8;
            this.PhoneTextBox.Text = "1234567890";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(103, 27);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.Text = "Mary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(103, 60);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.LastNameTextBox.TabIndex = 5;
            this.LastNameTextBox.Text = "Jones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Business email";
            // 
            // BusinessEmailTextBox
            // 
            this.BusinessEmailTextBox.Location = new System.Drawing.Point(103, 94);
            this.BusinessEmailTextBox.Name = "BusinessEmailTextBox";
            this.BusinessEmailTextBox.Size = new System.Drawing.Size(199, 20);
            this.BusinessEmailTextBox.TabIndex = 6;
            this.BusinessEmailTextBox.Text = "maryjonesAbc@mycompany.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validate Contact using DataAnnotations";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValidateSingleContactButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PersonalEmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BusinessEmailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
    }
}

