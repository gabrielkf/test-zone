using LeetCode;
using LeetCode.DailyProblem;

namespace TestZone.LeetCode;

public class CustomTrieTest
{
    [Fact]
    public void TestCase_01()
    {
        var trie = new Trie();
        trie.Insert("apple");
        trie.Search("apple").ShouldBeTrue();
        trie.Search("app").ShouldBeFalse();
        trie.StartsWith("app").ShouldBeTrue();

        trie.Insert("app");
        trie.Search("app").ShouldBeTrue();
    }
}
