namespace TestZone.DataStructures;

public class EnumProcessing
{
    [Theory]
    [InlineData(3, true, Week.Wednesday)]
    [InlineData(9, false, Week.Unknown)]
    public void ParseInt_AsEnum_ShouldWork(int numDay, bool isDay, Week weekDay)
    {
        var isWeekDay = Enum.IsDefined(typeof(Week), numDay);

        isWeekDay.ShouldBe(isDay);

        if (isWeekDay)
        {
            var enumDay = (Week)numDay;
            enumDay.ShouldBe(weekDay);
        }
    }
}

public enum Week
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Unknown
}
