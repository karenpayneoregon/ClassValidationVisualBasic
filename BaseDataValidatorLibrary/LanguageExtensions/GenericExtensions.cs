using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDataValidatorLibrary.LanguageExtensions
{
    public static class GenericExtensions
    {
        public static bool Between<TSource>(this IComparable<TSource> sender, TSource minimumValue, TSource maximumValue) =>
            sender.CompareTo(minimumValue) >= 0 && sender.CompareTo(maximumValue) <= 0;


    }
}
