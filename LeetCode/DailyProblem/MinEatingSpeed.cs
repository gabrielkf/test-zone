namespace LeetCode.DailyProblem;

public static class MinEatingSpeed
{
    public static int BinarySearch(int[] piles, int h)
    {
        var size = piles.Length;
        if (size == 1)
            return piles[0] > h
                ? (piles[0] + h - 1) / h
                : 1;

        if (h == size) return piles.Max();

        var lo = size;
        var hi = piles.Max();

        while (hi - lo > 1)
        {
            var mid = lo + ((hi - lo) / 2);
            if (IsFastEnough(piles, h, mid))
                hi = mid;
            else
                lo = mid;
        }

        while (IsFastEnough(piles, h, hi)) hi--;
        return hi + 1;
    }

    private static bool IsFastEnough(int[] piles, int h, int speed)
    {
        var time = 0;
        foreach (var bananas in piles)
        {
            time += speed >= bananas
                ? 1
                : (bananas + speed - 1) / speed;
        }

        return time <= h;
    }
}
