namespace LeetCode.DailyProblem;

public class NumberOfEnclaves
{
    private const int Land = 1;
    private const int Water = 0;

    private readonly (int row, int col)[] _directions =
    {
        (1, 0), (0, 1), (-1, 0), (0, -1)
    };

    private int[][] Grid;
    private bool[][] Visited;
    private int MaxRow;
    private int MaxCol;

    public int NumEnclaves(int[][] grid)
    {
        MaxRow = grid.Length - 1;
        MaxCol = grid[0].Length - 1;
        Grid = grid;

        Visited = new bool[MaxRow + 1][];
        for (var row = 0; row <= MaxRow; row++)
            Visited[row] = Enumerable.Repeat(false, MaxCol + 1).ToArray();

        var count = 0;

        for (var row = 0; row <= MaxRow; row++)
            for (var col = 0; col <= MaxCol; col++)
                if (ShouldVisit(row, col))
                    count += WalkWithinLandDfs(row, col, out var island)
                        ? island
                        : 0;

        return count;
    }

    private bool WalkWithinLandDfs(int sRow, int sCol, out int count)
    {
        var isWithin = true;
        Visited[sRow][sCol] = true;
        count = 0;

        foreach (var (dRow, dCol) in _directions)
        {
            var nRow = sRow + dRow;
            var nCol = sCol + dCol;

            if (BeyondBorder(nRow, nCol))
            {
                isWithin = false;
                continue;
            }

            if (!ShouldVisit(nRow, nCol)) continue;

            count = WalkWithinLandDfs(nRow, nCol, out var subCount)
                ? subCount + 1
                : 0;
        }

        return isWithin;

        bool BeyondBorder(int row, int col) => row < 0 || row > MaxRow ||
                                               col < 0 || col > MaxCol;
    }

    private bool ShouldVisit(int row, int col) => Grid[row][col] == Land && !Visited[row][col];
}
