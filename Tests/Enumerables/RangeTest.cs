using System.Text.Json;

namespace TestZone.Enumerables;

public class RangeTest
{
    [Fact]
    public void TestNames()
    {
        User? user;
        using (var reader = new StreamReader("Enumerables/user.json"))
        {
            var json = reader.ReadToEnd();
            user = JsonSerializer.Deserialize<User>(json);
        }

        user.ShouldNotBeNull();

        user.ShouldBeEquivalentTo(new User
        {
            FirstName = "John",
            MiddleName = "Doe",
            LastName = "Smith"
        });

        user.ToFields().ShouldBeEquivalentTo(new TaskField[]
        {
            new ("FirstName", "John"),
            new ("MiddleName", "Doe"),
            new ("LastName", "Smith")
        });
    }
}
