using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDataValidatorLibrary.CommonRules;

namespace BaseModelsLibrary.Models
{
    public class Contact
    {
        [RegularExpression("^.{3,}$", ErrorMessage = "{0} Minimum 3 characters required")]
        [Required(ErrorMessage = "{0} Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
        public string FirstName { get; set; }

        [RegularExpression("^.{3,}$", ErrorMessage = "{0} Minimum 3 characters required")]
        [Required(ErrorMessage = "{0} Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
        public string LastName { get; set; }

        public string FullName 
            => $"{FirstName} {LastName}";

        [Required(ErrorMessage = "Please Enter Email Address")]
        [RegularExpression("^([a-zA-Z0-9_\\.\\-])+\\@(([a-zA-Z0-9\\-])+\\.)+([a-zA-Z0-9]{2,4})+$", 
            ErrorMessage = "Please Enter Correct {0} Email Address")]
        [EmailAddress]
        public string BusinessEmail { get; set; }

        /// <summary>
        /// Personal Email address
        /// </summary>
        [Required(ErrorMessage = "Please enter your {0} email address")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(70)]
        [RegularExpression("[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}", 
            ErrorMessage = "Please enter correct {0} email")]
        public string PersonalEmail { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        /// <remarks>
        /// Data annotations for phone can be simple as show below
        /// [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        /// But in this case there is a custom rule to keep phone number to 10 characters
        /// </remarks>
        [Required(ErrorMessage = "Mobile number is required")]
        [CheckPhoneValidation(ErrorMessage = "{0} must be no longer than 10")]
        public string Phone { get; set; }

        public override string ToString() 
            => $"{FirstName} {LastName} '{BusinessEmail}'";
    }

}
