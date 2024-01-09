namespace TestZone.Enumerables;

public class LinqShowDown
{
    [Fact]
    public void Aggregating_WithSeed_Case1()
    {
        var arr = Enumerable.Range(1, 10).ToArray();

        const int numSeed = 0;
        const string textSeed = "numbers:";

        var aggregateSum = arr.Aggregate(numSeed, (sum, nextItem) => sum + nextItem);
        var aggregateText = arr.Aggregate(textSeed, (text, nextItem) => text + nextItem);

        aggregateSum.ShouldBe(55);
        aggregateText.ShouldBe("numbers:12345678910");
    }
}
