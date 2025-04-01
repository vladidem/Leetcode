using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Medium._129_Sum_Root_to_Leaf_Numbers;

public class Tests
{
    public static TestData[] SumNumbers_NotEmptyTree_ReturnsSumOfAllPathsCases =
    {
        new(
            [1, 2, 3],
            25
        ),
        new(
            [4, 9, 0, 5, 1],
            1026
        )
    };

    [TestCaseSource(nameof(SumNumbers_NotEmptyTree_ReturnsSumOfAllPathsCases))]
    public void SumNumbers_NotEmptyTree_ReturnsSumOfAllPaths(TestData testData)
    {
        var result = new Solution().SumNumbers(TreeNode.FromArray(testData.Tree));

        result.Should().Be(testData.result);
    }

    public record TestData(int?[] Tree, int result);
}