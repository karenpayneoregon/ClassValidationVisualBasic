using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModelsLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace NetCoreUnitTestProject
{
    public partial class TaxpayerTests
    {
        [TestInitialize]
        public void Initialization()
        {

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

        public Taxpayer TheTaxpayer = new()
        {
            FirstName = "Mary",
            LastName = "Smith",
            SSN = "205661234"
        };

    }

}