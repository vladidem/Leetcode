using System.Collections;

namespace LeetCode.Solutions.Medium._973_K_Closest_Points_to_Origin;

/// <summary>
///     https://leetcode.com/problems/k-closest-points-to-origin/
/// </summary>
public class Solution
{
    private readonly int[] PointZero = [0, 0];

    public int[][] KClosest(int[][] points, int k)
    {
        var minHeap = new Heap<int[], double>(Comparer<double>.Create((x, y) => x.CompareTo(y)));

        for (int i = 0; i < points.Length; i++)
        {
            double distance = Distance(PointZero, points[i]);
            if (minHeap.Count < k)
            {
                minHeap.Enqueue(points[i], distance);
                continue;
            }

            if (distance < minHeap.Peek().Priority)
            {
                minHeap.EnqueueDequeue(points[i], distance);
            }
        }

        return minHeap.ToArray();
    }

    private double Distance(int[] pointA, int[] pointB)
    {
        return Math.Sqrt(
            Math.Pow(pointB[0] - pointA[0], 2)
            + Math.Pow(pointB[1] - pointA[1], 2));
    }

    public class Heap<TValue, TPriority> : IEnumerable<TValue>
    {
        private readonly Comparer<TPriority> _comparer;
        private readonly List<(TValue Value, TPriority Priority)> _heap = new();

        public Heap(Comparer<TPriority> comparer)
        {
            _comparer = comparer ?? Comparer<TPriority>.Default;
        }

        public int Count => _heap.Count;

        public IEnumerator<TValue> GetEnumerator()
        {
            return _heap.Select(it => it.Value).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _heap.Select(it => it.Value).GetEnumerator();
        }

        public (TValue Value, TPriority Priority) Peek()
        {
            return _heap[0];
        }

        public void Enqueue(TValue value, TPriority priority)
        {
            _heap.Add((value, priority));
            int newNodeIndex = _heap.Count - 1;
            SwimUp(newNodeIndex);
        }

        private void SwimUp(int i)
        {
            while (i != 0)
            {
                int parent = (i - 1) / 2;

                if (_comparer.Compare(_heap[parent].Priority, _heap[i].Priority) < 0)
                {
                    (_heap[i], _heap[parent]) = (_heap[parent], _heap[i]);
                }

                i = parent;
            }
        }

        public void EnqueueDequeue(TValue value, TPriority priority)
        {
            _heap[0] = (value, priority);
            Sink(0);
        }

        private void Sink(int i)
        {
            int? childToSwimUp;

            do
            {
                int childLeft = 2 * i + 1;
                int childRight = 2 * i + 2;
                bool hasLeftChild = _heap.Count - 1 >= childLeft;
                bool hasRightChild = _heap.Count - 1 >= childRight;
                if (!hasLeftChild && !hasRightChild) return;
                childToSwimUp = null;

                if (_comparer.Compare(_heap[childLeft].Priority, _heap[i].Priority) > 0
                    && (!hasRightChild
                        || _comparer.Compare(_heap[childLeft].Priority, _heap[childRight].Priority) >= 0))
                    childToSwimUp = childLeft;

                else if (hasRightChild
                         && _comparer.Compare(_heap[childRight].Priority, _heap[i].Priority) > 0
                         && _comparer.Compare(_heap[childRight].Priority, _heap[childLeft].Priority) >= 0)
                    childToSwimUp = childRight;

                if (childToSwimUp != null)
                {
                    (_heap[i], _heap[childToSwimUp.Value]) = (_heap[childToSwimUp.Value], _heap[i]);
                    i = childToSwimUp.Value;
                }
            } while (childToSwimUp != null);
        }
    }
}
