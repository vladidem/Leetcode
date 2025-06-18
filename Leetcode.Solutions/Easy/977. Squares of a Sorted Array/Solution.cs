namespace Leetcode.Solutions.Easy._977._Squares_of_a_Sorted_Array;

/// <summary>
///     https://leetcode.com/problems/squares-of-a-sorted-array/
/// </summary>
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int[] result = new int[nums.Length];
        int i = 0;
        (int negativePointer, int positivePointer) = GetMiddle(nums);

        while (negativePointer >= 0 || positivePointer <= nums.Length - 1)
        {
            if (negativePointer < 0
                || (positivePointer <= nums.Length - 1
                    && Math.Abs(nums[positivePointer]) < Math.Abs(nums[negativePointer])))
            {
                result[i] = nums[positivePointer] * nums[positivePointer];
                i++;
                positivePointer++;
            }
            else
            {
                result[i] = nums[negativePointer] * nums[negativePointer];
                i++;
                negativePointer--;
            }
        }

        return result;
    }

    private (int negativePointer, int positivePointer) GetMiddle(int[] nums)
    {
        int negativePointer = 0;
        int positivePointer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0 && nums[i] >= 0)
            {
                negativePointer = -1;
                positivePointer = 0;
                break;
            }

            if (i == nums.Length - 1 && nums[i] <= 0)
            {
                negativePointer = nums.Length - 1;
                positivePointer = nums.Length;
                break;
            }

            if (i > 0 && nums[i - 1] <= 0 && nums[i] >= 0)
            {
                negativePointer = i - 1;
                positivePointer = i;
            }
        }

        return (negativePointer, positivePointer);
    }
}
