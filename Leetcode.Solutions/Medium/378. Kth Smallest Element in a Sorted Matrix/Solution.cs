namespace Leetcode.Solutions.Medium._378._Kth_Smallest_Element_in_a_Sorted_Matrix;

/// <summary>
///     https://leetcode.com/problems/merge-k-sorted-lists/
/// </summary>
public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        var minHeap = new PriorityQueue<IEnumerator<int>, int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));
        foreach (int[] row in matrix)
        {
            var rowEnumerator = row.AsEnumerable().GetEnumerator();
            if (rowEnumerator.MoveNext())
                minHeap.Enqueue(rowEnumerator, rowEnumerator.Current);
        }

        int result = 0;
        for (int i = 0; i < k; i++)
        {
            var enumerator = minHeap.Dequeue();
            result = enumerator.Current;

            if (enumerator.MoveNext())
            {
                minHeap.Enqueue(enumerator, enumerator.Current);
            }
            else
            {
                enumerator.Dispose();
            }
        }

        return result;
    }
}
