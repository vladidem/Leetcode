namespace LeetCode.Solutions.Medium._137_Single_Number_II;

/// <summary>
///     https://leetcode.com/problems/single-number-ii/
/// </summary>
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        var result = new TriBitNumber();

        for (int i = 0; i < nums.Length; i++)
        {
            result.Add(nums[i]);
        }

        return result.ToInt();
    }

    public class TriBitNumber
    {
        private readonly int[] bits = new int[sizeof(int) * 8];

        public void Add(int num)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if ((num & (1 << i)) != 0)
                    bits[i] = (bits[i] + 1) % 3;
            }
        }

        public int ToInt()
        {
            int result = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1)
                {
                    result |= 1 << i;
                }
            }

            return result;
        }
    }
}
