using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class MinFallingPathSumMatrixTest
{

    [Fact]
    public void TestCase1_ShouldPass()
    {
        int[][] matrix =
        {
            new[] { 2, 1, 3 },
            new[] { 6, 5, 4 },
            new[] { 7, 8, 9 }
        };

        MinFallingPathSumMatrix.MinFallingPathSum(matrix).ShouldBe(13);
    }
}
