using FluentAssertions;

namespace Leetcode.Solutions.Medium._49._Group_Anagrams;

public class Tests
{
    [Test]
    public void GroupAnagrams_NotEmpty_ReturnsGroupedAnagrams()
    {
        string[] anagrams = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var expectedResult = new List<IList<string>>
        {
            new List<string> { "bat" },
            new List<string> { "nat", "tan" },
            new List<string> { "ate", "eat", "tea" }
        };

        var result = new Solution().GroupAnagrams(anagrams);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void GroupAnagrams_OneWord_ReturnsOneGroup()
    {
        string[] anagrams = new[] { "a" };
        var expectedResult = new List<IList<string>>
        {
            new List<string> { "a" }
        };

        var result = new Solution().GroupAnagrams(anagrams);

        result.Should().BeEquivalentTo(expectedResult);
    }
}
