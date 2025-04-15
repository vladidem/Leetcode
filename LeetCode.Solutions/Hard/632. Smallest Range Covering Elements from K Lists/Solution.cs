namespace LeetCode.Solutions.Hard._632_Smallest_Range_Covering_Elements_from_K_Lists;

/// <summary>
///     https://leetcode.com/problems/smallest-range-covering-elements-from-k-lists/
/// </summary>
public class Solution
{
    public int[] SmallestRange(IList<IList<int>> nums)
    {
        var minHeap = new PriorityQueue<IEnumerator<int>, int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));
        int bottom = int.MaxValue;
        int top = int.MinValue;

        foreach (var row in nums)
        {
            var rowEnumerator = row.AsEnumerable().GetEnumerator();
            if (rowEnumerator.MoveNext())
            {
                if (rowEnumerator.Current < bottom)
                    bottom = rowEnumerator.Current;
                if (rowEnumerator.Current > top)
                    top = rowEnumerator.Current;

                minHeap.Enqueue(rowEnumerator, rowEnumerator.Current);
            }
        }

        int[] minRange = [bottom, top];
        while (minHeap.Count > 0)
        {
            var enumerator = minHeap.Dequeue();
            if (!enumerator.MoveNext())
                break;

            if (enumerator.Current > top)
                top = enumerator.Current;
            minHeap.Enqueue(enumerator, enumerator.Current);
            bottom = minHeap.Peek().Current;
            if (top - bottom < minRange[1] - minRange[0])
            {
                minRange = [bottom, top];
            }
        }

        return minRange;
    }
}
