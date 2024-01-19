namespace LeetCode.DailyProblem;

public class BrowserHistory
{
    private HistNode _curr;

    public BrowserHistory(string homepage)
    {
        _curr = new HistNode(homepage);
    }

    public void Visit(string url)
    {
        _curr.Next = new HistNode(url) { Prev = _curr };
        _curr = _curr.Next;
    }

    public string Back(int steps)
    {
        while (steps > 0)
        {
            if (_curr.Prev is not null)
                _curr = _curr.Prev;
            else
                break;

            steps--;
        }

        return _curr.Value;
    }

    public string Forward(int steps)
    {
        while (steps > 0)
        {
            if (_curr.Next is not null)
                _curr = _curr.Next;
            else
                break;

            steps--;
        }

        return _curr.Value;
    }
}

public class HistNode
{
    public string Value { get; init; }
    public HistNode? Next { get; set; }
    public HistNode? Prev { get; set; }

    public HistNode(string value)
    {
        Value = value;
    }
}
