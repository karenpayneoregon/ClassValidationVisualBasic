using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BaseDataValidatorLibrary.Helpers;
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
    public partial class TaxpayerTests : TestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidTaxpayerTest()
        {
            // arrange
            Taxpayer taxpayer = TheTaxpayer;

            // act
            EntityValidationResult validationResult = ValidationHelper.ValidateEntity(taxpayer);

            // assert
            Check.That(validationResult.HasError).IsFalse();
        }

        [TestMethod]
        [TestTraits(Trait.AnnotationsHelpers)]
        public void RequiredErrorMessages_Test()
        {
            // arrange
            Dictionary<string, string> expected = new Dictionary<string, string>()
            {
                ["Title"] = "{0} is required",
                ["ISBN"] = "{0} is required",
                ["Category"] = "{0} is required",
            };

            
            Book book = new ();

            // act
            var result = ValidationHelper.GetRequiredErrorMessages(book);

            // assert
            CollectionAssert.AreEqual(
                expected.OrderBy(kv => kv.Key).ToList(),
                result.OrderBy(kv => kv.Key).ToList()
            );


        }
    }

}