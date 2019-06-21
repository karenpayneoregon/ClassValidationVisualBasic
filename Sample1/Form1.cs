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
using DataValidatorLibrary.LanguageExtensions;
using LanguageExtensionsLibrary;

namespace Sample1
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bsContacts = new BindingSource();
        private bool _dataGridViewSizeDone;
        public Form1()
        {
            InitializeComponent();
        }
        private void ValidateSingleContactButton_Click(object sender, EventArgs e)
        {
            var contact = new Contact()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                PersonalEmail = PersonalEmailTextBox.Text,
                BusinessEmail = BusinessEmailTextBox.Text,
                Phone = PhoneTextBox.Text
            };

            var validationResult = ValidationHelper.ValidateEntity(contact);

            if (!validationResult.HasError)
            {
                _bsContacts.Add(contact);
                if (_dataGridViewSizeDone) return;

                dataGridView1.ExpandColumns();
                _dataGridViewSizeDone = true;

            }
            else
            {
                MessageBox.Show(validationResult.ErrorMessageList());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bsContacts;
        }
    }
}
