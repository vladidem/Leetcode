namespace Leetcode.Solutions.Medium._658._Find_K_Closest_Elements;

/// <summary>
///     https://leetcode.com/problems/find-k-closest-elements/
/// </summary>
public class Solution
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        return FindClosestElementsShrink(arr, k, x);
    }

    public IList<int> FindClosestElementsShrink(int[] arr, int k, int x)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (x < arr[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }

        int rangeStart = Math.Max(0, left - k);
        int rangeEnd = Math.Min(arr.Length - 1, left + k);
        while (rangeEnd - rangeStart >= k)
        {
            if (ACloserThanB(x, arr[rangeStart], arr[rangeEnd]))
                rangeEnd--;
            else
                rangeStart++;
        }

        return arr[rangeStart..(rangeEnd + 1)];
    }

    private bool ACloserThanB(int x, int a, int b)
    {
        return Math.Abs(x - a) < Math.Abs(x - b)
               || (Math.Abs(x - a) == Math.Abs(x - b) && a < b);
    }
}
