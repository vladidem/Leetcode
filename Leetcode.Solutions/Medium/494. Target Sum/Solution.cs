namespace Leetcode.Solutions.Medium._494._Target_Sum;

/// <summary>
///     https://leetcode.com/problems/target-sum/
/// </summary>
public class Solution
{
    private Dictionary<(ArraySegment<int>, int target), int> cache = new();

    public int FindTargetSumWays(int[] nums, int target)
    {
        return FindTargetSumWaysBottomUp(nums, target);
    }

    public int FindTargetSumWaysBottomUp(int[] nums, int target)
    {
        var waysToSum = new Dictionary<int, Dictionary<int, int>>();
        for (int i = -1; i <= nums.Length - 1; i++)
        {
            waysToSum[i] = new Dictionary<int, int>();
        }

        waysToSum[-1][0] = 1;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            foreach ((int sum, int ways) in waysToSum[i - 1])
            {
                waysToSum[i][sum + nums[i]] = waysToSum[i].GetValueOrDefault(sum + nums[i], 0) + ways;
                waysToSum[i][sum - nums[i]] = waysToSum[i].GetValueOrDefault(sum - nums[i], 0) + ways;
            }
        }

        return waysToSum[nums.Length - 1].GetValueOrDefault(target, 0);
    }

    public int FindTargetSumWaysRecursive(int[] nums, int target)
    {
        cache = new Dictionary<(ArraySegment<int>, int target), int>();
        return FindTargetSumWaysRecursive(new ArraySegment<int>(nums, 0, nums.Length), target);
    }

    private int FindTargetSumWaysRecursive(ArraySegment<int> nums, int target)
    {
        if (cache.TryGetValue((nums, target), out int cachedResult))
            return cachedResult;

        if (nums.Count == 0 && target == 0)
            return 1;

        if (nums.Count == 0 && target != 0) return 0;

        int result = FindTargetSumWaysRecursive(nums[1..], target - nums[0])
                     + FindTargetSumWaysRecursive(nums[1..], target + nums[0]);

        cache[(nums, target)] = result;

        return result;
    }
}
