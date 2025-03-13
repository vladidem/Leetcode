namespace LeetCode.Solutions.Medium._75_Sort_Colors;

/// <summary>
/// https://leetcode.com/problems/sort-colors/
/// </summary>
public class Solution
{
    private const int Red = 0;
    private const int White = 1;
    private const int Blue = 2;

    public void SortColors(int[] nums)
    {
        int lastSorted = -1;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == Red)
            {
                lastSorted++;
                (nums[i], nums[lastSorted]) = (nums[lastSorted], nums[i]);
            }
        }      
        
        for (int i = lastSorted + 1; i < nums.Length; i++)
        {
            if (nums[i] == White)
            {
                lastSorted++;
                (nums[i], nums[lastSorted]) = (nums[lastSorted], nums[i]);
            }
        }    
    }
}
