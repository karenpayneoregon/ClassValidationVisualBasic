using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BaseModelsLibrary.Models;
using FluentValidation;
using FluentValidationUnitTests.LanguageExtensions;

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

            //RuleFor(customer => customer.Email)
            //    .NotEmpty()
            //    .EmailAddress()
            //    .Must(HaveValidEmailAddress)
            //    .WithMessage("Bad email address");

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

            Transform(from: customer => customer.Pin, to: value => 
                    int.TryParse(value, out var result) ? (int?)result : null)
                .GreaterThan(8888);

            Transform(
                from: customer => customer.SocialSecurity,
                to: value => value.IsSSNValid()).Must(value => value);

            RuleFor(customer => customer.BirthDate).GreaterThan(new DateTime(1932,1,1));
        }

        private static bool HasValidEmailAddress(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private static bool HasValidPostcode(string postcode)
        {
            List<string> list = new() { "97301", "97223", "97209", "97146", "97374", "97734" };
            var result = list.FirstOrDefault(item => item == postcode);
            return result is not null;
        }
    }
}
