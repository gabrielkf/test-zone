namespace LeetCode;

public class CountIslands
{
    private const int Water = 1;
    private const int Land = 0;

    private readonly (int dRow, int dCol)[] _directions = { (1, 0), (0, 1), (-1, 0), (0, -1) };

    private int[][]? Grid;
    private Dictionary<(int row, int col), bool> Visited;

    public int ClosedIsland(int[][] grid)
    {
        var maxRow = grid.Length - 1;
        var maxCol = grid[0].Length - 1;

        var count = 0;
        Grid = grid;
        Visited = new Dictionary<(int row, int col), bool>();

        for (var row = 0; row <= maxRow; row++)
            for (var col = 0; col <= maxCol; col++)
                Visited.Add((row, col), false);

        for (var row = 0; row <= maxRow; row++)
        {
            for (var col = 0; col <= maxCol; col++)
            {
                var cell = Grid[row][col];
                if (Grid[row][col] == Water || Visited[(row, col)]) continue;

                count += IsClosedBfs(row, col, maxRow, maxCol) ? 1 : 0;
            }
        }

        return count;
    }

    private bool IsClosedBfs(int sRow, int sCol, int maxRow, int maxCol)
    {
        var isClosed = true;
        var queue = new Queue<(int row, int col)>();
        queue.Enqueue((sRow, sCol));
        Visited[(sRow, sCol)] = true;

        while (queue.TryDequeue(out var curr))
        {
            var (row, col) = curr;

            foreach (var (dRow, dCol) in _directions)
            {
                var nRow = row + dRow;
                var nCol = col + dCol;

                if (nRow < 0 || nRow > maxRow ||
                    nCol < 0 || nCol > maxCol)
                {
                    isClosed = false;
                    continue;
                }

                var cell = Grid[nRow][nCol];
                if (Grid[nRow][nCol] == Water || Visited[(nRow, nCol)]) continue;

                queue.Enqueue((nRow, nCol));
                Visited[(nRow, nCol)] = true;
            }
        }

        return isClosed;
    }
}
