using System;
using System.Runtime.CompilerServices;
using BaseDataValidatorLibrary.Helpers;
using BaseModelsLibrary.Models;
using static System.DateTime;

namespace PersonValidationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonIsValid();
            Console.WriteLine();
            PersonIsNotValid();
            
            Console.ReadLine();
        }

        private static void PersonIsNotValid()
        {
            Title(nameof(PersonIsNotValid));
            Person person = Person;
            person.BirthDate = new DateTime(1931, Now.Month, Now.Day);

            EntityValidationResult result = Model.Validate(person);

            if (result.IsValid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }

        private static void PersonIsValid()
        {
            Title(nameof(PersonIsValid));
            Person person = Person;
            
            EntityValidationResult result = Model.Validate(person);

            if (result.IsValid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }

        private static Person Person => new()
        {
            FirstName = "Mike",
            LastName = "Flowers",
            BirthDate = new DateTime(1932, Now.Month, Now.Day)
        };

        private static void Title(string sender)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Running");
            Console.ResetColor();
            Console.Write($" {sender}\n");
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Verbs code samples";
        }
    }
}
