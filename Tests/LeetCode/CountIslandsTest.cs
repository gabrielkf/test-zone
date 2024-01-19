using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class CountIslandsTest
{
    private readonly CountIslands _unit = new();

    [Fact]
    public void ClosedIsland_ShouldSolve_TestCase1()
    {
        var grid = new[]
        {

            new [] { 1, 1, 1, 1, 1, 1, 1, 0 },
            new [] { 1, 0, 0, 0, 0, 1, 1, 0 },
            new [] { 1, 0, 1, 0, 1, 1, 1, 0 },
            new [] { 1, 0, 0, 0, 0, 1, 0, 1 },
            new [] { 1, 1, 1, 1, 1, 1, 1, 0 }
        };

        _unit.ClosedIsland(grid).ShouldBe(2);
    }

    [Fact]
    public void ClosedIsland_ShouldSolve_TestCase2()
    {
        var grid = new[]
        {
            new[] { 0, 0, 1, 0, 0 },
            new[] { 0, 1, 0, 1, 0 },
            new[] { 0, 1, 1, 1, 0 }
        };

        _unit.ClosedIsland(grid).ShouldBe(1);
    }

    [Fact]
    public void ClosedIsland_ShouldSolve_TestCase3()
    {
        var grid = new[]
        {
            new[] { 1, 1, 1, 1, 1, 1, 1 },
            new[] { 1, 0, 0, 0, 0, 0, 1 },
            new[] { 1, 0, 1, 1, 1, 0, 1 },
            new[] { 1, 0, 1, 0, 1, 0, 1 },
            new[] { 1, 0, 1, 1, 1, 0, 1 },
            new[] { 1, 0, 0, 0, 0, 0, 1 },
            new[] { 1, 1, 1, 1, 1, 1, 1 }
        };

        _unit.ClosedIsland(grid).ShouldBe(2);
    }
}
