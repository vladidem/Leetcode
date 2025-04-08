namespace LeetCode.Solutions.Medium._238_Product_of_Array_Except_Self;

/// <summary>
///     https://leetcode.com/problems/product-of-array-except-self/
/// </summary>
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] prefixProduct = new int[nums.Length];

        prefixProduct[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            prefixProduct[i] = nums[i] * prefixProduct[i - 1];
        }

        int[] suffixProduct = nums;

        for (int i = suffixProduct.Length - 2; i >= 0; i--)
        {
            suffixProduct[i] = suffixProduct[i + 1] * suffixProduct[i];
        }

        int[] result = suffixProduct;
        int first = suffixProduct[1];
        int last = prefixProduct[prefixProduct.Length - 2];
        for (int i = 1; i < result.Length - 1; i++)
        {
            result[i] = prefixProduct[i - 1] * suffixProduct[i + 1];
        }

        result[0] = first;
        result[result.Length - 1] = last;

        return result;
    }
}
