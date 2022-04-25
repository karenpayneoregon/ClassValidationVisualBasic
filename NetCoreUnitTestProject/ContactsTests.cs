using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BaseDataValidatorLibrary.Helpers;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace NetCoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class ContactsTests : TestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidContact()
        {
            // arrange
            var contact = TheContact;

            // act
            EntityValidationResult validationResult = ValidationHelper.ValidateEntity(contact);
            
            // assert
            Check.That(validationResult.HasError).IsFalse();
        }

    }

}