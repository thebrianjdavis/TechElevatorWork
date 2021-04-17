﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if 6 appears as either the first or last element in the array.
         The array will be length 1 or more.
         FirstLast6([1, 2, 6]) → true
         FirstLast6([6, 1, 2, 3]) → true
         FirstLast6([13, 6, 1, 2, 3]) → false
         */
        public bool FirstLast6(int[] nums)
        {
            bool numIsSix = false;
            if (nums[0] == 6 || nums[nums.Length - 1] == 6)
            {
                numIsSix = true;
            }
            return numIsSix;
        }
    }
}
