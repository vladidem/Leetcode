using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Medium._92_Reverse_Linked_List_II;

/// <summary>
///     https://leetcode.com/problems/reverse-linked-list-ii/
/// </summary>
public class Solution
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        var current = head;
        ListNode? previous = null;
        for (int i = 1; i < left; i++)
        {
            previous = current;
            current = current.next;
        }

        var leftNode = current;
        var preLeftNode = previous;

        for (int i = left; i < right; i++) current = current.next;

        var rightNode = current;
        var postRightNode = current.next;

        current = leftNode;
        while (current != postRightNode)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        leftNode.next = postRightNode;
        if (preLeftNode != null)
            preLeftNode.next = rightNode;
        else
            head = rightNode;

        return head;
    }
}
