namespace LeetCode.Solutions.Easy._70_Climbing_Stairs;

/// <summary>
///     https://leetcode.com/problems/climbing-stairs/
/// </summary>
public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        int[] possibleWays = new int[n + 1];
        possibleWays[n] = 1;
        possibleWays[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            possibleWays[i] = possibleWays[i + 1] + possibleWays[i + 2];
        }

        return possibleWays[0];
    }
}
