using System.Text.Json.Serialization;

namespace TestZone;

public class NameOfTest
{
    [JsonPropertyName("dateOfBirth")] public string BirthDate { get; set; }

    [Fact]
    public void NameOf_ShouldReturn_PropertyName()
    {
        nameof(BirthDate).ShouldBe("BirthDate");
    }

}
