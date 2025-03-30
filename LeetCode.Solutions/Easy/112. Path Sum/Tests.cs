using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Easy._112_Path_Sum;

public class Tests
{
    public static TestData[] HasPathSum_PathSumExists_ReturnsTrueCases =
    {
        new(
            [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1],
            22
        )
    };

    [TestCaseSource(nameof(HasPathSum_PathSumExists_ReturnsTrueCases))]
    public void HasPathSum_PathSumExists_ReturnsTrue(TestData testData)
    {
        var result = new Solution().HasPathSum(TreeNode.FromArray(testData.Tree), testData.Sum);

        result.Should().BeTrue();
    }

    public record TestData(int?[] Tree, int Sum);
}