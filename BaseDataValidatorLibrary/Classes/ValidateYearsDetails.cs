using System;

namespace BaseDataValidatorLibrary.Classes
{
    public class ValidateYearsDetails
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime Min { get; set; }
        public DateTime Max { get; set; }
        public override string ToString() => string.Format(ErrorMessage, Min.Year, Max.Year);

    }
}