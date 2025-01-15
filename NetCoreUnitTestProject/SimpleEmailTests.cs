using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using static BaseDataValidatorLibrary.Classes.Annotate;
using static NetCoreUnitTestProject.Base.Trait;

namespace NetCoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class SimpleEmailTests : TestBase
    {

        [TestMethod]
        [TestTraits(Annotations)]
        public void SimpleSingleTest()
        {
            var result = ValidEmail("payne@gmail.com");
            Check.That(result).IsTrue();
        }

        [TestMethod]
        [TestTraits(Annotations)]
        public void SimpleSingleInvalidTest()
        {
            var result = ValidEmail("paynegmail.com");
            Check.That(result).IsFalse();
        }
        

        [TestMethod]
        [TestTraits(PlaceHolder)]
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
            public static List<Human> Humans =>
            [
                new Human() { Name = "Karen", Email = "karen@gmail" },
                new Human() { Name = "Bill", Email = "billgmail" },
                new Human() { Name = "Mike", Email = "mike@" },
                new Human() { Name = "Sue", Email = "sue@comcast.net" }
            ];
        }
    }

}