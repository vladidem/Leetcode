using FluentAssertions;

namespace LeetCode.Solutions.Medium._22_Generate_Parentheses;

public class Tests
{
    public static TestData[] GenerateParenthesis_NotEmpty_ReturnsAllPermutationsCases =
    {
        new(
            3,
            ["((()))", "(()())", "(())()", "()(())", "()()()"]
        ),
        new(
            1,
            ["()"]
        )
    };

    [TestCaseSource(nameof(GenerateParenthesis_NotEmpty_ReturnsAllPermutationsCases))]
    public void GenerateParenthesis_NotEmpty_ReturnsAllPermutations(TestData testData)
    {
        var result = new Solution().GenerateParenthesis(testData.N);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(int N, IList<string> Expected);
}