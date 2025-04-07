namespace LeetCode.Solutions.Easy._704_Binary_Search;

public class Tests
{
    [TestCase(new[] { 2, 7, 11, 15 }, 7, ExpectedResult = 1)]
    [TestCase(new[] { 2, 3, 4 }, 4, ExpectedResult = 2)]
    [TestCase(new[] { 1, 3 }, 3, ExpectedResult = 1)]
    [TestCase(new[] { -1, 0, 3, 5, 9, 12 }, 9, ExpectedResult = 4)]
    public int BinarySearch_ResultExist_ReturnsIndex(int[] nums, int target)
    {
        return new Solution().Search(nums, target);
    }

    [TestCase(new[] { 2, 5 }, 0, ExpectedResult = -1)]
    public int BinarySearch_NoResult_ReturnsNegativeOne(int[] nums, int target)
    {
        return new Solution().Search(nums, target);
    }
}