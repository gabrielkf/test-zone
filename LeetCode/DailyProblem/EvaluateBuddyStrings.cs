namespace LeetCode.DailyProblem;

public class EvaluateBuddyStrings
{
    private const int AlphabetLettersCount = 26;

    public bool BuddyStrings(string orig, string goal)
    {
        var size = orig.Length;

        var seenLetters = new HashSet<char>(AlphabetLettersCount);
        var repeatedLetters = new HashSet<char>(AlphabetLettersCount);

        var diffs = new List<(char, char)>();

        for (var i = 0; i < size; i++)
        {
            if (orig[i] == goal[i])
            {
                if (!seenLetters.Add(orig[i]))
                {
                    repeatedLetters.Add(orig[i]);
                }
            }
            else
            {
                diffs.Add((orig[i], goal[i]));
            }

            if (diffs.Count > 2)
            {
                return false;
            }
        }

        return diffs.Count switch
        {
            1 => false,
            2 => CompareDiffs(diffs),
            _ => repeatedLetters.Count > 0
        };
    }

    private bool CompareDiffs(List<(char, char)> diffs)
    {
        return diffs[0].Item1 == diffs[1].Item2 && diffs[0].Item2 == diffs[1].Item1;
    }
}
