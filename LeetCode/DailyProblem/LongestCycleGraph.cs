namespace LeetCode.DailyProblem;

public static class LongestCycleGraph
{
    public static int LongestCycle(int[] edges)
    {
        var size = edges.Length;

        var indegree = Enumerable.Repeat(0, size).ToArray();
        foreach (var edge in edges)
            if (edge != -1) indegree[edge]++;

        var queue = new Queue<int>();
        for (var node = 0; node < size; node++)
            if (indegree[node] == 0) queue.Enqueue(node);

        var visited = Enumerable.Repeat(false, size).ToArray();

        while (queue.Any())
        {
            var node = queue.Dequeue();
            visited[node] = true;
            var neighbor = edges[node];

            if (neighbor == -1) continue;

            indegree[neighbor]--;

            if (indegree[neighbor] == 0)
                queue.Enqueue(neighbor);
        }

        var max = -1;
        for (var node = 0; node < size; node++)
        {
            if (visited[node]) continue;

            var count = CountCycle(node, edges, visited);
            max = Math.Max(max, count);
        }

        return max;
    }

    private static int CountCycle(int node, int[] edges, bool[] visited)
    {
        var count = 1;
        var curr = edges[node];

        while (curr != node)
        {
            count++;
            visited[curr] = true;
            curr = edges[curr];
        }

        return count;
    }
}
