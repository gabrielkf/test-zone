using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class SetMismatchTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 2, 4 }, new[] { 2, 3 })]
    [InlineData(new[] { 1, 1 }, new[] { 1, 2 })]
    public void TestCases_ShouldPass(int[] nums, int[] ans)
    {
        SetMismatch.FindErrorNums(nums).ShouldBeEquivalentTo(ans);
    }
}
