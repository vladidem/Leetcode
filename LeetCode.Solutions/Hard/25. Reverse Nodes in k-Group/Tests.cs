using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Hard._25_Reverse_Nodes_in_k_Group;

public class Tests
{
    [TestCase(new[] { 2, 7, 11, 15 }, 2, new[] { 7, 2, 15, 11 })]
    public void ReverseKGroup_FullGroups_ReturnsWithReversedGroups(
        int[] nums,
        int k,
        int[] expected)
    {
        var head = ListNode.FromArray(nums);

        new Solution().ReverseKGroup(head, k)
            .ToArray()
            .Should()
            .BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    [TestCase(new[] { 2, 7, 11, 15 }, 3, new[] { 11, 7, 2, 15 })]
    [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 3, 2, 1, 4, 5 })]
    public void ReverseKGroup_NotFullGroups_ReturnsReversedWithRemainderUnchanged(
        int[] nums,
        int k,
        int[] expected)
    {
        var head = ListNode.FromArray(nums);

        new Solution().ReverseKGroup(head, k)
            .ToArray()
            .Should()
            .BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
}