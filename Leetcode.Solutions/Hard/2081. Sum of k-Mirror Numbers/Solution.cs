using System.Text;

namespace Leetcode.Solutions.Hard._2081._Sum_of_k_Mirror_Numbers;

/// <summary>
///     https://leetcode.com/problems/sum-of-k-mirror-numbers/
/// </summary>
public class Solution
{
    public long KMirror(int k, int n)
    {
        int sum = 0;
        int i = 1;
        while (n > 0)
        {
            if (IsMirror(ToKBase(i, k)) && IsMirror(i.ToString()))
            {
                sum += i;
                n--;
            }

            i++;
        }

        return sum;
    }

    private string ToKBase(int number, int k)
    {
        var sb = new StringBuilder();

        while (number > 0)
        {
            int newNumber = number / k;
            int remainder = number - newNumber * k;
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
