using System.Linq;
using System.Text;
using SimpleValidation.Helpers;
using SimpleValidation.Models;

namespace SimpleValidation.Classes
{
    public class ValidationOperations
    {
        /// <summary>
        /// Validate <see cref="TaxpayerAnnotated"/>
        /// </summary>
        /// <param name="taxpayer">instance of a <see cref="TaxpayerAnnotated"/></param>
        /// <returns>success and error messages if invalid</returns>
        public static (bool success, string errorMessages) IsValidTaxpayer(TaxpayerAnnotated taxpayer)
        {
            // generic method to validate model instance
            var result = ValidationHelper.ValidateEntity(taxpayer);

            if (result.IsNotValid)
            {
                var builder = new StringBuilder();
                result.Errors.ToList().ForEach(x => builder.AppendLine(x.ErrorMessage));
                return (false, builder.ToString());
            }
            else
            {
                return (true, null);
            }


        }
    }
}
