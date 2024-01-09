namespace TestZone;

public class SubstringFromLength
{
    public static class Token
    {
        private const string Type = "Bearer";

        public static string RemoveTypePrefix(string bearerToken) =>
            bearerToken.Substring(Type.Length);
    }

    private const string TokenValue = "asdf-qwer-iuyt-jhgf";
    private const string SampleToken = $"Bearer {TokenValue}";

    [Fact]
    public void RemoveTypePrefix_ShouldReturn_TokenValue()
    {
        Token.RemoveTypePrefix(SampleToken).ShouldBe(TokenValue);
    }
}
