using System.Runtime.InteropServices;
using LeetCode;

namespace TestZone.LeetCode;

public class MinimizeArrayMaximumTest
{
    [Theory]
    [InlineData(new [] {3,7,1,6}, 5)]
    [InlineData(new [] {10,1}, 10)]
    public void MinimizeArrayValue(int[] nums, int ans)
    {
        MinimizeArrayMaximum.MinimizeArrayValue(nums)
            .ShouldBe(ans);
    }
}
