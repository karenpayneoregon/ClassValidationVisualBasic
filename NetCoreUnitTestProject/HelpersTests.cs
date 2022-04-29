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
using BaseModelsLibrary.Models;
using FluentLocalLibrary.LanguageExtensions;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace NetCoreUnitTestProject
{

    [TestClass]
    public partial class HelpersTests : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.AnnotationsHelpers)]
        public void RequiredErrorMessages_Test()
        {
            // arrange
            Dictionary<string, string> expected = new()
            {
                ["Title"] = "{0} is required",
                ["ISBN"] = "{0} is required",
                ["Category"] = "{0} is required",
            };


            Book book = new();

            // act
            var result = Model.GetRequiredErrorMessages(book);

            // assert
            CollectionAssert.AreEqual(
                expected.OrderBy(kv => kv.Key).ToList(),
                result.OrderBy(kv => kv.Key).ToList()
            );


        }


    }

}