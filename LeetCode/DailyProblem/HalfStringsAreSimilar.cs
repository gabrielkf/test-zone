namespace LeetCode.DailyProblem;

/**
You are given a string s of even length. Split this string into two halves of equal lengths,
and let a be the first half and b be the second half.

Two strings are alike if they have the same number of vowels
 ('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U').
 Notice that s contains uppercase and lowercase letters.

Return true if a and b are alike. Otherwise, return false.
 */

public static class HalfStringsAreSimilar
{
    public static HashSet<char> Vowels = new()
    {
        'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'
    };

    public static bool HalvesAreAlike(string s)
    {
        var half = s.Length / 2;

        var vowels = 0;

        for (var i = 0; i < half; i++)
        {
            if (Vowels.Contains(s[i])) vowels++;

            if (Vowels.Contains(s[i + half])) vowels--;
        }

        return vowels == 0;
    }
}
