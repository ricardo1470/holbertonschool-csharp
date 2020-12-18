using System;
using System.Collections.Generic;

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
			if (nums == null || nums.Count == 0)
			{
				return (0);
			}
			int num_max = nums[0];

			foreach (int i in nums)
			{
				num_max = i > num_max ? i : num_max;
			}
			return num_max;
		}
    }
}
