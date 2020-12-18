using System;

namespace Text
{
    /// <summary>
    /// method that determines how many words are in a string.
    /// Each word begins with a capital letter except the first word.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// camelCase
        /// </summary>
        public static int CamelCase(string s)
        {
            if (s.Length < 1)
            {
                return 0;
            }
            int count = 1;
            foreach (char letter in s)
            {
                if (Char.IsUpper(letter))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
