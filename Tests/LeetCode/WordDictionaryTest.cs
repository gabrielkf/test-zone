using LeetCode;

namespace TestZone.LeetCode;

public class WordDictionaryTest
{
    [Fact]
    public void Solves_TestCase_1()
    {
        var sut = new WordDictionary();
        sut.AddWord("bad");
        sut.AddWord("dad");
        sut.AddWord("mad");

        sut.Search("pad").ShouldBeFalse();
        sut.Search("bad").ShouldBeTrue();
        sut.Search(".ad").ShouldBeTrue();
        sut.Search("b..").ShouldBeTrue();
    }
}
