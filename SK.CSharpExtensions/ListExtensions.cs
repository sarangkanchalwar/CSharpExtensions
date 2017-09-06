using System;
using System.Collections.Generic;

namespace SK.CSharpExtensions
{
    public static class ListExtensions
    {
        public static bool IsFirst<T>(this IList<T> list, T item)
        {
            if (item == null) throw new ArgumentNullException("Item can not be null.");

            return (list.IndexOf(item) == 0);
        }

        public static bool IsLast<T>(this IList<T> list, T item)
        {
            if (item == null) throw new ArgumentNullException("Item can not be null.");

            return list.IndexOf(item).Equals(list.Count - 1);
        }
    }
}
