using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using static BaseDataValidatorLibrary.Classes.Annotate;

namespace NetCoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class SimpleEmailTests : TestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void SimpleSingleTest()
        {
            var result = ValidEmail("payne@gmail.com");
            Check.That(result).IsTrue();
        }
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void SimpleSingleInvalidTest()
        {
            var result = ValidEmail("paynegmail.com");
            Check.That(result).IsFalse();
        }




        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void ListTest()
        {
            var humans = Mocked.Humans;


            var results = humans
                .Select(x => new { Human = x, IsValid = ValidEmail(x.Email) }).ToList();

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Human.Name,-15}{result.IsValid}");
            }
        }


        public class Human
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
        public class Mocked
        {
            public static List<Human> Humans => new List<Human>()
            {
                new Human() {Name = "Karen", Email = "karen@gmail"},
                new Human() {Name = "Bill", Email = "billgmail"},
                new Human() {Name = "Mike", Email = "mike@"},
                new Human() {Name = "Sue", Email = "sue@comcast.net"},
            };
        }
    }

}