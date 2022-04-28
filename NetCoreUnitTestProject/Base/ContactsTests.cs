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
    public partial class ContactsTests
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

        public static Contact TheContact => new()
        {
            FirstName = "Karen",
            LastName = "Payne",
            BusinessEmail = "payne@abc.net",
            PersonalEmail = "payne@home.com",
            Phone = "1234567890"
        };

    }

}