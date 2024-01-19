namespace LeetCode.DailyProblem;

public class Trie
{
    private const char EndOfWord = '#';
    private readonly TrieNode _root;

    public Trie()
    {
        _root = new TrieNode();
    }

    public void Insert(string word)
    {
        var size = word.Length;
        var curr = _root;

        for (var i = 0; i < size; i++)
        {
            if (curr.Children.TryGetValue(word[i], out var foundNext))
            {
                curr = foundNext;
                if (i == size - 1) curr.End = true;

                continue;
            }

            var newNext = new TrieNode(i == size - 1);
            curr.Children.Add(word[i], newNext);
            curr = newNext;
        }
    }

    public bool Search(string word)
    {
        var size = word.Length;
        var curr = _root;

        for (var i = 0; i < size; i++)
        {
            if (!curr.Children.TryGetValue(word[i], out var next))
                return false;

            curr = next;
        }

        return curr.End;
    }

    public bool StartsWith(string prefix)
    {
        var size = prefix.Length;
        var curr = _root;

        for (var i = 0; i < size; i++)
        {
            if (!curr.Children.TryGetValue(prefix[i], out var next))
                return false;

            curr = next;
        }

        return true;
    }
}

public class TrieNode
{
    public bool End { get; set; }
    public Dictionary<char, TrieNode> Children = new();

    public TrieNode(bool end = false)
    {
        End = end;
    }
}
