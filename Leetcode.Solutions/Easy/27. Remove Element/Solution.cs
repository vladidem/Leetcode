namespace Leetcode.Solutions.Easy._27._Remove_Element;

/// <summary>
///     https://leetcode.com/problems/remove-element/
/// </summary>
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int lastNotVal = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                lastNotVal++;
                (nums[i], nums[lastNotVal]) = (nums[lastNotVal], nums[i]);
            }
        }

        return lastNotVal + 1;
    }
}
