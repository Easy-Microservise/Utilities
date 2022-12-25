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
            List<string> result = new List<string>();
            int startIndex = 0;
            string endOfString = input;
            for (int i = 0; i < count; i++)
            {
                var index = endOfString.IndexOf(separator);
                if (index < 0)
                    break;

                string first = endOfString.Substring(startIndex, index);
                if (first.Length > separator.Length)
                {
                    result.Add(first.Substring(0, first.Length));
                }
                else if (first.Length > 0 && first != separator)
                    result.Add(first);
                endOfString = endOfString.Substring(index + 1);
            }
            if (!string.IsNullOrEmpty(endOfString))
                result.Add(endOfString);
            return result.ToArray();
        }
    }
}
