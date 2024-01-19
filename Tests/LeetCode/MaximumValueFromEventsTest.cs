using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

/**
 * You are given an array of events where events[i] = [startDayi, endDayi, valuei].
 * The ith event starts at startDayi and ends at endDayi,
 * and if you attend this event, you will receive a value of valuei.
 * You are also given an integer k which represents the maximum number of events you can attend.
 *
 * You can only attend one event at a time. If you choose to attend an event, you must attend the entire event.
 * Note that the end day is inclusive: that is, you cannot attend two events
 * where one of them starts and the other ends on the same day.
 *
 * Return the maximum sum of values that you can receive by attending events.
 */

public class MaximumValueFromEventsTest
{
    private readonly MaximumValueFromEvents _sut = new();

    private readonly Dictionary<int, int[][]> _events = new()
    {
        {
            0,
            new[] { new[] { 1, 2, 4 }, new[] { 3, 4, 3 }, new[] { 2, 3, 1 } }
        },
        {
            1,
            new[] { new[] { 1, 2, 4 }, new[] { 3, 4, 3 }, new[] { 2, 3, 10 } }
        },
        {
            2,
            new[] { new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 3, 3, 3 }, new[] { 4, 4, 4 } }
        },
        {
            3,
            new[] { new[] { 1, 3, 4 }, new[] { 2, 4, 1 }, new[] { 1, 1, 4 }, new[] { 3, 5, 1 }, new[] { 2, 5, 5 } }
        },
        {
            4,
            new[]
            {
                new [] { 41, 54, 68 },
                new [] { 28, 84, 88 },
                new [] { 35, 44, 51 },
                new [] { 10, 64, 36 },
                new [] { 81, 86, 25 },
                new [] { 6, 51, 80 },
                new [] { 17, 99, 35 },
                new [] { 8, 86, 22 },
                new [] { 82, 89, 60 },
                new [] { 61, 73, 96 },
                new [] { 50, 52, 28 }
            }
        }
    };

    [Theory]
    [InlineData(0, 2, 7)]
    [InlineData(1, 2, 10)]
    [InlineData(2, 3, 9)]
    [InlineData(3, 3, 9)]
    [InlineData(4, 11, 236)]
    public void MaxValue_ShouldSolve_TestCases(int eventsIndex, int maxEvents, int expected)
    {
        _sut.MaxValue(_events[eventsIndex], maxEvents).ShouldBe(expected);
    }
}
