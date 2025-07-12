using FluentAssertions;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._24._Swap_Nodes_in_Pairs;

public class Tests
{
    [TestCase(new[] { 1, 2, 3, 4 }, new[] { 2, 1, 4, 3 })]
    [TestCase(new[] { 1, 2, 3 }, new[] { 2, 1, 3 })]
    [TestCase(new[] { 1 }, new[] { 1 })]
    public void SwapPairs_NotEmpty_ReturnsListWithReversedPairs(
        int[] nums,
        int[] expected)
    {
        var head = ListNode.FromArray(nums)!;

        new Solution().SwapPairs(head)!
            .ToArray()
            .Should()
            .BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    [Test]
    public void SwapPairs_Empty_ReturnsEmpty()
    {
        ListNode head = null;

        new Solution().SwapPairs(head)!
            .Should()
            .BeNull();
    }
}
