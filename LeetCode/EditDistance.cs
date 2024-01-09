namespace LeetCode;

/**
 * Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
 * You have the following three operations permitted on a word:
    - Insert a character
    - Delete a character
    - Replace a character
 */

public static class EditDistance
{
    public static int DynamicProgramming(string word1, string word2)
    {
        var len1 = word1.Length;
        var len2 = word2.Length;

        if (word1 == word2) return 0;
        if (len1 == 0 || len2 == 0) return Math.Max(len1, len2);

        var table = new int[len1 + 1][];
        for (var i = 0; i <= len1; i++)
        {
            if (i == 0)
            {
                table[i] = Enumerable.Range(0, len2 + 1).ToArray();
                continue;
            }

            table[i] = new int[len2 + 1];
            table[i][0] = i;
        }

        for (var i = 1; i <= len1; i++)
        {
            for (var j = 1; j <= len2; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                {
                    table[i][j] = table[i - 1][j - 1];
                }
                else
                {
                    var xyMin = Math.Min(table[i - 1][j], table[i][j - 1]);
                    table[i][j] = 1 + Math.Min(table[i - 1][j - 1], xyMin);
                }
                Console.WriteLine($"{table}, {i}, {j}");
            }
        }

        return table[len1][len2];
    }
}
