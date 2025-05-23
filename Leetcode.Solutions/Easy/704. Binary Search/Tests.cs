namespace Leetcode.Solutions.Easy._704._Binary_Search;

public class Tests
{
    [TestCase(new[] { 2, 7, 11, 15 }, 7, ExpectedResult = 1)]
    [TestCase(new[] { 2, 3, 4 }, 4, ExpectedResult = 2)]
    [TestCase(new[] { 1, 3 }, 3, ExpectedResult = 1)]
    [TestCase(new[] { -1, 0, 3, 5, 9, 12 }, 9, ExpectedResult = 4)]
    public int BinarySearchIterative_ResultExist_ReturnsIndex(int[] nums, int target)
    {
        return new Solution().Search(nums, target);
    }

    [TestCase(new[] { 2, 5 }, 0, ExpectedResult = -1)]
    public int BinarySearchIterative_NoResult_ReturnsNegativeOne(int[] nums, int target)
    {
        return new Solution().Search(nums, target);
    }

    [TestCase(new[] { 2, 7, 11, 15 }, 7, ExpectedResult = 1)]
    [TestCase(new[] { 2, 3, 4 }, 4, ExpectedResult = 2)]
    [TestCase(new[] { 1, 3 }, 3, ExpectedResult = 1)]
    [TestCase(new[] { -1, 0, 3, 5, 9, 12 }, 9, ExpectedResult = 4)]
    public int BinarySearchRecursive_ResultExist_ReturnsIndex(int[] nums, int target)
    {
        return new Solution().SearchRecursive(nums, target);
    }

    [TestCase(new[] { 2, 5 }, 0, ExpectedResult = -1)]
    public int BinarySearchRecursive_NoResult_ReturnsNegativeOne(int[] nums, int target)
    {
        return new Solution().SearchRecursive(nums, target);
    }
}
