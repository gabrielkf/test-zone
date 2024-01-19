using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class RestaurantChefTest
{
    [Theory]
    [InlineData(new[] { -1, -8, 0, 5, -9 }, 14)]
    [InlineData(new[] { 4, 3, 2 }, 20)]
    [InlineData(new[] { -1, -4, -5 }, 0)]
    public void TopDownDp_ShouldResolve_TestCases(int[] satisfaction, int ans)
    {
        var uat = new RestaurantChef();
        uat.TopDownDp(satisfaction).ShouldBe(ans);
    }

    [Theory]
    [InlineData(new[] { -1, -8, 0, 5, -9 }, 14)]
    [InlineData(new[] { 4, 3, 2 }, 20)]
    [InlineData(new[] { -1, -4, -5 }, 0)]
    public void BottomUpDp_ShouldResolve_TestCases(int[] satisfaction, int ans)
    {
        var uat = new RestaurantChef();
        uat.BottomUpDp(satisfaction).ShouldBe(ans);
    }

    [Theory]
    [InlineData(new[] { -1, -8, 0, 5, -9 }, 14)]
    [InlineData(new[] { 4, 3, 2 }, 20)]
    [InlineData(new[] { -1, -4, -5 }, 0)]
    public void SpaceOptBottomUp_ShouldResolve_TestCases(int[] satisfaction, int ans)
    {
        var uat = new RestaurantChef();
        uat.SpaceOptBottomUp(satisfaction).ShouldBe(ans);
    }
}
