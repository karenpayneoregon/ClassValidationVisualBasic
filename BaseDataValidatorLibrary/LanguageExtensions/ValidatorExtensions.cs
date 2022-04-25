using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BaseDataValidatorLibrary.Helpers;

namespace BaseDataValidatorLibrary.LanguageExtensions
{
    public static class ValidatorExtensions
    {
        public static string ErrorMessages(this EntityValidationResult sender, bool title = false)
        {
            string RemoveSpaces(string item)
            {
                return Regex.Replace(item, @"\s+", " ");
            }

            StringBuilder builder = new ();
            
            if (title)
            {
                builder.AppendLine("Validation issues");
            }

            foreach (var validationResult in sender.Errors)
            {
                builder.AppendLine(RemoveSpaces(validationResult.ErrorMessage.SplitCamelCase()));
            }

            return builder.ToString();
        }

        public static List<string> ErrorMessagesList(this EntityValidationResult sender)
        {
            string RemoveSpaces(string item) 
                => Regex.Replace(item, @"\s+", " ");


            return sender.Errors.Select(validationResult 
                => RemoveSpaces(validationResult.ErrorMessage.SplitCamelCase())).ToList();
        }

    }
}
