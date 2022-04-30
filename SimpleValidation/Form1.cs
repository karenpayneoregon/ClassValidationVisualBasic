using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataValidatorLibrary.Helpers;
using SimpleValidation.Classes;

namespace SimpleValidation
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        private Taxpayer _taxpayer;
        public Form1()
        {
            InitializeComponent();
            SocialSecurityTextBox.ToggleShow(false);
            SocialSecurityTextBox.MaxLength = 11;

            _bindingSource.DataSource = new List<Taxpayer>() { new Taxpayer() };
            errorProvider1.DataSource = _bindingSource;

            FirstNameTextBox.DataBindings.Add("Text", _bindingSource, "FirstName");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SocialSecurityTextBox.ToggleShow(checkBox1.Checked);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
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

        private void SubmitBadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
