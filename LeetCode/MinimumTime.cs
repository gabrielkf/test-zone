namespace LeetCode;

/**
 * You are given an array time where time[i] denotes the time taken
 * by the ith bus to complete one trip.
 *
 * Each bus can make multiple trips successively; that is, the next trip can start
 * immediately after completing the current trip. Also, each bus operates independently;
 * that is, the trips of one bus do not influence the trips of any other bus.
 *
 * You are also given an integer totalTrips, which denotes the number of trips all buses
 * should make in total. Return the minimum time required for all buses to complete at
 * least totalTrips trips.
 *
 * Constraints:
 * 1 <= time.length <= 105
 * 1 <= time[i], totalTrips <= 107
 */

public static class MinimumTime
{
    public static long BruteForce(int[] time, int totalTrips)
    {
        long tick = 0;
        var completed = 0;

        while (completed < totalTrips)
        {
            tick++;
            completed += time.Sum(t => tick % t == 0 ? 1 : 0);
        }

        return tick;
    }

    public static long BinarySearch(int[] time, int totalTrips)
    {
        long left = 1;
        var right = long.MaxValue;

        while (left <= right)
        {
            var mid = left + ((right - left) / 2);
            long sum = 0;
            foreach (var t in time) sum += mid / t;

            if (sum >= totalTrips)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return left;
    }
}
