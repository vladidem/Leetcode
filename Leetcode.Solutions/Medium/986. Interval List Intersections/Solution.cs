namespace Leetcode.Solutions.Medium._986._Interval_List_Intersections;

/// <summary>
///     https://leetcode.com/problems/interval-list-intersections/
/// </summary>
public class Solution
{
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        return IntervalIntersectionTwoPointers(firstList, secondList);
    }

    public int[][] IntervalIntersectionTwoPointers(int[][] firstList, int[][] secondList)
    {
        int i = 0;
        int j = 0;
        var result = new List<int[]>();
        int[]? intersection;

        while (i < firstList.Length && j < secondList.Length)
        {
            if ((intersection = Intersection(firstList[i], secondList[j])) != null)
                result.Add(intersection);

            if (firstList[i][1] < secondList[j][1])
                i++;
            else
                j++;
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
