using System.ComponentModel.DataAnnotations;
using DataValidatorLibrary.CommonRules;

namespace Sample1
{
    public class Contact
    {
        [RegularExpression(@"^.{5,}$", ErrorMessage = "Minimum 3 characters required")]
        [Required(ErrorMessage = "{0} Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
        public string FirstName { get; set; }

        [RegularExpression(@"^.{5,}$", ErrorMessage = "Minimum 3 characters required")]
        [Required(ErrorMessage = "{0} Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
        public string LastName { get; set; }
        /// <summary>
        /// Email address
        /// </summary>
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        /// <remarks>
        /// Data annotations for phone can be simple as show below
        /// [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        /// But in this case there is a custom rule to keep phone number to 10 characters
        /// </remarks>
        [Required(ErrorMessage = "Mobile no. is required")]
        [CheckPhoneValidation(ErrorMessage = "{0} must be no longer than 10")]
        public string Phone { get; set; }
    }
}