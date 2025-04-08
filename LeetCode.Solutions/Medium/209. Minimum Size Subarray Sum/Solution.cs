namespace LeetCode.Solutions.Medium._209_Minimum_Size_Subarray_Sum;

/// <summary>
///     https://leetcode.com/problems/minimum-size-subarray-sum/description/
/// </summary>
public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int windowStart = 0;
        int windowSum = 0;
        int? minimumLenght = null;

        for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
        {
            windowSum += nums[windowEnd];
            while (windowSum >= target)
            {
                int length = windowEnd - windowStart + 1;
                if ((minimumLenght ?? int.MaxValue) > length)
                {
                    minimumLenght = length;
                }

                windowSum -= nums[windowStart];
                windowStart++;
            }
        }

        return minimumLenght ?? 0;
    }
}
