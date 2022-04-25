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
using BaseDataValidatorLibrary.LanguageExtensions;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace NetCoreUnitTestProject
{

    [TestClass]
    public partial class BooksTests : TestBase
    {

        [TestMethod]
        [TestTraits(Trait.Books)]
        public void ValidateBook_Good_Test()
        {
            // arrange
            Book book = TheBook;
            
            // act
            EntityValidationResult validationResult = ValidationHelper.ValidateEntity(book);

            // assert
            Check.That(validationResult.HasError).IsFalse();
        }

        [TestMethod]
        [TestTraits(Trait.Books)]
        public void ValidateBook_NoCategory_Test()
        {
            // arrange
            Book book = TheBook;
            book.Category = null;
            string expected = "Category is required";

            // act
            EntityValidationResult result = ValidationHelper.ValidateEntity(book);

            // assert
            Check.That(result.Errors.Any(validationResult => 
                validationResult.ErrorMessage!.Contains(expected)))
                .IsTrue();
        }
        [TestMethod]
        [TestTraits(Trait.Books)]
        public void ValidateBook_NoIsbn_Test()
        {
            // arrange
            Book book = TheBook;
            book.ISBN = "";
            string expected = "ISBN is required";

            // act
            EntityValidationResult result = ValidationHelper.ValidateEntity(book);

            // assert
            Check.That(result.Errors.Any(validationResult => 
                validationResult.ErrorMessage!.Contains(expected)))
                .IsTrue();

        }
        [TestMethod]
        [TestTraits(Trait.Books)]
        public void ValidateBook_EmptyBook_Test()
        {
            // arrange
            Book book = new Book();

            // act
            EntityValidationResult result = ValidationHelper.ValidateEntity(book);


            // assert
            Check.That(result.Errors.Count).Equals(4);

        }
    }

}