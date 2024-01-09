namespace LeetCode;

public class IncreaseJobProfit
{
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        var size = profit.Length;

        if (size == 1) return profit[0];

        var jobs = new Job[size];
        for (var i = 0; i < size; i++)
        {
            jobs[i] = new Job(startTime[i], endTime[i], profit[i]);
        }

        Array.Sort(jobs);

        var dp = new int[size + 1];

        for (var i = 0; i < size; i++)
        {
            var latestNonConflictJobIndex = UpperBound(jobs, i);
            dp[i + 1] = Math.Max(
                dp[i],
                dp[latestNonConflictJobIndex] + jobs[i].Profit);
        }

        return dp[size];
    }

    private int UpperBound(Job[] jobs, int endIndex)
    {
        var low = 0;
        var high = endIndex;

        while (low < high)
        {
            var mid = (low + high) / 2;

            if (jobs[mid].EndTime <= jobs[endIndex].StartTime)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }

    private record struct Job(int StartTime, int EndTime, int Profit) : IComparable<Job>
    {
        public int CompareTo(Job other)
        {
            if (EndTime > other.EndTime) return 1;
            return -1;
        }
    }
}
