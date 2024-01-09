using LeetCode;

namespace TestZone.LeetCode;

public class BankLaserBeamsTest
{
    [Fact]
    public void TestCase_01()
    {
        // Arrange
        var devices = new[] { "011001", "000000", "010100", "001000" };

        // Act
        var result = BankLaserBeams.NumberOfBeams(devices);

        // Assert
        result.ShouldBe(8);
    }
}
