namespace Leetcode.Solutions.Easy._2200._Find_AllK_Distant_Indices_in_an_Array;

/// <summary>
///     https://leetcode.com/problems/find-all-k-distant-indices-in-an-array/
/// </summary>
public class Solution
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var keys = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == key)
                keys.Add(i);
        }

        var result = keys
            .Select(i =>
            {
                int min = Math.Max(i - k, 0);
                int max = Math.Min(i + k, nums.Length - 1);

                return Enumerable.Range(min, max - min + 1);
            })
            .SelectMany(it => it)
            .ToList();
        var resultDistinct = new SortedSet<int>(result);

        return resultDistinct.ToList();
    }
}
