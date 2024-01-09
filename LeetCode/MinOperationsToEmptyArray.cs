namespace LeetCode;

public static class MinOperationsToEmptyArray
{
    public static int MinOperations(int[] nums)
    {
        var numCountList = nums.Aggregate(
            (new Dictionary<int, int>(), 0),
            (acc, curr) =>
            {
                var (dict, index) = acc;

                if (!dict.TryAdd(curr, 1))
                {
                    dict[curr]++;
                }

                return (dict, index + 1);
            },
            acc =>
            {
                return acc.Item1
                    .Select(keyValue => keyValue.Value)
                    .ToArray();
            });

        var opCount = 0;

        foreach (var count in numCountList)
        {
            if (count == 1) return -1;

            opCount += count % 3 == 0
                ? count / 3
                : (count / 3) + 1;
        }

        return opCount;
    }
}
