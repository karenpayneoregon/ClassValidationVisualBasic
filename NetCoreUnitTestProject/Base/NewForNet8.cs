using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModelsLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace NetCoreUnitTestProject;

public partial class NewForNet8
{
    private State _state;
    [TestInitialize]
    public void Initialization()
    {
        _state = new State() { Id = 1, Name = "Oregon", PostalCode = "22222"};
    }

    /// <summary>
    /// Perform any initialize for the class
    /// </summary>
    /// <param name="testContext"></param>
    [ClassInitialize()]
    public static void ClassInitialize(TestContext testContext)
    {
        TestResults = new List<TestContext>();
    }

}