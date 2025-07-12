namespace Leetcode.Solutions.Medium._53._Maximum_Subarray;

/// <summary>
///     https://leetcode.com/problems/maximum-subarray/
/// </summary>
public class Solution
{
    // Kadane's Algorithm
    public int MaxSubArray(int[] nums)
    {
        int maxSum = int.MinValue;
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = Math.Max(sum + nums[i], nums[i]);
            maxSum = Math.Max(sum, maxSum);
        }

        return maxSum;
    }
}
