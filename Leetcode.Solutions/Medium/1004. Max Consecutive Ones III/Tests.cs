using FluentAssertions;

namespace Leetcode.Solutions.Medium._1004._Max_Consecutive_Ones_III;

public class Tests
{
    public static TestData[] LongestOnes_NotEmpty_ReturnsLengthOfMaxSequenceCases =
    {
        new(
            [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0],
            2,
            6
        ),
        new(
            [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1],
            3,
            10
        )
    };


    [TestCaseSource(nameof(LongestOnes_NotEmpty_ReturnsLengthOfMaxSequenceCases))]
    public void LongestOnes_NotEmpty_ReturnsLengthOfMaxSequence(TestData testData)
    {
        int result = new Solution().LongestOnes(testData.Nums, testData.K);

        result.Should().Be(testData.Expected);
    }

    public record TestData(int[] Nums, int K, int Expected);
}
