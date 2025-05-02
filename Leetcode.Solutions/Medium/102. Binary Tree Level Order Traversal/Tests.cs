using FluentAssertions;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._102._Binary_Tree_Level_Order_Traversal;

public class Tests
{
    public static TestData[] BinaryTreeLevelOrder_NotEmpty_ReturnsLevelsCases =
    {
        new(
            [3, 9, 20, null, null, 15, 7],
            [[3], [9, 20], [15, 7]]
        )
    };

    [TestCaseSource(nameof(BinaryTreeLevelOrder_NotEmpty_ReturnsLevelsCases))]
    public void BinaryTreeLevelOrder_NotEmpty_ReturnsLevels(TestData testData)
    {
        var result = new Solution().LevelOrder(TreeNode.FromArray(testData.Tree));

        result.Should().BeEquivalentTo(testData.Expected, options => options.WithStrictOrdering());
    }

    public record TestData(int?[] Tree, List<IList<int>> Expected);
}
