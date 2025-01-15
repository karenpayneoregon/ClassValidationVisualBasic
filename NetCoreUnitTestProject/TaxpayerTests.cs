using BaseDataValidatorLibrary.Helpers;
using BaseDataValidatorLibrary.LanguageExtensions;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using static NetCoreUnitTestProject.Base.Trait;

namespace NetCoreUnitTestProject
{
  
    [TestClass]
    public partial class TaxpayerTests : TestBase
    {

        [TestMethod]
        [TestTraits(Annotations)]
        public void ValidTaxpayerTest()
        {
            // arrange
            Taxpayer taxpayer = Taxpayer;

            // act
            EntityValidationResult result = Model.Validate(taxpayer);

            // assert
            Check.That(result.IsValid).IsTrue();

        }

        [TestMethod]
        [TestTraits(Annotations)]
        public void InValidTaxpayerTest()
        {
            // arrange
            Taxpayer taxpayer = Taxpayer;
            taxpayer.SSN = "12355"; //  not enough digits

            // act
            EntityValidationResult result = Model.Validate(taxpayer);

            // assert
            //Check.That(result.HasError).IsFalse();
            Check.That(result.IsValid).IsFalse();

            result.ShowErrorMessages();
        }

    }

}