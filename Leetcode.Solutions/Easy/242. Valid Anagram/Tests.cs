namespace LeetCode.Solutions.Easy._242_Valid_Anagram;

public class Tests
{
    [TestCase("anagram", "nagaram", ExpectedResult = true)]
    public bool IsAnagram_ValidAnagrams_ReturnsTrue(string s, string t)
    {
        return new Solution().IsAnagram(s, t);
    }

    [TestCase("rat", "car", ExpectedResult = false)]
    public bool IsAnagram_InvalidAnagrams_ReturnsFalse(string s, string t)
    {
        return new Solution().IsAnagram(s, t);
    }
}
