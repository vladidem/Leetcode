using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Hard._25_Reverse_Nodes_in_k_Group;

/// <summary>
///     https://leetcode.com/problems/reverse-nodes-in-k-group/
/// </summary>
public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (k == 1)
            return head;

        foreach ((int left, int right) in ReverseGroups(Length(head), k))
        {
            head = ReverseBetween(head, left, right);
        }

        return head;
    }

    private IEnumerable<(int left, int right)> ReverseGroups(int length, int k)
    {
        int left = 1;
        int right = left + k - 1;

        while (right <= length)
        {
            yield return (left, right);
            left = right + 1;
            right = left + k - 1;
        }
    }

    private int Length(ListNode head)
    {
        int i = 1;
        while (head != null)
        {
            head = head.next;

            if (head != null)
                i++;
        }

        return i;
    }

    private ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (left == right) return head;
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
