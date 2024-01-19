using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class MakeComputersConnectedTest
{
    [Fact]
    public void MakeConnected_ShouldSolve_TestCase1()
    {
        const int n = 4;
        var connections = new[]
        {
            new[] { 0, 1 },
            new[] { 0, 2 },
            new[] { 1, 2 }
        };

        MakeComputersConnected.MakeConnected(n, connections).ShouldBe(1);
    }

    [Fact]
    public void MakeConnected_ShouldSolve_TestCase2()
    {
        const int n = 6;
        var connections = new[]
        {
            new[] { 0, 1 },
            new[] { 0, 2 },
            new[] { 0, 3 },
            new[] { 1, 2 },
            new[] { 1, 3 }
        };

        MakeComputersConnected.MakeConnected(n, connections).ShouldBe(2);
    }

    [Fact]
    public void MakeConnected_ShouldSolve_TestCase3()
    {
        const int n = 6;
        var connections = new[]
        {
            new[] { 0, 1 },
            new[] { 0, 2 },
            new[] { 0, 3 },
            new[] { 1, 2 }
        };

        MakeComputersConnected.MakeConnected(n, connections).ShouldBe(-1);
    }

    [Fact]
    public void MakeConnected_ShouldSolve_TestCase4()
    {
        const int n = 10;
        var connections = new[]
        {
            new [] {0,4},
            new [] {1,6},
            new [] {2,9},
            new [] {4,7},
            new [] {0,6},
            new [] {6,9},
            new [] {4,8},
            new [] {1,4},
            new [] {4,9},
            new [] {1,8},
            new [] {2,8},
            new [] {3,4},
            new [] {0,9}
        };

        MakeComputersConnected.MakeConnected(n, connections).ShouldBe(1);
    }

    [Fact]
    public void MakeConnected_ShouldSolve_TestCase5()
    {
        const int n = 100;
        var connections = new[]
        {
            new[] { 17, 51 },
            new[] { 33, 83 },
            new[] { 53, 62 },
            new[] { 25, 34 },
            new[] { 35, 90 },
            new[] { 29, 41 },
            new[] { 14, 53 },
            new[] { 40, 84 },
            new[] { 41, 64 },
            new[] { 13, 68 },
            new[] { 44, 85 },
            new[] { 57, 58 },
            new[] { 50, 74 },
            new[] { 20, 69 },
            new[] { 15, 62 },
            new[] { 25, 88 },
            new[] { 4, 56 },
            new[] { 37, 39 },
            new[] { 30, 62 },
            new[] { 69, 79 },
            new[] { 33, 85 },
            new[] { 24, 83 },
            new[] { 35, 77 },
            new[] { 2, 73 },
            new[] { 6, 28 },
            new[] { 46, 98 },
            new[] { 11, 82 },
            new[] { 29, 72 },
            new[] { 67, 71 },
            new[] { 12, 49 },
            new[] { 42, 56 },
            new[] { 56, 65 },
            new[] { 40, 70 },
            new[] { 24, 64 },
            new[] { 29, 51 },
            new[] { 20, 27 },
            new[] { 45, 88 },
            new[] { 58, 92 },
            new[] { 60, 99 },
            new[] { 33, 46 },
            new[] { 19, 69 },
            new[] { 33, 89 },
            new[] { 54, 82 },
            new[] { 16, 50 },
            new[] { 35, 73 },
            new[] { 19, 45 },
            new[] { 19, 72 },
            new[] { 1, 79 },
            new[] { 27, 80 },
            new[] { 22, 41 },
            new[] { 52, 61 },
            new[] { 50, 85 },
            new[] { 27, 45 },
            new[] { 4, 84 },
            new[] { 11, 96 },
            new[] { 0, 99 },
            new[] { 29, 94 },
            new[] { 9, 19 },
            new[] { 66, 99 },
            new[] { 20, 39 },
            new[] { 16, 85 },
            new[] { 12, 27 },
            new[] { 16, 67 },
            new[] { 61, 80 },
            new[] { 67, 83 },
            new[] { 16, 17 },
            new[] { 24, 27 },
            new[] { 16, 25 },
            new[] { 41, 79 },
            new[] { 51, 95 },
            new[] { 46, 47 },
            new[] { 27, 51 },
            new[] { 31, 44 },
            new[] { 0, 69 },
            new[] { 61, 63 },
            new[] { 33, 95 },
            new[] { 17, 88 },
            new[] { 70, 87 },
            new[] { 40, 42 },
            new[] { 21, 42 },
            new[] { 67, 77 },
            new[] { 33, 65 },
            new[] { 3, 25 },
            new[] { 39, 83 },
            new[] { 34, 40 },
            new[] { 15, 79 },
            new[] { 30, 90 },
            new[] { 58, 95 },
            new[] { 45, 56 },
            new[] { 37, 48 },
            new[] { 24, 91 },
            new[] { 31, 93 },
            new[] { 83, 90 },
            new[] { 17, 86 },
            new[] { 61, 65 },
            new[] { 15, 48 },
            new[] { 34, 56 },
            new[] { 12, 26 },
            new[] { 39, 98 },
            new[] { 1, 48 },
            new[] { 21, 76 },
            new[] { 72, 96 },
            new[] { 30, 69 },
            new[] { 46, 80 },
            new[] { 6, 29 },
            new[] { 29, 81 },
            new[] { 22, 77 },
            new[] { 85, 90 },
            new[] { 79, 83 },
            new[] { 6, 26 },
            new[] { 33, 57 },
            new[] { 3, 65 },
            new[] { 63, 84 },
            new[] { 77, 94 },
            new[] { 26, 90 },
            new[] { 64, 77 },
            new[] { 0, 3 },
            new[] { 27, 97 },
            new[] { 66, 89 },
            new[] { 18, 77 },
            new[] { 27, 43 }
        };

        MakeComputersConnected.MakeConnected(n, connections).ShouldBe(13);
    }
}
