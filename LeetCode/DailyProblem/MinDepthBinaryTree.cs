namespace LeetCode.DailyProblem;

public class MinDepthBinaryTree
{
    public int MinDepth(TreeNode root)
    {
        if (root is null) return 0;

        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 1));
        var minDepth = int.MaxValue;

        while (queue.TryDequeue(out var current))
        {
            var (curNode, curDepth) = current;

            if (curNode.left is null && curNode.right is null)
            {
                return curDepth;
            }

            minDepth = Math.Min(minDepth, curDepth);

            if (curNode.left is not null) queue.Enqueue((curNode.left, curDepth + 1));
            if (curNode.right is not null) queue.Enqueue((curNode.right, curDepth + 1));
        }

        return minDepth;
    }
}

