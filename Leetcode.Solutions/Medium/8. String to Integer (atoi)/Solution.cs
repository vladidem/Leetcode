namespace Leetcode.Solutions.Medium._8._String_to_Integer_atoi;

/// <summary>
///     https://leetcode.com/problems/string-to-integer-atoi/
/// </summary>
public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.Trim(' ');

        if (s.Length == 0)
            return 0;

        int sign = 1;
        int i = 0;
        int result = 0;

        if (s[0] == '-')
        {
            sign = -1;
            i = 1;
        }
        else if (s[0] == '+')
        {
            i = 1;
        }

        while (i < s.Length && char.IsNumber(s[i]))
        {
            try
            {
                result = checked(result * 10 + (s[i] - '0') * sign);
            }
            catch (OverflowException _)
            {
                if (sign == 1) return int.MaxValue;

                return int.MinValue;
            }

            i++;
        }

        return result;
    }
}
