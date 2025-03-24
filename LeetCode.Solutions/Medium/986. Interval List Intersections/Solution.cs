namespace LeetCode.Solutions.Medium._986_Interval_List_Intersections;

/// <summary>
///     https://leetcode.com/problems/interval-list-intersections/
/// </summary>
public class Solution
{
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        var secondIntervalIndex = 0;
        var result = new List<int[]>();

        foreach (var interval in firstList)
        {
            while (secondIntervalIndex < secondList.Length
                   && interval[0] > secondList[secondIntervalIndex][1])
                secondIntervalIndex++;

            int[]? intersection;
            var movedForward = false;
            while (secondIntervalIndex < secondList.Length
                   && (intersection = Intersection(interval, secondList[secondIntervalIndex])) != null)
            {
                result.Add(intersection);
                movedForward = true;
                secondIntervalIndex++;
            }

            if (movedForward)
                secondIntervalIndex--;
        }

        return result.ToArray();
    }

    private int[]? Intersection(int[] firstInterval, int[] secondInterval)
    {
        int[] left;
        int[] right;
        if (firstInterval[0] <= secondInterval[0])
        {
            left = firstInterval;
            right = secondInterval;
        }
        else
        {
            left = secondInterval;
            right = firstInterval;
        }

        if (left[1] < right[0])
            return null;
        return [Math.Max(left[0], right[0]), Math.Min(left[1], right[1])];
    }
}