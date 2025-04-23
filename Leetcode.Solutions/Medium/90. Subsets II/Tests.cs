using FluentAssertions;

namespace LeetCode.Solutions.Medium._90_Subsets_II;

public class Tests
{
    public static TestData[] SubsetsWithDup_NotEmpty_ReturnsAllUniqueSubsetsCases =
    {
        new(
            [1, 2, 2],
            [[], [1], [1, 2], [1, 2, 2], [2], [2, 2]]
        ),
        new(
            [0],
            [[], [0]]
        )
    };

    [TestCaseSource(nameof(SubsetsWithDup_NotEmpty_ReturnsAllUniqueSubsetsCases))]
    public void SubsetsWithDup_NotEmpty_ReturnsAllUniqueSubsets(TestData testData)
    {
        var result = new Solution().SubsetsWithDup(testData.Nums);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[] Nums, int[][] Expected);
}
