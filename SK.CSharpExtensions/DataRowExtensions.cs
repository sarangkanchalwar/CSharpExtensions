using System;
using System.Data;

namespace SK.CSharpExtensions
{
    public static class DataRowExtensions
    {
        public static int GetInt(this DataRow row, string parameter)
        {
            return row[parameter] is DBNull ? 0 : Convert.ToInt32(row[parameter]);
        }

        public static int GetInt(this DataRow row, int columnIndex)
        {
            return row[columnIndex] is DBNull ? 0 : Convert.ToInt32(row[columnIndex]);
        }

        public static string GetString(this DataRow row, string parameter)
        {
            return row[parameter] is DBNull ? string.Empty : ((string)row[parameter]).ToCleanString();
        }        
        
        public static string GetString(this DataRow row, int columnIndex)
        {
            return row[columnIndex] is DBNull ? string.Empty : ((string)row[columnIndex]).ToCleanString();
        }

        public static bool GetBool(this DataRow row, string parameter)
        {
            return !(row[parameter] is DBNull) && ((bool)row[parameter]);
        }

        public static bool GetBool(this DataRow row, int columnIndex)
        {
            return !(row[columnIndex] is DBNull) && ((bool)row[columnIndex]);
        }
    }
}
