using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BaseDataValidatorLibrary.LanguageExtensions;

namespace BaseDataValidatorLibrary.CommonRules
{
    public class ListHasElements : ValidationAttribute
    {
        public override bool IsValid(object sender)
        {
            if (sender == null)
            {
                return false;
            }

            if (sender.IsList())
            {
                var result = ((IEnumerable)sender).Cast<object>().ToList();
                return result.Any();
            }
            else
            {
                return false;
            }
        }
    }
}
