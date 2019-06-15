using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataValidatorLibrary.Helpers;

namespace DataValidatorLibrary.LanguageExtensions
{
    public static class ValidatorExtensions
    {
        public static string ErrorMessageList(this EntityValidationResult sender)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Validation issues");
            foreach (var validationResult in sender.Errors)
            {
                sb.AppendLine(validationResult.ErrorMessage);
            }

            return sb.ToString();
        }

    }
}
