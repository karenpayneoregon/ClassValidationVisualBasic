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

        public Form1()
        {
            InitializeComponent();
            SocialSecurityTextBox.ToggleShow(false);
            SocialSecurityTextBox.MaxLength = 11;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SocialSecurityTextBox.ToggleShow(checkBox1.Checked);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var taxpayer = new Taxpayer()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                SSN = SocialSecurityTextBox.Text
            };

            var (success, errorMessages) = ValidationOperations.IsValidTaxpayer(taxpayer);
            MessageBox.Show(success ? "Valid" : $"Not valid\n{errorMessages}");
        }

        private void SubmitBadButton_Click(object sender, EventArgs e)
        {
            /*
             * Developer will do things like
             *
             * Does a text box have a value and if so are things like length in range
             * For SSN only validate we have a number with a specific length
             *
             * Will write all code in this event
             */

            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && string.IsNullOrWhiteSpace(LastNameTextBox.Text) & string.IsNullOrWhiteSpace(SocialSecurityTextBox.Text))
            {
                // not valid
            }
            else
            {
                // valid
            }
        }
    }
}
