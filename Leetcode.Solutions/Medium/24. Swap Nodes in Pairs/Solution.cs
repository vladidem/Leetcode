using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._24._Swap_Nodes_in_Pairs;

/// <summary>
///     https://leetcode.com/problems/swap-nodes-in-pairs/
/// </summary>
public class Solution
{
    public ListNode SwapPairs(ListNode? head)
    {
        bool hasHead = false;
        var node = head;
        var nextNode = node?.next;
        ListNode prevNode = null;

        while (node != null && nextNode != null)
        {
            node.next = nextNode.next;
            nextNode.next = node;
            if (prevNode != null)
                prevNode.next = nextNode;

            if (!hasHead)
            {
                head = nextNode;
                hasHead = true;
            }

            prevNode = node;

            node = node.next;
            nextNode = node?.next;
        }

        return head;
    }
}
