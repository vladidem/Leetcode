using FluentAssertions;

namespace LeetCode.Solutions.Medium._986_Interval_List_Intersections;

public class Tests
{
    public static TestData[] IntervalListIntersections_IntervalsIntersect_ReturnsIntersectionCases =
    {
        new(
            [[1, 3], [5, 6], [7, 9]],
            [[2, 3], [5, 7]],
            [[2, 3], [5, 6], [7, 7]]
        ),
        new(
            [[1, 3], [5, 7], [9, 12]],
            [[5, 10]],
            [[5, 7], [9, 10]]
        )
    };


    [TestCaseSource(nameof(IntervalListIntersections_IntervalsIntersect_ReturnsIntersectionCases))]
    public void IntervalListIntersections_IntervalsIntersect_ReturnsIntersection(TestData testData)
    {
        var result = new Solution().IntervalIntersection(testData.firstList, testData.secondList);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[][] firstList, int[][] secondList, int[][] Expected);
}