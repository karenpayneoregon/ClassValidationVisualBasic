using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NFluent.Extensibility;
using NFluent.Kernel;

namespace FluentLocalLibrary.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class FluentExtensions
    {
        /// <summary>
        /// Provides entry point to NFluent checks using extension syntax
        /// </summary>
        /// <param name="sender">the system under test</param>
        /// <typeparam name="T">Type of the system under test.</typeparam>
        /// <returns>an Instance of <see cref="ICheck{T}"/></returns>
        public static ICheck<T> KarenVerifies<T>(this T sender)
        {
            return Check.That(sender);
        }

        public static ICheckLink<ICheck<char>> IsADigit(this ICheck<char> sender)
        {
            var checker = ExtensibilityHelper.ExtractChecker(sender);

            return checker.ExecuteCheck(
                () =>
                {
                    if (!char.IsDigit(checker.Value))
                    {
                        throw new FluentCheckException(
                            checker.BuildMessage("The {0} is not a decimal digit.").ToString());
                    }
                },
                checker.BuildMessage("The {0} is a decimal digit whereas it must not.").ToString());
        }

    }
}
