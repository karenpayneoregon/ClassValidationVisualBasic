using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDataValidatorLibrary.CommonRules;

namespace BaseModelsLibrary.Models
{
    public class Athlete
    {
        [ValidKey]
        [Required(ErrorMessage = "{0} is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(15)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(20)]
        public string LastName { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
