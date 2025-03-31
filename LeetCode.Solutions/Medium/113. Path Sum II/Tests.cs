using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Medium._113_Path_Sum_II;

public class Tests
{
    public static TestData[] PathSum_PathSumExists_ReturnsAllPathsCases =
    {
        new(
            [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1],
            22,
            [[5, 4, 11, 2], [5, 8, 4, 5]]
        )
    };

    [TestCaseSource(nameof(PathSum_PathSumExists_ReturnsAllPathsCases))]
    public void PathSum_PathSumExists_ReturnsAllPaths(TestData testData)
    {
        var result = new Solution().PathSum(TreeNode.FromArray(testData.Tree), testData.targetSum);

        result.Should().BeEquivalentTo(testData.result, options => options.WithStrictOrdering());
    }

    public record TestData(int?[] Tree, int targetSum, IList<IList<int>> result);
}