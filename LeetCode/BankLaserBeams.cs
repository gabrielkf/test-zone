namespace LeetCode;

public static class BankLaserBeams
{
    public static int NumberOfBeams(string[] bank)
    {
        if (bank.Length < 2) return 0;

        var (devicesByRow, _) = bank.Aggregate(
            (new List<int>(), 0),
            (acc, currRow) => {
                var (list, index) = acc;

                var devs = currRow.Aggregate(0, (sum, curr) => sum + curr - '0');

                if (devs > 0) list.Add(devs);

                return (list, index + 1);
            });

        if (devicesByRow.Count == 1) return 0;

        var lasers = 0;

        for (var i = 1; i < devicesByRow.Count; i++)
        {
            lasers += devicesByRow[i] * devicesByRow[i - 1];
        }

        return lasers;
    }
}
