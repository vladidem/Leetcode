using FluentAssertions;

namespace LeetCode.Solutions.Easy.Cyclic_Sort;

public class Tests
{
    [TestCase(new[] { 3, 1, 5, 4, 2 }, new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 2, 6, 4, 3, 1, 5 }, new[] { 1, 2, 3, 4, 5, 6 })]
    [TestCase(new[] { 1, 5, 6, 4, 3, 2 }, new[] { 1, 2, 3, 4, 5, 6 })]
    public void CyclicSort_NonEmptyArray_SortsInPlace(int[] nums, int[] sorted)
    {
        new Solution().Sort(nums);
        nums.Should().BeEquivalentTo(sorted, options => options.WithStrictOrdering());
    }
}