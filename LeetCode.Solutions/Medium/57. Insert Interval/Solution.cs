namespace LeetCode.Solutions.Medium._57_Insert_Interval;

/// <summary>
///     https://leetcode.com/problems/insert-interval/
/// </summary>
public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
            return [newInterval];

        var start = 0;
        var end = 0;
        if (intervals[0][0] <= newInterval[0])
        {
            start = intervals[0][0];
            end = intervals[0][1];
        }
        else
        {
            start = newInterval[0];
            end = newInterval[1];
        }

        var result = new List<int[]>();

        foreach (var interval in IntervalIterator(intervals, newInterval))
            if (interval[0] <= end)
            {
                end = Math.Max(interval[1], end);
            }
            else
            {
                result.Add([start, end]);
                start = interval[0];
                end = interval[1];
            }

        result.Add([start, end]);

        return result.ToArray();
    }

    private IEnumerable<int[]> IntervalIterator(int[][] intervals, int[] newInterval)
    {
        var sortedIntervals = intervals.OrderBy(i => i[0]).ToArray();
        var returned = false;
        foreach (var interval in sortedIntervals)
        {
            if (!returned && interval[0] >= newInterval[0])
            {
                returned = true;
                yield return newInterval;
            }

            yield return interval;
        }

        if (!returned)
            yield return newInterval;
    }
}