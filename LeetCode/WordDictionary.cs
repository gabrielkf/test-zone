using System.Reflection.Metadata.Ecma335;

namespace LeetCode;

public class WordDictionary
{
    private const char AnyLetter = '.';

    private readonly DictNode _root = new();

    public void AddWord(string word)
    {
        var size = word.Length;
        var curr = _root;

        for (var i = 0; i < size; i++)
        {
            if (curr.Children.TryGetValue(word[i], out var foundNext))
            {
                curr = foundNext;

                if (i == size - 1)
                    curr.End = true;

                continue;
            }

            var newNext = new DictNode(i == size - 1);
            curr.Children.Add(word[i], newNext);
            curr = newNext;
        }
    }

    public bool Search(string word)
    {
        return SearchRecursive(word, _root);
    }

    private bool SearchRecursive(string word, DictNode root)
    {
        var size = word.Length;
        var curr = root;

        for (var i = 0; i < size; i++)
        {
            if (word[i] == AnyLetter)
            {
                if (i == size - 1)
                {
                    foreach (var child in curr.Children)
                        if (child.Value.End)
                            return true;
                }
                else
                {
                    foreach (var child in curr.Children)
                        if (SearchRecursive(word.Substring(i + 1), child.Value))
                            return true;
                }

                return false;
            }

            if (!curr.Children.TryGetValue(word[i], out var next))
                return false;

            curr = next;
        }

        return curr.End;
    }
}

public class DictNode
{
    public bool End { get; set; }
    public readonly Dictionary<char, DictNode> Children = new();

    public DictNode(bool end = false)
    {
        End = end;
    }
}
