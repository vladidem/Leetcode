using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Medium._142_Linked_List_Cycle_II;

public class Tests
{
    [TestCase(new[] { 2, 7, 11, 15, 5, 9, 13 }, 3)]
    [TestCase(new[] { 3, 4, 2, 8, 7 }, 2)]
    public void DetectCycle_ListWithNotFullCycle_ReturnsFirstNodeOfCycle(int[] nums, int cyclePosition)
    {
        var head = ListNode.FromArray(nums);
        var cycle = head.Nth(cyclePosition);
        var last = head.Last();

        last.next = cycle;

        new Solution().DetectCycle(head).Should().Be(cycle);
    }

    [TestCase(new[] { 2, 7, 11, 15 })]
    [TestCase(new[] { 3, 4, 2 })]
    [TestCase(new[] { 3, 3 })]
    public void DetectCycle_ListWithFullCycle_ReturnsHead(int[] nums)
    {
        var head = ListNode.FromArray(nums);
        var last = head.Last();

        last.next = head;

        new Solution().DetectCycle(head).Should().Be(head);
    }

    [TestCase(new[] { 2, 7, 11, 15 })]
    [TestCase(new[] { 3, 4, 2 })]
    [TestCase(new[] { 3, 3 })]
    public void DetectCycle_ListWithoutCycle_ReturnsNull(int[] nums)
    {
        var head = ListNode.FromArray(nums);

        new Solution().DetectCycle(head).Should().Be(null);
    }

    [Test]
    public void DetectCycle_EmptyList_ReturnsNull()
    {
        new Solution().DetectCycle(null).Should().Be(null);
    }
}