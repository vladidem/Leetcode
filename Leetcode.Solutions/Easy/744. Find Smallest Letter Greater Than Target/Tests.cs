namespace LeetCode.Solutions.Easy._744_Find_Smallest_Letter_Greater_Than_Target;

public class Tests
{
    [TestCase(new[] { 'c', 'f', 'j' }, 'a', ExpectedResult = 'c')]
    [TestCase(new[] { 'c', 'f', 'j' }, 'c', ExpectedResult = 'f')]
    public char NextGreatestLetter_ResultExist_ReturnsFirstGreaterChar(char[] chars, char target)
    {
        return new Solution().NextGreatestLetter(chars, target);
    }

    [TestCase(new[] { 'x', 'x', 'y', 'y' }, 'z', ExpectedResult = 'x')]
    public char NextGreatestLetter_NoResult_ReturnsFirstChar(char[] chars, char target)
    {
        return new Solution().NextGreatestLetter(chars, target);
    }
}
