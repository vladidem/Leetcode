using System.Collections;
using System.Text;

namespace Leetcode.Solutions.Hard._2081._Sum_of_k_Mirror_Numbers;

/// <summary>
///     https://leetcode.com/problems/sum-of-k-mirror-numbers/
/// </summary>
public class Solution
{
    public long KMirror(int k, int n)
    {
        long sum = 0;
        foreach (string numberAsString in new PalindromeEnumerable())
        {
            long number = long.Parse(numberAsString);
            if (IsMirror(ToKBase(number, k)))
            {
                sum += number;
                n--;
            }

            if (n == 0)
                return sum;
        }

        return sum;
    }

    private string ToKBase(long number, int k)
    {
        var sb = new StringBuilder();

        while (number > 0)
        {
            long newNumber = number / k;
            long remainder = number - newNumber * k;
            sb.Insert(0, remainder.ToString());
            number = newNumber;
        }

        return sb.ToString();
    }

    private bool IsMirror(string number)
    {
        int right = 0;
        int left = number.Length - 1;

        while (left > right)
        {
            if (number[left--] != number[right++])
                return false;
        }

        return true;
    }
}

public class PalindromeEnumerable : IEnumerable<string>
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<string> GetEnumerator()
    {
        return new PalindromeGenerator();
    }
}

public class PalindromeGenerator : IEnumerator<string>
{
    private List<int> digits = [0];

    public bool MoveNext()
    {
        int middle;
        int middle2;
        if (digits.Count % 2 == 0)
        {
            middle = digits.Count / 2 - 1;
            middle2 = digits.Count / 2;
        }
        else
        {
            middle = middle2 = digits.Count / 2;
        }

        while (middle >= 0 && digits[middle] == 9)
        {
            if (middle != 0)
            {
                digits[middle] = 0;
                digits[middle2] = 0;
            }

            middle--;
            middle2++;
        }

        if (middle < 0)
        {
            int newLength = digits.Count + 1;
            digits = Enumerable.Range(0, newLength).Select(i =>
            {
                if (i == 0 || i == newLength - 1)
                    return 1;

                return 0;
            }).ToList();
            return true;
        }

        digits[middle]++;
        if (middle != middle2)
            digits[middle2]++;

        return true;
    }

    public void Reset()
    {
        digits = [0];
    }

    object IEnumerator.Current => Current;

    public string Current => string.Join(string.Empty, digits);

    public void Dispose()
    {
    }
}
