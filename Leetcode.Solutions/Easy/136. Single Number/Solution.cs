namespace Leetcode.Solutions.Easy._136._Single_Number;

/// <summary>
///     https://leetcode.com/problems/single-number/
/// </summary>
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result;
    }
}
