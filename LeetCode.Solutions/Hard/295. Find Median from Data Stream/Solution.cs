namespace LeetCode.Solutions.Hard._295_Find_Median_from_Data_Stream;

/// <summary>
///     https://leetcode.com/problems/find-median-from-data-stream/
/// </summary>
public class MedianFinder
{
    public MedianFinder()
    {
        // Descending Sort
        _firstHalf = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

        // Ascending Sort
        _secondHalf = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => x - y));
    }

    private PriorityQueue<int, int> _firstHalf { get; }
    private PriorityQueue<int, int> _secondHalf { get; }

    public void AddNum(int num)
    {
        _firstHalf.Enqueue(num, num);

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
    }

    public double FindMedian()
    {
        if (_firstHalf.Count == _secondHalf.Count)
            return (double)(_firstHalf.Peek() + _secondHalf.Peek()) / 2;

        return _secondHalf.Peek();
    }
}