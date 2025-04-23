namespace LeetCode.Solutions.Medium._416_Partition_Equal_Subset_Sum;

/// <summary>
///     https://leetcode.com/problems/partition-equal-subset-sum/
/// </summary>
public class Solution
{
    public bool CanPartition(int[] nums)
    {
        if (nums.Length <= 1) return false;

        int sum = nums.Sum();
        if (sum % 2 != 0) return false;
        sum /= 2;

        var possiblePartialSums = new HashSet<int> { 0 };
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            var newSums = new HashSet<int>();
            foreach (int partialSum in possiblePartialSums)
            {
                int newSum = partialSum + nums[i];
                if (newSum == sum)
                    return true;
                if (newSum < sum)
                    newSums.Add(newSum);
            }

            possiblePartialSums.UnionWith(newSums);
        }

        return false;
    }
}
