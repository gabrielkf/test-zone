namespace LeetCode.DailyProblem;

/*
 * A chef has collected data on the satisfaction level of his n dishes. Chef can cook any dish in 1 unit of time.
 * Like-time coefficient of a dish is defined as the time taken to cook that dish including previous dishes
 * multiplied by its satisfaction level i.e. time[i] * satisfaction[i].
 *
 * Return the maximum sum of like-time coefficient that the chef can obtain after dishes preparation.
 * Dishes can be prepared in any order and the chef can discard some dishes to get this maximum value.
 */

public class RestaurantChef
{
    public int TopDownDp(int[] satisfaction)
    {
        var size = satisfaction.Length;
        Array.Sort(satisfaction);
        var memo = Enumerable.Repeat(
            Enumerable.Repeat(int.MinValue, size + 1).ToArray(),
            size + 1).ToArray();

        return Recurse(0, 1);

        int Recurse(int index, int time)
        {
            if (index == size)
                return 0;

            if (memo[index][time] != int.MinValue)
                return memo[index][time];

            memo[index][time] = Math.Max(
                (satisfaction[index] * time) + Recurse(index + 1, time + 1),
                Recurse(index + 1, time));

            return memo[index][time];
        }
    }

    public int BottomUpDp(int[] satisfaction)
    {
        var size = satisfaction.Length;
        Array.Sort(satisfaction);
        var dp = Enumerable.Repeat(
            Enumerable.Repeat(0, size + 2).ToArray(),
            size + 1).ToArray();

        for (var dish = size - 1; dish >= 0; dish--)
        {
            for (var time = 1; time <= size; time++)
            {
                dp[dish][time] = Math.Max(
                    (satisfaction[dish] * time) + dp[dish + 1][time + 1],
                    dp[dish + 1][time]);
            }
        }

        return dp[0][1];
    }

    public int SpaceOptBottomUp(int[] satisfaction)
    {
        var size = satisfaction.Length;
        Array.Sort(satisfaction);
        var prev = Enumerable.Repeat(0, size + 2).ToArray();

        for (var dish = size - 1; dish >= 0; dish--)
        {
            var dp = new int[size + 2];

            for (var time = 1; time <= size; time++)
            {
                dp[time] = Math.Max(
                    (satisfaction[dish] * time) + prev[time + 1],
                    prev[time]);
            }

            prev = dp;
        }

        return prev[1];
    }
}
