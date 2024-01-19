namespace LeetCode.DailyProblem;

/** ?
 * You are given an array prices where prices[i] is the price of a given stock on the ith day.
 * You want to maximize your profit by choosing a single day to buy one stock and choosing
 * a different day in the future to sell that stock.
 * Return the maximum profit you can achieve from this transaction.
 * If you cannot achieve any profit, return 0.
 */

public static class MaxProfit
{
    public static int Calculate(int[] prices)
    {
        var size = prices.Length;
        var maxProfit = 0;

        if (size <= 2)
        {
            if (size == 1) return 0;

            maxProfit = prices[1] - prices[0];
            return Math.Max(maxProfit, 0);
        }

        var minPrice = int.MaxValue;
        foreach (var price in prices)
        {
            minPrice = Math.Min(minPrice, price);
            maxProfit = Math.Max(maxProfit, price - minPrice);
        }

        return maxProfit;
    }
}
