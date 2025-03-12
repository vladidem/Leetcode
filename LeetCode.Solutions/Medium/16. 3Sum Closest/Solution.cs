namespace LeetCode.Solutions.Medium._16_3_Sum_Closest;

/// <summary>
/// https://leetcode.com/problems/3sum-closest/
/// </summary>
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int[] sortedNums = nums.OrderBy(x => x).ToArray();
        int smallestDiff = int.MaxValue;

        for (int i = 0; i < sortedNums.Length - 2; i++)
        {
            if (i >= 1 && sortedNums[i] == sortedNums[i - 1]) continue;
            int right = nums.Length - 1;
            int left = i + 1;

            while (left < right)
            {
                int diff = target - sortedNums[left] - sortedNums[right] - sortedNums[i];
                if (Math.Abs(diff) < Math.Abs(smallestDiff))
                {
                    smallestDiff = diff;
                }

                if (diff > 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return target - smallestDiff;
    }
}
