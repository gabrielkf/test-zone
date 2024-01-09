namespace LeetCode;

public class ArithmeticProgressionSubArrays
{
    public static int NumberOfArithmeticSlices(int[] nums)
    {
        var size = nums.Length;
        if (size < 3) return 0;

        var arithProgs = new Dictionary<int, List<IList<int>>>();
        var count = 0;

        for (var front = 1; front < size; front++)
        {
            var hasAddedZero = false;

            for (var back = front -1; back >= 0; back--)
            {
                var diff = nums[front] - nums[back];

                if (diff == 0 && hasAddedZero) continue;

                var isNewDiff = arithProgs.TryAdd(
                    diff,
                    new List<IList<int>>
                    {
                        new List<int> { back, front }
                    });

                if (isNewDiff) continue;

                hasAddedZero = diff == 0 && !hasAddedZero;

                var len = arithProgs[diff].Count;
                for (var i = 0; i < len; i++)
                {
                    if (arithProgs[diff][i].Last() == back)
                    {
                        arithProgs[diff][i].Add(front);

                        count += diff != 0 && arithProgs[diff][i].Count > 2
                            ? arithProgs[diff][i].Count - 2
                            : 0;

                        continue;
                    }

                    arithProgs[diff].Add(new List<int>{ back, front});

                    if (hasAddedZero) break;
                }
            }
        }

        var zeroCombinationCalc = new Dictionary<int, int> { { 3, 1 } };

        if (arithProgs.TryGetValue(0, out var zeroProgs))
        {
            foreach (var zeroList in zeroProgs.Where(zp => zp.Count > 2))
            {
                if (zeroCombinationCalc.TryGetValue(zeroList.Count, out var calc))
                    count += calc;

                var sum = 1;
                for (var i = 3; i < zeroList.Count; i++)
                {
                    sum += Enumerable.Range(i + 1, zeroList.Count - i)
                               .Aggregate(1, (acc, curr) => acc * curr)
                           /
                           Enumerable.Range(1, zeroList.Count - i)
                               .Aggregate(1, (acc, curr) => acc * curr);
                }

                zeroCombinationCalc.Add(zeroList.Count, sum);

                count += sum;
            }
        }

        return count;
    }
}
