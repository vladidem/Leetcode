namespace Leetcode.Solutions.Medium._494._Target_Sum;

public class Tests
{
    [TestCase(new[] { 1, 1, 1, 1, 1 }, 3, ExpectedResult = 5)]
    [TestCase(new[] { 1 }, 1, ExpectedResult = 1)]
    [TestCase(new[] { 22, 36, 7, 44, 38, 32, 16, 32, 1, 16, 25, 45, 49, 45, 27, 9, 41, 31, 10, 1 }, 1, ExpectedResult = 6060)]
    [Timeout(100)]
    public int FindTargetSumWaysBottomUp_SumExists_ReturnsNumOfWaysToSum(int[] nums, int target)
    {
        return new Solution().FindTargetSumWays(nums, target);
    }

    [TestCase(new[] { 1 }, 2, ExpectedResult = 0)]
    public int FindTargetSumWaysBottomUp_SumDoesntExists_Returns0(int[] nums, int target)
    {
        return new Solution().FindTargetSumWays(nums, target);
    }

    [TestCase(new[] { 1, 1, 1, 1, 1 }, 3, ExpectedResult = 5)]
    [TestCase(new[] { 1 }, 1, ExpectedResult = 1)]
    [TestCase(new[] { 22, 36, 7, 44, 38, 32, 16, 32, 1, 16, 25, 45, 49, 45, 27, 9, 41, 31, 10, 1 }, 1, ExpectedResult = 6060)]
    [Timeout(100)]
    public int FindTargetSumWaysRecursive_SumExists_ReturnsNumOfWaysToSum(int[] nums, int target)
    {
        return new Solution().FindTargetSumWaysRecursive(nums, target);
    }

    [TestCase(new[] { 1 }, 2, ExpectedResult = 0)]
    public int FindTargetSumWaysRecursive_SumDoesntExists_Returns0(int[] nums, int target)
    {
        return new Solution().FindTargetSumWaysRecursive(nums, target);
    }
}
