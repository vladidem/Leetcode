namespace LeetCode.Solutions.Easy.Cyclic_Sort;

public class Solution
{
    public void Sort(int[] nums)
    {
        for (var i = 0; i < nums.Length - 1; i++)
            while (nums[i] != i + 1)
                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
    }
}