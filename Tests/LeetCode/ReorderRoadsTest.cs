using LeetCode;

namespace TestZone.LeetCode;

public class ReorderRoadsTest
{
    [Fact]
    public void MinReorder_ShouldSolve_TestCase1()
    {
        const int nCities = 6;
        var connections = new[]
        {
            new[] { 0, 1 },
            new[] { 1, 3 },
            new[] { 2, 3 },
            new[] { 4, 0 },
            new[] { 4, 5 }
        };

        ReorderRoads.MinReorder(nCities, connections).ShouldBe(3);
    }

    [Fact]
    public void MinReorder_ShouldSolve_TestCase2()
    {
        const int nCities = 5;
        var connections = new[]
        {
            new[] { 1, 0 },
            new[] { 1, 2 },
            new[] { 3, 2 },
            new[] { 3, 4 }
        };

        ReorderRoads.MinReorder(nCities, connections).ShouldBe(2);
    }

    [Fact]
    public void MinReorder_ShouldSolve_TestCase3()
    {
        const int nCities = 5;
        var connections = new[]
        {
            new[] { 1, 0 },
            new[] { 2, 0 }
        };

        ReorderRoads.MinReorder(nCities, connections).ShouldBe(0);
    }
}
