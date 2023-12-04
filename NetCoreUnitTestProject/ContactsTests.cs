using BaseDataValidatorLibrary.Helpers;
using BaseDataValidatorLibrary.LanguageExtensions;
using BaseModelsLibrary.Models;

using FluentAssertions;

using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using NFluent;

namespace NetCoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class ContactsTests : TestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidContact_Test()
        {
            // arrange
            var contact = TheContact;

            // act
            EntityValidationResult result = Model.Validate(contact);
            
            // assert
            Check.That(result.HasError).IsFalse();
        }

        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void EmptyContactTest()
        {
            // arrange
            var contact = new Contact();

            List<string> expected = new()
            {
                "First Name Required",
                "Last Name Required",
                "Please Enter Email Address",
                "Please enter your Personal Email email address",
                "Mobile number is required"
            };


            // act
            EntityValidationResult result = Model.Validate(contact);

            // assert
     
            expected.Should().Equal(result.ErrorMessagesList());

        }

    }

}