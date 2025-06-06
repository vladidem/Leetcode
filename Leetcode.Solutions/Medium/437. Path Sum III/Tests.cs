using FluentAssertions;
using Leetсode.Solutions.DataStructures;

namespace Leetcode.Solutions.Medium._437._Path_Sum_III;

public class Tests
{
    public static TestData[] CountPathSums_PathSumsExist_ReturnsCountCases =
    {
        new(
            [10, 5, -3, 3, 2, null, 11, 3, -2, null, 1],
            8,
            3
        ),
        new(
            [1, null, 2, null, 3, null, 4, null, 5],
            3,
            2
        ),
        new(
            [1, -2, -3, 1, 3, -2, null, -1],
            -1,
            4
        )
    };

    public static TestData[] CountPathSums_PathSumsExist_Overflow_ReturnsCountCases =
    {
        new(
            [1000000000, 1000000000, null, 294967296, null, 1000000000, null, 1000000000, null, 1000000000],
            0,
            0
        )
    };

    [TestCaseSource(nameof(CountPathSums_PathSumsExist_ReturnsCountCases))]
    public void CountPathSums_PathSumsExist_ReturnsCount(TestData testData)
    {
        int result = new Solution().PathSum(TreeNode.FromArray(testData.Tree)!, testData.Sum);

        result.Should().Be(testData.Count);
    }

    [TestCaseSource(nameof(CountPathSums_PathSumsExist_Overflow_ReturnsCountCases))]
    public void CountPathSums_PathSumsExist_Overflow_ReturnsCount(TestData testData)
    {
        int result = new Solution().PathSum(TreeNode.FromArray(testData.Tree)!, testData.Sum);

        result.Should().Be(testData.Count);
    }


    public record TestData(int?[] Tree, int Sum, int Count);
}
