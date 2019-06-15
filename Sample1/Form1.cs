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

namespace Sample1
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bsContacts = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }
        private void ValidateSingleContactButton_Click(object sender, EventArgs e)
        {
            var contact = new Contact() {Email = EmailTextBox.Text, Phone = PhoneTextBox.Text};
            var validationResult = ValidationHelper.ValidateEntity(contact);

            if (!validationResult.HasError)
            {
                _bsContacts.Add(contact);
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
