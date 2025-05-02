namespace Leetcode.Solutions.Easy._448._Find_All_Numbers_Disappeared_in_an_Array;

/// <summary>
///     https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array
/// </summary>
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int i = 0;
        var result = new List<int>();

        while (i < nums.Length)
        {
            if (nums[i] != i + 1 && nums[i] != nums[nums[i] - 1])
                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
            else
                i++;
        }

        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
                result.Add(i + 1);
        }

        return result;
    }
}
