namespace LeetCode.Solutions.Medium._494_Target_Sum;

public class Tests
{
    [TestCase(new[] { 1, 1, 1, 1, 1 }, 3, ExpectedResult = 5)]
    [TestCase(new[] { 1 }, 1, ExpectedResult = 1)]
    [TestCase(new[] { 22, 36, 7, 44, 38, 32, 16, 32, 1, 16, 25, 45, 49, 45, 27, 9, 41, 31, 10, 1 }, 1, ExpectedResult = 6060)]
    [Timeout(100)]
    public int NumSubarrayProductLessThanK_ProductsExist_ReturnsNumOfSubarrays(int[] nums, int target)
    {
        return new Solution().FindTargetSumWays(nums, target);
    }
}
