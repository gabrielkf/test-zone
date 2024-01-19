namespace LeetCode.DailyProblem;

/**
 * You have planned some train traveling one year in advance. The days of the year in which you will travel
 * are given as an integer array days. Each day is an integer from 1 to 365.
 *
 * Train tickets are sold in three different ways:
        a 1-day pass is sold for costs[0] dollars,
        a 7-day pass is sold for costs[1] dollars, and
        a 30-day pass is sold for costs[2] dollars.

 * The passes allow that many days of consecutive travel.
 * For example, if we get a 7-day pass on day 2, then we can travel for 7 days: 2, 3, 4, 5, 6, 7, and 8.
 *
 * Return the minimum number of dollars you need to travel every day in the given list of days.
 */

public class BestTrainTickets
{
    private const int TicketTypes = 3;
    private int[] days;
    private int size;
    private int[] costs;
    private int[] memo;
    private readonly int[] durations = new int[] { 1, 7, 30 };

    public int MincostTickets(int[] days, int[] costs)
    {
        this.days = days;
        this.costs = costs;
        size = days.Length;
        memo = Enumerable.Repeat(-1, size).ToArray();

        return DynamicRecursion(0);
    }

    private int DynamicRecursion(int curr)
    {
        if (curr >= size)
            return 0;

        if (memo[curr] != -1)
            return memo[curr];

        var ans = int.MaxValue;
        var next = curr;
        for (var ticket = 0; ticket < TicketTypes; ticket++)
        {
            while (next < size && days[next] < days[curr] + durations[ticket])
                next++;

            ans = Math.Min(ans, DynamicRecursion(next) + costs[ticket]);
        }

        memo[curr] = ans;
        return ans;
    }
}