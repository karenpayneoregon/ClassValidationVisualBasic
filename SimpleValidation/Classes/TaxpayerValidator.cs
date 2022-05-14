using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SimpleValidation.Helpers;
using SimpleValidation.Models;

namespace SimpleValidation.Classes
{
    public class TaxpayerValidator : AbstractValidator<TaxpayerFluent>
    {
        public TaxpayerValidator()
        {
            Transform(
                    from: taxpayer => taxpayer.SSN,
                    to: value => value.IsSocialSecurityNumberValid()).Must(value => value)
                .WithMessage("SSN not acceptable");

            RuleFor(taxpayer => taxpayer.FirstName)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(20)
                .WithName("First name");

            RuleFor(taxpayer => taxpayer.LastName)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(30)
                .WithName("Last name");

            RuleFor(taxpayer => taxpayer.BirthDate.Year)
                .NotNull()
                .LessThan(2022)
                .GreaterThan(1931);
        }
    }
}
