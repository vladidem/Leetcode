namespace LeetCode.Solutions.Medium._260_Single_Number_III;

/// <summary>
///     https://leetcode.com/problems/single-number-iii/
/// </summary>
public class Solution
{
    public int[] SingleNumber(int[] nums)
    {
        int aXorB = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            aXorB ^= nums[i];
        }

        int differentBit = 1;
        while ((aXorB & differentBit) == 0)
        {
            differentBit <<= 1;
        }

        int a = 0;
        int b = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if ((nums[i] & differentBit) != 0)
                a ^= nums[i];
            else
                b ^= nums[i];
        }

        return [a, b];
    }
}
