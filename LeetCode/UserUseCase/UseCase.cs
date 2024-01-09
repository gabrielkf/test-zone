namespace LeetCode.UserUseCase;

public class UseCase
{
    private readonly User _user;

    public UseCase(User user)
    {
        _user = user;
    }

    public void PrintAddress()
    {
        Console.WriteLine(_user.Address!);
    }
}
