using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace System
{
    /// <summary>
    /// 
    /// </summary>
    public static class ExceptionHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="name"></param>
        public static void ThrowIfNull<T>(this T source, string name)
            where T : class
        {
            if (source == null)
            {
                if (name.HasValue())
                {
                    throw new NullReferenceException(name);
                }
                else
                    throw new NullReferenceException(nameof(source));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="name"></param>
        public static void ThrowIfNullOrEmpty<T>(this IEnumerable<T> source, string name = default)
        {
            if (source.IsNullOrEmpty())
            {
                if (name.HasValue())
                {
                    throw new NullReferenceException($"{name} of type IEnumerable<{typeof(T).FullName}>");
                }
                else
                    throw new NullReferenceException($"{nameof(source)} of type IEnumerable<{typeof(T).FullName}>");
            }
        }
    }
}
