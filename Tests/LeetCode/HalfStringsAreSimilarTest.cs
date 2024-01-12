using LeetCode;

namespace TestZone.LeetCode;

public class HalfStringsAreSimilarTest
{
    [Theory]
    [InlineData("book", true)]
    [InlineData("textbook", false)]
    [InlineData("AbCdEfGh", true)]
    public void TestCases_ShouldPass(string word, bool expected)
    {
        HalfStringsAreSimilar.HalvesAreAlike(word).ShouldBe(expected);
    }
}
