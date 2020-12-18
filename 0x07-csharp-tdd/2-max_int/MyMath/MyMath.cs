using System;

namespace MyMath
{
    /// <summary>
    /// method that returns the max integer in a list of integers.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// method that returns max integer in a list
        /// </summary>
        public static int Max(List<int> nums)
        {
            int i = 0;
            if (nums.Count > 0)
            {
                foreach (int num in nums)
                {
                    if (num > i)
                    {
                        i = num;
                    }
                }
            }
            return i;
        }
    }
}
