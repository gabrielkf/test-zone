namespace LeetCode.DailyProblem;

public static class MinFallingPathSumMatrix
{

    public static int MinFallingPathSum(int[][] matrix)
    {
        var nRow = matrix.Length;
        var nCol = matrix[0].Length;

        var dp = new int[nRow][];
        for (var i = 0; i < nRow; i++)
            dp[i] = new int[nCol];

        dp[0] = matrix[0];

        for (var row = 1; row < nRow; row++)
        {
            for (var col = 0; col < nCol; col++)
            {
                var min = dp[row - 1][col];
                if (col > 0) min = Math.Min(min, dp[row - 1][col - 1]);
                if (col < nCol - 1) min = Math.Min(min, dp[row - 1][col + 1]);

                dp[row][col] = matrix[row][col] + min;
            }
        }

        return dp.Last().Min();
    }

    public static int Recursive(int[][] matrix)
    {
        var nRow = matrix.Length;
        var nCol = matrix[0].Length;

        var dp = new int[nRow][];
        for (var i = 0; i < nRow; i++)
            dp[i] = Enumerable.Repeat(int.MaxValue, nCol).ToArray();

        dp[0] = matrix[0];

        var min = int.MaxValue;
        for (var i = 0; i < nCol; i++)
        {
            min = Math.Min(min, MinPathSum(nRow - 1, i));
        }

        foreach (var num in dp[nRow-1]) Console.WriteLine(num);

        return min;

        int MinPathSum(int row, int col)
        {
            if (row == 0 || dp[row][col] < 200) return dp[row][col];

            var minTop = MinPathSum(row - 1, col);
            if (col > 0) minTop = Math.Min(minTop, MinPathSum(row - 1, col - 1));
            if (col < nCol - 1) minTop = Math.Min(minTop, MinPathSum(row - 1, col + 1));

            dp[row][col] = minTop + matrix[row][col];
            return dp[row][col];
        }
    }
}
