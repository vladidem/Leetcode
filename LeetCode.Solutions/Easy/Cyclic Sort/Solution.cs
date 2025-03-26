namespace LeetCode.Solutions.Easy.Cyclic_Sort;

public class Solution
{
    public void Sort(int[] nums)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            var j = i;
            while (nums[j] != j - 1)
                (nums[j], nums[nums[j] - 1]) = (nums[nums[j] - 1], nums[j]);
        }
    }
}