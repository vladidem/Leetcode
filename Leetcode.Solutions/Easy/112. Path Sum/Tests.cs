using FluentAssertions;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Easy._112._Path_Sum;

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
        bool result = new Solution().HasPathSum(TreeNode.FromArray(testData.Tree), testData.Sum);

        result.Should().BeTrue();
    }

    public record TestData(int?[] Tree, int Sum);
}
