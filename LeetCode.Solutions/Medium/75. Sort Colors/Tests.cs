using FluentAssertions;

namespace LeetCode.Solutions.Medium._75_Sort_Colors;

public class Tests
{
    [TestCase(new[] { 2, 0, 2, 1, 1, 0 }, new [] { 0, 0, 1, 1, 2, 2 })]
    [TestCase(new[] { 1, 0, 2, 1, 0 }, new [] { 0, 0, 1, 1, 2 })]
    [TestCase(new[] { 2, 2, 0, 1, 2, 0 }, new [] { 0, 0, 1, 2, 2, 2 })]
    public void SortColors_NormalArray_SortsInPlace(int[] nums, int[] sortedNums)
    {
        new Solution().SortColors(nums);
        nums.Should().BeEquivalentTo(sortedNums, options => options.WithStrictOrdering());
    }
    
    [TestCase(new[] { 1 }, new [] { 1 })]
    public void SortColors_SingleNumber_DoesNothing(int[] nums, int[] sortedNums)
    {
        new Solution().SortColors(nums);
        nums.Should().BeEquivalentTo(sortedNums, options => options.WithStrictOrdering());
    }
}
