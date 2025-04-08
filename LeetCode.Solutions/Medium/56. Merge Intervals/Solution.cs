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

        int[][] sortedIntervals = intervals.OrderBy(i => i[0]).ToArray();
        int start = sortedIntervals[0][0];
        int end = sortedIntervals[0][1];
        var result = new List<int[]>();

        foreach (int[] interval in sortedIntervals)
        {
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
        }

        result.Add([start, end]);

        return result.ToArray();
    }
}
