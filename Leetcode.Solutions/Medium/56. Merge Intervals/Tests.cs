using FluentAssertions;

namespace Leetcode.Solutions.Medium._56._Merge_Intervals;

public class Tests
{
    public static TestData[] MergeIntervals_IntervalsIntersect_ReturnsMergedCases =
    {
        new(
            [[6, 7], [2, 4], [5, 9]],
            [[2, 4], [5, 9]]
        ),
        new(
            [[1, 4], [2, 6], [3, 5]],
            [[1, 6]]
        ),
        new(
            [[1, 3], [2, 6], [8, 10], [15, 18]],
            [[1, 6], [8, 10], [15, 18]]
        )
    };

    [TestCaseSource(nameof(MergeIntervals_IntervalsIntersect_ReturnsMergedCases))]
    public void MergeIntervals_IntervalsIntersect_ReturnsMerged(TestData testData)
    {
        int[][] result = new Solution().Merge(testData.Intervals);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[][] Intervals, int[][] Expected);
}
