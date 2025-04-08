using FluentAssertions;

namespace LeetCode.Solutions.Medium._784_Letter_Case_Permutation;

public class Tests
{
    public static TestData[] LetterCasePermutation_NotEmpty_ReturnsAllPermutationsCases =
    {
        new(
            "a1b2",
            ["a1b2", "a1B2", "A1b2", "A1B2"]
        ),
        new(
            "3z4",
            ["3z4", "3Z4"]
        )
    };

    [TestCaseSource(nameof(LetterCasePermutation_NotEmpty_ReturnsAllPermutationsCases))]
    public void LetterCasePermutation_NotEmpty_ReturnsAllPermutations(TestData testData)
    {
        var result = new Solution().LetterCasePermutation(testData.Input);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(string Input, string[] Expected);
}
