using FluentAssertions;

namespace Leetcode.Solutions.Easy._20._Valid_Parentheses;

public class Tests
{
    [TestCase("()")]
    [TestCase("()[]{}")]
    [TestCase("([])")]
    public void ValidParentheses_Valid_ReturnsTrue(string s)
    {
        new Solution().IsValid(s).Should().BeTrue();
    }

    [TestCase("(}")]
    [TestCase("(]")]
    public void ValidParentheses_Invalid_ReturnsFalse(string s)
    {
        new Solution().IsValid(s).Should().BeFalse();
    }

    [TestCase("(}}")]
    public void ValidParentheses_StackBecomesEmpty_ReturnsFalse(string s)
    {
        new Solution().IsValid(s).Should().BeFalse();
    }
}
