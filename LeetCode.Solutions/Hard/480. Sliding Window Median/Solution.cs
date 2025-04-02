namespace LeetCode.Solutions.Hard._480_Sliding_Window_Median;

/// <summary>
///     https://leetcode.com/problems/sliding-window-median/
/// </summary>
public class Solution
{
    public double[] MedianSlidingWindow(int[] nums, int k)
    {
        if (k == 1) return nums.Select(it => (double)it).ToArray();

        var medianFinder = new MedianFinder();
        var result = new List<double>();
        for (var i = 0; i < nums.Length; i++)
        {
            medianFinder.AddNum(nums[i]);
            if (i < k - 1)
                continue;

            if (i - k >= 0)
                medianFinder.RemoveNum(nums[i - k]);
            result.Add(medianFinder.FindMedian());
        }

        return result.ToArray();
    }

    public class MedianFinder
    {
        public MedianFinder()
        {
            // Descending Sort
            _firstHalf =
                new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => -Comparer<int>.Default.Compare(x, y)));

            // Ascending Sort
            _secondHalf =
                new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => Comparer<int>.Default.Compare(x, y)));
        }

        private PriorityQueue<int, int> _firstHalf { get; }
        private PriorityQueue<int, int> _secondHalf { get; }

        public void AddNum(int num)
        {
            _firstHalf.Enqueue(num, num);

            BalanceQueues();
        }

        public void RemoveNum(int num)
        {
            if (num < _secondHalf.Peek())
                _firstHalf.Remove(num, out _, out _);
            else
                _secondHalf.Remove(num, out _, out _);
            BalanceQueues();
        }

        private void BalanceQueues()
        {
            if (_firstHalf.Count > _secondHalf.Count)
            {
                var element = _firstHalf.Dequeue();
                _secondHalf.Enqueue(element, element);
            }
            else if (_firstHalf.Count == _secondHalf.Count && _firstHalf.Peek() > _secondHalf.Peek())
            {
                var firstElement = _firstHalf.Dequeue();
                _secondHalf.Enqueue(firstElement, firstElement);

                var secondElement = _secondHalf.Dequeue();
                _firstHalf.Enqueue(secondElement, secondElement);
            }

            while (_secondHalf.Count - _firstHalf.Count > 1)
            {
                var element = _secondHalf.Dequeue();
                _firstHalf.Enqueue(element, element);
            }
        }

        public double FindMedian()
        {
            if (_firstHalf.Count == _secondHalf.Count)
                return (double)_firstHalf.Peek() / 2 + (double)_secondHalf.Peek() / 2;

            return _secondHalf.Peek();
        }
    }
}