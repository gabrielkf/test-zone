using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class MinScoreCitiesPathTest
{
    [Fact]
    public void MinScore_ShouldSolve_TestCase1()
    {
        var n = 4;
        var roads = new[]
        {
            new[] { 1, 2, 9 },
            new[] { 2, 3, 6 },
            new[] { 2, 4, 5 },
            new[] { 1, 4, 7 }
        };

        MinScoreCitiesPath.MinScore(n, roads).ShouldBe(5);
    }
}
