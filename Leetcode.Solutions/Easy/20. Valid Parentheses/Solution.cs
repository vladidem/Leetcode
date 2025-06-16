namespace Leetcode.Solutions.Easy._20._Valid_Parentheses;

/// <summary>
///     https://leetcode.com/problems/valid-parentheses/
/// </summary>
public class Solution
{
    private static readonly IReadOnlyCollection<char> ClosingBrackets = [')', ']', '}'];

    private static readonly IReadOnlyDictionary<char, char> OpeningBrackets = new Dictionary<char, char>
    {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };

    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            if (ClosingBrackets.Contains(c))
            {
                if (!stack.Any())
                    return false;

                char maybeOpeningBracket = stack.Pop();
                if (maybeOpeningBracket != OpeningBrackets[c])
                    return false;
            }
            else
            {
                stack.Push(c);
            }
        }

        return !stack.Any();
    }
}
