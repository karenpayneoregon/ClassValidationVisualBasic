using System.Collections.Generic;

namespace SimpleValidation.Models
{
    public class ValidatorItem
    {
        public string ControlName { get; set; }
        public string PropertyName { get; set; }
        public List<string> ErrorMessagesList { get; set; }
        public override string ToString() => PropertyName;

        public ValidatorItem()
        {
            ErrorMessagesList = new List<string>();
        }
    }
}