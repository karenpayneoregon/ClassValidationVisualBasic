using BaseDataValidatorLibrary.CommonRules;
using BaseDataValidatorLibrary.Helpers;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using static NetCoreUnitTestProject.Base.Trait;

namespace NetCoreUnitTestProject
{

    [TestClass]
    public partial class ValidKeyTests : TestBase
    {
        [TestMethod]
        [TestTraits(KeyAnnotations)]
        public void ValidKeyTest()
        {
            // arrange
            int value = 123456789;
            Athlete athlete = new () { Id = value, FirstName = "Jim", LastName = "Adams" };

            // act
            EntityValidationResult result = Model.Validate(athlete);

            // assert
            Check.That(result.IsValid).IsTrue();

        }
        [TestMethod]
        [TestTraits(Annotations)]
        public void NotValidBadIdKeyTest()
        {
            // arrange
            int value = 126456789;
            Athlete athlete = new() { Id = value, FirstName = "Jim", LastName = "Adams" };

            // act
            EntityValidationResult result = Model.Validate(athlete);

            // assert
            Check.That(result.IsValid).IsFalse();
            var isValid = new ValidKeyAttribute().IsValid(value);
        }

        [TestMethod]
        [TestTraits(Annotations)]
        public void NotValidNoIdKeyTest()
        {
            // arrange
            Athlete athlete = new() { FirstName = "Jim", LastName = "Adams" };
            // act
            EntityValidationResult result = Model.Validate(athlete);
            // assert
            Check.That(result.IsValid).IsFalse();

        }
    }
}
