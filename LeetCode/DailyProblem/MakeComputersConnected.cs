namespace LeetCode.DailyProblem;

public static class MakeComputersConnected
{
    public static int MakeConnected(int n, int[][] connections)
    {
        var cableCount = connections.Length;
        if (cableCount < n - 1)
            return -1;

        var adj = CreateAdjList(n, connections);
        var nConnected = 0;
        var visited = Enumerable.Repeat(false, n).ToArray();

        for (var i = 0; i < n; i++)
        {
            if (visited[i]) continue;

            nConnected++;
            Dfs(i);
        }

        return nConnected - 1;

        void Dfs(int node)
        {
            visited![node] = true;

            if (!adj!.TryGetValue(node, out var connList))
                return;

            foreach (var neighbor in connList)
            {
                if (visited[neighbor]) continue;

                visited[neighbor] = true;
                Dfs(neighbor);
            }
        }
    }

    private static Dictionary<int, List<int>> CreateAdjList(int n, int[][] connections)
    {
        var adj = new Dictionary<int, List<int>>();

        foreach (var road in connections)
        {
            if (adj.TryGetValue(road[0], out var zeroList))
                zeroList.Add(road[1]);
            else
                adj.Add(road[0], new List<int> { road[1] });

            if (adj.TryGetValue(road[1], out var oneList))
                oneList.Add(road[0]);
            else
                adj.Add(road[1], new List<int> { road[0] });
        }

        return adj;
    }
}
