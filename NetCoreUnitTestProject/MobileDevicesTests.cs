using BaseDataValidatorLibrary.Helpers;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace NetCoreUnitTestProject
{
    /// <summary>
    /// Example using upper-cased rule
    /// </summary>
    [TestClass]
    public partial class MobileDevicesTests : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void MobileDevicesValidTest()
        {
            MobileDeviceCodes mobileDevice = new()
            {
                Code = 'P',
                Description = "Phone"
            };

            EntityValidationResult result = Model.Validate(mobileDevice);
            Check.That(result.IsValid).IsTrue();

        }
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void MobileDeviceInvalidCodeTest()
        {
            MobileDeviceCodes mobileDevice = new()
            {
                Code = 'p',
                Description = "Phone"
            };

            EntityValidationResult result = Model.Validate(mobileDevice);
            
            Check.That(result.IsValid).IsFalse();

        }
    }

}