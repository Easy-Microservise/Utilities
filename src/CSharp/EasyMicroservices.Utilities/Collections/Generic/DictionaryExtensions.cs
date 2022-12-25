namespace System.Collections.Generic
{
    /// <summary>
    /// Extensions method helper for dictionary
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool TryAddItem<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
#if (NET45 || NETSTANDARD2_0)
            if (dictionary.ContainsKey(key))
                return false;
            dictionary[key] = value;
            return true;
#else
            return dictionary.TryAdd(key, value);
#endif
        }
    }
}
