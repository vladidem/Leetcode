namespace Leetcode.Solutions.Medium._424._Longest_Repeating_Character_Replacement;

/// <summary>
///     https://leetcode.com/problems/longest-repeating-character-replacement/
/// </summary>
public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int maxCharsToReplace = k;
        int windowStart = 0;
        var windowChars = new Dictionary<char, int>();
        int maxLenght = 1;

        for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
        {
            char endChar = s[windowEnd];
            if (windowChars.GetValueOrDefault(endChar, 0) > 0)
            {
                windowChars[endChar]++;
            }
            else
            {
                windowChars[endChar] = 1;
            }

            int mostFrequentCharCount = windowChars.Values.Max();
            int charsToReplace = windowEnd - windowStart + 1 - mostFrequentCharCount;

            while (charsToReplace > maxCharsToReplace)
            {
                char startChar = s[windowStart];
                windowChars[startChar]--;
                windowStart++;

                mostFrequentCharCount = windowChars.Values.Max();
                charsToReplace = windowEnd - windowStart + 1 - mostFrequentCharCount;
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
