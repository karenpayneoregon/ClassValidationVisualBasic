using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataValidatorLibrary.Helpers;

namespace SimpleValidation.Classes
{
    public class ValidationOperations
    {
        public static (bool success, string errorMessages) IsValidTaxpayer(Taxpayer taxpayer)
        {
            var result = ValidationHelper.ValidateEntity(taxpayer);
            if (result.IsNotValid)
            {
                StringBuilder builder = new StringBuilder();
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
