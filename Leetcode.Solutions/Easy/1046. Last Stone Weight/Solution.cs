namespace Leetcode.Solutions.Easy._1046._Last_Stone_Weight;

/// <summary>
///     https://leetcode.com/problems/last-stone-weight/
/// </summary>
public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var heap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        for (int i = 0; i < stones.Length; i++)
        {
            heap.Enqueue(stones[i], stones[i]);
        }

        while (heap.Count > 1)
        {
            int firstStone = heap.Dequeue();
            int secondStone = heap.Dequeue();

            if (firstStone != secondStone)
            {
                int newStone = Math.Abs(firstStone - secondStone);

                heap.Enqueue(newStone, newStone);
            }
        }

        return heap.Count == 0 ? 0 : heap.Dequeue();
    }
}
