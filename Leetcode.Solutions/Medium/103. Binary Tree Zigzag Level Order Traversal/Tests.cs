using FluentAssertions;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._103._Binary_Tree_Zigzag_Level_Order_Traversal;

public class Tests
{
    public static TestData[] BinaryTreeZigzagLevelOrder_NotEmpty_ReturnsLevelsCases =
    {
        new(
            [3, 9, 20, null, null, 15, 7],
            [[3], [20, 9], [15, 7]]
        ),
        new([1], [[1]])
    };

    [TestCaseSource(nameof(BinaryTreeZigzagLevelOrder_NotEmpty_ReturnsLevelsCases))]
    public void BinaryTreeZigzagLevelOrder_NotEmpty_ReturnsLevels(TestData testData)
    {
        var result = new Solution().ZigzagLevelOrder(TreeNode.FromArray(testData.Tree)!);

        result.Should().BeEquivalentTo(testData.Expected, options => options.WithStrictOrdering());
    }

    public record TestData(int?[] Tree, List<IList<int>> Expected);
}
