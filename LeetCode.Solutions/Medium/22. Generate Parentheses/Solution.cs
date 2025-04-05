namespace LeetCode.Solutions.Medium._22_Generate_Parentheses;

/// <summary>
///     https://leetcode.com/problems/generate-parentheses/
/// </summary>
public class Solution
{
    private const string OpenParenthesis = "(";
    private const string CloseParenthesis = ")";

    public IList<string> GenerateParenthesis(int n)
    {
        if (n == 0) return [];

        List<Permutation> result = new();
        result.Add(new Permutation(OpenParenthesis, 1, 0));

        for (var i = 1; i < n * 2; i++)
        {
            List<Permutation> newResult = new();

            foreach (var permutation in result)
            {
                if (permutation.open > permutation.close)
                    newResult.Add(new Permutation(
                        permutation.s.Insert(permutation.s.Length, CloseParenthesis),
                        permutation.open,
                        permutation.close + 1));
                if (permutation.open < n)
                    newResult.Add(new Permutation(
                        permutation.s.Insert(permutation.s.Length, OpenParenthesis),
                        permutation.open + 1,
                        permutation.close));
                result = newResult;
            }
        }

        return result.Select(it => it.s).ToList();
    }

    public record Permutation(string s, int open, int close);
}