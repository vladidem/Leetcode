using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Easy._141._Linked_List_Cycle;

/// <summary>
///     https://leetcode.com/problems/linked-list-cycle/
/// </summary>
public class Solution
{
    public bool HasCycle(ListNode? head)
    {
        var slow = head;
        var fast = head?.next;

        while (fast != slow && fast?.next?.next != null)
        {
            slow = slow?.next;
            fast = fast.next?.next;
        }

        return fast != null && fast == slow;
    }
}
