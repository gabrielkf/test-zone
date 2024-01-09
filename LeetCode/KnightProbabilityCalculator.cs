namespace LeetCode;

public class KnightProbabilityCalculator
{
    private readonly Square[] _moves =
    {
        new (2, 1),
        new (1, 2),
        new (-1, 2),
        new (-2, 1),
        new (-2, -1),
        new (-1, -2),
        new (1, -2),
        new (2, -1),
    };

    public double KnightProbability(int size, int steps, int row, int column)
    {
        if (steps == 0) return 1d;
        if (size < 3) return 0d;

        if (size == 3)
        {
            if (row == 1 && column == 1) return 0d;


        }

        var validMoves = Enumerable.Repeat(new List<int>(), steps).ToArray();
        var nextSquares = new Queue<(Square square, int step)>();
        nextSquares.Enqueue((new Square(row, column), 0));

        while (nextSquares.TryDequeue(out var current) && current.step < steps)
        {
            var (square, step) = current;
            var validOptions = 0;

            foreach (var move in _moves)
            {
                var next = square + move;

                if (OutOfBoard(next)) continue;

                validOptions++;
                nextSquares.Enqueue((next, step + 1));
            }

            validMoves[step].Add(validOptions);
        }

        var prob = validMoves.Aggregate(1d, (acc, validList) =>
            acc * validList.Sum() / (8 * validList.Count));

        return prob;

        bool OutOfBoard(Square square)
        {
            return square.Row < 0 || square.Column < 0 ||
                   square.Row >= size || square.Column >= size;
        }
    }

    internal record struct Square(int Row, int Column)
    {
        public static Square operator +(Square s1, Square s2)
        {
            return new Square(s1.Row + s2.Row, s1.Column + s2.Column);
        }
    }
}
