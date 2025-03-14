namespace LeetCode.Solutions.Easy._1_Two_Sum;

public class Tests
{
    [TestCase(new[] { 2, 7, 11, 15 }, 9, ExpectedResult = new[] { 1, 0 })]
    [TestCase(new[] { 3, 4, 2 }, 6, ExpectedResult = new[] { 2, 1 })]
    [TestCase(new[] { 3, 3 }, 6, ExpectedResult = new[] { 1, 0 })]
    public int[] TwoSum_ResultExist_ReturnsIndexes(int[] nums, int target)
    {
        return new Solution().TwoSum(nums, target).OrderByDescending(i => i).ToArray();
    }

    [TestCase(new[] { 3, 3 }, 9, ExpectedResult = new int[] { })]
    public int[] TwoSum_NoResult_ReturnsEmptyArray(int[] nums, int target)
    {
        return new Solution().TwoSum(nums, target);
    }
}