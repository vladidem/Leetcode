using FluentAssertions;

namespace LeetCode.Solutions.Medium._15_3_Sum;

public class Tests
{
    public static TestData[] ThreeSum_NotEmpty_ReturnsThreeSumCases =
    {
        new(
            [-1, 0, 1, 2, -1, -4],
            [[-1, 0, 1], [-1, -1, 2]]
        ),
        new(
            [-3, 0, 1, 2, -1, 1, -2],
            [[-3, 1, 2], [-2, 1, 1], [-2, 0, 2], [-1, 0, 1]]
        ),
        new(
            [0, 0, 0, 0],
            [[0, 0, 0]]
        ),
        new(
            [2, -3, 0, -2, -5, -5, -4, 1, 2, -2, 2, 0, 2, -4, 5, 5, -10],
            [[-10, 5, 5], [-5, 0, 5], [-4, 2, 2], [-3, -2, 5], [-3, 1, 2], [-2, 0, 2]]
        )
    };

    [TestCaseSource(nameof(ThreeSum_NotEmpty_ReturnsThreeSumCases))]
    public void ThreeSum_NotEmpty_ReturnsThreeSum(TestData testData)
    {
        var result = new Solution().ThreeSum(testData.Nums);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[] Nums, List<IList<int>> Expected);
}