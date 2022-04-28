using System;
using System.ComponentModel.DataAnnotations;
using BaseDataValidatorLibrary.CommonRules;

namespace BaseModelsLibrary.Models
{
    public partial class CustomerLogin
    {

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [MaxLength(12, ErrorMessage = "The {0} can not have more than {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(12, MinimumLength = 6)]
        public string Password { get; set; }

        /// <summary>
        /// Disallow date to be a weekend date
        /// </summary>
        /// <returns></returns>
        [WeekendDateNotPermitted]
        public DateTime EntryDate { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Passwords do not match, please try again")]
        [StringLength(12, MinimumLength = 6)]
        public string PasswordConfirmation { get; set; }

        public DateTime LastLoginDate { get; set; }

    }
}
