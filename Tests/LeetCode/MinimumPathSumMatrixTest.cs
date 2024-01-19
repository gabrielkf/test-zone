using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class MinimumPathSumMatrixTest
{
    [Fact]
    public void MinPathSum_ShouldSolve_Case1()
    {
        var grid = new[]
        {
            new[] { 1, 3, 1 },
            new[] { 1, 5, 1 },
            new[] { 4, 2, 1 }
        };
        MinimumPathSumMatrix.MinPathSum(grid).ShouldBe(7);
    }

    [Fact]
    public void MinPathSum_ShouldSolve_Case2()
    {
        var grid = new[]
        {
            new[] { 1, 2, 3 },
            new[] { 4, 5, 6 }
        };
        MinimumPathSumMatrix.MinPathSum(grid).ShouldBe(12);
    }

    [Fact]
    public void MinPathSum_ShouldSolve_Case3()
    {
        var grid = new[]
        {
            new[] { 7, 1, 3, 5, 8, 9, 9, 2, 1, 9, 0, 8, 3, 1, 6, 6, 9, 5 },
            new[] { 9, 5, 9, 4, 0, 4, 8, 8, 9, 5, 7, 3, 6, 6, 6, 9, 1, 6 },
            new[] { 8, 2, 9, 1, 3, 1, 9, 7, 2, 5, 3, 1, 2, 4, 8, 2, 8, 8 },
            new[] { 6, 7, 9, 8, 4, 8, 3, 0, 4, 0, 9, 6, 6, 0, 0, 5, 1, 4 },
            new[] { 7, 1, 3, 1, 8, 8, 3, 1, 2, 1, 5, 0, 2, 1, 9, 1, 1, 4 },
            new[] { 9, 5, 4, 3, 5, 6, 1, 3, 6, 4, 9, 7, 0, 8, 0, 3, 9, 9 },
            new[] { 1, 4, 2, 5, 8, 7, 7, 0, 0, 7, 1, 2, 1, 2, 7, 7, 7, 4 },
            new[] { 3, 9, 7, 9, 5, 8, 9, 5, 6, 9, 8, 8, 0, 1, 4, 2, 8, 2 },
            new[] { 1, 5, 2, 2, 2, 5, 6, 3, 9, 3, 1, 7, 9, 6, 8, 6, 8, 3 },
            new[] { 5, 7, 8, 3, 8, 8, 3, 9, 9, 8, 1, 9, 2, 5, 4, 7, 7, 7 },
            new[] { 2, 3, 2, 4, 8, 5, 1, 7, 2, 9, 5, 2, 4, 2, 9, 2, 8, 7 },
            new[] { 0, 1, 6, 1, 1, 0, 0, 6, 5, 4, 3, 4, 3, 7, 9, 6, 1, 9 }
        };
        MinimumPathSumMatrix.MinPathSum(grid).ShouldBe(85);
    }
}
