using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class BestTrainTicketTest
{
    [Theory]
    [InlineData(new[] { 1, 4, 6, 7, 8, 20 }, new[] { 2, 7, 15 }, 11)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 }, new[] { 2, 7, 15 }, 17)]
    public void MincostTickets_ShouldSolve_TestCases(int[] days, int[] costs, int ans)
    {
        var uat = new BestTrainTickets();
        uat.MincostTickets(days, costs).ShouldBe(ans);
    }
}
