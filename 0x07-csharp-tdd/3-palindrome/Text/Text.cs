using System;

namespace Text
{
    /// <summary>
    /// method that returns True if a string.
    /// is a palindrome or False if it’s not.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// returns True if a string.
        /// is a palindrome or False if it’s not.
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int left = 0, right = s.Length - 1;
            while ((left != right) && (right >= 0) && (left < s.Length))
            {
                while ((left < s.Length) && (!Char.IsLower(s[left])))
                {
                    left++;
                }
                while ((right >= 0) && (!Char.IsLower(s[right])))
                {
                    right--;
                }
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
