namespace LeetCode.Solutions.Medium._852_Peak_Index_in_a_Mountain_Array;

/// <summary>
///     https://leetcode.com/problems/peak-index-in-a-mountain-array/
/// </summary>
public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (IsAscending(arr, mid - 1, mid)
                && IsDescending(arr, mid, mid + 1))
                return mid;
            if (IsAscending(arr, mid, mid + 1))
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    private bool IsAscending(int[] arr, int a, int b)
    {
        return b > arr.Length - 1
               || a < 0
               || arr[a] < arr[b];
    }

    private bool IsDescending(int[] arr, int a, int b)
    {
        return b > arr.Length - 1
               || a < 0
               || arr[a] > arr[b];
    }
}
