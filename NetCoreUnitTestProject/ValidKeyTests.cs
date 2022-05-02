using BaseDataValidatorLibrary.CommonRules;
using BaseDataValidatorLibrary.Helpers;
using BaseDataValidatorLibrary.LanguageExtensions;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace NetCoreUnitTestProject
{

    [TestClass]
    public partial class ValidKeyTests : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Annotations)]
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
        [TestTraits(Trait.Annotations)]
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
        [TestTraits(Trait.Annotations)]
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
    //var test = new ValidKeyAttribute().IsValid(value);
    //Check.That(test).IsFalse();