using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BaseDataValidatorLibrary.Helpers;

namespace BaseDataValidatorLibrary.LanguageExtensions
{
    public static class ValidatorExtensions
    {

        /// <summary>
        /// List errors if any
        /// </summary>
        /// <param name="sender"><see cref="EntityValidationResult"/></param>
        /// <returns>list of 0 to many error messages</returns>
        public static List<string> ErrorMessagesList(this EntityValidationResult sender)
        {
            string RemoveSpaces(string item) 
                => Regex.Replace(item, @"\s+", " ");
            
            return sender.Errors.Select(validationResult 
                => RemoveSpaces(validationResult.ErrorMessage.SplitCamelCase())).ToList();
        }

    }
}
