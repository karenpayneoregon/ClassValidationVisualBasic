using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BaseDataValidatorLibrary.Helpers;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using NFluent;
using static System.DateTime;
using BaseDataValidatorLibrary.LanguageExtensions;

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
        public void invalidFirstNamePerson()
        {

            // arrange
            Person person = new()
            {
                FirstName = "Mi",
                LastName = "Flowers",
                BirthDate = new DateTime(1932, Now.Month, Now.Day)
            };

            // act
            EntityValidationResult result = Model.Validate(person);


            // assert

            /*
             * Here there are two possible assertions
             */

            //Check.That(result.IsValid).IsFalse();

            Check.That(result.Errors.FirstOrDefault().ErrorMessage)
                .ContainsExactly("Invalid FirstName");

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


            var errorMessage = person.GetAttribute<RequiredAttribute>("BirthDate").ErrorMessage;

            // raw
            Console.WriteLine(errorMessage);
            // formatted 
            Console.WriteLine(errorMessage, "Birthdate");

            // assert
            Check.That(birthdayErrorInformation.ToString())
                .Equals("Valid range for BirthDate is from 1932 to 2022");

        }

        /// <summary>
        /// Different options for n-fluent asserts
        /// </summary>
        /// <remarks>
        /// There are two flavors, first commented out which is brittle as the property name is
        /// a string and thus if the property name changes the test will break while the
        /// second un-commented method will not break when renaming in this case FirstName in
        /// Visual Studio.
        /// </remarks>
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ListContainsExactlyTest()
        {

            object[] firstNames = { "Karen", "Mike", "Anne" };

            Check.That(People.Extracting("FirstName")).ContainsExactly(firstNames);

            Check.That(People.Extracting(nameof(Person.FirstName))).ContainsExactly(firstNames);

        }
    }

}