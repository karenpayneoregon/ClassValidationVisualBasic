using BaseDataValidatorLibrary.Helpers;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace NetCoreUnitTestProject
{

    [TestClass]
    public partial class GreaterThanAttributeTests : TestBase
    {

        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void TripEndDateIsValid()
        {
            Trip trip = new ()
            {
                StartDate = new DateTime(2022, 2, 23), 
                EndDate = new DateTime(2022, 2, 27)
            };

            EntityValidationResult result = Model.Validate(trip);

            // assert
            Check.That(result.IsValid).IsTrue();

        }
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void TripEndDateIsInvalid()
        {
            Trip trip = new ()
            {
                StartDate = new DateTime(2022, 2, 23),
                EndDate = new DateTime(2022, 2, 22)
            };

            EntityValidationResult result = Model.Validate(trip);

            // assert
            Check.That(result.IsValid).IsFalse();

        }

        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void SomeItemIsValid()
        {
            // arrange
            SomeItem someItem = new () { Min = 12, Max = 15 };

            // act
            EntityValidationResult result = Model.Validate(someItem);

            // assert
            Check.That(result.IsValid).IsTrue();

        }
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void SomeItemIsNotValid()
        {
            // arrange
            SomeItem someItem = new() { Min = 12, Max = 1 };

            // act
            EntityValidationResult result = Model.Validate(someItem);

            // assert
            Check.That(result.IsValid).IsFalse();

        }
    }

}