using FluentAssertions;

namespace Leetcode.Solutions.Hard._632._Smallest_Range_Covering_Elements_from_K_Lists;

public class Tests
{
    public static TestData[] SmallestRange_SortedLists_ReturnsMinRangeCases =
    {
        new(
            [[4, 10, 15, 24, 26], [0, 9, 12, 20], [5, 18, 22, 30]],
            [20, 24]
        ),
        new(
            [[1, 2, 3], [1, 2, 3], [1, 2, 3]],
            [1, 1]
        )
    };


    [TestCaseSource(nameof(SmallestRange_SortedLists_ReturnsMinRangeCases))]
    public void SmallestRange_SortedLists_ReturnsMinRange(TestData testData)
    {
        int[] result = new Solution().SmallestRange(testData.Lists);

        result.Should().BeEquivalentTo(testData.Result);
    }

    public record TestData(IList<IList<int>> Lists, int[] Result);
}
