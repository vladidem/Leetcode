using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Easy._876_Middle_of_the_Linked_List;

/// <summary>
///     https://leetcode.com/problems/middle-of-the-linked-list/
/// </summary>
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        if (head == null) return null;

        var fast = head;
        var slow = head;

        while (fast != null && fast.next != null)
        {
            slow = slow!.next!;
            fast = fast?.next?.next;
        }

        return slow;
    }
}
