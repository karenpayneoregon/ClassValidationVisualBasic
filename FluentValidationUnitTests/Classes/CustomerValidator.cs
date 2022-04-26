using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModelsLibrary.Models;
using FluentValidation;

namespace FluentValidationUnitTests.Classes
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {

            RuleFor(customer => customer.Id)
                .InclusiveBetween(1, 10);

            RuleFor(customer => customer.FirstName)
                .NotEmpty()
                .Length(3, 10)
                .WithMessage("Please specify a first name");

            RuleFor(customer => customer.LastName)
                .NotEmpty()
                .Length(3, 20)
                .WithMessage("Please specify a last name");

            RuleFor(customer => customer.Email)
                .EmailAddress();

            RuleFor(customer => customer.Discount)
                .NotEqual(0)
                .When(customer => customer.HasDiscount);

            RuleFor(customer => customer.CreditLimit)
                .LessThanOrEqualTo(9999);


            RuleFor(customer => customer.Address)
                .MaximumLength(250);

            RuleFor(customer => customer.Postcode)
                .Must(HasValidPostcode)
                .WithMessage("Please specify a valid postcode");

            Transform(from: x => x.Pin, to: value => int.TryParse(value, out int val) ? (int?)val : null)
                .GreaterThan(8888);

            RuleFor(customer => customer.BirthDate).GreaterThan(new DateTime(1932,1,1));
        }

        private static bool HasValidPostcode(string postcode)
        {
            List<string> list = new() { "97301", "97223", "97209", "97146", "97374", "97734" };
            var result = list.FirstOrDefault(item => item == postcode);
            return result is not null;
        }
    }
}
