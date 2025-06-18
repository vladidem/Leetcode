using FluentAssertions;

namespace Leetcode.Solutions.Medium._2966._Divide_Array_Into_Arrays_With_Max_Difference;

public class Tests
{
    public static TestData[] DivideArray_DivisionExists_ReturnsDividedArrayCases =
    {
        new(
            2,
            [1, 3, 4, 8, 7, 9, 3, 5, 1]
        ),
        new(
            14,
            [4, 2, 9, 8, 2, 12, 7, 12, 10, 5, 8, 5, 5, 7, 9, 2, 5, 11]
        )
    };

    public static TestData[] DivideArray_DivisionDoesntExist_ReturnsEmptyArrayCases =
    {
        new(
            2,
            [2, 4, 2, 2, 5, 2]
        )
    };


    [TestCaseSource(nameof(DivideArray_DivisionExists_ReturnsDividedArrayCases))]
    public void DivideArray_DivisionExists_ReturnsDividedArray(TestData testData)
    {
        int[][] result = new Solution().DivideArray(testData.Nums, testData.K);

        result.Length.Should().Be(testData.Nums.Length / 3);
        foreach (int[] chunk in result)
        {
            chunk.Length.Should().Be(3);

            int diff = chunk.Max() - chunk.Min();

            diff.Should().BeLessOrEqualTo(testData.K);
        }
    }

    [TestCaseSource(nameof(DivideArray_DivisionDoesntExist_ReturnsEmptyArrayCases))]
    public void DivideArray_DivisionDoesntExist_ReturnsEmptyArray(TestData testData)
    {
        int[][] result = new Solution().DivideArray(testData.Nums, testData.K);

        result.Length.Should().Be(0);
    }

    public record TestData(int K, int[] Nums);
}
