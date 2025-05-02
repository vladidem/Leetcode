namespace Leetcode.Solutions.Easy._268._Missing_Number;

public class Tests
{
    [TestCase(new[] { 3, 0, 1 }, ExpectedResult = 2)]
    [TestCase(new[] { 4, 0, 3, 1 }, ExpectedResult = 2)]
    [TestCase(new[] { 8, 3, 5, 2, 4, 6, 0, 1 }, ExpectedResult = 7)]
    [TestCase(new[] { 0, 1 }, ExpectedResult = 2)]
    public int MissingNumberXor_NumberIsMissing_ReturnsMissing(int[] nums)
    {
        return new Solution().MissingNumber(nums);
    }

    [TestCase(new[] { 3, 0, 1 }, ExpectedResult = 2)]
    [TestCase(new[] { 4, 0, 3, 1 }, ExpectedResult = 2)]
    [TestCase(new[] { 8, 3, 5, 2, 4, 6, 0, 1 }, ExpectedResult = 7)]
    [TestCase(new[] { 0, 1 }, ExpectedResult = 2)]
    public int MissingNumberCyclicSort_NumberIsMissing_ReturnsMissing(int[] nums)
    {
        return new Solution().MissingNumberCyclicSort(nums);
    }
}
