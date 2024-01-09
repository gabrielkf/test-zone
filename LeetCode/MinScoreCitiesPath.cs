namespace LeetCode;

public static class MinScoreCitiesPath
{
    public static int MinScore(int n, int[][] roads)
    {
        var adj = CreateAdjList(n, roads);
        return Bfs(n, adj);
    }

    private static int Bfs(int n, Dictionary<int, List<(int to, int score)>> adj)
    {
        var visit = new bool[n + 1];
        var queue = new Queue<int>();
        var min = int.MaxValue;

        const int first = 1;
        queue.Enqueue(first);
        visit[first] = true;

        while (queue.Any())
        {
            var curr = queue.Dequeue();

            if (!adj.TryGetValue(curr, out var neighborList))
                continue;

            foreach (var (to, score) in neighborList)
            {
                min = Math.Min(min, score);

                if (!visit[to])
                {
                    queue.Enqueue(to);
                    visit[to] = true;
                }
            }
        }

        return min;
    }

    private static Dictionary<int, List<(int to, int score)>> CreateAdjList(int n, int[][] roads)
    {
        var adj = new Dictionary<int, List<(int to, int score)>>();

        foreach (var road in roads)
        {
            if (adj.TryGetValue(road[0], out var zeroList))
                zeroList.Add((road[1], road[2]));
            else
                adj.Add(road[0], new List<(int to, int score)> { (road[1], road[2]) });

            if (adj.TryGetValue(road[1], out var oneList))
                oneList.Add((road[0], road[2]));
            else
                adj.Add(road[1], new List<(int to, int score)> { (road[0], road[2]) });
        }

        return adj;
    }
}
