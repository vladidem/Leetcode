namespace Leetcode.Solutions.Medium._567._Permutation_in_String;

/// <summary>
///     https://leetcode.com/problems/permutation-in-string/
/// </summary>
public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s2.Length < s1.Length) return false;

        var neededChars = new Dictionary<char, int>();
        for (int i = 0; i < s1.Length; i++)
        {
            neededChars[s1[i]] = neededChars.GetValueOrDefault(s1[i], 0) + 1;
        }

        for (int windowI = 0; windowI < s1.Length; windowI++)
        {
            neededChars[s2[windowI]] = neededChars.GetValueOrDefault(s2[windowI], 0) - 1;
            if (neededChars[s2[windowI]] == 0)
                neededChars.Remove(s2[windowI]);
        }

        if (!neededChars.Any()) return true;

        for (int windowEnd = s1.Length; windowEnd < s2.Length; windowEnd++)
        {
            int exWindowStart = windowEnd - s1.Length;
            neededChars[s2[exWindowStart]] = neededChars.GetValueOrDefault(s2[exWindowStart], 0) + 1;
            neededChars[s2[windowEnd]] = neededChars.GetValueOrDefault(s2[windowEnd], 0) - 1;

            if (neededChars[s2[exWindowStart]] == 0)
                neededChars.Remove(s2[exWindowStart]);
            if (neededChars.ContainsKey(s2[windowEnd]) && neededChars[s2[windowEnd]] == 0)
                neededChars.Remove(s2[windowEnd]);

            if (!neededChars.Any()) return true;
        }

        return false;
    }
}
