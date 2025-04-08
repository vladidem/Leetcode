namespace LeetCode.Solutions.Easy._217_Contains_Duplicate;

/// <summary>
///     https://leetcode.com/problems/contains-duplicate/
/// </summary>
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var uniqueNums = new HashSet<int>();
        foreach (int num in nums)
        {
            if (uniqueNums.Contains(num))
                return true;

            uniqueNums.Add(num);
        }

        return false;
    }
}
