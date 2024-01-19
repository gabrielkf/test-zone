using LeetCode;
using LeetCode.DailyProblem;
using Shouldly;

namespace TestZone.LeetCode;

public class FindKthPositiveTest
{
    [Theory]
    [InlineData(new [] { 2, 3, 4, 7, 11 }, 5, 9)]
    [InlineData(new [] { 1, 2, 3, 4 }, 2, 6)]
    public void Execute_ShouldFindKthPositive(int[] nums, int k, int expected)
    {
        FindKthPositive.Execute(nums, k).ShouldBe(expected);
    }
}
