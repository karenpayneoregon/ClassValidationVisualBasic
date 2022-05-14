using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FluentValidation.Results;
using SimpleValidation.Classes;
using SimpleValidation.Models;

namespace SimpleValidation.Helpers
{
    public static class ValidatingHelpers
    {
        /// <summary>
        /// Extreme validation for social security number
        /// </summary>
        /// <param name="ssn">value to validate</param>
        /// <returns></returns>
        /// <remarks>
        /// For simple validation see BaseDataValidatorLibrary.CommonRules.SocialSecurityAttribute
        /// </remarks>
        public static bool IsSocialSecurityNumberValid(this string ssn)
        {
            if (string.IsNullOrWhiteSpace(ssn))
            {
                return false;
            }

            if (ssn.Length == 9)
            {
                ssn = ssn.Insert(5, "-").Insert(3, "-");
            }

            return !string.IsNullOrWhiteSpace(ssn) && new Regex(
                    @"^(?!\b(\d)\1+-(\d)\1+-(\d)\1+\b)(?!123-45-6789|219-09-9999|078-05-1120)(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0{4})\d{4}$")
                .IsMatch(ssn);
        }

        public static string PresentErrorMessage(this ValidationResult sender)
        {
            StringBuilder builder = new StringBuilder();
            var test = sender.Errors;
            Console.WriteLine();
            sender.Errors.Select(validationFailure => validationFailure.ErrorMessage)
                .ToList()
                .ForEach(x => builder.AppendLine(x));



            return builder.Length == 0 ?
                "Valid" :
                builder.ToString();

        }

        public static List<ErrorDetail> ErrorDetails(this ValidationResult sender) =>
            sender
                .Errors
                .Select(item => 
                    new ErrorDetail(
                        item.PropertyName, 
                        item.ErrorMessage))
                .ToList();

        public static string BeforePeriod(this string sender) 
            => sender.Contains(".") ? 
                sender.Split('.')[0] : 
                sender;
    }
}
