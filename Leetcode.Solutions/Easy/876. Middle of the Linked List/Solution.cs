using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Easy._876._Middle_of_the_Linked_List;

/// <summary>
///     https://leetcode.com/problems/middle-of-the-linked-list/
/// </summary>
public class Solution
{
    public ListNode? MiddleNode(ListNode? head)
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
