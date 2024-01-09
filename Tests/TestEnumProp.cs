using Shouldly;

namespace TestZone;

public class TestEnumProp
{
    [Fact]
    public void ToString_ReturnsName()
    {
        Heroes.Batman.ToString().ShouldBe("Batman");
        Heroes.Superman.ToString().ShouldBe("Superman");
        Heroes.SpiderMan.ToString().ShouldBe("SpiderMan");
    }
}

public enum Heroes
{
    Batman,
    Superman,
    SpiderMan
}
