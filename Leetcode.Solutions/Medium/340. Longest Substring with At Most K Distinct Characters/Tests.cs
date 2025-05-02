namespace Leetcode.Solutions.Medium._340._Longest_Substring_with_At_Most_K_Distinct_Characters;

public class Tests
{
    [TestCase("araaci", 2, ExpectedResult = 4)]
    [TestCase("araaci", 1, ExpectedResult = 2)]
    [TestCase("cbbebi", 3, ExpectedResult = 5)]
    public int LongestSubstringKDistinct_NormalString_ReturnsLongestDistinct(string str, int max)
    {
        return new Solution().LongestSubstringKDistinct(str, max);
    }
}
