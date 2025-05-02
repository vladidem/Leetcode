using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Easy._876_Middle_of_the_Linked_List;

public class Tests
{
    [TestCase(new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 2, 7, 11, 15, 5, 9, 13 })]
    [TestCase(new[] { 3, 4, 2, 8, 7 })]
    public void MiddleNode_OddNodes_ReturnsMiddle(int[] nums)
    {
        var head = ListNode.FromArray(nums);
        int middleIndex = (int) Math.Ceiling((double) (nums.Length - 1) / 2);
        var middleNode = head.Nth(middleIndex);

        new Solution().MiddleNode(head).Should().Be(middleNode);
    }

    [TestCase(new[] { 1, 2, 3, 4, 5, 6 })]
    [TestCase(new[] { 2, 7, 11, 15, 5, 9 })]
    [TestCase(new[] { 3, 4, 2, 8 })]
    public void MiddleNode_EvenNodes_ReturnsSecondMiddle(int[] nums)
    {
        var head = ListNode.FromArray(nums);
        int middleIndex = (int) Math.Ceiling((double) (nums.Length - 1) / 2);
        var middleNode = head.Nth(middleIndex);

        new Solution().MiddleNode(head).Should().Be(middleNode);
    }

    [Test]
    public void MiddleNode_EmptyList_ReturnsNull()
    {
        new Solution().MiddleNode(null).Should().Be(null);
    }
}
