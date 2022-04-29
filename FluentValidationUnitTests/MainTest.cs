using System;
using System.Threading.Tasks;
using FluentLocalLibrary.LanguageExtensions;
using FluentValidationUnitTests.Base;
using FluentValidationUnitTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using FluentValidation.TestHelper;
using NFluent.Helpers;

namespace FluentValidationUnitTests
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task ReadOregonDataTest()
        {
            // arrange
            var expected = 411;
            
            // act
            var data = await Operations.ReadOregonInformation();


            // assert
            Check.That(data.Count).Equals(expected);

        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task CleanCustomerTest()
        {
            // arrange
            Customer thisCustomer = ValidCustomer;

            // act
            var result = await CustomerValidator.ValidateAsync(thisCustomer);

            // assert
            Check.That(result.IsValid).IsTrue();
        }


        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task CustomerNoFirstNameNoLastNameTest()
        {
            // arrange
            Customer thisCustomer = ValidCustomer;
            thisCustomer.FirstName = "";
            thisCustomer.LastName = "";


            // act
            var result = await CustomerValidator.TestValidateAsync(thisCustomer);
            
            // assert
            result.ShouldHaveValidationErrorFor(customer => customer.FirstName);
            result.ShouldHaveValidationErrorFor(customer => customer.LastName);

        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task CustomerBadEmailTest()
        {
            // arrange
            Customer thisCustomer = ValidCustomer;
            thisCustomer.Email = "karenGmail";

            // act
            var result = await CustomerValidator.TestValidateAsync(thisCustomer);

            // assert
            result.ShouldHaveValidationErrorFor(customer => customer.Email);

        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task CustomerInvalidPostalCodeTest()
        {
            // arrange
            Customer thisCustomer = ValidCustomer;
            thisCustomer.Postcode = "99999";

            // act
            var result = await CustomerValidator.TestValidateAsync(thisCustomer);

            // assert
            result.ShouldHaveValidationErrorFor(customer => customer.Postcode);

        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task CustomerInvalidPrimaryKeyTest()
        {
            // arrange
            Customer thisCustomer = ValidCustomer;
            thisCustomer.Id = 0;

            // act
            var result = await CustomerValidator.TestValidateAsync(thisCustomer);

            // assert
            result.ShouldHaveValidationErrorFor(customer => customer.Id);

        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task CustomerInvalidPinTest()
        {
            // arrange
            Customer thisCustomer = ValidCustomer;
            thisCustomer.Pin = "5555";  // must be greater than 8888

            // act
            var result = await CustomerValidator.TestValidateAsync(thisCustomer);

            // assert
            result.ShouldHaveValidationErrorFor(customer => customer.Pin);
        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task CustomerBirthDateInvalidTest()
        {
            // arrange
            Customer thisCustomer = ValidCustomer;
            thisCustomer.BirthDate = new DateTime(1930, 1, 1);

            // act
            var result = await CustomerValidator.TestValidateAsync(thisCustomer);

            // assert
            result.ShouldHaveValidationErrorFor(customer => customer.BirthDate);
        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task CustomerSocialSecurityNumberInvalidTest()
        {
            // arrange
            Customer thisCustomer = ValidCustomer;
            thisCustomer.SocialSecurity = "219-09-9999";

            // act
            var result = await CustomerValidator.TestValidateAsync(thisCustomer);

            // assert
            result.ShouldHaveValidationErrorFor(customer => customer.SocialSecurity);
        }

        [TestMethod]
        [TestTraits(Trait.FluentValidationExtended)]
        public void Extended_1_Test()
        {
            new[] { 1, 2, 3 }.KarenVerifies().IsEquivalentTo(3, 2, 1);
        }

    }
}

