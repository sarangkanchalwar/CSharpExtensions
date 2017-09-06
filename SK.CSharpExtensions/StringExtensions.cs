﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SK.CSharpExtensions
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        public static bool IsNumeric(this string text)
        {
            try
            {
                var value = decimal.Parse(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string TitleCaseToHumanReadableString(this string text)
        {
            var regex = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
            return regex.Replace(text, " ");
        }

        public static string ToCleanString(this string stringValue)
        {
            var cleanString = stringValue.Trim().Replace("\n", "");
            do
            {
                cleanString = cleanString.Replace("  ", " ");
            } while (cleanString.Contains("  "));
            return cleanString;
        }
    }
}
