using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Easy._206_Reverse_Linked_List;

public class Tests
{
    [TestCase(new[] { 2, 7, 11, 15 })]
    [TestCase(new[] { 3, 4, 2 })]
    [TestCase(new[] { 3, 3 })]
    public void ReverseList_ListNotEmpty_ReturnsReversedList(int[] nums)
    {
        var head = ListNode.FromArray(nums);

        new Solution().ReverseList(head)
            .ToArray()
            .Should()
            .BeEquivalentTo(nums.Reverse().ToArray(), opt => opt.WithStrictOrdering());
    }
}