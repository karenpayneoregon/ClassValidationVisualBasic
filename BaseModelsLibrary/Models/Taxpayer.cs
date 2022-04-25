using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModelsLibrary.Models
{
    public class Taxpayer
    {

        [RegularExpression("^\\d{9}|\\d{3}-\\d{2}-\\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        [Required(ErrorMessage = "Contact {0} is required"), DataType(DataType.Text)]
        public string SSN { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required"), DataType(DataType.Text)]
        public string LastName { get; set; }
    }
}
