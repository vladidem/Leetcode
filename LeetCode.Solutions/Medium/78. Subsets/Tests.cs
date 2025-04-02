using FluentAssertions;

namespace LeetCode.Solutions.Medium._78_Subsets;

public class Tests
{
    public static TestData[] Subsets_NotEmpty_ReturnsAllSubsetsCases =
    {
        new(
            [1, 2, 3],
            [[], [1], [2], [1, 2], [3], [1, 3], [2, 3], [1, 2, 3]]
        ),
        new(
            [0],
            [[], [0]]
        )
    };

    [TestCaseSource(nameof(Subsets_NotEmpty_ReturnsAllSubsetsCases))]
    public void Subsets_NotEmpty_ReturnsAllSubsets(TestData testData)
    {
        var result = new Solution().Subsets(testData.Nums);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[] Nums, int[][] Expected);
}