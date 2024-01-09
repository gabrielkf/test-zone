namespace LeetCode;

public class SpellsAndPotions
{
    public static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);
        var sSize = spells.Length;
        var pSize = potions.Length;

        var sortSpell = new List<(int spell, int index)>(sSize);
        for (var i = 0; i < sSize; i++) sortSpell.Add((spells[i], i));
        sortSpell.Sort((a, b) => a.spell.CompareTo(b.spell));

        var ans = new int[sSize];
        var pot = pSize - 1;

        for (var ss = 0; ss < sSize; ss++)
        {
            var (spell, index) = sortSpell[ss];
            while (pot >= 0 && IsSuccessful(spell, potions[pot], success))
                pot--;

            ans[index] = pSize - (pot + 1);
        }

        return ans;
    }

    private static bool IsSuccessful(long spell, long potion, long success) => spell * potion >= success;
}
