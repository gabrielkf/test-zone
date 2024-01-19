namespace LeetCode.DailyProblem;

public static class UnreachableGraphNodes
{
    public static long CountPairs(int nNodes, int[][] edges)
    {
        var adj = MakeAdjList(nNodes, edges);
        var visited = Enumerable.Repeat(false, nNodes).ToArray();

        long pairs = 0;
        long compSize = 0;
        long remaining = nNodes;

        for (var curr = 0; curr < nNodes; curr++)
        {
            if (visited[curr]) continue;

            visited[curr] = true;
            compSize = TraverseCount(curr, visited, adj);
            remaining -= compSize;
            pairs += compSize * remaining;

            curr = FindFirstUnvisited(visited);
        }

        return pairs;
    }

    private static int FindFirstUnvisited(bool[] visited)
    {
        for (var i = 0; i < visited.Length; i++)
            if (visited[i]) return i;

        return -1;
    }

    private static int TraverseCount(int node, bool[] visited, Dictionary<int, List<int>> adj)
    {
        var connected = 1;

        if (!adj.TryGetValue(node, out var children))
            return connected;

        foreach (var child in children)
        {
            if (visited[child]) continue;

            visited[child] = true;
            connected += TraverseCount(child, visited, adj);
        }

        return connected;
    }

    private static Dictionary<int, List<int>> MakeAdjList(int nNodes, int[][] edges)
    {
        var adj = new Dictionary<int, List<int>>(nNodes);

        foreach (var edge in edges)
        {
            if (adj.TryGetValue(edge[0], out var zeroNbs))
                zeroNbs.Add(edge[1]);
            else
                adj.Add(edge[0], new List<int> {edge[1]});

            if (adj.TryGetValue(edge[1], out var oneNbs))
                oneNbs.Add(edge[0]);
            else
                adj.Add(edge[1], new List<int> {edge[0]});
        }

        return adj;
    }
}
