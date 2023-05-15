using System.Collections.Generic;
using System;

namespace System.Linq
{
    /// <summary>
    /// 
    /// </summary>
    public static class LinqHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TSource FirstOrEmptyException<TSource>(this IEnumerable<TSource> source)
        {
            source.ThrowIfNullOrEmpty(nameof(source));
            return source.First();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<TSource>(this IEnumerable<TSource> source)
        {
            return source == null || !source.Any();
        }
    }
}
