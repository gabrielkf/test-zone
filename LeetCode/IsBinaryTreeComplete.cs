namespace LeetCode;

public static class IsBinaryTreeComplete
{
    public static bool IsCompleteTree(TreeNode root)
    {
        var q = new Queue<TreeNode?>();
        q.Enqueue(root);

        var seenNull = false;
        while (q.Any())
        {
            var curr = q.Dequeue();
            if (curr is null)
            {
                seenNull = true;
            }
            else
            {
                if (seenNull)
                    return false;

                q.Enqueue(curr.left);
                q.Enqueue(curr.right);
            }

        }

        return true;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
