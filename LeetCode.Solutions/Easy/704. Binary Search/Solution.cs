namespace LeetCode.Solutions.Easy._704_Binary_Search;

/// <summary>
///     https://leetcode.com/problems/binary-search/
/// </summary>
public class Solution
{
    public int Search(int[] nums, int target)
    {
        return SearchIterative(nums, target);
    }

    public int SearchRecursive(int[] nums, int target, int left, int right)
    {
        if (left > right || (left == right && nums[left] != target))
            return -1;
        int mid = left + (right - left) / 2;

        if (nums[mid] == target) return mid;

        if (target < nums[mid])
            return SearchRecursive(nums, target, left, mid - 1);

        return SearchRecursive(nums, target, mid + 1, Math.Min(right, nums.Length - 1));
    }

    public int SearchIterative(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target) return mid;
            if (target < nums[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;
    }
}
