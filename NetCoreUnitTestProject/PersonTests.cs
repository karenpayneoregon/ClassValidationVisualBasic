using System;
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
            Person person = new ()
            {
                FirstName = "Mike",
                LastName = "Flowers",
                BirthDate = new DateTime(1931, Now.Month, Now.Day)
            };

            // act
            EntityValidationResult result = Model.Validate(person);

            // assert
            Check.That(result.IsValid).IsFalse();

        }
    }

}