namespace TestZone.DataStructures;

public class Child : Parent
{
    public new int GetValue()
    {
        return base.GetValue() + 69;
    }
}
