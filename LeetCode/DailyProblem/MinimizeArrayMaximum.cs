namespace LeetCode.DailyProblem;

/*
 * You are given a 0-indexed array nums comprising of n non-negative integers.
 * In one operation, you must:
 *      Choose an integer i such that 1 <= i < n and nums[i] > 0.
 *      Decrease nums[i] by 1.
 *      Increase nums[i - 1] by 1.
 *
 * Return the minimum possible value of the maximum integer of nums after performing any number of operations.
 */
public class MinimizeArrayMaximum
{
    public static int MinimizeArrayValue(int[] numbers)
    {
        var answer = 0L;
        var prefixSum = 0L;

        for (var i = 0; i < numbers.Length; i++)
        {
            prefixSum += numbers[i];
            answer = Math.Max(answer, (prefixSum + i) / (i + 1));
        }

        return (int)answer;
    }
}
