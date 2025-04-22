namespace LeetCode.Solutions.Medium._494_Target_Sum;

/// <summary>
///     https://leetcode.com/problems/target-sum/
/// </summary>
public class Solution
{
    private Dictionary<(ArraySegment<int>, int target), int> cache = new();

    public int FindTargetSumWays(int[] nums, int target)
    {
        cache = new Dictionary<(ArraySegment<int>, int target), int>();
        return FindTargetSumWays(new ArraySegment<int>(nums, 0, nums.Length), target);
    }

    public int FindTargetSumWays(ArraySegment<int> nums, int target)
    {
        if (cache.TryGetValue((nums, target), out int cachedResult))
            return cachedResult;

        if (nums.Count == 0 && target == 0)
            return 1;

        if (nums.Count == 0 && target != 0) return 0;

        int result = FindTargetSumWays(nums[1..], target - nums[0])
                     + FindTargetSumWays(nums[1..], target + nums[0]);

        cache[(nums, target)] = result;

        return result;
    }
}
