namespace Leetcode.Solutions.Medium._75._Sort_Colors;

/// <summary>
///     https://leetcode.com/problems/sort-colors/
/// </summary>
public class Solution
{
    private const int Red = 0;
    private const int White = 1;
    private const int Blue = 2;

    public void SortColors(int[] nums)
    {
        SortColors1Pass(nums);
    }

    public void SortColors2Pass(int[] nums)
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

    private void SortColors1Pass(int[] nums)
    {
        int lastRed = -1;
        int firstBlue = nums.Length;

        for (int i = 0; i < firstBlue;)
        {
            if (nums[i] == Red)
            {
                lastRed++;
                (nums[i], nums[lastRed]) = (nums[lastRed], nums[i]);
                i++;
            }
            else if (nums[i] == White)
            {
                i++;
            }
            else if (nums[i] == Blue)
            {
                firstBlue--;
                (nums[i], nums[firstBlue]) = (nums[firstBlue], nums[i]);
            }
        }
    }
}
