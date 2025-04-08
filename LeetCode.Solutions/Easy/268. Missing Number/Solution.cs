namespace LeetCode.Solutions.Easy._268_Missing_Number;

/// <summary>
///     https://leetcode.com/problems/missing-number/
/// </summary>
public class Solution
{
    public int MissingNumber(int[] nums)
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
