namespace Leetcode.Solutions.Easy._28._Find_the_Index_of_the_First_Occurrence_in_a_String;

/// <summary>
///     https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
/// </summary>
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        for (int start = 0; start <= haystack.Length - needle.Length; start++)
        {
            bool equal = true;
            for (int c = 0; c < needle.Length; c++)
            {
                if (haystack[start + c] != needle[c])
                {
                    equal = false;
                    break;
                }
            }

            if (equal)
                return start;
        }

        return -1;
    }
}
