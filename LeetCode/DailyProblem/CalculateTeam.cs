namespace LeetCode.DailyProblem;

public class CalculateTeam
{
    public int[] SmallestSufficientTeam(string[] requiredSkills, IList<IList<string>> people)
    {
        var nSkills = requiredSkills.Length;

        var skillId = Enumerable.Range(0, nSkills)
            .ToDictionary(key => requiredSkills[key], value => value);



        return new[] { 0 };
    }
}
