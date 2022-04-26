using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FluentValidationUnitTests.LanguageExtensions
{
    public static class ValidatingHelpers
    {
        public static bool IsSSNOverlyValid(this string ssn) 
            => new Regex(@"^(?!\b(\d)\1+-(\d)\1+-(\d)\1+\b)(?!123-45-6789|219-09-9999|078-05-1120)(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0{4})\d{4}$").IsMatch(ssn);
    }
}
