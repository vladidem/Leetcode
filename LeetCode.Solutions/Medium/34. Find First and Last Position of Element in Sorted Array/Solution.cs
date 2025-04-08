namespace LeetCode.Solutions.Medium._34_Find_First_and_Last_Position_of_Element_in_Sorted_Array;

/// <summary>
///     https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
/// </summary>
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (target < nums[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }

        if (left > nums.Length || left <= 0 || nums[left - 1] != target)
            return [-1, -1];

        int rangeEnd = left - 1;
        left = 0;
        right = rangeEnd;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (target > nums[mid])
                left = mid + 1;
            else
                right = mid - 1;
        }

        int rangeStart = left;

        return [rangeStart, rangeEnd];
    }
}
