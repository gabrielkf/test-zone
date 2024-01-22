namespace LeetCode.DailyProblem;

public static class SetMismatch
{
    public static int[] FindErrorNums(int[] nums)
    {
        var size = nums.Length;
        var seen = new bool[size + 1];

        var ans = new int[2];

        foreach (var num in nums)
        {
            if (!seen[num])
            {
                seen[num] = true;
            }
            else
            {
                ans[0] = num;
            }
        }

        for (var i = 1; i <= size; i++)
        {
            if (seen[i]) continue;

            ans[1] = i;
            break;
        }

        return ans;
    }
}
