namespace Leetcode.Solutions.Medium._8._String_to_Integer_atoi;

public class Tests
{
    [TestCase("   -042", ExpectedResult = -42)]
    [TestCase("42", ExpectedResult = 42)]
    [TestCase("1337c0d3", ExpectedResult = 1337)]
    [TestCase("0-1", ExpectedResult = 0)]
    [TestCase("words and 987", ExpectedResult = 0)]
    public int StringToInteger_NonZero_ReturnsConvertedInteger(string s)
    {
        return new Solution().MyAtoi(s);
    }
}
