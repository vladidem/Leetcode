using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Easy._141_Linked_List_Cycle;

public class Tests
{
    [TestCase(new[] { 2, 7, 11, 15, 5, 9, 13 }, 3)]
    [TestCase(new[] { 3, 4, 2, 8, 7 }, 2)]
    public void HasCycle_ListWithNotFullCycle_ReturnsTrue(int[] nums, int cyclePosition)
    {
        var head = ListNode.FromArray(nums);
        var cycle = head.Nth(cyclePosition);
        var last = head.Last();

        last.next = cycle;

        new Solution().HasCycle(head).Should().BeTrue();
    }

    [TestCase(new[] { 2, 7, 11, 15 })]
    [TestCase(new[] { 3, 4, 2 })]
    [TestCase(new[] { 3, 3 })]
    public void HasCycle_ListWithFullCycle_ReturnsTrue(int[] nums)
    {
        var head = ListNode.FromArray(nums);
        var last = head.Last();

        last.next = head;

        new Solution().HasCycle(head).Should().BeTrue();
    }

    [TestCase(new[] { 2, 7, 11, 15 })]
    [TestCase(new[] { 3, 4, 2 })]
    [TestCase(new[] { 3, 3 })]
    public void HasCycle_ListWithoutCycle_ReturnsFalse(int[] nums)
    {
        var head = ListNode.FromArray(nums);

        new Solution().HasCycle(head).Should().BeFalse();
    }

    [Test]
    public void HasCycle_EmptyList_ReturnsFalse()
    {
        new Solution().HasCycle(null).Should().BeFalse();
    }
}
