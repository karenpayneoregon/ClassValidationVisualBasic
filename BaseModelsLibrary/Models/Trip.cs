using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDataValidatorLibrary.CommonRules;

namespace BaseModelsLibrary.Models
{
    public class Trip
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        [GreaterThan("StartDate")]
        public DateTime EndDate { get; set; }
    }
}
