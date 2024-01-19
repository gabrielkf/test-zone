namespace LeetCode.DailyProblem;

/**
 * Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right,
 * which minimizes the sum of all numbers along its path.
 *
 * Note: You can only move either down or right at any point in time.
 */

public static class MinimumPathSumMatrix
{
    public static int MinPathSum(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        for (var i = 1; i < m; i++)
            grid[i][0] += grid[i - 1][0];

        for (var j = 1; j < n; j++)
            grid[0][j] += grid[0][j - 1];

        for (var i =1; i < m; i++)
            for (var j = 1; j < n; j++)
                grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);

        return grid[m - 1][n - 1];
    }

    public static int Dijkstra(int[][] grid)
    {
        var maxCol = grid[0].Length - 1;
        var maxRow = grid.Length - 1;

        var distances = InitDistances(maxRow, maxCol);
        var queue = new PriorityQueue<(int row, int col), int>();
        distances[0][0] = grid[0][0];
        queue.Enqueue((0, 0), grid[0][0]);

        while (queue.TryDequeue(out var curr, out var dist))
        {
            var (row, col) = curr;
            if (row < maxRow)
            {
                var downDist = Math.Min(distances[row + 1][col], grid[row + 1][col] + dist);
                distances[row + 1][col] = downDist;
                queue.Enqueue((row+1, col), downDist);
            }

            if (col < maxCol)
            {
                var rightDist = Math.Min(distances[row][col + 1], grid[row][col + 1] + dist);
                distances[row][col + 1] = rightDist;
                queue.Enqueue((row, col+1), rightDist);
            }
        }

        return distances[maxRow][maxCol];
    }

    private static int[][] InitDistances(int maxRow, int maxCol)
    {
        var distances = new int[maxRow + 1][];

        for (var row = 0; row <= maxRow; row++)
            distances[row] = Enumerable.Repeat(int.MaxValue, maxCol + 1).ToArray();

        return distances;
    }
}
