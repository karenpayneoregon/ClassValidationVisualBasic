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
    public partial class BooksTests
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

        public Book TheBook => new ()
        {
            Title = "Gone with the wind",
            ISBN = "9780024894403",
            Category = BookCategory.Romance,
            NotesList = new List<string>()
            {
                "Few books evoke the Civil War-era South " + 
                "so powerfully, compellingly, and iconically."
            }
        };

    }

}