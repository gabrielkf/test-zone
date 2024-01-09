using LeetCode;

namespace TestZone.LeetCode;

public class UnreachableGraphNodesTest
{
    [Fact]
    public void CountPairs_ShouldSolve_TestCase1()
    {
        const int nNodes = 3;
        var edges = new[]
        {
            new[] { 0, 1 },
            new[] { 0, 2 },
            new[] { 1, 2 }
        };

        UnreachableGraphNodes.CountPairs(nNodes, edges).ShouldBe(0);
    }

    [Fact]
    public void CountPairs_ShouldSolve_TestCase2()
    {
        const int nNodes = 7;
        var edges = new[]
        {
            new[] { 0, 2 },
            new[] { 0, 5 },
            new[] { 2, 4 },
            new[] { 1, 6 },
            new[] { 5, 4 }
        };

        UnreachableGraphNodes.CountPairs(nNodes, edges).ShouldBe(14);
    }
}
