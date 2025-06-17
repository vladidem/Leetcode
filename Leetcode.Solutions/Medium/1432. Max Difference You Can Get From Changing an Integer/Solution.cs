namespace Leetcode.Solutions.Medium._1432._Max_Difference_You_Can_Get_From_Changing_an_Integer;

/// <summary>
///     https://leetcode.com/problems/max-difference-you-can-get-from-changing-an-integer/
/// </summary>
public class Solution
{
    public int MaxDiff(int num)
    {
        var digits = new List<int>();
        int numLeft = num;
        while (numLeft > 0)
        {
            digits.Insert(0, numLeft % 10);
            numLeft /= 10;
        }

        if (!digits.Any())
            return 0;

        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int permutation in Permutations(digits))
        {
            if (permutation < min)
            {
                min = permutation;
            }

            if (permutation > max)
            {
                max = permutation;
            }
        }

        return max - min;
    }

    public IEnumerable<int> Permutations(List<int> digits)
    {
        yield return int.Parse(string.Join("", digits));

        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                if (i == j) continue;
                if (digits[0] == i && j == 0) continue;

                bool hasI = false;
                var swappedDigits = new List<int>();
                for (int digitIndex = 0; digitIndex < digits.Count; digitIndex++)
                {
                    if (digits[digitIndex] == i)
                    {
                        hasI = true;
                        swappedDigits.Add(j);
                    }
                    else
                    {
                        swappedDigits.Add(digits[digitIndex]);
                    }
                }

                if (hasI)
                    yield return int.Parse(string.Join("", swappedDigits));
            }
        }
    }
}
