﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints length 3, figure out which is larger between the first and last elements
         in the array, and set all the other elements to be that value. Return the changed array.
         MaxEnd3([1, 2, 3]) → [3, 3, 3]
         MaxEnd3([11, 5, 9]) → [11, 11, 11]
         MaxEnd3([2, 11, 3]) → [3, 3, 3]
         */
        public int[] MaxEnd3(int[] nums)
        {
            int newValue = 0;
            if (nums[0] > nums[nums.Length - 1])
            {
                newValue = nums[0];
            }
            else
            {
                newValue = nums[nums.Length - 1];
            }
            return new int[] {newValue, newValue, newValue };
        }
    }
}