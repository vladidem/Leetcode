namespace Leetcode.Solutions.Medium._2294._Partition_Array_Such_That_Maximum_Difference_Is_K;

public class Tests
{
    [TestCase(new[] { 3, 6, 1, 2, 5 }, 2, ExpectedResult = 2)]
    [TestCase(new[] { 1, 2, 3 }, 1, ExpectedResult = 2)]
    [TestCase(new[] { 2, 2, 4, 5 }, 0, ExpectedResult = 3)]
    public int PartitionArray_NotEmptyArray_ReturnsMinPartitionsWithMaxDiff(int[] nums, int k)
    {
        return new Solution().PartitionArray(nums, k);
    }
}
