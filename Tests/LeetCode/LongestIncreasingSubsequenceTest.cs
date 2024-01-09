using LeetCode;

namespace TestZone.LeetCode;

public class LongestIncreasingSubsequenceTest
{
    [Theory]
    [InlineData(new [] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)]
    [InlineData(new [] { 0, 1, 0, 3, 2, 3 }, 4)]
    [InlineData(new [] { 7, 7, 7, 7, 7, 7, 7 }, 1)]
    public void TestCases_ShouldPass(int[] nums, int result)
    {
        LongestIncreasingSubsequence.LengthOfLis(nums).ShouldBe(result);
    }
}
