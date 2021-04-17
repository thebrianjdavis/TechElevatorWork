﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return the sum of the first 2 elements in the array. If the array length
          is less than 2, just sum up the elements that exist, returning 0 if the array is length 0.
         Sum2([1, 2, 3]) → 3
         Sum2([1, 1]) → 2
         Sum2([1, 1, 1, 1]) → 2
         */
        public int Sum2(int[] nums)
        {
            int sumValue = 0;
            if (nums.Length >= 2)
            {
                sumValue = nums[0] + nums[1];
            }
            else if (nums.Length == 1)
            {
                sumValue = nums[0];
            }
            else
            {
                sumValue = 0;
            }
            return sumValue;
        }
    }
}
