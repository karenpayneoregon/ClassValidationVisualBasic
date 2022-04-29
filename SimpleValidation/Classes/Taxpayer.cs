using System.ComponentModel.DataAnnotations;

namespace SimpleValidation.Classes
{
    public class Taxpayer
    {

        [RegularExpression("^\\d{9}|\\d{3}-\\d{2}-\\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string SSN { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string LastName { get; set; }
    }
}