namespace Leetcode.Solutions.Easy._2016._Maximum_Difference_Between_Increasing_Elements;

/// <summary>
///     https://leetcode.com/problems/maximum-difference-between-increasing-elements/
/// </summary>
public class Solution
{
    public int MaximumDifference(int[] nums)
    {
        if (nums.Length < 2) return 0;

        int maxDiff = -1;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] > nums[i]
                    && nums[j] - nums[i] > maxDiff)
                    maxDiff = nums[j] - nums[i];
            }
        }

        return maxDiff;
    }

    public int MaximumDifference_Linear(int[] nums)
    {
        if (nums.Length < 2) return 0;

        int maxDiff = -1;
        int minNumber = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < minNumber)
                minNumber = nums[i];

            if (nums[i] > minNumber
                && nums[i] - minNumber > maxDiff)
                maxDiff = nums[i] - minNumber;
        }

        return maxDiff;
    }
}
