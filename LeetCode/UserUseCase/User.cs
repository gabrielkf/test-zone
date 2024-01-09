namespace LeetCode.UserUseCase;

public class User
{
    public string Name { get; set; } = string.Empty;

    public Address Address { get; } = new Address();
}
