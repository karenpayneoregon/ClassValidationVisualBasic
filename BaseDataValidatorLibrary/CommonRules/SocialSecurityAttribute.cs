using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BaseDataValidatorLibrary.CommonRules
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SocialSecurityAttribute : ValidationAttribute
    {
        public string SocialValue { get; set; }

        public override bool IsValid(object value)
        {
            if (value is null)
            {
                return false;
            }
            if (value.ToString().Length == 9 && Regex.IsMatch(value.ToString()!, @"^\d{9}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
