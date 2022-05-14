using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimpleValidation.Classes;
using SimpleValidation.Models;
using SimpleValidation.Properties;

namespace SimpleValidation
{
    public partial class AnnotatedForm : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        private TaxpayerAnnotated _taxpayer;
        public AnnotatedForm()
        {
            InitializeComponent();

            errorProvider1.Icon = Resources.deleteIcon;
            
            Controls.OfType<TextBox>().ToList().ForEach(tb => 
                errorProvider1.SetIconPadding(tb,10));

            SocialSecurityTextBox.ToggleShow(false);
            SocialSecurityTextBox.MaxLength = 11;

            _bindingSource.DataSource = new List<TaxpayerAnnotated>() { new TaxpayerAnnotated()};
           
            SocialSecurityTextBox.DataBindings.Add("Text", _bindingSource, nameof(TaxpayerAnnotated.SSN));
            FirstNameTextBox.DataBindings.Add("Text", _bindingSource, nameof(TaxpayerAnnotated.FirstName));
            LastNameTextBox.DataBindings.Add("Text", _bindingSource, nameof(TaxpayerAnnotated.LastName));
            BirthDateTimePicker.DataBindings.Add("DateTime", _bindingSource, nameof(TaxpayerAnnotated.BirthDate));

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

            _taxpayer = (TaxpayerAnnotated)_bindingSource.Current;
            _taxpayer.BirthDate = BirthDateTimePicker.DateTime;

            var (success, errorMessages) = ValidationOperations.IsValidTaxpayer(_taxpayer);
            MessageBox.Show(success ? "Valid" : $"Not valid\n{errorMessages}");
        }
    }
}
