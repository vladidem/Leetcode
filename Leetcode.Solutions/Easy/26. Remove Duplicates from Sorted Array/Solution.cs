﻿namespace Leetcode.Solutions.Easy._26._Remove_Duplicates_from_Sorted_Array;

/// <summary>
///     https://leetcode.com/problems/remove-duplicates-from-sorted-array/
/// </summary>
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int lastUnique = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[lastUnique])
            {
                lastUnique++;
                nums[lastUnique] = nums[i];
            }
        }

        return lastUnique + 1;
    }
}
