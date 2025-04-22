namespace LeetCode.Solutions.Medium._198_House_Robber;

/// <summary>
///     https://leetcode.com/problems/house-robber/
/// </summary>
public class Solution
{
    private Dictionary<int, int> cache = new();

    public int Rob(int[] nums)
    {
        cache = new Dictionary<int, int>();
        return Rob(nums, 0);
    }

    private int Rob(int[] nums, int start)
    {
        if (start > nums.Length - 1) return 0;
        if (start == nums.Length - 1) return nums[start];

        if (cache.ContainsKey(start)) return cache[start];

        int includeFirst = nums[start] + Rob(nums, start + 2);
        int withoutFirst = Rob(nums, start + 1);

        int result = Math.Max(includeFirst, withoutFirst);
        cache.Add(start, result);

        return result;
    }
}
