using LeetCode;

namespace TestZone.LeetCode;

public class UncrossedLinesTest
{
    [Theory]
    [InlineData(new[] { 1, 4, 2 }, new[] { 1, 2, 4 }, 2)]
    [InlineData(new[] { 2, 5, 1, 2, 5 }, new[] { 10, 5, 2, 1, 5, 2 }, 3)]
    [InlineData(new[] { 1, 3, 7, 1, 7, 5 }, new[] { 1, 9, 2, 5, 1 }, 2)]
    public void MaxUncrossedLines_ShouldSolve_TestCases(int[] nums1, int[] nums2, int ans)
    {
        UncrossedLines.MaxUncrossedLines(nums1, nums2).ShouldBe(ans);
    }
}
