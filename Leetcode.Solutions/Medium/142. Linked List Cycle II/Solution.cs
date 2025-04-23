using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Medium._142_Linked_List_Cycle_II;

/// <summary>
///     https://leetcode.com/problems/linked-list-cycle-ii
/// </summary>
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        return DetectCycleSlowFast(head);
    }

    public ListNode DetectCycleHash(ListNode head)
    {
        var nodes = new HashSet<ListNode>();
        var current = head;
        while (current != null)
        {
            if (nodes.Contains(current)) return current;
            nodes.Add(current);
            current = current.next;
        }

        return null;
    }

    public ListNode DetectCycleSlowFast(ListNode head)
    {
        var slow = head;
        var fast = head;
        if (!FindCycle(ref slow, ref fast))
            return null;

        return GetCycleStart(head, slow);
    }

    private bool FindCycle(ref ListNode slow, ref ListNode fast)
    {
        while (fast?.next?.next != null)
        {
            slow = slow!.next!;
            fast = fast.next.next;
            if (slow == fast) return true;
        }

        return false;
    }

    private ListNode GetCycleStart(ListNode head, ListNode fastAndSlowMeeting)
    {
        var slow = head;
        var alsoSlow = fastAndSlowMeeting;

        while (slow != alsoSlow)
        {
            slow = slow!.next;
            alsoSlow = alsoSlow!.next;
        }

        return slow!;
    }
}
