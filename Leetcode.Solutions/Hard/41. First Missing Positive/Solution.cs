namespace Leetcode.Solutions.Hard._41._First_Missing_Positive;

/// <summary>
///     https://leetcode.com/problems/first-missing-positive/
/// </summary>
public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int i;
        for (i = 0; i < nums.Length; i++)
        {
            while (nums[i] != i + 1
                   && nums[i] < nums.Length
                   && nums[i] > 0)
            {
                if (nums[i] == nums[nums[i] - 1]) break;

                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
            }
        }

        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }

        return nums.Length + 1;
    }
}
