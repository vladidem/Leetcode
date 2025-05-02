namespace Leetcode.Solutions.Medium._713._Subarray_Product_Less_Than_K;

/// <summary>
///     https://leetcode.com/problems/subarray-product-less-than-k/
/// </summary>
public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        int windowStart = 0;
        int windowProduct = 1;
        int count = 0;
        int target = k;

        for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
        {
            windowProduct *= nums[windowEnd];

            while (windowProduct >= target && windowStart < windowEnd)
            {
                windowProduct /= nums[windowStart];
                windowStart++;
            }

            if (windowProduct < target)
            {
                int numsInWindow = windowEnd - windowStart + 1;

                count += numsInWindow;
            }
        }

        return count;
    }
}
