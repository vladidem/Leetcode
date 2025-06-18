namespace Leetcode.Solutions.Medium._2966._Divide_Array_Into_Arrays_With_Max_Difference;

/// <summary>
///     https://leetcode.com/problems/divide-array-into-arrays-with-max-difference/
/// </summary>
public class Solution
{
    public int[][] DivideArray(int[] nums, int k)
    {
        int arraysCount = nums.Length / 3;
        Array.Sort(nums);
        List<int[]> result = new();

        foreach ((int start, int end) in GetBoundaries(nums.Length, nums.Length / arraysCount))
        {
            if (nums[end] - nums[start] > k)
            {
                return [];
            }

            result.Add(nums[start..(end + 1)]);
        }

        return result.ToArray();
    }

    public IEnumerable<(int start, int end)> GetBoundaries(int length, int size)
    {
        int start = 0;
        int end = start + size - 1;

        while (start <= length - 1)
        {
            yield return (start, end);

            start = end + 1;
            end = start + size - 1;
        }
    }
}
