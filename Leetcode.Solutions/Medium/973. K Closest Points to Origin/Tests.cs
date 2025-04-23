using FluentAssertions;

namespace LeetCode.Solutions.Medium._973_K_Closest_Points_to_Origin;

public class Tests
{
    public static TestData[] KClosest_NotEmpty_ReturnsClosestPointsCases =
    {
        new(
            [[1, 3], [-2, 2]],
            1,
            [[-2, 2]]
        ),
        new(
            [[3, 3], [5, -1], [-2, 4]],
            2,
            [[3, 3], [-2, 4]]
        )
    };

    [TestCaseSource(nameof(KClosest_NotEmpty_ReturnsClosestPointsCases))]
    public void KClosest_NotEmpty_ReturnsClosestPoints(TestData testData)
    {
        int[][] result = new Solution().KClosest(testData.Points, testData.K);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[][] Points, int K, int[][] Expected);
}
