using LeetCode;

// ReSharper disable InvalidXmlDocComment

namespace TestZone.LeetCode;

/**
 * https://leetcode.com/problems/knight-probability-in-chessboard/description/
 * On an n x n chessboard, a knight starts at the cell (row, column) and attempts to make exactly k moves.
 * The rows and columns are 0-indexed, so the top-left cell is (0, 0), and the bottom-right cell is (n - 1, n - 1).
 *
 * A chess knight has eight possible moves it can make, as illustrated below. Each move is two cells
 * in a cardinal direction, then one cell in an orthogonal direction.
 *
 * Each time the knight is to move, it chooses one of eight possible moves uniformly at random
 * (even if the piece would go off the chessboard) and moves there.
 * The knight continues moving until it has made exactly k moves or has moved off the chessboard.
 *
 * Return the probability that the knight remains on the board after it has stopped moving.
 *
 * Constraints:
        1 <= n <= 25
        0 <= k <= 100
        0 <= row, column <= n - 1
 */

public class KnightProbabilityCalculatorTest
{
    private readonly KnightProbabilityCalculator _sut = new();

    [Theory]
    [InlineData(3, 2, 0, 0, 0.06250)]
    [InlineData(1, 0, 0, 0, 1.00000)]
    [InlineData(8, 30, 6, 4, 0.5)]
    public void ShouldSolve_TestCases(int size, int steps, int row, int col, double expected)
    {
        _sut.KnightProbability(size, steps, row, col).ShouldBe(expected);
    }
}
