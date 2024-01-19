using LeetCode;
using LeetCode.DailyProblem;
using Shouldly;

namespace TestZone.LeetCode;

public class EditDistanceTests
{
    [Fact]
    public void Case1()
    {
        var word1 = "horse";
        var word2 = "ros";
        var result = EditDistance.DynamicProgramming(word1, word2);

        result.ShouldBe(3);
    }

    [Fact]
    public void Case2()
    {
        var word1 = "intention";
        var word2 = "execution";
        var result = EditDistance.DynamicProgramming(word1, word2);

        result.ShouldBe(5);
    }

    [Fact]
    public void Case3()
    {
        var word1 = "a";
        var word2 = "a";
        var result = EditDistance.DynamicProgramming(word1, word2);

        result.ShouldBe(0);
    }
}
