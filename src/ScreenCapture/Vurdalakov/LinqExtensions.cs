namespace Vurdalakov
{
    using System;
    using System.Collections.Generic;

    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (null == source)
            {
                throw new ArgumentNullException("source");
            }
            if (null == action)
            {
                throw new ArgumentNullException("action");
            }

            foreach (T item in source)
            {
                action(item);
            }
        }
    }
}
