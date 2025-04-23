using FluentAssertions;

namespace LeetCode.Solutions.Medium._378_Kth_Smallest_Element_in_a_Sorted_Matrix;

public class Tests
{
    public static TestData[] KthSmallest_SortedMatrix_ReturnsKthSmallestCases =
    {
        new(
            [[1, 5, 9], [10, 11, 13], [12, 13, 15]],
            8,
            13
        ),
        new(
            [[-5]],
            1,
            -5
        )
    };

    [TestCaseSource(nameof(KthSmallest_SortedMatrix_ReturnsKthSmallestCases))]
    public void KthSmallest_SortedMatrix_ReturnsKthSmallest(TestData testData)
    {
        int result = new Solution().KthSmallest(testData.matrix, testData.k);

        result.Should().Be(testData.result);
    }


    public record TestData(int[][] matrix, int k, int result);
}
