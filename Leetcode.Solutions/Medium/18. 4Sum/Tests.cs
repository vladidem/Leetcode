using FluentAssertions;

namespace LeetCode.Solutions.Medium._18_4_Sum;

public class Tests
{
    public static TestData[] FourSum_NotEmpty_ReturnsFourSumCases =
    {
        new(
            [1, 0, -1, 0, -2, 2],
            0,
            [[-2, -1, 1, 2], [-2, 0, 0, 2], [-1, 0, 0, 1]]
        ),
        new(
            [2, 2, 2, 2, 2],
            8,
            [[2, 2, 2, 2]]
        ),
        new(
            [0, 0, 0, 0],
            0,
            [[0, 0, 0, 0]]
        )
    };

    public static TestData[] FourSum_IntOverflow_ReturnsFourSumCases =
    {
        new(
            [1000000000, 1000000000, 1000000000, 1000000000],
            -294967296,
            []
        )
    };

    [TestCaseSource(nameof(FourSum_NotEmpty_ReturnsFourSumCases))]
    public void FourSum_NotEmpty_ReturnsFourSum(TestData testData)
    {
        var result = new Solution().FourSum(testData.Nums, testData.Target);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    [TestCaseSource(nameof(FourSum_IntOverflow_ReturnsFourSumCases))]
    public void FourSum_IntOverflow_ReturnsFourSum(TestData testData)
    {
        var result = new Solution().FourSum(testData.Nums, testData.Target);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[] Nums, int Target, List<IList<int>> Expected);
}
