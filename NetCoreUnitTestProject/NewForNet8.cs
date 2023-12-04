using BaseDataValidatorLibrary.Helpers;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

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






