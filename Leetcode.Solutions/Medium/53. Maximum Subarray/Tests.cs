namespace Leetcode.Solutions.Medium._53._Maximum_Subarray;

public class Tests
{
    [TestCase(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, ExpectedResult = 6)]
    [TestCase(new[] { 1 }, ExpectedResult = 1)]
    [TestCase(new[] { 5, 4, -1, 7, 8 }, ExpectedResult = 23)]
    public int MaxSubArray_NormalArray_ReturnsMaxSubArraySumgi(int[] nums)
    {
        return new Solution().MaxSubArray(nums);
    }
}
