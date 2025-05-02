using FluentAssertions;

namespace Leetcode.Solutions.Medium._416._Partition_Equal_Subset_Sum;

public class Tests
{
    [TestCase(new[] { 1, 5, 11, 5 })]
    [TestCase(new[] { 3, 3, 3, 4, 5 })]
    public void CanPartition_PartitionExists_ReturnsTrue(int[] nums)
    {
        new Solution().CanPartition(nums).Should().BeTrue();
    }

    [TestCase(new[] { 1, 2, 3, 5 })]
    [TestCase(new[] { 2, 2, 3, 5 })]
    public void CanPartition_PartitionDoesntExist_ReturnsFalse(int[] nums)
    {
        new Solution().CanPartition(nums).Should().BeFalse();
    }
}
