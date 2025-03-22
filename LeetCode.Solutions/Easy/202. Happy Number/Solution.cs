namespace LeetCode.Solutions.Easy._202_Happy_Number;

/// <summary>
///     https://leetcode.com/problems/happy-number/
/// </summary>
public class Solution
{
    public bool IsHappy(int n)
    {
        var slow = n;
        var fast = n;
        while (slow != 1 && fast != 1)
        {
            slow = NextStep(slow);
            fast = NextStep(NextStep(fast));
            if (slow == fast && slow != 1) return false;
        }

        return true;
    }

    private int NextStep(int n)
    {
        var result = 0;

        while (n > 0)
        {
            result += n % 10 * (n % 10);
            n /= 10;
        }

        return result;
    }
}