﻿namespace Leetcode.Solutions.Medium._90._Subsets_II;

/// <summary>
///     https://leetcode.com/problems/subsets/
/// </summary>
public class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        IList<IList<int>> sets = new List<IList<int>>();
        Array.Sort(nums);

        sets.Add([]);
        IList<IList<int>> current = new List<IList<int>>(sets);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                current = current.Select(it =>
                {
                    IList<int> newList = new List<int>(it);
                    newList.Add(nums[i]);

                    return newList;
                }).ToList();

            else
                current = sets.Select(it =>
                {
                    IList<int> newList = new List<int>(it);
                    newList.Add(nums[i]);

                    return newList;
                }).ToList();

            sets = sets.Concat(current).ToList();
        }

        return sets;
    }
}
