using System.Collections.Immutable;

namespace LeetCode.Solutions.Medium._46_Permutations;

/// <summary>
///     https://leetcode.com/problems/permutations/
/// </summary>
public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        return PermuteIterative(nums);
    }

    public IList<IList<int>> PermuteIterative(int[] nums)
    {
        if (nums.Length == 0)
            return [];
        IList<IList<int>> mutations = new List<IList<int>>();
        mutations.Add([nums[0]]);

        for (var i = 1; i < nums.Length; i++)
            mutations = mutations.SelectMany(mutation => NewMutations(nums, nums[i], mutation)).ToList();

        return mutations;
    }

    private IEnumerable<IList<int>> NewMutations(int[] nums, int newNum, IList<int> mutation)
    {
        for (var j = 0; j <= mutation.Count; j++)
        {
            IList<int> newMutation = new List<int>(mutation);
            newMutation.Insert(j, newNum);
            yield return newMutation;
        }
    }

    public IEnumerable<IList<int>> PermuteRecursive(int[] nums, ImmutableHashSet<int> visited, IList<int> path)
    {
        if (path.Count == nums.Length) return [path];
        return nums.Where(it => !visited.Contains(it)).SelectMany(it =>
        {
            IList<int> newPath = new List<int>(path);
            newPath.Add(it);
            return PermuteRecursive(nums, visited.Add(it), newPath);
        });
    }
}