using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class FairCookiesDistributionTest
{
    private readonly FairCookiesDistribution _sut = new();

    [Theory]
    [InlineData(new[] { 8, 15, 10, 20, 8 }, 2, 31)]
    [InlineData(new[] { 6, 1, 3, 2, 2, 4, 1, 2 }, 3, 7)]
    public void DistributeCookies_ShouldSolveTestCases(int[] cookies, int children, int expected)
    {
        _sut.DistributeCookies(cookies, children).ShouldBe(expected);
    }
}
