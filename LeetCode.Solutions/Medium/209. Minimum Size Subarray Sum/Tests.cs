namespace LeetCode.Solutions.Medium._209_Minimum_Size_Subarray_Sum;

public class Tests
{
    [TestCase(7, new[] { 2, 3, 1, 2, 4, 3 }, ExpectedResult = 2)]
    [TestCase(4, new[] { 1, 4, 4 }, ExpectedResult = 1)]
    [TestCase(7, new[] { 1, 1, 1, 1, 7 }, ExpectedResult = 1)]
    public int MinSubArrayLen_NormalArray_ReturnsMinLength(int target, int[] nums)
    {
        return new Solution().MinSubArrayLen(target, nums);
    }

    [TestCase(11, new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = 0)]
    public int MinSubArrayLen_NoSum_Returns0(int target, int[] nums)
    {
        return new Solution().MinSubArrayLen(target, nums);
    }
}