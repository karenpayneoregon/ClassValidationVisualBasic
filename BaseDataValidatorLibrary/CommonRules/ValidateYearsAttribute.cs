using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Validate year only
    /// </summary>
    public class ValidateYearsAttribute : ValidationAttribute
    {
        private readonly DateTime _minValue = DateTime.UtcNow.AddYears(-90);
        private readonly DateTime _maxValue = DateTime.UtcNow;

        public override bool IsValid(object sender)
        {
            var value = (DateTime)sender;
            return value.Year >= _minValue.Year && value.Year <= _maxValue.Year;
        }

        public override string FormatErrorMessage(string name) 
            => string.Format(ErrorMessage!, 
                _minValue.ToString("yyyy"), 
                _maxValue.ToString("yyyy"));
    }
}
