namespace LeetCode.Solutions.Easy._1_Two_Sum;

/// <summary>
///     https://leetcode.com/problems/two-sum/
/// </summary>
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var numPositions = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int remainder = target - nums[i];

            if (numPositions.TryGetValue(remainder, out int j))
            {
                return [i, j];
            }

            numPositions[nums[i]] = i;
        }

        return [];
    }
}
