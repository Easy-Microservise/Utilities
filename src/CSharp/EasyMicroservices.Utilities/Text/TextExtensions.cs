using System.Collections.Generic;

namespace System
{
    /// <summary>
    /// Text extensions methods
    /// </summary>
    public static class TextExtensions
    {
        /// <summary>
        /// split by count
        /// </summary>
        /// <param name="input"></param>
        /// <param name="separator"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string[] SplitCount(this string input, char separator, int count)
        {
            return SplitCount(input, separator.ToString(), count);
        }

        /// <summary>
        /// split by count
        /// </summary>
        /// <param name="input"></param>
        /// <param name="separator"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string[] SplitCount(this string input, string separator, int count)
        {
            List<string> result = new(count);
            int startIndex = 0;
            int separatorLength = separator.Length;
            string endOfString = input;
            for (int i = 0; i < count; i++)
            {
                var index = endOfString.IndexOf(separator);
                if (index < 0)
                {
                    break;
                }
                var separtorIndex = index;
                if (separtorIndex > 1)
                {
                    separtorIndex += separatorLength - 1;
                }
                string first = endOfString.Substring(startIndex, index);
                if (first.Length > separatorLength)
                {
                    result.Add(first.Substring(0, first.Length));
                }
                else if (first.Length > 0 && first != separator)
                {
                    result.Add(first);
                }
                endOfString = endOfString.Substring(separtorIndex + 1);
            }
            if (result.Count < count && !string.IsNullOrEmpty(endOfString))
            {
                result.Add(endOfString);
            }
            return result.ToArray();
        }
    }
}
