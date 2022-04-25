using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BaseDataValidatorLibrary.Helpers;
using BaseDataValidatorLibrary.LanguageExtensions;
using BaseModelsLibrary.Models;
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
            EntityValidationResult validationResult = ValidationHelper.ValidateEntity(contact);
            
            // assert
            Check.That(validationResult.HasError).IsFalse();
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
            EntityValidationResult validationResult = ValidationHelper.ValidateEntity(contact);

            // assert
            CollectionAssert.AreEqual(expected, validationResult.ErrorMessagesList());
 
        }

    }

}