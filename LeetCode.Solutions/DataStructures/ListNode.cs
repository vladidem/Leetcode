namespace LeetCode.Solutions.DataStructures;

public class ListNode
{
    public ListNode? next;
    public int val;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }

    public static ListNode FromArray(int[] nums)
    {
        var result = new ListNode(nums[0]);
        var current = result;

        for (var i = 1; i < nums.Length; i++)
        {
            current.next = new ListNode(nums[i]);
            current = current.next;
        }

        return result;
    }

    public ListNode Last()
    {
        var current = this;
        while (current.next != null && current.next != this) current = current.next;

        return current;
    }

    public ListNode Nth(int n)
    {
        var current = this;

        for (var i = 0; i < n; i++)
            if (current.next != null)
                current = current.next;

        return current;
    }
}