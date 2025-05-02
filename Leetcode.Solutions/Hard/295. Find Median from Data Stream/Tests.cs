namespace Leetcode.Solutions.Hard._295._Find_Median_from_Data_Stream;

public class Tests
{
    [TestCase(new[] { 1, 2 }, ExpectedResult = 1.5)]
    [TestCase(new[] { 1, 2, 3 }, ExpectedResult = 2.0)]
    public double MedianFinder_NotEmptySequence_ReturnsMedianAfterEachStep(int[] numbers)
    {
        var medianFinder = new MedianFinder();
        foreach (int number in numbers)
        {
            medianFinder.AddNum(number);
        }

        return medianFinder.FindMedian();
    }
}
