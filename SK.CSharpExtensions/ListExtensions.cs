using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SK.CSharpExtensions
{
    public static class ListExtensions
    {
        public static bool IsFirst<T>(this List<T> list, T item)
        {
            if (item == null) throw new ArgumentNullException("Item can not be null.");

            return (list.IndexOf(item) == 0);
        }

        public static bool IsLast<T>(this List<T> list, T item)
        {
            if (item == null) throw new ArgumentNullException("Item can not be null.");

            return list.LastIndexOf(item).Equals(list.Count - 1);
        }
    }
}
