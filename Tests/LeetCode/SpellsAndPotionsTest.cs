using LeetCode;

namespace TestZone.LeetCode;

public class SpellsAndPotionsTest
{
    [Fact]
    public void SuccessfulPairs_ShouldSolve_TestCase1()
    {
        const int min = 7;
        var spells = new[] { 5, 1, 3 };
        var potions = new[] { 1, 2, 3, 4, 5 };
        var ans = new[] { 4, 0, 3 };

        SpellsAndPotions.SuccessfulPairs(spells, potions, min)
            .ShouldBeEquivalentTo(ans);
    }

    [Fact]
    public void SuccessfulPairs_ShouldSolve_TestCase2()
    {
        const int min = 16;
        var spells = new[] { 3, 1, 2 };
        var potions = new[] { 8, 5, 8 };
        var ans = new[] { 2, 0, 2 };

        SpellsAndPotions.SuccessfulPairs(spells, potions, min)
            .ShouldBeEquivalentTo(ans);
    }

    [Fact]
    public void SuccessfulPairs_ShouldSolve_TestCase3()
    {
        const int min = 328;
        var spells = new[] { 15,8,19 };
        var potions = new[] { 38,36,23 };
        var ans = new[] { 3, 0, 3 };

        SpellsAndPotions.SuccessfulPairs(spells, potions, min)
            .ShouldBeEquivalentTo(ans);
    }
}
