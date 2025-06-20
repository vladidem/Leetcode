namespace Leetcode.Solutions.Medium._3443._Maximum_Manhattan_Distance_After_K_Changes;

/// <summary>
///     https://leetcode.com/problems/maximum-manhattan-distance-after-k-changes/
/// </summary>
public class Solution
{
    private const char North = 'N';
    private const char South = 'S';
    private const char West = 'W';
    private const char East = 'E';

    public int MaxDistance(string s, int k)
    {
        var currentDirections = new Dictionary<char, int>
        {
            { North, 0 },
            { South, 0 },
            { West, 0 },
            { East, 0 }
        };
        int maxDistance = int.MinValue;

        foreach (char direction in s)
        {
            currentDirections[direction] += 1;

            int currentDistance = 0;
            int possibleCorrectingSteps = 0;

            currentDistance += Math.Abs(currentDirections[North] - currentDirections[South]);
            possibleCorrectingSteps += Math.Min(currentDirections[North], currentDirections[South]);

            currentDistance += Math.Abs(currentDirections[West] - currentDirections[East]);
            possibleCorrectingSteps += Math.Min(currentDirections[West], currentDirections[East]);

            currentDistance += Math.Min(k, possibleCorrectingSteps) * 2;
            if (currentDistance > maxDistance)
                maxDistance = currentDistance;
        }

        return maxDistance;
    }
}
