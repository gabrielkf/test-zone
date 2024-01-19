namespace LeetCode.DailyProblem;

public class FairCookiesDistribution
{
    public int DistributeCookies(int[] cookies, int children)
    {
        var maxCookies = 0;
        var childrenQueue = new PriorityQueue<int, int>(children);
        childrenQueue.EnqueueRange(Enumerable.Repeat((0, 0), children));


        foreach (var ck in cookies)
        {
            var leastCookies = childrenQueue.Dequeue();
            leastCookies += ck;
            maxCookies = Math.Max(maxCookies, leastCookies);
            childrenQueue.Enqueue(leastCookies, leastCookies);
        }

        return maxCookies;
    }
}
