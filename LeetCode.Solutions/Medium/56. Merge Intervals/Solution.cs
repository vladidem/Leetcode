namespace LeetCode.Solutions.Medium._56_Merge_Intervals;

/// <summary>
///     https://leetcode.com/problems/merge-intervals/
/// </summary>
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 1)
            return intervals;

        var sortedIntervals = intervals.OrderBy(i => i[0]).ToArray();
        var start = sortedIntervals[0][0];
        var end = sortedIntervals[0][1];
        var result = new List<int[]>();

        foreach (var interval in sortedIntervals)
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
}