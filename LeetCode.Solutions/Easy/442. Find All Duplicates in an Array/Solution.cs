namespace LeetCode.Solutions.Easy._448_Find_All_Duplicates_in_an_Array;

/// <summary>
///     https://leetcode.com/problems/find-all-duplicates-in-an-array/
/// </summary>
public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var i = 0;
        var duplicates = new HashSet<int>();

        while (i < nums.Length)
            if (nums[i] != i + 1)
            {
                if (nums[i] == nums[nums[i] - 1])
                {
                    duplicates.Add(nums[i]);
                    i++;
                }
                else
                {
                    (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
                }
            }
            else
            {
                i++;
            }

        return duplicates.ToList();
    }
}