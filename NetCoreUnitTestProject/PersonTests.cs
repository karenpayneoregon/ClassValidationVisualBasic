using System;
using System.Linq;
using BaseDataValidatorLibrary.Helpers;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using static System.DateTime;

namespace NetCoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class PersonTests : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidPerson()
        {

            // arrange
            Person person = new ()
            {
                FirstName = "Mike",
                LastName = "Flowers",
                BirthDate = new DateTime(1932, Now.Month, Now.Day)
            };

            // act
            EntityValidationResult result = Model.Validate(person);

            // assert
            Check.That(result.IsValid).IsTrue();
        }

        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void InvalidDateValidPerson()
        {
            // arrange
            DateTime date = new (2022, 4, 27);

            Person person = new ()
            {
                FirstName = "Mike",
                LastName = "Flowers",
                BirthDate = new DateTime(1931, date.Month, date.Day)
            };

            // act
            EntityValidationResult result = Model.Validate(person);

            // assert
            Check.That(result.IsValid).IsFalse();

        }

        /// <summary>
        /// For <see cref="Model.GetValidateYearsErrorMessages(T)"/>
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidateYearsInformationInvalidDateValidPerson()
        {


            // arrange
            DateTime date = new(2022, 4, 27);

            Person person = new()
            {
                FirstName = "Mike",
                LastName = "Flowers",
                BirthDate = new DateTime(1931, date.Month, date.Day)
            };

            // act
            var birthdayErrorInformation = 
                Model.GetValidateYearsErrorMessages(person)
                    .FirstOrDefault();


            // assert
            Check.That(birthdayErrorInformation.ToString())
                .Equals("Valid range for BirthDate is from 1932 to 2022");

        }
    }

}