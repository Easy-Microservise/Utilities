namespace System.Text
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// all valid encode chars
        /// </summary>
        public const string ValidEncodeChars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// check the string is not null or empty
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool HasValue(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// check the string is null or empty
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="keyChars"></param>
        /// <returns></returns>
        public static string EncodeByKey(long value, string keyChars = ValidEncodeChars)
        {
            int count = 32;
            char[] bufferData = new char[count];
            long charLength = keyChars.Length;
            do
            {
                bufferData[--count] = keyChars[(int)(value % charLength)];
                value /= charLength;
            }
            while (value > 0);

            char[] result = new char[32 - count];
            Array.Copy(bufferData, count, result, 0, 32 - count);

            return new string(result);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="keyChars"></param>
        /// <returns></returns>
        public static long DecodeByKey(string value, string keyChars = ValidEncodeChars)
        {
            long result = 0;
            int charLength = keyChars.Length;
            int count = value.Length - 1;
            for (int i = 0; i < value.Length; i++)
            {
                result += keyChars.IndexOf(value[i]) * ((long)Math.Pow(charLength, count));
                count--;
            }

            return result;
        }
    }
}
