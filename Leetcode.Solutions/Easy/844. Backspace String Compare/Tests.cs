using FluentAssertions;

namespace Leetcode.Solutions.Easy._844._Backspace_String_Compare;

public class Tests
{
    [TestCase("ab#c", "ad#c")]
    [TestCase("ab##", "c#d#")]
    [TestCase("xywrrmp", "xywrrmu#p")]
    [TestCase("bxj##tw", "bxo#j##tw")]
    [TestCase("nzp#o#g", "b#nzp#o#g")]
    public void BackspaceCompare_Equal_ReturnsTrue(string s, string t)
    {
        new Solution().BackspaceCompare(s, t).Should().BeTrue();
    }

    [TestCase("a#c", "b")]
    public void BackspaceCompare_NotEqual_ReturnsFalse(string s, string t)
    {
        new Solution().BackspaceCompare(s, t).Should().BeFalse();
    }

    [TestCase("a##c", "#a#c")]
    public void BackspaceCompare_Equal_BackspaceEmpty_ReturnsTrue(string s, string t)
    {
        new Solution().BackspaceCompare(s, t).Should().BeTrue();
    }

    [TestCase("a", "aa#a")]
    public void BackspaceCompare_NotEqual_OutOfSync_ReturnsFalse(string s, string t)
    {
        new Solution().BackspaceCompare(s, t).Should().BeFalse();
    }
}
