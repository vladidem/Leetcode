namespace LeetCode.Solutions.Medium._238_Product_of_Array_Except_Self;

public class Tests
{
    [TestCase(new[] { 1, 2, 3, 4 }, ExpectedResult = new[] { 24, 12, 8, 6 })]
    [TestCase(new[] { -1, 1, 0, -3, 3 }, ExpectedResult = new[] { 0, 0, 9, 0, 0 })]
    public int[] ProductExceptSelf_NormalArray_ReturnsProductArray(int[] nums)
    {
        return new Solution().ProductExceptSelf(nums);
    }
}