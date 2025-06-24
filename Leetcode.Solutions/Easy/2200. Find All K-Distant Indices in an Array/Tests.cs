using FluentAssertions;

namespace Leetcode.Solutions.Easy._2200._Find_AllK_Distant_Indices_in_an_Array;

public class Tests
{
    public static TestData[] FindKDistantIndices_NotEmpty_ReturnsIndexesInRangeCases =
    {
        new(
            [3, 4, 9, 1, 3, 9, 5],
            9,
            1,
            [1, 2, 3, 4, 5, 6]
        ),
        new(
            [2, 2, 2, 2, 2],
            2,
            2,
            [0, 1, 2, 3, 4]
        )
    };

    [TestCaseSource(nameof(FindKDistantIndices_NotEmpty_ReturnsIndexesInRangeCases))]
    public void FindKDistantIndices_NotEmpty_ReturnsIndexesInRange(TestData testData)
    {
        var result = new Solution().FindKDistantIndices(testData.Nums, testData.Key, testData.K);

        result.Should().BeEquivalentTo(testData.Expected);
    }


    public record TestData(int[] Nums, int Key, int K, List<int> Expected);
}
