using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.CSharpExtensions
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this String text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        public static bool IsNumeric(this String text)
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
    }
}
