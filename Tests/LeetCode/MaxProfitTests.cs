using LeetCode;
using Shouldly;

namespace TestZone.LeetCode;

public class MaxProfitTests
{
    [Fact]
    public void Case1()
    {
        var prices = new int[] { 7, 1, 5, 3, 6, 4 };
        var result = MaxProfit.Calculate(prices);
        result.ShouldBe(5);
    }

    [Fact]
    public void Case2()
    {
        var prices = new int[] { 7, 6, 4, 3, 1 };
        var result = MaxProfit.Calculate(prices);
        result.ShouldBe(0);
    }
}
