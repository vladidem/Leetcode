namespace Leetcode.Solutions.Easy._2016._Maximum_Difference_Between_Increasing_Elements;

public class Tests
{
    [TestCase(new[] { 7, 1, 5, 4 }, ExpectedResult = 4)]
    [TestCase(new[] { 1, 5, 2, 10 }, ExpectedResult = 9)]
    public int MaximumDifference_DifferenceExists_ReturnsMaximumDifference(int[] nums)
    {
        return new Solution().MaximumDifference(nums);
    }

    [TestCase(new[] { 9, 4, 3, 2 }, ExpectedResult = -1)]
    public int MaximumDifference_DifferenceDoesntExist_ReturnsMinusOne(int[] nums)
    {
        return new Solution().MaximumDifference(nums);
    }

    [TestCase(new[] { 7, 1, 5, 4 }, ExpectedResult = 4)]
    [TestCase(new[] { 1, 5, 2, 10 }, ExpectedResult = 9)]
    public int MaximumDifference_Linear_DifferenceExists_ReturnsMaximumDifference(int[] nums)
    {
        return new Solution().MaximumDifference_Linear(nums);
    }

    [TestCase(new[] { 9, 4, 3, 2 }, ExpectedResult = -1)]
    public int MaximumDifference_Linear_DifferenceDoesntExist_ReturnsMinusOne(int[] nums)
    {
        return new Solution().MaximumDifference_Linear(nums);
    }
}
