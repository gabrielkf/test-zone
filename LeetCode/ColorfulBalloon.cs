namespace LeetCode;

/**
 * Alice has n balloons arranged on a rope. You are given a 0-indexed string colors
 * where colors[i] is the color of the ith balloon.
 * Alice wants the rope to be colorful. She does not want two consecutive balloons to be of the same color,
 * so she asks Bob for help. Bob can remove some balloons from the rope to make it colorful.
 *
 * You are given a 0-indexed integer array neededTime where neededTime[i] is the time (in seconds)
 * that Bob needs to remove the ith balloon from the rope.
 *
 * Return the minimum time Bob needs to make the rope colorful.
 */

public static class ColorfulBalloon
{
    public static int MinCost(string colors, int[] neededTime)
    {
        var size = neededTime.Length;

        if (size < 2) return 0;

        if (size == 2) return colors[0] != colors[1] ? 0 : Math.Min(neededTime[0], neededTime[1]);

        var totalTime = 0;
        var index = 0;

        while (index < size - 1)
        {
            var lastSequenceIndex = GetFinalRepetitionIndex(index, out var batchCost);

            if (lastSequenceIndex == index)
            {
                index++;
                continue;
            }

            totalTime += batchCost;

            if (lastSequenceIndex == size - 1) break;

            index = lastSequenceIndex + 1;
        }

        return totalTime;

        int GetFinalRepetitionIndex(int startIndex, out int batchCost)
        {
            batchCost = 0;
            var maxCost = 0;
            var blockCost = 0;
            var endIndex = startIndex;

            while (endIndex < size && colors[startIndex] == colors[endIndex])
            {
                blockCost += neededTime[endIndex];
                maxCost = Math.Max(maxCost, neededTime[endIndex]);
                batchCost = blockCost - maxCost;
                endIndex++;
            }

            return endIndex - 1;
        }
    }
}
