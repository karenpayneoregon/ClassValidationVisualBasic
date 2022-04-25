using System;
using System.ComponentModel.DataAnnotations;
using BaseDataValidatorLibrary.CommonRules;

namespace BaseModelsLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }
        [RegularExpression("^.{3,}$", ErrorMessage = "{0} Minimum 3 characters required")]
        [Required(ErrorMessage = "{0} Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
        public string FirstName { get; set; }

        [RegularExpression("^.{3,}$", ErrorMessage = "{0} Minimum 3 characters required")]
        [Required(ErrorMessage = "{0} Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
        public string LastName { get; set; }

        [ValidateYears(ErrorMessage = "Valid range for BirthDate is {0} and {1}")]
        public DateTime BirthDate { get; set; }
    }
}