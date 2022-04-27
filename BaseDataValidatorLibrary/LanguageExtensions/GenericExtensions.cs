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

        /// <summary>
        /// Get ErrorMessage for specific Attribute
        /// </summary>
        /// <typeparam name="T">Attribute</typeparam>
        /// <param name="instance">instance of a class</param>
        /// <param name="propertyName">Property name in instance to get error message</param>
        /// <returns>error message</returns>
        public static T GetAttribute<T>(this object instance, string propertyName) where T : Attribute
        {
            var attrType = typeof(T);
            var property = instance.GetType().GetProperty(propertyName);
            return (T)property!.GetCustomAttributes(attrType, false).First();
        }
    }
}
