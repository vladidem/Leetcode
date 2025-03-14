namespace LeetCode.Solutions.Medium._15_3_Sum;

/// <summary>
///     https://leetcode.com/problems/3sum/
/// </summary>
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        int[] sortedNums = nums.OrderBy(x => x).ToArray();

        for (int i = 0; i < sortedNums.Length - 2; i++)
        {
            if (i >= 1 && sortedNums[i] == sortedNums[i - 1]) continue;

            var currentNumSumms = TwoSumsOnSorted(sortedNums, -sortedNums[i], i + 1);
            foreach (var partialSumm in currentNumSumms)
            {
                partialSumm.Insert(0, sortedNums[i]);
                result.Add(partialSumm);
            }
        }

        return result;
    }

    public List<List<int>> TwoSumsOnSorted(int[] nums, int target, int leftStart)
    {
        int right = nums.Length - 1;
        int left = leftStart;
        var result = new List<List<int>>();

        while (left < right)
        {
            if (nums[left] + nums[right] == target)
            {
                result.Add([nums[left], nums[right]]);
                int leftNum = nums[left];
                int rightNum = nums[right];

                while (nums[left] == leftNum && left < right)
                {
                    left++;
                }

                while (nums[right] == rightNum && right > left)
                {
                    right--;
                }
            }
            else if (nums[left] + nums[right] < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return result;
    }
}