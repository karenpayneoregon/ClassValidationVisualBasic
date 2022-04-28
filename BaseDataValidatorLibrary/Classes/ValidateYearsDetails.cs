using System;
using BaseDataValidatorLibrary.CommonRules;
using BaseDataValidatorLibrary.Helpers;

namespace BaseDataValidatorLibrary.Classes
{
    /// <summary>
    /// For obtaining <see cref="ValidateYearsAttribute"/> ErrorMessage
    /// using <see cref="Model.GetValidateYearsErrorMessages(T)"/>
    /// </summary>
    public class ValidateYearsDetails
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime Min { get; set; }
        public DateTime Max { get; set; }
        public override string ToString() => string.Format(ErrorMessage, Min.Year, Max.Year);

    }
}