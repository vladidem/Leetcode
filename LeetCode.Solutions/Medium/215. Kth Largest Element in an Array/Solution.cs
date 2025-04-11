namespace LeetCode.Solutions.Medium._215_Kth_Largest_Element_in_an_Array;

/// <summary>
///     https://leetcode.com/problems/kth-largest-element-in-an-array/
/// </summary>
public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        return FindKthLargestCustomHeap(nums, k);
    }

    public int FindKthLargestBuiltInHeap(int[] nums, int k)
    {
        var minHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => Comparer<int>.Default.Compare(x, y)));

        for (int i = 0; i < nums.Length; i++)
        {
            if (minHeap.Count < k)
            {
                minHeap.Enqueue(nums[i], nums[i]);
                continue;
            }

            if (nums[i] > minHeap.Peek())
            {
                minHeap.EnqueueDequeue(nums[i], nums[i]);
            }
        }

        return minHeap.Peek();
    }

    public int FindKthLargestCustomHeap(int[] nums, int k)
    {
        var minHeap = new MinHeap();

        for (int i = 0; i < nums.Length; i++)
        {
            if (minHeap.Count < k)
            {
                minHeap.Enqueue(nums[i]);
                continue;
            }

            if (nums[i] > minHeap.Peek())
            {
                minHeap.EnqueueDequeue(nums[i]);
            }
        }

        return minHeap.Peek();
    }

    public class MinHeap
    {
        private readonly List<int> _heap = new();

        public int Count => _heap.Count;

        public int Peek()
        {
            return _heap[0];
        }

        public void Enqueue(int value)
        {
            _heap.Add(value);
            int newNodeIndex = _heap.Count - 1;
            SwimUp(newNodeIndex);
        }

        private void SwimUp(int i)
        {
            while (i != 0)
            {
                int parent = (i - 1) / 2;

                if (_heap[parent] > _heap[i])
                {
                    (_heap[i], _heap[parent]) = (_heap[parent], _heap[i]);
                }

                i = parent;
            }
        }

        public void EnqueueDequeue(int value)
        {
            _heap[0] = value;
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

                if (_heap[childLeft] < _heap[i]
                    && (!hasRightChild || _heap[childRight] >= _heap[childLeft]))
                    childToSwimUp = childLeft;

                else if (hasRightChild
                         && _heap[childRight] < _heap[i]
                         && _heap[childRight] <= _heap[childLeft])
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
