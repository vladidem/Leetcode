using FluentAssertions;

namespace Leetcode.Solutions.Medium._46._Permutations;

public class Tests
{
    public static TestData[] Permute_NotEmpty_ReturnsAllPermutationsCases =
    {
        new(
            [1, 2, 3],
            [[1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]]
        ),
        new(
            [0, 1],
            [[0, 1], [1, 0]]
        ),
        new(
            [1],
            [[1]]
        )
    };

    [TestCaseSource(nameof(Permute_NotEmpty_ReturnsAllPermutationsCases))]
    public void Permute_NotEmpty_ReturnsAllPermutations(TestData testData)
    {
        var result = new Solution().Permute(testData.Nums);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[] Nums, int[][] Expected);
}
