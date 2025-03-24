using FluentAssertions;

namespace LeetCode.Solutions.Medium._57_Insert_Interval;

public class Tests
{
    public static TestData[] InsertInterval_IntervalsIntersect_ReturnsMergedCases =
    {
        new(
            [[1, 3], [5, 7], [8, 12]],
            [4, 6],
            [[1, 3], [4, 7], [8, 12]]
        ),
        new(
            [[1, 3], [5, 7], [8, 12]],
            [4, 10],
            [[1, 3], [4, 12]]
        ),
        new(
            [[2, 3], [5, 7]],
            [1, 4],
            [[1, 4], [5, 7]]
        ),
        new(
            [[1, 5]],
            [2, 7],
            [[1, 7]])
    };


    public static TestData[] InsertInterval_IntervalsEmpty_ReturnsNewCases =
    {
        new(
            [],
            [4, 6],
            [[4, 6]]
        )
    };

    [TestCaseSource(nameof(InsertInterval_IntervalsEmpty_ReturnsNewCases))]
    public void InsertInterval_IntervalsEmpty_ReturnsNew(TestData testData)
    {
        var result = new Solution().Insert(testData.Intervals, testData.NewInterval);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    [TestCaseSource(nameof(InsertInterval_IntervalsIntersect_ReturnsMergedCases))]
    public void InsertInterval_IntervalsIntersect_ReturnsMerged(TestData testData)
    {
        var result = new Solution().Insert(testData.Intervals, testData.NewInterval);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[][] Intervals, int[] NewInterval, int[][] Expected);
}