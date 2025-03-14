namespace LeetCode.Solutions.Easy._125_Valid_Palindrome;

/// <summary>
///     https://leetcode.com/problems/valid-palindrome/
/// </summary>
public class Solution
{
    public bool IsPalindrome(string s)
    {
        for (int startPointer = 0, endPointer = s.Length; startPointer < endPointer; startPointer++, endPointer--)
        {
            if (s[startPointer] != s[endPointer])
                return false;
        }

        return true;
    }
}