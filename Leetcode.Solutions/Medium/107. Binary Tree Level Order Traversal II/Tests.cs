using FluentAssertions;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._107._Binary_Tree_Level_Order_Traversal_II;

public class Tests
{
    public static TestData[] BinaryTreeLevelOrderBottom_NotEmpty_ReturnsLevelsCases =
    {
        new(
            [3, 9, 20, null, null, 15, 7],
            [[15, 7], [9, 20], [3]]
        ),
        new([1], [[1]])
    };

    [TestCaseSource(nameof(BinaryTreeLevelOrderBottom_NotEmpty_ReturnsLevelsCases))]
    public void BinaryTreeLevelOrderBottom_NotEmpty_ReturnsLevels(TestData testData)
    {
        var result = new Solution().LevelOrderBottom(TreeNode.FromArray(testData.Tree)!);

        result.Should().BeEquivalentTo(testData.Expected, options => options.WithStrictOrdering());
    }

    public record TestData(int?[] Tree, List<IList<int>> Expected);
}
