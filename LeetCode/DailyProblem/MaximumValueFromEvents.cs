namespace LeetCode.DailyProblem;

public class MaximumValueFromEvents
{
    public int MaxValue(int[][] events, int maxEvents)
    {
        if (maxEvents == 1)
        {
            return events
                .Select(ev => ev[2])
                .Max();
        }

        Array.Sort(events, (a, b) =>
        {
            var comp = a[0].CompareTo(b[0]);

            return comp == 0
                ? b[2].CompareTo(a[2])
                : comp;
        });

        var nEvents = events.Length;
        var max = 0;

        var paths = new Stack<int[]>[nEvents];
        var totals = Enumerable.Repeat(0, nEvents).ToArray();

        for (var i = 0; i < nEvents; i++)
        {
            var ev = events[i];
            var evStart = ev[0];
            // var evEnd = ev[1];
            var evVal = ev[2];

            var pathStartingNow = new Stack<int[]>();
            pathStartingNow.Push(ev);

            paths[i] = pathStartingNow;
            totals[i] = evVal;

            for (var j = 0; j <= i; j++)
            {
                var path = paths[j];

                var pathLast = path.Peek();
                var pathLastEnd = pathLast[1];

                if (evStart > pathLastEnd && path.Count < maxEvents)
                {
                    path.Push(ev);
                    totals[j] += evVal;
                }

                max = Math.Max(max, totals[j]);
            }
        }

        return max;
    }
}
