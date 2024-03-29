﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModelsLibrary.Models;


// ReSharper disable once CheckNamespace - do not change
namespace NetCoreUnitTestProject
{
    public partial class CustomerLoginTest
    {
        /// <summary>
        /// Perform initialization before test runs using assertion on current test name.
        /// </summary>
        [TestInitialize]
        public void Initialization()
        {
            if (TestContext.TestName == nameof(ValidateCustomerLogin_Good_Test))
            {
                // TODO
            }
        }

        /// <summary>
        /// Perform cleanup after test runs using assertion on current test name.
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName == nameof(ValidateCustomerLogin_Good_Test))
            {
                // TODO
            }
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

        private static CustomerLogin CustomerLoginValid => new ()
        {
            Name = "JaneDoe",
            EntryDate = new DateTime(2022, 4, 25),
            Password = "@Password",
            PasswordConfirmation = "@Password"
        };
    }
}
