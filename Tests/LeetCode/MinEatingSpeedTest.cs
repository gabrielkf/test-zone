using LeetCode;
using Shouldly;

namespace TestZone.LeetCode;

public class MinEatingSpeedTest
{
    [Theory]
    [InlineData(new[] { 3, 6, 7, 11 }, 8, 4)]
    [InlineData(new[] { 30, 11, 23, 4, 20 }, 5, 30)]
    [InlineData(new[] { 30, 11, 23, 4, 20 }, 6, 23)]
    [InlineData(new[] { 805306368, 805306368, 805306368 }, 1000000000, 3)]
    [InlineData(new[] { 312884470 }, 968709470, 1)]
    [InlineData(new[] { 312884470 }, 312884470, 1)]
    [InlineData(new[] { 968709470 }, 312884470, 4)]
    public void BinarySearch_ShouldReturnExpected(int[] piles, int h, int expected)
    {
        MinEatingSpeed.BinarySearch(piles, h).ShouldBe(expected);
    }
}
