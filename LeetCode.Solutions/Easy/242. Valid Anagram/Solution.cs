namespace LeetCode.Solutions.Easy._242_Valid_Anagram;

/// <summary>
///     https://leetcode.com/problems/valid-anagram/
/// </summary>
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        SortedDictionary<char, int> sChars = new();
        SortedDictionary<char, int> tChars = new();

        foreach (char c in s)
            sChars[c] = sChars.GetValueOrDefault(c, 0) + 1;

        foreach (char c in t)
            tChars[c] = tChars.GetValueOrDefault(c, 0) + 1;

        return sChars.SequenceEqual(tChars);
    }
}