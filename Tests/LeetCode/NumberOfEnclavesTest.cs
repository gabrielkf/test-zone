using LeetCode;

namespace TestZone.LeetCode;

public class NumberOfEnclavesTest
{
    private readonly NumberOfEnclaves _unit = new();

    [Fact]
    public void NumEnclaves_ShouldSolve_TestCase1()
    {
        var grid = new[]
        {
            new[] { 0, 0, 0, 0 },
            new[] { 1, 0, 1, 0 },
            new[] { 0, 1, 1, 0 },
            new[] { 0, 0, 0, 0 }
        };

        _unit.NumEnclaves(grid).ShouldBe(3);
    }

    [Fact]
    public void NumEnclaves_ShouldSolve_TestCase2()
    {
        var grid = new[]
        {
            new [] {0,1,1,0},
            new [] {0,0,1,0},
            new [] {0,0,1,0},
            new [] {0,0,0,0}
        };

        _unit.NumEnclaves(grid).ShouldBe(0);
    }

    [Fact]
    public void NumEnclaves_ShouldSolve_TestCase3()
    {
        var grid = new[]
        {
            new[] { 0, 0, 0, 1, 1, 1, 0, 1, 0, 0 },
            new[] { 1, 1, 0, 0, 0, 1, 0, 1, 1, 1 },
            new[] { 0, 0, 0, 1, 1, 1, 0, 1, 0, 0 },
            new[] { 0, 1, 1, 0, 0, 0, 1, 0, 1, 0 },
            new[] { 0, 1, 1, 1, 1, 1, 0, 0, 1, 0 },
            new[] { 0, 0, 1, 0, 1, 1, 1, 1, 0, 1 },
            new[] { 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 },
            new[] { 0, 0, 1, 0, 0, 1, 0, 1, 0, 1 },
            new[] { 1, 0, 1, 0, 1, 1, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 1 }
        };

        _unit.NumEnclaves(grid).ShouldBe(3);
    }
}
