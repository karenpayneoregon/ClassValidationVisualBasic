using System.ComponentModel.DataAnnotations;
using BaseDataValidatorLibrary.CommonRules;

namespace BaseModelsLibrary.Models
{
    public class SomeItem
    {
        [Required]
        public int Min { get; set; }

        [Required]
        [GreaterThan("Min")]
        public int Max { get; set; }
    }
}