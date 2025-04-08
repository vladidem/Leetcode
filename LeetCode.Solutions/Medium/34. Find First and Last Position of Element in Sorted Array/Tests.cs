using FluentAssertions;

namespace LeetCode.Solutions.Medium._34_Find_First_and_Last_Position_of_Element_in_Sorted_Array;

public class Tests
{
    public static TestData[] SearchRange_TargetExist_ReturnsClosestSubarrayCases =
    {
        new(
            [5, 7, 7, 8, 8, 10],
            8,
            [3, 4]
        ),
        new(
            [5, 7, 7, 8, 8, 10],
            6,
            [-1, -1]
        )
    };

    [TestCaseSource(nameof(SearchRange_TargetExist_ReturnsClosestSubarrayCases))]
    public void SearchRange_TargetExist_ReturnsClosestSubarray(TestData testData)
    {
        var result = new Solution().SearchRange(testData.Nums, testData.Target);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int[] Nums, int Target, int[] Expected);
}