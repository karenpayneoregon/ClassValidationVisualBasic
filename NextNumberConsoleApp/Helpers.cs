using System.Text.RegularExpressions;

namespace NextNumberConsoleApp
{
    class Helpers
    {
        public static string NextValue(string value)
        {
            string number = Regex.Match(value, "[0-9]+$").Value;
            return value.Substring(0, value.Length - number.Length) + (long.Parse(number) + 1).ToString().PadLeft(number.Length, '0');
        }
    }
}