using FluentAssertions;
using LeetCode.Solutions.DataStructures;

namespace LeetCode.Solutions.Hard._23_Merge_k_Sorted_Lists;

public class Tests
{
    public static TestData[] MergeKLists_SortedLists_ReturnsMergedCases =
    {
        new(
            [[1, 4, 5], [1, 3, 4], [2, 6]],
            [1, 1, 2, 3, 4, 4, 5, 6]
        )
    };

    public static TestData[] MergeKLists_empty_ReturnsEmptyCases =
    {
        new(
            [],
            []
        ),
        new(
            [[]],
            []
        )
    };

    [TestCaseSource(nameof(MergeKLists_SortedLists_ReturnsMergedCases))]
    public void MergeKLists_SortedLists_ReturnsMerged(TestData testData)
    {
        var result = new Solution().MergeKLists(testData.Lists.Select(ListNode.FromArray).ToArray());

        result.ToArray().Should().BeEquivalentTo(testData.Result, options => options.WithStrictOrdering());
    }

    [TestCaseSource(nameof(MergeKLists_empty_ReturnsEmptyCases))]
    public void MergeKLists_empty_ReturnsEmpty(TestData testData)
    {
        var result = new Solution().MergeKLists(testData.Lists.Select(ListNode.FromArray).ToArray());

        result.Should().BeNull();
    }

    public record TestData(int[][] Lists, IList<int> Result);
}
