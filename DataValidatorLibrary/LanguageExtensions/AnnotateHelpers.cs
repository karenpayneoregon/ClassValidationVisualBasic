using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DataValidatorLibrary.LanguageExtensions
{
    public static class AnnotateHelpers
    {
        /// <summary>
        /// Obtain property name and ErrorMessage for properties with a <see cref="RequiredAttribute"/>
        /// </summary>
        /// <typeparam name="T">Type to get messages</typeparam>
        /// <param name="sender">instantiated instance of T</param>
        /// <returns>Dictionary of names and error messages</returns>
        public static Dictionary<string, string> GetRequiredErrorMessages<T>(T sender)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            var type = typeof(T);
            PropertyInfo[] propertyInfo = type.GetProperties();

            foreach (PropertyInfo prop in propertyInfo)
            {
                object[] attributes = prop.GetCustomAttributes(true);

                foreach (var attribute in attributes)
                {

                    if (attribute.GetType() != typeof(RequiredAttribute))
                    {
                        continue;
                    }
                    else
                    {
                        var currentAttribute = (RequiredAttribute)attribute;
                        string propName = prop.Name;
                        string auth = currentAttribute.ErrorMessage;

                        dictionary.Add(propName, auth);
                    }


                }
            }

            return dictionary;
        }

    }
}
