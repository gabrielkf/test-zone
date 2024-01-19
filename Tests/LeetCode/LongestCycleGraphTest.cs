using System.Runtime.InteropServices;
using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class LongestCycleGraphTest
{
    [Theory]
    [InlineData(new[] { 3, 3, 4, 2, 3 }, 3)]
    [InlineData(new[] { 2, -1, 3, 1 }, -1)]
    public void LongestCycle_ShouldSolve_Case1(int[] edges, int ans)
    {
        LongestCycleGraph.LongestCycle(edges).ShouldBe(ans);
    }
}
