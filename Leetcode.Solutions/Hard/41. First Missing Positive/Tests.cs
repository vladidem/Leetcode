namespace Leetcode.Solutions.Hard._41._First_Missing_Positive;

public class Tests
{
    [TestCase(new[] { 1, 2, 0 }, ExpectedResult = 3)]
    [TestCase(new[] { 3, 4, -1, 1 }, ExpectedResult = 2)]
    [TestCase(new[] { 7, 8, 9, 11, 12 }, ExpectedResult = 1)]
    [TestCase(new[] { 1 }, ExpectedResult = 2)]
    public int FirstMissingPositive_NumberIsMissing_ReturnsFirstMissing(int[] nums)
    {
        return new Solution().FirstMissingPositive(nums);
    }
}
