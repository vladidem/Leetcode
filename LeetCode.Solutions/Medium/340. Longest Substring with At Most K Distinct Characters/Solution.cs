namespace LeetCode.Solutions.Medium._340_Longest_Substring_With_At_Most_K_Distinct_Characters;

/// <summary>
///     https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/description/
/// </summary>
public class Solution
{
    public int LongestSubstringKDistinct(string str, int maxDistinct)
    {
        if (maxDistinct < 1) return 0;

        int windowStart = 0;
        int windowDistinct = 0;
        var windowChars = new Dictionary<char, int>();
        int maxLenght = 1;

        for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
        {
            char endChar = str[windowEnd];
            if (windowChars.GetValueOrDefault(endChar, 0) > 0)
            {
                windowChars[endChar]++;
            }
            else
            {
                windowChars[endChar] = 1;
                windowDistinct++;
            }

            while (windowDistinct > maxDistinct)
            {
                char startChar = str[windowStart];
                windowChars[startChar]--;
                if (windowChars[startChar] == 0)
                {
                    windowDistinct--;
                }

                windowStart++;
            }

            int windowLength = windowEnd - windowStart + 1;
            if (windowLength > maxLenght)
            {
                maxLenght = windowLength;
            }
        }

        return maxLenght;
    }
}