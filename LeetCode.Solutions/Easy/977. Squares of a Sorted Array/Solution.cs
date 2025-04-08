namespace LeetCode.Solutions.Easy._977_Squares_Of_A_Sorted_Array;

/// <summary>
///     https://leetcode.com/problems/squares-of-a-sorted-array/
/// </summary>
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int firstNonNegative = nums.Length - 1;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] >= 0)
            {
                firstNonNegative = i;
                break;
            }
        }

        int left = Math.Max(firstNonNegative - 1, 0);
        int right = left + 1;
        int[] result = new int[nums.Length];

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (right > nums.Length - 1
                || (left >= 0 && (int)Math.Pow(nums[left], 2) <= (int)Math.Pow(nums[right], 2)))
            {
                result[i] = (int)Math.Pow(nums[left], 2);
                left--;
            }
            else
            {
                result[i] = (int)Math.Pow(nums[right], 2);
                right++;
            }
        }

        return result;
    }
}
