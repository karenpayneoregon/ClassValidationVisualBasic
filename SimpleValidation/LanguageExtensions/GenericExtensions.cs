using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleValidation.LanguageExtensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Determine if a value is within a specified range
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="value">value to determine if between lowerValue and upperValue</param>
        /// <param name="lowerValue">lower value</param>
        /// <param name="upperValue">upper value</param>
        /// <returns>bool</returns>
        public static bool Between<T>(this T value, T lowerValue, T upperValue) where T : struct, IComparable<T>
            => Comparer<T>.Default.Compare(value, lowerValue) >= 0 &&
               Comparer<T>.Default.Compare(value, upperValue) <= 0;

        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                if (child is T thisControl)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
    }
}
