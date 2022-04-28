using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModelsLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.DateTime;

// ReSharper disable once CheckNamespace
namespace NetCoreUnitTestProject
{
    public partial class PersonTests
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

        public static List<Person> People => new()
        {
            new Person() {FirstName = "Karen", LastName = "Payne", BirthDate = new DateTime(1956, 9, 24)},
            new Person() {FirstName = "Mike", LastName = "Smith", BirthDate = new DateTime(1957, 1, 2)},
            new Person() {FirstName = "Anne", LastName = "Jackson", BirthDate = new DateTime(1958, 4, 4)},
        };

    }

}