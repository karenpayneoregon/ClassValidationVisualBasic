using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using SimpleValidation.Classes;
using SimpleValidation.Helpers;

namespace SimpleValidation.Models
{
    public class TaxpayerAnnotated : BaseModel, INotifyPropertyChanged
    {
        private DateTime birthDate;

        [RegularExpression("^\\d{9}|\\d{3}-\\d{2}-\\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string SSN { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Invalid {0}")]
        public string LastName { get; set; }

        [Required, YearRange(2022, MinimumYear = 1932)]
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                birthDate = value;
                OnPropertyChanged();
            }
        }

        public TaxpayerAnnotated()
        {
            BirthDate = DateTime.MinValue;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}