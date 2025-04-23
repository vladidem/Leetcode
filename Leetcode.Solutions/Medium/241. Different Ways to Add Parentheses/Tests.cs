using FluentAssertions;

namespace LeetCode.Solutions.Medium._241_Different_Ways_to_Add_Parentheses;

public class Tests
{
    public static TestData[] DiffWaysToCompute_NotEmpty_ReturnsAllWaysCases =
    {
        new(
            "2-1-1",
            [0, 2]
        ),
        new(
            "2*3-4*5",
            [-34, -14, -10, -10, 10]
        )
    };

    [TestCaseSource(nameof(DiffWaysToCompute_NotEmpty_ReturnsAllWaysCases))]
    public void DiffWaysToCompute_NotEmpty_ReturnsAllWays(TestData testData)
    {
        var result = new Solution().DiffWaysToCompute(testData.Expression);

        result.Should().BeEquivalentTo(testData.Expected);
    }

    public record TestData(string Expression, IList<int> Expected);
}
