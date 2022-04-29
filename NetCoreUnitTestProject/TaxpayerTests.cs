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
    public partial class TaxpayerTests : TestBase
    {

        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidTaxpayerTest()
        {
            // arrange
            Taxpayer taxpayer = TheTaxpayer;

            // act
            EntityValidationResult result = Model.Validate(taxpayer);

            // assert
            Check.That(result.HasError).IsFalse();
            Check.That(result.IsValid).IsTrue();
        }
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void InValidTaxpayerTest()
        {
            // arrange
            Taxpayer taxpayer = TheTaxpayer;
            taxpayer.SSN = "12355123"; //  not enough digits

            // act
            EntityValidationResult result = Model.Validate(taxpayer);

            // assert
            //Check.That(result.HasError).IsFalse();
            Check.That(result.IsValid).IsFalse();

            result.ShowErrorMessages();
        }

    }

}