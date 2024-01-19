using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class LinkedListNumberTest
{
    private readonly LinkedListNumber _sut = new();

    [Fact]
    public void AddTwoNumbers_ShouldSolve_Case1()
    {
        var list1 = ArrayToNodeList(new[] { 7, 2, 4, 3 });
        var list2 = ArrayToNodeList(new[] { 5, 6, 4 });
        var expected = ArrayToNodeList(new[] { 7, 8, 0, 7 });

        var result = _sut.AddTwoNumbers(list1, list2);

        result.val.ShouldBe(expected.val);
        while (result.next is not null)
        {
            result = result.next;
            expected = expected.next!;

            result.val.ShouldBe(expected.val);
        }
    }

    private static ListNode ArrayToNodeList(int[] nodeValues)
    {
        var list = new ListNode();

        for (var i = nodeValues.Length - 1; i >= 0; i--)
        {
            list.val = nodeValues[i];
            list = new ListNode(0, list);
        }

        return list.next!;
    }
}
