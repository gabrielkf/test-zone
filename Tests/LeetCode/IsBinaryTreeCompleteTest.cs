using LeetCode;
using Shouldly;

namespace TestZone.LeetCode;

public class IsBinaryTreeCompleteTest
{
    [Fact]
    public void IsComplete_ShouldReturnExpected_ForTestCase_1()
    {
        var root = new TreeNode(1);
        root.left = new TreeNode(2,
            new TreeNode(4),
            new TreeNode(5));
        root.right = new TreeNode(3, new TreeNode(6));

        IsBinaryTreeComplete.IsCompleteTree(root).ShouldBe(true);
    }

    [Fact]
    public void IsComplete_ShouldReturnExpected_ForTestCase_2()
    {
        var root = new TreeNode(1);
        root.left = new TreeNode(2,
            new TreeNode(4),
            new TreeNode(5));
        root.right = new TreeNode(3, right: new TreeNode(7));

        IsBinaryTreeComplete.IsCompleteTree(root).ShouldBe(false);
    }
}
