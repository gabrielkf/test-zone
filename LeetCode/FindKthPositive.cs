namespace LeetCode;

/**
 * Given an array arr of positive integers sorted in a strictly increasing order,
 * and an integer k.
 * Return the kth positive integer that is missing from this array.
 */

public static class FindKthPositive
{
    public static int Execute(int[] arr, int k)
    {
        var miss = arr[0] - 1;
        if (miss >= k) return k;

        var i = 0;
        var last = 0;
        while (i < arr.Length && miss < k)
        {
            i++;
            last = miss;
            if (i < arr.Length) miss += arr[i] - arr[i - 1] - 1;
        }

        return arr[i - 1] + k - last;
    }
}
