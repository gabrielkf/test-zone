namespace LeetCode.DailyProblem;

public static class LongestIncreasingSubsequence
{
    public static int LengthOfLis(int[] nums)
    {
        var size = nums.Length;

        var dp = Enumerable.Repeat(1, size).ToArray();

        for (var i = 1; i < size; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        return dp.Max();
    }
}
