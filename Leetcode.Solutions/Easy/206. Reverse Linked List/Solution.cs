using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Easy._206._Reverse_Linked_List;

/// <summary>
///     https://leetcode.com/problems/reverse-linked-list/
/// </summary>
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        var current = head;
        ListNode? previous = null;

        while (current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous!;
    }
}
