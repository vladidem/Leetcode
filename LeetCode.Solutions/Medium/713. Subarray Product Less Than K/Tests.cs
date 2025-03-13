using FluentAssertions;

namespace LeetCode.Solutions.Medium._713_Subarray_Product_Less_Than_K;

public class Tests
{
    [TestCase(new[] { 10, 5, 2, 6 }, 100, ExpectedResult = 8)]
    [TestCase(new[] { 2, 5, 3, 10 }, 30, ExpectedResult = 6)]
    [TestCase(new[] { 8, 2, 6, 5 }, 50, ExpectedResult = 7)]
    public int NumSubarrayProductLessThanK_ProductsExist_ReturnsNumOfSubarrays(int[] nums, int k)
    {
        return new Solution().NumSubarrayProductLessThanK(nums, k);
    }
}
