using LeetCode;

namespace TestZone.LeetCode;

public class ArithmeticProgressionSubArraysTest
{
    [Theory]
    [InlineData(new[] { 2, 4, 6, 8, 10 }, 7)]
    [InlineData(new[] { 7, 7, 7, 7, 7 }, 16)]
    [InlineData(new[] { 2, 2, 3, 4 }, 2)]
    public void TestCases_ShouldPass(int[] nums, int result)
    {
        ArithmeticProgressionSubArrays.NumberOfArithmeticSlices(nums)
            .ShouldBe(result);
    }
}
