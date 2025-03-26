namespace LeetCode.Solutions.Easy._448_Find_All_Numbers_Disappeared_In_An_Array;

/// <summary>
///     https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array
/// </summary>
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var i = 0;
        var result = new List<int>();

        while (i < nums.Length)
            if (nums[i] != i + 1 && nums[i] != nums[nums[i] - 1])
                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
            else
                i++;

        for (i = 0; i < nums.Length; i++)
            if (nums[i] != i + 1)
                result.Add(i + 1);

        return result;
    }
}