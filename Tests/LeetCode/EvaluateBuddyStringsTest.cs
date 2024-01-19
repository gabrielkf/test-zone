using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class EvaluateBuddyStringsTest
{
    private static readonly EvaluateBuddyStrings _sut = new();

    [Theory]
    [InlineData("ab", "ba", true)]
    [InlineData("ab", "ab", false)]
    [InlineData("aa", "aa", true)]
    [InlineData("aaaaaaabc", "aaaaaaacb", true)]
    public void BuddyStrings_ShouldSolve_TestCases(string orig, string goal, bool expected)
    {
        _sut.BuddyStrings(orig, goal).ShouldBe(expected);
    }
}
