namespace Leetcode.Solutions.Medium._424._Longest_Repeating_Character_Replacement;

public class Tests
{
    [TestCase("ABAB", 2, ExpectedResult = 4)]
    [TestCase("AABABBA", 1, ExpectedResult = 4)]
    public int CharacterReplacement_NormalString_ReturnsLongestDistinct(string s, int k)
    {
        return new Solution().CharacterReplacement(s, k);
    }
}
