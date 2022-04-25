﻿using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Provides custom rule for phone number rather than using [Phone]
    /// </summary>
    public class CheckPhoneValidationAttribute : ValidationAttribute 
    {
        public override bool IsValid(object value)
        {

            bool IsDigitsOnly(string str)
            {
                foreach (var c in str)
                {
                    if (c < '0' || c > '9')
                        return false;
                }

                return true;
            }

            if (value == null)
            {
                return false;
            }

            string convertedValue = value.ToString();

            return !string.IsNullOrWhiteSpace(convertedValue) && 
                   IsDigitsOnly(convertedValue) && 
                   convertedValue.Length <= 10;
        }
    }
}