namespace LeetCode.Solutions.Medium._241_Different_Ways_to_Add_Parentheses;

/// <summary>
///     https://leetcode.com/problems/different-ways-to-add-parentheses/
/// </summary>
public class Solution
{
    private readonly Dictionary<char, Func<int, int, int>> operations = new()
    {
        ['+'] = (x, y) => x + y,
        ['*'] = (x, y) => x * y,
        ['-'] = (x, y) => x - y
    };

    public IList<int> DiffWaysToCompute(string expression)
    {
        return DiffWaysToCompute(expression, 0, expression.Length - 1).ToList();
    }

    public IEnumerable<int> DiffWaysToCompute(string expression, int left, int right)
    {
        bool hasOperations = false;
        for (int i = left; i < right; i++)
        {
            var operation = operations.GetValueOrDefault(expression[i]);
            if (operation != null)
            {
                hasOperations = true;
                var leftPieces = DiffWaysToCompute(expression, left, i - 1);
                var rightPieces = DiffWaysToCompute(expression, i + 1, right);
                var combinations = leftPieces.SelectMany(
                    x => rightPieces,
                    (y, z) => operation(y, z));
                foreach (int result in combinations)
                {
                    yield return result;
                }
            }
        }

        if (!hasOperations)
            yield return int.Parse(expression[left..(right + 1)]);
    }
}
