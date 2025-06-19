namespace Leetcode.Solutions.Medium._2294._Partition_Array_Such_That_Maximum_Difference_Is_K;

/// <summary>
///     https://leetcode.com/problems/partition-array-such-that-maximum-difference-is-k/
/// </summary>
public class Solution
{
    public int PartitionArray(int[] nums, int k)
    {
        if (nums.Length <= 1)
            return 1;

        Array.Sort(nums);
        int partitionStart = 0;
        int partitionsCount = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[partitionStart] > k)
            {
                partitionsCount++;
                partitionStart = i;
            }
        }

        return partitionsCount;
    }
}
