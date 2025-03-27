using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Medium._92_Reverse_Linked_List_II;

public class Tests
{
    [TestCase(new[] { 2, 7, 11, 15 }, 2, 3, new[] { 2, 11, 7, 15 })]
    public void ReverseBetween_NotFull_ReturnsListWithReversedPart(
        int[] nums,
        int left,
        int right,
        int[] expected)
    {
        var head = ListNode.FromArray(nums);

        new Solution().ReverseBetween(head, left, right)
            .ToArray()
            .Should()
            .BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    [TestCase(new[] { 5 }, 1, 1, new[] { 5 })]
    [TestCase(new[] { 3, 5 }, 1, 2, new[] { 5, 3 })]
    public void ReverseBetween_FullList_ReturnsFullReversed(
        int[] nums,
        int left,
        int right,
        int[] expected)
    {
        var head = ListNode.FromArray(nums);

        new Solution().ReverseBetween(head, left, right)
            .ToArray()
            .Should()
            .BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
}