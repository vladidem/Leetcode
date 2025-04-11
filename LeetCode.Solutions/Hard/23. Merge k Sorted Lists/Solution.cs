using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Hard._23_Merge_k_Sorted_Lists;

/// <summary>
///     https://leetcode.com/problems/merge-k-sorted-lists/
/// </summary>
public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var minHeap = new PriorityQueue<ListNode, int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));

        foreach (var list in lists)
        {
            if (list == null) continue;
            minHeap.Enqueue(list, list.val);
        }

        if (minHeap.Count == 0) return null;

        var newList = new List<int>();

        while (minHeap.Count > 0)
        {
            var currentMin = minHeap.Dequeue();
            if (currentMin.next != null)
            {
                minHeap.Enqueue(currentMin.next, currentMin.next.val);
            }

            newList.Add(currentMin.val);
        }

        return FromArray(newList.ToArray());
    }

    private static ListNode FromArray(int[] nums)
    {
        if (nums.Length == 0) return null;
        var result = new ListNode(nums[0]);
        var current = result;

        for (int i = 1; i < nums.Length; i++)
        {
            current.next = new ListNode(nums[i]);
            current = current.next;
        }

        return result;
    }
}
