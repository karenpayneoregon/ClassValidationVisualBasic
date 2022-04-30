using System.ComponentModel.DataAnnotations;
using WindowsForms.DataAnnotationsValidation;

namespace SimpleValidation.Classes
{
    public class Taxpayer : BaseModel
    {

        [RegularExpression("^\\d{9}|\\d{3}-\\d{2}-\\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string SSN { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Invalid {0}")]
        public string LastName { get; set; }
    }
}