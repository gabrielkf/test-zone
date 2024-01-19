// ReSharper disable InconsistentNaming
namespace LeetCode.DailyProblem;

public class LinkedListNumber
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var values1 = ConvertListToStack(l1);
        var values2 = ConvertListToStack(l2);
        var nodeList = new ListNode();
        var remain = 0;
        var curr = 0;

        while (values1.Any() || values2.Any() || remain > 0)
        {
            var partial = remain
                       + (values1.TryPop(out var d1) ? d1 : 0)
                       + (values2.TryPop(out var d2) ? d2 : 0);

            curr = partial % 10;
            remain = partial / 10;

            nodeList.val = curr;
            nodeList = new ListNode(0, nodeList);
        }

        return nodeList.next!;
    }

    private static Stack<int> ConvertListToStack(ListNode list)
    {
        var curr = list;
        var nodes = new Stack<int>();

        nodes.Push(curr.val);

        while (curr.next is not null)
        {
            curr = curr.next;
            nodes.Push(curr.val);
        }

        return nodes;
    }
}

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val=0, ListNode? next=null)
    {
        this.val = val;
        this.next = next;
    }
}
