using System.Collections.Generic;

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
        public static bool HasAny<TSource>(this IEnumerable<TSource> source)
        {
            return source != null && source.Any();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsEmpty<TSource>(this IEnumerable<TSource> source)
        {
            return source == null || !source.Any();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static TResult FirstOrDefaultSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            if (source == null)
                return default;
            return source.Select(selector).FirstOrDefault();
        }
    }
}
