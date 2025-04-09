namespace LeetCode.Solutions.Easy._268_Missing_Number;

/// <summary>
///     https://leetcode.com/problems/missing-number/
/// </summary>
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        return MissingNumberXor(nums);
    }

    public int MissingNumberXor(int[] nums)
    {
        int result = 0;
        for (int i = 0; i <= nums.Length; i++)
        {
            result ^= i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result;
    }

    public int MissingNumberCyclicSort(int[] nums)
    {
        int i;
        for (i = 0; i < nums.Length; i++)
        {
            while (nums[i] != i && nums[i] < nums.Length)
            {
                (nums[i], nums[nums[i]]) = (nums[nums[i]], nums[i]);
            }
        }

        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
                return i;
        }

        return nums.Length;
    }
}
