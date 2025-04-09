using FluentAssertions;

namespace LeetCode.Solutions.Medium._852_Peak_Index_in_a_Mountain_Array;

public class Tests
{
    public static TestData[] eakIndexInMountainArray_NotEmpty_ReturnsPeakIndexCases =
    {
        new(
            [0, 1, 0],
            1
        ),
        new(
            [0, 2, 1, 0],
            1
        ),
        new(
            [0, 10, 5, 2],
            1
        )
    };

    [TestCaseSource(nameof(eakIndexInMountainArray_NotEmpty_ReturnsPeakIndexCases))]
    public void PeakIndexInMountainArray_NotEmpty_ReturnsPeakIndex(TestData testData)
    {
        new Solution().PeakIndexInMountainArray(testData.Nums).Should().Be(testData.Expected);
    }

    public record TestData(int[] Nums, int Expected);
}
