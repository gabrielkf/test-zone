using LeetCode;

namespace TestZone.LeetCode;

public class MinimumTimeTest
{
    [Theory]
    [InlineData(new [] {1,2, 3}, 5, 3)]
    [InlineData(new [] {2}, 1, 2)]
    public void BruteForce_ShouldCalculate_ForExamples(int[] time, int totalTrips, long expected)
    {
        MinimumTime.BruteForce(time, totalTrips).ShouldBe(expected);
    }

    [Theory]
    [InlineData(new [] {1,2, 3}, 5, 3)]
    [InlineData(new [] {2}, 1, 2)]
    public void BinarySearch_ShouldCalculate_ForExamples(int[] time, int totalTrips, long expected)
    {
        MinimumTime.BinarySearch(time, totalTrips).ShouldBe(expected);
    }
}
