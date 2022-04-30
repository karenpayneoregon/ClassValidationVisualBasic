using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimpleValidation.Classes;
using SimpleValidation.Properties;

namespace SimpleValidation
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        private Taxpayer _taxpayer;
        public Form1()
        {
            InitializeComponent();

            errorProvider1.Icon = Resources.deleteIcon;
            
            Controls.OfType<TextBox>().ToList().ForEach(tb => errorProvider1.SetIconPadding(tb,10));

            SocialSecurityTextBox.ToggleShow(false);
            SocialSecurityTextBox.MaxLength = 11;

            _bindingSource.DataSource = new List<Taxpayer>() { new Taxpayer() };
            

            SocialSecurityTextBox.DataBindings.Add("Text", _bindingSource, nameof(Taxpayer.SSN));
            FirstNameTextBox.DataBindings.Add("Text", _bindingSource, nameof(Taxpayer.FirstName));
            LastNameTextBox.DataBindings.Add("Text", _bindingSource, nameof(Taxpayer.LastName));

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SocialSecurityTextBox.ToggleShow(checkBox1.Checked);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            errorProvider1.DataSource = _bindingSource;
            errorProvider1.DataSource = null;
        }

        private void ErrorMessagesButton_Click(object sender, EventArgs e)
        {
            _taxpayer = new Taxpayer()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                SSN = SocialSecurityTextBox.Text
            };

            var (success, errorMessages) = ValidationOperations.IsValidTaxpayer(_taxpayer);
            MessageBox.Show(success ? "Valid" : $"Not valid\n{errorMessages}");
        }
    }
}
