namespace Leetcode.Solutions.Easy._744._Find_Smallest_Letter_Greater_Than_Target;

/// <summary>
///     https://leetcode.com/problems/find-smallest-letter-greater-than-target/
/// </summary>
public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int left = 0;
        int right = letters.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (target < letters[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }

        if (left < letters.Length && letters[left] > target) return letters[left];

        return letters[0];
    }
}
