using SimpleValidation.LanguageExtensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleValidation.Classes
{

    /// <summary>
    /// Provides a rule for min and max year
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class YearRangeAttribute : ValidationAttribute
    {
        /// <summary>
        /// Constructor to pass in maximum year for range
        /// </summary>
        /// <param name="maximumYear">Maximum year for range</param>
        public YearRangeAttribute(int maximumYear)
        {
            MaximumYear = maximumYear;
        }
        /// <summary>
        /// Maximum year permitted
        /// </summary>
        public int MaximumYear { get; }
        /// <summary>
        /// Minimum year permitted 
        /// </summary>
        public int MinimumYear { get; set; }
        public override string FormatErrorMessage(string name)
        {
            if (ErrorMessage is null && ErrorMessageResourceName is null)
            {
                ErrorMessage = @"'Year {0}' and/or year '{1}' are invalid";
            }

            return $"{name} year must be between {MinimumYear} and {MaximumYear}";

        }

        public override bool IsValid(object sender) 
            => ((DateTime)sender).Year.Between(MinimumYear, MaximumYear);
    }
}

