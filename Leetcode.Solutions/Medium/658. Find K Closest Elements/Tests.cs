using FluentAssertions;

namespace Leetcode.Solutions.Medium._658._Find_K_Closest_Elements;

public class Tests
{
    public static TestData[] FindClosestElements_TargetExitst_ReturnsRangeCases =
    {
        new(
            [1, 2, 3, 4, 5],
            4,
            3,
            [1, 2, 3, 4]
        ),
        new(
            [1, 1, 2, 3, 4, 5],
            4,
            -1,
            [1, 1, 2, 3]
        ),
        new(
            [1, 2],
            1,
            1,
            [1]
        ),
        new(
            [1, 1, 1, 10, 10, 10],
            1,
            9,
            [10]
        )
    };


    public static TestData[] FindClosestElements_EdgeCases_ReturnsRangeCases =
    {
        new(
            [1],
            1,
            1,
            [1]
        )
    };

    [TestCaseSource(nameof(FindClosestElements_TargetExitst_ReturnsRangeCases))]
    public void FindClosestElements_TargetExitst_ReturnsRange(TestData testData)
    {
        var result = new Solution().FindClosestElements(testData.Nums, testData.K, testData.X);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    [TestCaseSource(nameof(FindClosestElements_EdgeCases_ReturnsRangeCases))]
    public void FindClosestElements_EdgeCases_ReturnsRange(TestData testData)
    {
        var result = new Solution().FindClosestElements(testData.Nums, testData.K, testData.X);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[] Nums, int K, int X, int[] Expected);
}
