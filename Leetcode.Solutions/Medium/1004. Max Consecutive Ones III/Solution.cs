namespace Leetcode.Solutions.Medium._1004._Max_Consecutive_Ones_III;

/// <summary>
///     https://leetcode.com/problems/max-consecutive-ones-iii/
/// </summary>
public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length <= k) return k;

        int windowStart = 0;
        int windowEnd = 0;
        int maxLength = k;
        int windowZeroes = 0;
        if (nums[0] == 0) windowZeroes = 1;

        while (windowEnd < nums.Length - 1)
        {
            if (windowZeroes <= k)
            {
                windowEnd++;
                if (nums[windowEnd] == 0) windowZeroes++;
            }

            if (windowZeroes > k)
            {
                if (nums[windowStart] == 0) windowZeroes--;
                windowStart++;
            }

            if (windowZeroes <= k
                && windowEnd - windowStart + 1 > maxLength)
            {
                maxLength = windowEnd - windowStart + 1;
            }
        }

        return maxLength;
    }
}
