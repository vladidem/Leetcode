namespace Leetcode.Solutions.Medium._215._Kth_Largest_Element_in_an_Array;

public class Tests
{
    [TestCase(new[] { 3, 2, 1, 5, 6, 4 }, 2, ExpectedResult = 5)]
    [TestCase(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, ExpectedResult = 4)]
    public int FindKthLargestCustomHeap_ResultExist_ReturnsKthLargest(int[] nums, int k)
    {
        return new Solution().FindKthLargest(nums, k);
    }

    [TestCase(new[] { 3, 2, 1, 5, 6, 4 }, 2, ExpectedResult = 5)]
    [TestCase(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, ExpectedResult = 4)]
    public int FindKthLargestBuiltInHeap_ResultExist_ReturnsKthLargest(int[] nums, int k)
    {
        return new Solution().FindKthLargestBuiltInHeap(nums, k);
    }
}
