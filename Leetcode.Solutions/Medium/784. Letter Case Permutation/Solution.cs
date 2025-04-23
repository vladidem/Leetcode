using System.Text;

namespace LeetCode.Solutions.Medium._784_Letter_Case_Permutation;

/// <summary>
///     https://leetcode.com/problems/letter-case-permutation/
/// </summary>
public class Solution
{
    public IList<string> LetterCasePermutation(string s)
    {
        IList<StringBuilder> permutations = [new(s)];

        for (int i = 0; i < s.Length; i++)
        {
            if (!char.IsLetter(s[i])) continue;
            IList<StringBuilder> newPermutations = [];

            foreach (var permutation in permutations)
            {
                var newPermutation = new StringBuilder(permutation.Length);
                newPermutation.Append(permutation);

                if (char.IsLower(permutation[i]))
                    newPermutation[i] = char.ToUpper(permutation[i]);
                else
                    newPermutation[i] = char.ToLower(permutation[i]);

                newPermutations.Add(newPermutation);
            }

            permutations = permutations.Concat(newPermutations).ToList();
        }

        return permutations.Select(it => it.ToString()).ToList();
    }
}
