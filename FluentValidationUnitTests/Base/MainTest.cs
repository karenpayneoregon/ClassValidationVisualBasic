using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidationUnitTests.Classes;


// ReSharper disable once CheckNamespace - do not change
namespace FluentValidationUnitTests
{
    public partial class MainTest
    {
        private CustomerValidator CustomerValidator;
        /// <summary>
        /// Perform initialization before test runs using assertion on current test name.
        /// </summary>
        [TestInitialize]
        public void Initialization()
        {
            CustomerValidator = new CustomerValidator();
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

        public static Customer ValidCustomer => new Customer
        {
            Id = 1,
            FirstName = "Karen",
            LastName = "Payne",
            BirthDate = new DateTime(1956,9,24),
            Pin = "8889",
            Email = "kp@gmail.com",
            CreditLimit = 9999,
            Discount = 10, // TODO
            SocialSecurity = "205-55-1234",
            HasDiscount = true,
            Address = "101 Microsoft Way",
            Postcode = "97209"
        };
    }
}
