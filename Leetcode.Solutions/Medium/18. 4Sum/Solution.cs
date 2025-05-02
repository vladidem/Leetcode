namespace Leetcode.Solutions.Medium._18._4Sum;

/// <summary>
///     https://leetcode.com/problems/4sum/
/// </summary>
public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        int[] sortedNums = nums.OrderBy(x => x).ToArray();

        return NSumOnSorted(sortedNums, target, 4, 0);
    }

    public IList<IList<int>> NSumOnSorted(int[] sortedNums, long target, int n, int leftStart)
    {
        var result = new List<IList<int>>();

        if (!sortedNums.Any())
            return result;
        if (sortedNums.Length - leftStart < n)
            return result;
        if (n == 2)
            return TwoSumsOnSorted(sortedNums, target, leftStart);

        for (int i = leftStart; i <= sortedNums.Length - n; i++)
        {
            if (i >= 1 && i > leftStart && sortedNums[i] == sortedNums[i - 1]) continue;

            var currentNumSums = NSumOnSorted(
                sortedNums,
                target - sortedNums[i],
                n - 1,
                i + 1);

            foreach (var partialSumm in currentNumSums)
            {
                partialSumm.Insert(0, sortedNums[i]);
                result.Add(partialSumm);
            }
        }

        return result;
    }

    public IList<IList<int>> TwoSumsOnSorted(int[] nums, long target, int leftStart)
    {
        int right = nums.Length - 1;
        int left = leftStart;
        IList<IList<int>> result = new List<IList<int>>();

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
