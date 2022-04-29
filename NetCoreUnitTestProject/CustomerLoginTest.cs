using System;
using System.Linq;
using BaseDataValidatorLibrary.Helpers;
using BaseDataValidatorLibrary.LanguageExtensions;
using BaseModelsLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoreUnitTestProject.Base;
using NFluent;

namespace NetCoreUnitTestProject
{
    [TestClass]
    public partial class CustomerLoginTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidateCustomerLogin_Good_Test()
        {
            // arrange

            var customerLogin = CustomerLoginValid;
            // act
            EntityValidationResult validationResult = Model.Validate(customerLogin);


            // assert

            Check.That(validationResult.HasError).IsFalse();

        }

        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidateCustomerLogin_WeekendDate_Test()
        {
            // arrange
            const string expected = "The field EntryDate is invalid.";
            var customerLogin = CustomerLoginValid;
            customerLogin.EntryDate = new DateTime(2022, 4, 24);

            // act
            EntityValidationResult result = Model.Validate(customerLogin);
            
            // assert 
            Check.That(result.Errors.Any(validationResult => validationResult.ErrorMessage == expected)).IsTrue();
        }

        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidateCustomerLogin_PasswordMismatch_Test()
        {
            // arrange
            const string expected = "Passwords do not match";
            var customerLogin = CustomerLoginValid;
            customerLogin.PasswordConfirmation = "@password";

            // act
            EntityValidationResult result = Model.Validate(customerLogin);

            // assert 
            Check.That(result.Errors.Any(validationResult => validationResult.ErrorMessage!.Contains(expected))).IsTrue();

        }
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidateCustomerLogin_MultipleIssues_Test()
        {
            // arrange
            string[] expected =
            {
                "Passwords do not match , please try again", 
                "The Name can not have more than 12 characters"
            };

            var customerLogin = CustomerLoginValid;
            customerLogin.Name = "WayTooLongName";
            customerLogin.PasswordConfirmation = "@password"; // casing mismatch

            // act
            EntityValidationResult result = Model.Validate(customerLogin);

            // assert 
            var validation = result.ErrorMessagesList()
                .Intersect(expected).Count() == result.ErrorMessagesList()
                .Count;
            
            Check.That(validation).IsTrue();

        }
    }
}
