namespace LeetCode.Solutions.Medium._78_Subsets;

/// <summary>
///     https://leetcode.com/problems/subsets/
/// </summary>
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> sets = new List<IList<int>>();
        sets.Add([]);
        for (var i = 0; i < nums.Length; i++)
            sets = sets.Concat(sets.Select(it =>
            {
                var newList = new List<int>(it);
                newList.Add(nums[i]);

                return newList;
            })).ToList();

        IList<IList<int>> result = new List<IList<int>>(sets.Select(it => it.ToList()));

        return result;
    }
}