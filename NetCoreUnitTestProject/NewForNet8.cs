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
using System.ComponentModel.DataAnnotations;

namespace NetCoreUnitTestProject;

/// <summary>
/// 
/// </summary>
[TestClass]
public partial class NewForNet8 : TestBase
{

    [TestMethod]
    [TestTraits(Trait.net8Additions)]
    public void IsValidState()
    {
        State state = _state;
        EntityValidationResult validationResult = Model.Validate(_state);
        Check.That(validationResult.HasError).IsFalse();
    }


            [TestMethod]
            [TestTraits(Trait.net8Additions)]
            public void IsNotValidState()
            {
                string expectedStateValue = "Invalid state";
                string expectedPostalValue = "Invalid postal code";
                State state = _state;
                state.Name = "California";
                state.PostalCode = "11111";
                EntityValidationResult validationResult = Model.Validate(_state);

                Check.That(validationResult.Errors[0].ErrorMessage)
                    .Equals(expectedStateValue);
                Check.That(validationResult.Errors[1].ErrorMessage)
                    .Equals(expectedPostalValue);
            }











}






