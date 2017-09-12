using System;
using System.Text.RegularExpressions;

namespace SK.CSharpExtensions
{
    public static class EnumExtensions
    {
        public static string ToHumanReadableString(this Enum value)
        {
            var regex = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
            return regex.Replace(value.ToString(), " ");
        }
    }
}
