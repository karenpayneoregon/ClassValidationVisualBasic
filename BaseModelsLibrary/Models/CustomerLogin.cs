using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModelsLibrary.Rules;

namespace BaseModelsLibrary.Models
{
    public class CustomerLogin
    {

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [MaxLength(12, ErrorMessage = "The {0} can not have more than {1} characters")]
        public string Name { get; set; }

        /// <summary>
        /// Disallow date to be a weekend date
        /// </summary>
        /// <returns></returns>
        [WeekendDateNotPermitted]
        public DateTime EntryDate { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(12, MinimumLength = 6)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Passwords do not match, please try again")]
        [StringLength(12, MinimumLength = 6)]
        public string PasswordConfirmation { get; set; }

    }
}
