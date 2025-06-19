using FluentAssertions;

namespace Leetcode.Solutions.Medium._17._Letter_Combinations_of_a_Phone_Number;

public class Tests
{
    public static TestData[] LetterCombinations_NotEmpty_ReturnsLetterCombinationsCases =
    {
        new(
            "23",
            ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"]
        ),
        new(
            "2",
            ["a", "b", "c"]
        )
    };

    [TestCaseSource(nameof(LetterCombinations_NotEmpty_ReturnsLetterCombinationsCases))]
    public void LetterCombinations_NotEmpty_ReturnsLetterCombinations(TestData testData)
    {
        var result = new Solution().LetterCombinations(testData.Digits);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    [Test]
    public void LetterCombinations_Empty_ReturnsEmptyList()
    {
        var result = new Solution().LetterCombinations(string.Empty);
        result.Should().BeEmpty();
    }

    public record TestData(string Digits, List<string> Expected);
}
