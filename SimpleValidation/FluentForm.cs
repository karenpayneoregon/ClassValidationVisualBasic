using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using FluentValidation.Results;
using SimpleValidation.Classes;
using SimpleValidation.Helpers;
using SimpleValidation.LanguageExtensions;
using SimpleValidation.Models;
using SimpleValidation.Properties;

namespace SimpleValidation
{
    public partial class FluentForm : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        private TaxpayerFluent _taxpayer;
        private readonly List<ValidatorItem> _validatorItems = new List<ValidatorItem>();
        public FluentForm()
        {
            InitializeComponent();

            errorProvider1.Icon = Resources.deleteIcon;

            Controls.OfType<TextBox>().ToList().ForEach(tb =>
                errorProvider1.SetIconPadding(tb, 10));

            errorProvider1.SetIconPadding(BirthDateTimePicker, 10);

            SocialSecurityTextBox.ToggleShow(false);
            SocialSecurityTextBox.MaxLength = 11;

            _bindingSource.DataSource = new List<TaxpayerFluent>()
            {
                new TaxpayerFluent()
                {
                    SSN = "345333333", 
                    FirstName = "Jane", 
                    LastName = "Miller", 
                    BirthDate = new DateTime(1955, 1, 1)
                }
            };

            SocialSecurityTextBox.DataBindings.Add("Text", _bindingSource, nameof(TaxpayerFluent.SSN));
            SocialSecurityTextBox.Tag = nameof(TaxpayerFluent.SSN);

            FirstNameTextBox.DataBindings.Add("Text", _bindingSource, nameof(TaxpayerFluent.FirstName));
            FirstNameTextBox.Tag = nameof(TaxpayerFluent.FirstName);

            LastNameTextBox.DataBindings.Add("Text", _bindingSource, nameof(TaxpayerFluent.LastName));
            LastNameTextBox.Tag = nameof(TaxpayerFluent.LastName);

            BirthDateTimePicker.DataBindings.Add("DateTime", _bindingSource, nameof(TaxpayerFluent.BirthDate));
            BirthDateTimePicker.Tag = $"{nameof(TaxpayerFluent.BirthDate)}.{nameof(TaxpayerFluent.BirthDate.Year)}";

            /*
             * This is to prep for working with the error provider
             */
            this.Descendants<Control>()
                .Where(control => control.Tag != null)
                .Select(control => new
                {
                    controlName = control.Name, 
                    PropertyName = control.Tag.ToString()
                })
                .ToList()
                .ForEach(x => _validatorItems.Add(new ValidatorItem()
                {
                    ControlName = x.controlName, 
                    PropertyName = x.PropertyName
                }));

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SocialSecurityTextBox.ToggleShow(checkBox1.Checked);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ValidateCurrent();
        }

        private void ErrorMessagesButton_Click(object sender, EventArgs e)
        {
            ValidateCurrent();
        }

        private void ValidateCurrent()
        {

            _taxpayer = (TaxpayerFluent)_bindingSource.Current;
            _validatorItems.ForEach(vi => vi.ErrorMessagesList = new List<string>());

            Controls.OfType<Control>().ToList().ForEach(control => errorProvider1.SetError(control, ""));
            TaxpayerValidator validator = new TaxpayerValidator();
            ValidationResult result = validator.Validate(_taxpayer);

            List<IGrouping<string, ErrorDetail>> groups = result.ErrorDetails().GroupBy(ed => ed.PropertyName).ToList();
            
            foreach (var group in groups)
            {
                var current = _validatorItems.FirstOrDefault(x => x.PropertyName == group.Key); 
                current.ErrorMessagesList.AddRange(group.ToList().Select(x => x.Message));
                var control = Controls.Find(current.ControlName, true)[0];

                if (current.ErrorMessagesList.Count >0)
                {
                    errorProvider1.SetError(control, current.ErrorMessagesList.FirstOrDefault());
                }
            }
        }

        private void ValidButton_Click(object sender, EventArgs e)
        {

            _taxpayer = (TaxpayerFluent)_bindingSource.Current;
            _taxpayer.SSN = "345333333";
            _taxpayer.FirstName = "Jane";
            _taxpayer.LastName = "Miller";
            _taxpayer.BirthDate = new DateTime(1955, 1, 1);

            //_bindingSource.ResetCurrentItem();
            _bindingSource.ResetBindings(false);
            //ValidateCurrent();

        }
    }
}
