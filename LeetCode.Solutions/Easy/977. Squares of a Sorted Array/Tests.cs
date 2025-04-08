namespace LeetCode.Solutions.Easy._977_Squares_Of_A_Sorted_Array;

public class Tests
{
    [TestCase(new[] { -4, -1, 0, 3, 10 }, ExpectedResult = new[] { 0, 1, 9, 16, 100 })]
    [TestCase(new[] { -7, -3, 2, 3, 11 }, ExpectedResult = new[] { 4, 9, 9, 49, 121 })]
    public int[] SortedSquares_MixedArray_ReturnsSortedSquares(int[] nums)
    {
        return new Solution().SortedSquares(nums);
    }

    [TestCase(new[] { -5, -3, -2, -1 }, ExpectedResult = new[] { 1, 4, 9, 25 })]
    public int[] SortedSquares_NegativeArray_ReturnsSortedSquares(int[] nums)
    {
        return new Solution().SortedSquares(nums);
    }

    [TestCase(new[] { 0, 2 }, ExpectedResult = new[] { 0, 4 })]
    public int[] SortedSquares_PositiveArray_ReturnsSortedSquares(int[] nums)
    {
        return new Solution().SortedSquares(nums);
    }
}
