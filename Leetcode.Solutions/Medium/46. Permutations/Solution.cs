namespace Leetcode.Solutions.Medium._46._Permutations;

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

        for (int i = 1; i < nums.Length; i++)
        {
            mutations = mutations.SelectMany(mutation => NewMutations(nums, nums[i], mutation)).ToList();
        }

        return mutations;
    }

    private IEnumerable<IList<int>> NewMutations(int[] nums, int newNum, IList<int> mutation)
    {
        for (int j = 0; j <= mutation.Count; j++)
        {
            IList<int> newMutation = new List<int>(mutation);
            newMutation.Insert(j, newNum);
            yield return newMutation;
        }
    }
}
