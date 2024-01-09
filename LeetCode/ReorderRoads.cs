namespace LeetCode;

public static class ReorderRoads
{
    public static int MinReorder(int nCities, int[][] connections)
    {
        var adj = GetAdjList(nCities, connections);

        return Dfs(0, -1, adj);
    }

    private static int Dfs(int node, int parent, Dictionary<int, List<(int to, bool flipped)>> adj)
    {
        var flip = 0;

        foreach (var child in adj[node])
        {
            if (child.to == parent) continue;

            flip += child.flipped is false ? 1 : 0;
            flip += Dfs(child.to, node, adj);
        }

        return flip;
    }

    private static Dictionary<int, List<(int to, bool fliped)>> GetAdjList(int nCities, int[][] connections)
    {
        var adj = new Dictionary<int, List<(int to, bool fliped)>>(nCities);

        foreach (var conn in connections)
        {
            var origin = conn[0];
            var dest = conn[1];

            if (adj.TryGetValue(origin, out var originToList))
                originToList.Add((dest, false));
            else
                adj.Add(origin, new List<(int to, bool fliped)> { (dest, false) });

            if (adj.TryGetValue(dest, out var destToList))
                destToList.Add((origin, true));
            else
                adj.Add(dest, new List<(int to, bool fliped)> { (origin, true) });
        }

        return adj;
    }
}
