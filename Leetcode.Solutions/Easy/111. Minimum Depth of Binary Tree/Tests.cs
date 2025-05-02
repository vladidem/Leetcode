using FluentAssertions;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Easy._111._Minimum_Depth_of_Binary_Tree;

public class Tests
{
    public static TestData[] BinaryTreeLevelOrder_NotEmpty_ReturnsLevelsCases =
    {
        new(
            [3, 9, 20, null, null, 15, 7],
            2
        ),
        new(
            [2, null, 3, null, 4, null, 5, null, 6],
            5
        )
    };

    [TestCaseSource(nameof(BinaryTreeLevelOrder_NotEmpty_ReturnsLevelsCases))]
    public void BinaryTreeLevelOrder_NotEmpty_ReturnsLevels(TestData testData)
    {
        int result = new Solution().MinDepth(TreeNode.FromArray(testData.Tree));

        result.Should().Be(testData.Expected);
    }

    public record TestData(int?[] Tree, int Expected);
}
